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

namespace QuanLyPhongGymNTN.KhachHang
{
    public partial class frmGoiTap : Form
    {
        int maKhachHang;

        public frmGoiTap(int maKhachHang)
        {
            InitializeComponent();

            this.maKhachHang = maKhachHang;

            dgvDanhSachGoiTap.AutoGenerateColumns = false;
            dgvDanhSachGoiTap.MultiSelect = false;
        }

        private void frmGoiTap_Load(object sender, EventArgs e)
        {
            dgvDanhSachGoiTap.DataSource = goiTapBUS.layDanhSachGoiTap();

            cbbMonTap.DataSource = monTapBUS.load();
            cbbMonTap.DisplayMember = "tenmontap";
            cbbMonTap.ValueMember = "mamontap";

            resetText();
        }

        public void resetText()
        {
            txtTenGoiTap.Text = string.Empty;
            if(cbbMonTap.Items.Count>0)
                cbbMonTap.SelectedIndex = Const.viTriDauTien;
            txtGiaGoi.Text = Const.khongCoGiaTri.ToString();
            txtGhiChu.Text = string.Empty;
        }

        private void dgvTTGoiTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachGoiTap.SelectedRows.Count == 0)
                return;
                
            txtTenGoiTap.Text = dgvDanhSachGoiTap.SelectedRows[0].Cells[1].Value.ToString();
            cbbMonTap.Text = dgvDanhSachGoiTap.SelectedRows[0].Cells[2].Value.ToString();
            txtGiaGoi.Text = dgvDanhSachGoiTap.SelectedRows[0].Cells[3].Value.ToString();
            txtGhiChu.Text = dgvDanhSachGoiTap.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachGoiTap.SelectedRows.Count == Const.khongCoGiaTri)
            {
                return;
            }

            goiTapDTO goiTap = new goiTapDTO
            {
                maGoiTap = Convert.ToInt32(dgvDanhSachGoiTap.SelectedRows[Const.viTriDauTien].Cells[Const.viTriDauTien].Value),
                tenGoiTap = txtTenGoiTap.Text,
                maMonTap = Convert.ToInt32(cbbMonTap.SelectedValue),
                giaGoiTap = Convert.ToInt32(txtGiaGoi.Text)
            };

            frmDangKyGoiTap frm = new frmDangKyGoiTap(maKhachHang, goiTap);
            frm.ShowDialog();
        }
    }
}
