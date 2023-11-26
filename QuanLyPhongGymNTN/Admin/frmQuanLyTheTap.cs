using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongGymNTN.KhachHang;
using BUS;
using DTO;

namespace QuanLyPhongGymNTN.Admin
{
    public partial class frmQuanLyTheTap : Form
    {
        public frmQuanLyTheTap()
        {
            InitializeComponent();

            dgvDanhSachTheTap.AllowUserToAddRows = false;
            dgvDanhSachTheTap.AutoGenerateColumns = false;
        }

        private void frmQuanLyTheTap_Load(object sender, EventArgs e)
        {
            cbbTrangThai.SelectedIndex = Const.viTriDauTien;
            radTatCa.Checked = true;
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTheTap.SelectedRows.Count == 0)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            DialogResult dg = MessageBox.Show(Const.xacNhanKhoa, Const.ThongBao,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                return;
            }

            int maTheTap = Convert.ToInt32(dgvDanhSachTheTap.SelectedRows[0].Cells[0].Value);

            if (theTapBUS.khoa(maTheTap))
            {
                MessageBox.Show(Const.khoaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.khoaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachTheTap.DataSource = theTapBUS.loadTatCa();

            cbbTrangThai.SelectedIndex = Const.viTriDauTien;
            radTatCa.Checked = true;
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTheTap.SelectedRows.Count == 0)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            DialogResult dg = MessageBox.Show(Const.xacNhanMoKhoa, Const.ThongBao,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                return;
            }

            int maTheTap = Convert.ToInt32(dgvDanhSachTheTap.SelectedRows[0].Cells[0].Value);

            if (theTapBUS.moKhoa(maTheTap))
            {
                MessageBox.Show(Const.moKhoaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.moKhoaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachTheTap.DataSource = theTapBUS.loadTatCa();

            cbbTrangThai.SelectedIndex = Const.viTriDauTien;
            radTatCa.Checked = true;
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                dgvDanhSachTheTap.DataSource = theTapBUS.loadTatCa();

                return;
            }

            if (radTrangThai.Checked)
            {
                dgvDanhSachTheTap.DataSource = theTapBUS.loadTheoTrangThai(cbbTrangThai.SelectedIndex != Const.iTrangThaiHoatDong);

                return;
            }

            if (radTheHetHan.Checked)
            {
                dgvDanhSachTheTap.DataSource = theTapBUS.loadTheHetHan();

                return;
            }
        }

        private void btnXemLichSuGoiTap_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTheTap.SelectedRows.Count == 0)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            int maTheTap = Convert.ToInt32(dgvDanhSachTheTap.SelectedRows[0].Cells[0].Value);

            frmLichSuGoiTap frm = new frmLichSuGoiTap(maTheTap);
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTheTap.SelectedRows.Count == 0)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            DialogResult dg = MessageBox.Show(Const.xacNhanXoaBangLienQuan + Const.xacNhanXoa, Const.ThongBao,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                return;
            }

            int maTheTap = Convert.ToInt32(dgvDanhSachTheTap.SelectedRows[0].Cells[0].Value);

            if (theTapBUS.xoa(maTheTap))
            {
                MessageBox.Show(Const.xoaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.xoaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachTheTap.DataSource = theTapBUS.loadTatCa();

            cbbTrangThai.SelectedIndex = Const.viTriDauTien;
        }
    }
}
