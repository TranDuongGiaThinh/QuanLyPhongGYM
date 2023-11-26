using QuanLyPhongGymNTN.Admin;
using QuanLyPhongGymNTN.KhachHang;
using QuanLyPhongGymNTN.PT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyPhongGymNTN.Public
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();

            txtTenDangNhap.Select();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (taiKhoanBUS.demSoTaiKhoan() == Const.khongCoGiaTri)
            {
                taiKhoanBUS.taoTaiKhoanSuperAdmin();
            }

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show(Const.xacNhanThoat, Const.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show(Const.duLieutrong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTenDangNhap.Select();

                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(Const.duLieutrong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtMatKhau.Select();

                return;
            }

            int maTaiKhoan = taiKhoanBUS.layMaTaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text);

            Form frmTrangChu;

            if (maTaiKhoan != Const.khongCoGiaTri)
            {
                int maLoaitaiKhoan = taiKhoanBUS.layMaLoaiTaiKhoan(maTaiKhoan);

                if (maLoaitaiKhoan == Const.maAdmin || maLoaitaiKhoan == Const.maSuperAdmin)
                {
                    if (maLoaitaiKhoan == Const.maSuperAdmin && taiKhoanBUS.chuaDoiMatKhau(Const.tenDangNhapSuperAdmin, Const.matKhauSuperAdmin))
                    {
                        MessageBox.Show(Const.yeuCauThayDoiMatKhau, Const.ThongBao,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        frmDoiMatKhauSuperAdmin form = new frmDoiMatKhauSuperAdmin(maTaiKhoan);

                        this.Visible = false;

                        form.ShowDialog();
                    }

                    frmTrangChu = new frmHeThongQuanLyAdmin(maTaiKhoan);
                }

                else if (maLoaitaiKhoan == Const.maPT)
                    frmTrangChu = new frmHeThongQuanLyPT(maTaiKhoan);

                else
                    frmTrangChu = new frmHeThongQuanLyKhachHang(maTaiKhoan);
                
                this.Visible = false;

                frmTrangChu.ShowDialog();

                this.Visible = true;
            }

            else
            {
                MessageBox.Show(Const.dangNhapThatBai,Const.ThongBao,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            txtTenDangNhap.Text = string.Empty;
            txtMatKhau.Text = string.Empty;

            txtTenDangNhap.Select();
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                txtMatKhau.Select();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(sender, e);
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Const.khoangTrang) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
