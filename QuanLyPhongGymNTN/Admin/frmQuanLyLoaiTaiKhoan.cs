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
    public partial class frmQuanLyLoaiTaiKhoan : Form
    {
        int maLoaiTaiKhoan;

        public frmQuanLyLoaiTaiKhoan(int maLTK)
        {
            InitializeComponent();

            this.maLoaiTaiKhoan = maLTK;

            dgvDanhSachLoaiTaiKhoan.AllowUserToAddRows = false;
            dgvDanhSachLoaiTaiKhoan.AutoGenerateColumns = false;
        }

        private void frmQuanLyLoaiTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvDanhSachLoaiTaiKhoan.DataSource = loaiTaiKhoanBUS.layDanhSachKhongCoSuperAdmin();

            txtTenLoaiTaiKhoan.Select();
        }

        private void dgvDanhSachLoaiTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachLoaiTaiKhoan.SelectedRows.Count == Const.khongCoGiaTri)
            {
                return;
            }

            txtTenLoaiTaiKhoan.Text = dgvDanhSachLoaiTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["tenloaitaikhoan"].Value.ToString();
            txtMoTa.Text = dgvDanhSachLoaiTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["mota"].Value.ToString();
        }

        public void lamMoi()
        {
            txtTenLoaiTaiKhoan.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtTenLoaiTaiKhoan.Select();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachLoaiTaiKhoan.SelectedRows.Count == Const.khongCoGiaTri)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (String.IsNullOrEmpty(txtTenLoaiTaiKhoan.Text) || String.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show(Const.duLieutrong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            int maLTK = Convert.ToInt32(dgvDanhSachLoaiTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["maloaitaikhoan"].Value);

            if (loaiTaiKhoanBUS.daTonTai(txtTenLoaiTaiKhoan.Text, maLTK))
            {
                MessageBox.Show(Const.thongTinDaTonTai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            loaiTaiKhoanDTO ltk = new loaiTaiKhoanDTO
            {
                tenLoaiTaiKhoan = txtTenLoaiTaiKhoan.Text,
                moTa = txtMoTa.Text
            };

            if (loaiTaiKhoanBUS.sua(ltk, maLTK))
            {
                MessageBox.Show(Const.suaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.suaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachLoaiTaiKhoan.DataSource = loaiTaiKhoanBUS.layDanhSachKhongCoSuperAdmin();
            lamMoi();
        }
    }
}
