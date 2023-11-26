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


namespace QuanLyPhongGymNTN.Admin
{
    public partial class frmQuanLyMonTap : Form
    {
        public frmQuanLyMonTap()
        {
            InitializeComponent();

            dgvDanhSachMontap.AllowUserToAddRows = false;
            dgvDanhSachMontap.AutoGenerateColumns = false;
        }

        public void resetText()
        {
            txtTenMonTap.Text = string.Empty;
            txtGhiChu.Text = string.Empty;

            txtTenMonTap.Select();
        }

        private void frmQuanLyMonTap_Load(object sender, EventArgs e)
        {
            dgvDanhSachMontap.DataSource = monTapBUS.load();

            resetText();
        }

        private void dgvDanhSachMontap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvDanhSachMontap.SelectedRows.Count == 0)
            {
                return;
            }

            txtTenMonTap.Text = dgvDanhSachMontap.SelectedRows[0].Cells[1].Value.ToString();
            txtGhiChu.Text = dgvDanhSachMontap.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMonTap.Text) || string.IsNullOrEmpty(txtGhiChu.Text))
            {
                MessageBox.Show(Const.duLieutrong, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (monTapBUS.daTonTai(txtTenMonTap.Text))
            {
                MessageBox.Show(Const.thongTinDaTonTai, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            monTapDTO monTap = new monTapDTO
            {
                tenMonTap = txtTenMonTap.Text,
                ghiChu = txtGhiChu.Text
            };

            if (monTapBUS.them(monTap))
            {
                MessageBox.Show(Const.themThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.themThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachMontap.DataSource = monTapBUS.load();

            resetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachMontap.SelectedRows.Count == 0)
            {
                    MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
            }

            if (string.IsNullOrEmpty(txtTenMonTap.Text) || string.IsNullOrEmpty(txtGhiChu.Text))
            {
                MessageBox.Show(Const.duLieutrong, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (monTapBUS.daTonTai(txtTenMonTap.Text))
            {
                MessageBox.Show(Const.thongTinDaTonTai, Const.ThongBao,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            int maMonTap = Convert.ToInt32(dgvDanhSachMontap.SelectedRows[0].Cells[0].Value);

            monTapDTO monTap = new monTapDTO
            {
                tenMonTap = txtTenMonTap.Text,
                ghiChu = txtGhiChu.Text
            };

            if (monTapBUS.sua(monTap, maMonTap))
            {
                MessageBox.Show(Const.suaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.suaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachMontap.DataSource = monTapBUS.load();

            resetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachMontap.SelectedRows.Count == 0)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            DialogResult dg = MessageBox.Show(Const.xacNhanXoa, Const.ThongBao,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                return;
            }

            int maMonTap = Convert.ToInt32(dgvDanhSachMontap.SelectedRows[0].Cells[0].Value);

            if (monTapBUS.xoa(maMonTap))
            {
                MessageBox.Show(Const.xoaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.xoaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachMontap.DataSource = monTapBUS.load();

            resetText();
        }
    }
}
