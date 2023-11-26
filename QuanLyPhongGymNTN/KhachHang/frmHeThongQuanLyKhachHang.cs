using DTO;
using QuanLyPhongGymNTN.Public;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongGymNTN.KhachHang
{
    public partial class frmHeThongQuanLyKhachHang : Form
    {
        Form frmHoatDong;
        int maKhachHang;

        public frmHeThongQuanLyKhachHang(int maKhachHang)
        {
            InitializeComponent();

            this.maKhachHang = maKhachHang;

            frmLichTap frm = new frmLichTap(maKhachHang);

            slHoTen.Text = BUS.taiKhoanBUS.layHoTen(maKhachHang);

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            moFormCon(frm);
        }

        void moFormCon(Form frm)
        {
            if (frmHoatDong != null)
            {
                frmHoatDong.Close();
            }

            frmHoatDong = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlNoiDung.Controls.Add(frm);
            pnlNoiDung.Tag = frm;

            frm.Show();
        }

        private void thongTinCaNhan_Click(object sender, EventArgs e)
        {
            frmQuanLyThongTinCaNhan frm = new frmQuanLyThongTinCaNhan(maKhachHang);
            moFormCon(frm);
        }

        private void theTap_Click(object sender, EventArgs e)
        {
            frmTheTap frm = new frmTheTap(BUS.theTapBUS.layMaTheTap(maKhachHang));
            moFormCon(frm);
        }

        private void goiTap_Click(object sender, EventArgs e)
        {
            frmGoiTap frm = new frmGoiTap(maKhachHang);
            moFormCon(frm);
        }

        private void lichTap_Click(object sender, EventArgs e)
        {
            frmLichTap frm = new frmLichTap(maKhachHang);
            moFormCon(frm);
        }

        private void dangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show(Const.xacNhanThoat, Const.ThongBao,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }

            this.Close();
        }
    }
}
