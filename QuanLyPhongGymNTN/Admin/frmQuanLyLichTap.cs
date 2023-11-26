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

namespace QuanLyPhongGymNTN.Admin
{
    public partial class frmQuanLyLichTap : Form
    {
        lichTapBUS busLichTap = new lichTapBUS();

        public frmQuanLyLichTap()
        {
            InitializeComponent();
        }

        private void frmQuanLyLichTap_Load(object sender, EventArgs e)
        {
            dgvDanhSachLichTap.AllowUserToAddRows = false;
            dgvDanhSachLichTap.AutoGenerateColumns = false;

            cbbPT.DataSource = taiKhoanBUS.layDanhSachTheoLoaiTaiKhoan(2);
            cbbPT.DisplayMember = "HoTen";
            cbbPT.ValueMember = "MaTaiKhoan";

            dgvDanhSachLichTap.DataSource = busLichTap.LoadTatCa();

            radTatCa.Checked = true;
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                dgvDanhSachLichTap.DataSource = busLichTap.LoadTatCa();

                return;
            }

            if (radPT.Checked)
            {
                dgvDanhSachLichTap.DataSource = busLichTap.LoadTheoPT(Convert.ToInt32(cbbPT.SelectedValue));

                return;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!radHoTenKhachHang.Checked)
            {
                //thong bao
                //thoat
                return;
            }

            if (String.IsNullOrEmpty(radHoTenKhachHang.Text))
            {
                //thong bao
                //thoat
                return;
            }

            dgvDanhSachLichTap.DataSource = busLichTap.LoadTheoHoTen(txtHoTenKhachHang.Text);
        }
    }
}
