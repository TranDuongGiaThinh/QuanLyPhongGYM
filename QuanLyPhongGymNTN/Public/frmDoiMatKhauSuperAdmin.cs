using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongGymNTN.Public
{
    public partial class frmDoiMatKhauSuperAdmin : Form
    {
        int maTaiKhoan;

        public frmDoiMatKhauSuperAdmin(int maTaiKhoan)
        {
            InitializeComponent();

            this.maTaiKhoan = maTaiKhoan;

            txtMatKhau.Select();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show(Const.xacNhanThoat, Const.ThongBao,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMatKhau.Text)|| string.IsNullOrEmpty(txtXacNhanMatKhau.Text))
            {
                MessageBox.Show(Const.duLieutrong, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if(!txtMatKhau.Text.Equals(txtXacNhanMatKhau.Text))
            {
                MessageBox.Show(Const.matKhauKhongChinhXac, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            string matKhau = txtMatKhau.Text;

            if (taiKhoanBUS.doiMatKhau(matKhau, maTaiKhoan))
            {
                MessageBox.Show(Const.luuThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show(Const.luuThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Const.khoangTrang) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
        }
    }
}
