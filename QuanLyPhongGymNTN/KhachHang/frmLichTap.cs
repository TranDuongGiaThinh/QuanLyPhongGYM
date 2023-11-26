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

namespace QuanLyPhongGymNTN.KhachHang
{
    public partial class frmLichTap : Form
    {
        int maTaiKhoan;
        BUS.lichTapBUS bus = new BUS.lichTapBUS();
        string[] arr = { "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy", "Chủ nhật" };

        public frmLichTap(int maTaiKhoan)
        {
            InitializeComponent();

            dgvLichTap.AllowUserToAddRows = false;
            dgvLichTap.AutoGenerateColumns = false;
            dgvLichTap.ReadOnly = true;

            this.maTaiKhoan = maTaiKhoan;
        }

        private void frmLichTap_Load(object sender, EventArgs e)
        {
            cbbNgayTap.DataSource = arr;
            cbbNgayTap.SelectedIndex = Const.viTriDauTien;

            dgvLichTap.DataSource = bus.LoadTheoKhachHang(maTaiKhoan);

            if(dgvLichTap.Rows.Count>0 && dgvLichTap.Rows[0].Cells["TenPT"].Value !=null)
                lblTenPT.Text = dgvLichTap.Rows[0].Cells["TenPT"].Value.ToString();
        }

        private void dgvLichTap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(Array.IndexOf(arr, dgvLichTap.Columns[e.ColumnIndex].HeaderText) == -1 || i==-1)
            {
                return;
            }

            cbbNgayTap.SelectedIndex = Array.IndexOf(arr, dgvLichTap.Columns[e.ColumnIndex].HeaderText);
            dtpThoiGian.Value = Convert.ToDateTime(dgvLichTap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvLichTap.Rows.Count == 0)
            {
                bus.ThemLichTap(maTaiKhoan);

                if (dgvLichTap.Rows.Count > 0 && dgvLichTap.Rows[0].Cells["TenPT"].Value != null)
                    lblTenPT.Text = dgvLichTap.Rows[0].Cells["TenPT"].Value.ToString();

                dgvLichTap.DataSource = bus.LoadTheoKhachHang(maTaiKhoan);

                return;
            }

            dgvLichTap.Rows[0].Cells[cbbNgayTap.SelectedIndex + 2].Value = dtpThoiGian.Value.ToString("hh:mm");
            if (cbbNgayTap.SelectedIndex < 6)
                cbbNgayTap.SelectedIndex = cbbNgayTap.SelectedIndex + 1;
            else
                cbbNgayTap.SelectedIndex = Const.viTriDauTien;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvLichTap.Rows.Count == 0)
                return;

            lichTapDTO lichTap = new lichTapDTO();

            lichTap.MATHETAP = Convert.ToInt32(dgvLichTap.Rows[0].Cells[0].Value);
            lichTap.THUHAI = dgvLichTap.Rows[0].Cells[2].Value !=null ? dgvLichTap.Rows[0].Cells[2].Value.ToString():"";
            lichTap.THUBA = dgvLichTap.Rows[0].Cells[3].Value != null ? dgvLichTap.Rows[0].Cells[3].Value.ToString() : "";
            lichTap.THUTU = dgvLichTap.Rows[0].Cells[4].Value != null ? dgvLichTap.Rows[0].Cells[4].Value.ToString() : "";
            lichTap.THUNAM = dgvLichTap.Rows[0].Cells[5].Value != null ? dgvLichTap.Rows[0].Cells[5].Value.ToString() : "";
            lichTap.THUSAU = dgvLichTap.Rows[0].Cells[6].Value != null ? dgvLichTap.Rows[0].Cells[6].Value.ToString() : "";
            lichTap.THUBAY = dgvLichTap.Rows[0].Cells[7].Value != null ? dgvLichTap.Rows[0].Cells[7].Value.ToString() : "";
            lichTap.CHUNHAT = dgvLichTap.Rows[0].Cells[8].Value != null ? dgvLichTap.Rows[0].Cells[8].Value.ToString() : "";

            if (bus.Luu(lichTap))
            {
                MessageBox.Show(Const.luuThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.luuThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvLichTap.DataSource = bus.LoadTheoKhachHang(maTaiKhoan);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bus.XoaLich(maTaiKhoan))
            {
                MessageBox.Show(Const.xoaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.xoaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvLichTap.DataSource = bus.LoadTheoKhachHang(maTaiKhoan);
        }
    }
}
