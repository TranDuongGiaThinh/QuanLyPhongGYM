using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyPhongGymNTN.Admin
{
    public partial class frmQuanLyGoiTap : Form
    {
        public frmQuanLyGoiTap()
        {
            InitializeComponent();

            dgvDanhSachGoiTap.AllowUserToAddRows = false;
            dgvDanhSachGoiTap.AutoGenerateColumns = false;
        }

        public void lamMoi()
        {
            txtTenGoi.Text = string.Empty;
            if(cbbMonTap.Items.Count>Const.khongTimThay)
                cbbMonTap.SelectedIndex = Const.viTriDauTien;
            txtGiaGoi.Text = Const.khongCoGiaTri.ToString();
            txtGhiChu.Text = string.Empty;
            txtTenGoi.Select();
        }

        private void frmQuanLyGoiTap_Load(object sender, EventArgs e)
        {
            dgvDanhSachGoiTap.DataSource = goiTapBUS.layDanhSachGoiTap();
            cbbMonTap.DataSource = monTapBUS.load();
            cbbMonTap.DisplayMember = "tenmontap";
            cbbMonTap.ValueMember = "mamontap";

            lamMoi();
        }

        private void dgvDanhSachGoiTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDanhSachGoiTap.SelectedRows.Count == Const.khongTimThay)
            {
                return;
            }

            txtTenGoi.Text = dgvDanhSachGoiTap.SelectedRows[Const.viTriDauTien].Cells["tengoitap"].Value.ToString();
            cbbMonTap.Text = dgvDanhSachGoiTap.SelectedRows[Const.viTriDauTien].Cells["montap"].Value.ToString();
            txtGiaGoi.Text = dgvDanhSachGoiTap.SelectedRows[Const.viTriDauTien].Cells["giagoitap"].Value.ToString();
            txtGhiChu.Text = dgvDanhSachGoiTap.SelectedRows[Const.viTriDauTien].Cells["ghichu"].Value.ToString();
        }

        public goiTapDTO layGoiTapNhapVao()
        {
            goiTapDTO goiTap = new goiTapDTO
            {
                tenGoiTap = txtTenGoi.Text,
                maMonTap = Convert.ToInt32(cbbMonTap.SelectedValue),
                giaGoiTap = Convert.ToInt32(txtGiaGoi.Text),
                ghiChu = txtGhiChu.Text
            };

            return goiTap;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenGoi.Text)|| string.IsNullOrEmpty(txtGiaGoi.Text) 
                || string.IsNullOrEmpty(txtGhiChu.Text))
            {
                MessageBox.Show(Const.duLieutrong, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (goiTapBUS.daTonTai(txtTenGoi.Text))
            {
                MessageBox.Show(Const.thongTinDaTonTai, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            goiTapDTO goiTap = layGoiTapNhapVao();

            if (goiTapBUS.them(goiTap))
            {
                MessageBox.Show(Const.themThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.themThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachGoiTap.DataSource = goiTapBUS.layDanhSachGoiTap();

            lamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachGoiTap.SelectedRows.Count == Const.khongTimThay)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            int maGoiTap = Convert.ToInt32(dgvDanhSachGoiTap.SelectedRows[Const.viTriDauTien].Cells["magoitap"].Value);

            if (goiTapBUS.daTonTai(txtTenGoi.Text, maGoiTap))
            {
                MessageBox.Show(Const.thongTinDaTonTai, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            goiTapDTO goiTap = layGoiTapNhapVao();

            if (goiTapBUS.sua(goiTap, maGoiTap))
            {
                MessageBox.Show(Const.suaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.suaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachGoiTap.DataSource = goiTapBUS.layDanhSachGoiTap();

            lamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachGoiTap.SelectedRows.Count == Const.khongTimThay)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            int maGoiTap = Convert.ToInt32(dgvDanhSachGoiTap.SelectedRows[Const.viTriDauTien].Cells["magoitap"].Value);

            if (goiTapBUS.dangSuDung(maGoiTap))
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

            if (goiTapBUS.xoa(maGoiTap))
            {
                MessageBox.Show(Const.xoaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.xoaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachGoiTap.DataSource = goiTapBUS.layDanhSachGoiTap();

            lamMoi();
        }

        private void txtGiaGoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
