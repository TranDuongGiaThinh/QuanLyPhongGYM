using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyPhongGymNTN.Admin
{
    public partial class frmQuanLyLoaiGoiTap : Form
    {
        public frmQuanLyLoaiGoiTap()
        {
            InitializeComponent();

            dgvDanhSachLoaiGoiTap.AllowUserToAddRows = false;
            dgvDanhSachLoaiGoiTap.AutoGenerateColumns = false;
        }

        private void frmQuanLyLoaiGoiTap_Load(object sender, EventArgs e)
        {
            dgvDanhSachLoaiGoiTap.DataSource = loaiGoiTapBUS.layDanhSachLoaiGoiTap();

            txtTenLoaiGoi.Select();
        }

        private void dgvDanhSachLoaiGoiTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachLoaiGoiTap.SelectedRows.Count == Const.khongCoGiaTri)
            {
                return;
            }

            txtTenLoaiGoi.Text = dgvDanhSachLoaiGoiTap.SelectedRows[Const.viTriDauTien].Cells["tenloaigoitap"].Value.ToString();
            nudThoiGianGoi.Text = dgvDanhSachLoaiGoiTap.SelectedRows[Const.viTriDauTien].Cells["thoigian"].Value.ToString();
        }

        public loaiGoiTapDTO layLoaiGoiTapNhapVao()
        {
            loaiGoiTapDTO loaiGoiTap = new loaiGoiTapDTO
            {
                tenLoaiGoiTap = txtTenLoaiGoi.Text,
                thoiGian = Convert.ToInt32(nudThoiGianGoi.Value)
            };

            return loaiGoiTap;
        }

        public void lamMoi()
        {
            txtTenLoaiGoi.Text = string.Empty;
            nudThoiGianGoi.Text = string.Empty;
            txtTenLoaiGoi.Select();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLoaiGoi.Text) || string.IsNullOrEmpty(nudThoiGianGoi.Text))
            {
                MessageBox.Show(Const.duLieutrong, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (loaiGoiTapBUS.datontai(txtTenLoaiGoi.Text))
            {
                MessageBox.Show(Const.thongTinDaTonTai, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            loaiGoiTapDTO loaiGoiTap = layLoaiGoiTapNhapVao();

            if (loaiGoiTapBUS.them(loaiGoiTap))
            {
                MessageBox.Show(Const.themThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.themThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachLoaiGoiTap.DataSource = loaiGoiTapBUS.layDanhSachLoaiGoiTap();

            lamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachLoaiGoiTap.SelectedRows.Count == Const.khongCoGiaTri)
            {
                return;
            }

            int maLoaiGoiTap = Convert.ToInt32(dgvDanhSachLoaiGoiTap.SelectedRows[Const.viTriDauTien].Cells["maloaigoitap"].Value);

            if (loaiGoiTapBUS.datontai(txtTenLoaiGoi.Text, maLoaiGoiTap))
            {
                MessageBox.Show(Const.thongTinDaTonTai, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            loaiGoiTapDTO loaiGoiTap = layLoaiGoiTapNhapVao();

            if (loaiGoiTapBUS.sua(loaiGoiTap, maLoaiGoiTap))
            {
                MessageBox.Show(Const.suaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.suaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachLoaiGoiTap.DataSource = loaiGoiTapBUS.layDanhSachLoaiGoiTap();

            lamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachLoaiGoiTap.SelectedRows.Count == Const.khongCoGiaTri)
            {
                return;
            }

            int maLoaiGoiTap = Convert.ToInt32(dgvDanhSachLoaiGoiTap.SelectedRows[Const.viTriDauTien].Cells["maloaigoitap"].Value);

            if (loaiGoiTapBUS.dangSuDung(maLoaiGoiTap))
            {
                MessageBox.Show(Const.khongTheXoa, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dg = MessageBox.Show(Const.xacNhanXoa, Const.ThongBao,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                return;
            }

            if (loaiGoiTapBUS.xoa(maLoaiGoiTap))
            {
                MessageBox.Show(Const.xoaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.xoaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachLoaiGoiTap.DataSource = loaiGoiTapBUS.layDanhSachLoaiGoiTap();

            lamMoi();
        }
    }
}
