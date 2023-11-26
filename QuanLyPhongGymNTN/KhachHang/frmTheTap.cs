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
using System.IO;
using DAO;

namespace QuanLyPhongGymNTN.KhachHang
{
    public partial class frmTheTap : Form
    {
        theTapDTO theTap;

        public frmTheTap(int maTheTap)
        {
            InitializeComponent();

            theTap = theTapBUS.layTheTap(maTheTap);

            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienthoai.Enabled = false;
        }

        private void frmTheTap_Load(object sender, EventArgs e)
        {
            hienThongTin();
        }

        public void hienThongTin()
        {
            if (theTap == null)
                return;

            ptbAnh.Image = utils.chuyenAnh(theTap.pathAnh);
            txtHoTen.Text = theTap.tenKhachHang;
            txtDiaChi.Text = theTap.diaChi;
            txtDienthoai.Text = theTap.soDienThoai;
        }

        private void btnLichSuGoiTap_Click(object sender, EventArgs e)
        {
            frmLichSuGoiTap frm = new frmLichSuGoiTap(theTap.maTheTap);
            frm.ShowDialog();
        }
    }
}
