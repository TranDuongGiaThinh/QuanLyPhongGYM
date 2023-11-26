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


namespace QuanLyPhongGymNTN.Admin
{
    public partial class frmHeThongQuanLyAdmin : Form
    {
        Form frmHoatDong;
        int maAdmin;

        public frmHeThongQuanLyAdmin(int maAdmin)
        {
            InitializeComponent();

            this.maAdmin = maAdmin;

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void frmHeThongQuanLyAdmin_Load(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan(BUS.taiKhoanBUS.layMaLoaiTaiKhoan(maAdmin));

            slHoTen.Text = BUS.taiKhoanBUS.layHoTen(maAdmin);

            moFormCon(frm);
        }   

        void moFormCon(Form frm)
        {
            if(frmHoatDong!=null)
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

        private void goiTap_Click(object sender, EventArgs e)
        {
            frmQuanLyGoiTap frm = new frmQuanLyGoiTap();
            moFormCon(frm);
        }

        private void loaiGoiTap_Click(object sender, EventArgs e)
        {
            frmQuanLyLoaiGoiTap frm = new frmQuanLyLoaiGoiTap();
            moFormCon(frm);
        }

        private void theTap_Click(object sender, EventArgs e)
        {
            frmQuanLyTheTap frm = new frmQuanLyTheTap();
            moFormCon(frm);
        }

        private void taiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frm = new  frmQuanLyTaiKhoan(BUS.taiKhoanBUS.layMaLoaiTaiKhoan(maAdmin));
            moFormCon(frm);
        }

        private void loaiTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyLoaiTaiKhoan frm = new frmQuanLyLoaiTaiKhoan(BUS.taiKhoanBUS.layMaLoaiTaiKhoan(maAdmin));
            moFormCon(frm);
        }

        private void lichTap_Click(object sender, EventArgs e)
        {
            frmQuanLyLichTap frm = new frmQuanLyLichTap();
            moFormCon(frm); ;
        }

        private void mônTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMonTap frm = new frmQuanLyMonTap();
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
        }
    }
}
