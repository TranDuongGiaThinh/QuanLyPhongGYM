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
using BUS;
using DTO;

namespace QuanLyPhongGymNTN.PT
{
    public partial class frmHeThongQuanLyPT : Form
    {
        Form frmHoatDong;
        int maPT;

        public frmHeThongQuanLyPT(int maPT)
        {
            InitializeComponent();

            this.maPT = maPT;

            frmXemLichTap frm = new frmXemLichTap(maPT);

            slHoTen.Text = BUS.taiKhoanBUS.layHoTen(maPT);

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
            frmQuanLyThongTinCaNhan frm = new frmQuanLyThongTinCaNhan(maPT);
            moFormCon(frm);
        }

        private void lichtap_Click(object sender, EventArgs e)
        {
            frmXemLichTap frm = new frmXemLichTap(maPT);
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
