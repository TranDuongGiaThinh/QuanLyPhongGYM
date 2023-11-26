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

namespace QuanLyPhongGymNTN.KhachHang
{
    public partial class frmLichSuGoiTap : Form
    {
        private List<lichSuGoiTapDTO> lsgt;

        public frmLichSuGoiTap(int mathetap)
        {
            InitializeComponent();

            this.lsgt = lichSuGoiTapBUS.layLichSuGoiTap(mathetap);

            lblTenKhachHang.Text = lichSuGoiTapBUS.layHoTen(mathetap);

            radTimTheoNgayDangKy.Checked = true;

            dgvDanhSachLichSuGoiTap.AllowUserToAddRows = false;
            dgvDanhSachLichSuGoiTap.AutoGenerateColumns = false;
        }

        public void resetText()
        {
            radTimTheoNgayDangKy.Checked = true;

            lblTenGoiTap.Text = string.Empty;
            lblTenMonTap.Text = string.Empty;
            lblGiaGoi.Text = string.Empty;
            lblGhiChu.Text = string.Empty;

            dtpNgayKetThuc.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
        }

        private void frmLichSuGoiTap_Load(object sender, EventArgs e)
        {
            dgvDanhSachLichSuGoiTap.DataSource = lsgt;
        }

        private void dgvDanhSachLichSuGoiTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachLichSuGoiTap.SelectedRows.Count == 0)
            {
                return;
            }

            int maGoiTap = Convert.ToInt32(dgvDanhSachLichSuGoiTap.SelectedRows[0].Cells[1].Value);

            goiTapDTO goiTap = goiTapBUS.layGoiTap(maGoiTap);

            lblTenGoiTap.Text = goiTap.tenGoiTap;
            lblTenMonTap.Text = goiTap.tenMonTap;
            lblGiaGoi.Text = goiTap.giaGoiTap.ToString();
            lblGhiChu.Text = goiTap.ghiChu;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvDanhSachLichSuGoiTap.DataSource = lichSuGoiTapBUS.layLichSuGoiTapTheokhoangThoiGian
                (radTimTheoNgayDangKy.Checked, dtpNgayBatDau.Value, dtpNgayKetThuc.Value);

            resetText();
        }
    }
}
