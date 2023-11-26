using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyPhongGymNTN.Admin
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        int maLoaiTaiKhoan;

        public frmQuanLyTaiKhoan(int maLTK)
        {
            InitializeComponent();

            this.maLoaiTaiKhoan = maLTK;

            dgvDanhSachTaiKhoan.AutoGenerateColumns = false;
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            string[] lstHoten = layDanhSachTheoHoTen();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(lstHoten);
            txtTimKiemHoTen.AutoCompleteCustomSource = source;

            cbbLoaiTaiKhoanTimKiem.DataSource = LayDanhSachLoaiTaiKhoan();
            cbbLoaiTaiKhoanTimKiem.DisplayMember = "tenLoaiTaiKhoan";
            cbbLoaiTaiKhoanTimKiem.ValueMember = "maLoaiTaiKhoan";

            cbbLoaiTaiKhoanThongTin.DataSource = LayDanhSachLoaiTaiKhoan();
            cbbLoaiTaiKhoanThongTin.DisplayMember = "tenLoaiTaiKhoan";
            cbbLoaiTaiKhoanThongTin.ValueMember = "maLoaiTaiKhoan";

            dgvDanhSachTaiKhoan.DataSource = LayDanhSachTaiKhoan();

            lamMoi();
        }
        
        public List<loaiTaiKhoanDTO> LayDanhSachLoaiTaiKhoan()
        {
            if (maLoaiTaiKhoan == Const.maSuperAdmin)
                return loaiTaiKhoanBUS.layDanhSachKhongCoSuperAdmin();
            else
                return loaiTaiKhoanBUS.layDanhSachKhongCoAdmin();
        }

        public List<taiKhoanDTO> LayDanhSachTaiKhoan()
        {
            if (maLoaiTaiKhoan == Const.maSuperAdmin)
                return taiKhoanBUS.layDanhSachTacCa();
            else
                return taiKhoanBUS.layDanhSachKhongCoAdmin();
        }

        public string[] layDanhSachTheoHoTen()
        {
            if (maLoaiTaiKhoan == Const.maSuperAdmin)
                return taiKhoanBUS.layTatCaHoTen();
            else
                return taiKhoanBUS.layTatCaHoTenKhongCoAdmin();
        }

        public List<taiKhoanDTO> layDanhSachTheoTrangThai(bool khoa)
        {
            if (maLoaiTaiKhoan == Const.maSuperAdmin)
                return taiKhoanBUS.layDanhSachTatCaTheoTrangThai(khoa);
            else
                return taiKhoanBUS.layDanhSachTheoTrangThaiKhongCoAdmin(khoa);
        }

        public List<taiKhoanDTO> layDanhSachTheoHoTen(string hoTen)
        {
            if (maLoaiTaiKhoan == Const.maSuperAdmin)
                return taiKhoanBUS.layDanhSachTatCaTheoHoTen(hoTen);
            else
                return taiKhoanBUS.layDanhSachTheoHoTenKhongCoAdmin(hoTen);
        }

        void lamMoi()
        {
            ptbAnh.Image = chuyenAnh(Const.anhMacDinh);
            ptbAnh.ImageLocation = null;
            txtHoTen.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
            radNam.Checked = true;
            txtGhiChu.Text = string.Empty;

            txtTenDangNhap.Text = string.Empty;
            txtMatKhau.Text = string.Empty;

            cbbLoaiTaiKhoanThongTin.SelectedValue = Const.maKhachHang;
            cbbLoaiTaiKhoanTimKiem.SelectedValue = Const.maKhachHang;

            cbbTrangThai.SelectedIndex = Const.viTriDauTien;

            radTatCa.Checked = true;
            txtTimKiemHoTen.Text = string.Empty;

            gbThongTinDangNhap.Visible = true;

            btnThem.Enabled = true;

            txtHoTen.Select();
        }

        public static Image chuyenAnh(string strAnh)
        {
            byte[] byteAnh = File.ReadAllBytes(string.Format(@"{0}", strAnh));

            using (MemoryStream ms = new MemoryStream(byteAnh))
            {
                Image img = Image.FromStream(ms);
                return img;
            }
        }

        private void dgvDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachTaiKhoan.SelectedRows.Count == Const.khongCoGiaTri)
            {
                return;
            }

            txtHoTen.Text = dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["hoten"].Value.ToString();
            txtEmail.Text = dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["email"].Value.ToString();
            txtDiaChi.Text = dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["diachi"].Value.ToString();
            txtDienThoai.Text = dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["dienthoai"].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["ngaysinh"].Value);
            
            if (dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["gioitinh"].Value.Equals("Nam"))
                radNam.Checked = true;
            else
                radNu.Checked = true;
            
            if (dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["ghichu"].Value != null)
                txtGhiChu.Text = dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["ghichu"].Value.ToString();
            
            cbbLoaiTaiKhoanThongTin.Text = dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["loaitaikhoan"].Value.ToString();

            if (dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["pathAnh"].Value != null)
            {
                ptbAnh.ImageLocation = dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["pathAnh"].Value.ToString();
                ptbAnh.Image = chuyenAnh(ptbAnh.ImageLocation);
            }

            else
            {
                ptbAnh.ImageLocation = null;
                ptbAnh.Image = chuyenAnh(Const.anhMacDinh);
            }
            int maLTK = taiKhoanBUS.layMaLoaiTaiKhoan(Convert.ToInt32(dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["mataikhoan"].Value));

            bool biKhoa = dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["trangthai"].Value.Equals(Const.strTrangThaiBiKhoa);
            if (biKhoa)
            {
                btnKhoa.Enabled = false;
                btnMoKhoa.Enabled = true;
            }
            else
            {
                btnKhoa.Enabled = true;
                btnMoKhoa.Enabled = false;
            }

            btnThem.Enabled = false;

            gbThongTinDangNhap.Visible = false;
        }

        private void ptbAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png,.jpg)|*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = Image.FromFile(openFile.FileName);
                ptbAnh.ImageLocation = openFile.FileName;
            }
        }

        public taiKhoanDTO layTaiKhoanNhapVao()
        {
            taiKhoanDTO taiKhoan = new taiKhoanDTO
            {
                tenDangNhap = txtTenDangNhap.Text,
                matKhau = txtMatKhau.Text,
                maLoaiTaiKhoan = Convert.ToInt32(cbbLoaiTaiKhoanThongTin.SelectedValue),
                pathHinhAnh = (ptbAnh.ImageLocation == Const.anhMacDinh) ? null : ptbAnh.ImageLocation,
                hoTen = txtHoTen.Text,
                email = txtEmail.Text,
                diaChi = txtDiaChi.Text,
                dienThoai = txtDienThoai.Text,
                ngaySinh = dtpNgaySinh.Value,
                strGioiTinh = radNam.Checked ? Const.gioiTinhNam : Const.gioiTinhNu,
                ghiChu = txtGhiChu.Text
            };

            return taiKhoan;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHoTen.Text) 
                || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtDiaChi.Text)
                || string.IsNullOrEmpty(txtDienThoai.Text)
                || string.IsNullOrEmpty(txtTenDangNhap.Text)
                || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(Const.duLieutrong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Regex dinhDangEmail = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (!dinhDangEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show(Const.emailKhongDungDinhDang, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtEmail.Select();
                return;
            }

            if (taiKhoanBUS.daTonTai(txtTenDangNhap.Text))
            {
                MessageBox.Show(Const.thongTinDaTonTai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            taiKhoanDTO taiKhoan = layTaiKhoanNhapVao();

            if (taiKhoanBUS.them(taiKhoan))
            {
                MessageBox.Show(Const.themThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.themThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachTaiKhoan.DataSource = LayDanhSachTaiKhoan();
            lamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTaiKhoan.SelectedRows.Count == Const.khongCoGiaTri)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtHoTen.Text)
                || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtDiaChi.Text)
                || string.IsNullOrEmpty(txtDienThoai.Text))
            {
                MessageBox.Show(Const.duLieutrong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Regex r = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (!r.IsMatch(txtEmail.Text))
            {
                MessageBox.Show(Const.emailKhongDungDinhDang, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtEmail.Select();
                return;
            }

            if (taiKhoanBUS.daTonTai(txtTenDangNhap.Text))
            {
                MessageBox.Show(Const.thongTinDaTonTai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int maTaiKhoan = Convert.ToInt32(dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["mataikhoan"].Value);

            taiKhoanDTO taiKhoan = layTaiKhoanNhapVao();

            if (taiKhoanBUS.sua(taiKhoan, maTaiKhoan))
            {
                MessageBox.Show(Const.suaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.suaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachTaiKhoan.DataSource = LayDanhSachTaiKhoan();
            lamMoi();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachTaiKhoan.SelectedRows.Count == Const.khongCoGiaTri)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dg = MessageBox.Show(Const.xacNhanKhoa, Const.ThongBao,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                return;
            }

            int maTK = Convert.ToInt32(dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["mataikhoan"].Value);

            if (taiKhoanBUS.khoa(maTK))
            {
                MessageBox.Show(Const.khoaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.khoaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachTaiKhoan.DataSource = LayDanhSachTaiKhoan();
            lamMoi();
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTaiKhoan.SelectedRows.Count == Const.khongCoGiaTri)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            DialogResult dg = MessageBox.Show(Const.xacNhanMoKhoa, Const.ThongBao,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                return;
            }

            int maTK = Convert.ToInt32(dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["mataikhoan"].Value);

            if (taiKhoanBUS.moKhoa(maTK))
            {
                MessageBox.Show(Const.moKhoaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.moKhoaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachTaiKhoan.DataSource = LayDanhSachTaiKhoan();
            lamMoi();
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                dgvDanhSachTaiKhoan.DataSource = LayDanhSachTaiKhoan();

                return;
            }

            if (radTrangThai.Checked)
            {
                bool khoa = cbbTrangThai.SelectedIndex!=Const.iTrangThaiHoatDong;

                dgvDanhSachTaiKhoan.DataSource = layDanhSachTheoTrangThai(khoa);

                return;
            }

            if (radLoaiTaiKhoan.Checked)
            {
                int loaiTaiKhoan =  Convert.ToInt32(cbbLoaiTaiKhoanTimKiem.SelectedValue);

                dgvDanhSachTaiKhoan.DataSource = taiKhoanBUS.layDanhSachTheoLoaiTaiKhoan(loaiTaiKhoan);

                return;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTaiKhoan.SelectedRows.Count == Const.khongCoGiaTri)
            {
                MessageBox.Show(Const.chuaChonDoiTuong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            DialogResult dg = MessageBox.Show(Const.xacNhanXoaBangLienQuan + Const.xacNhanXoa, Const.ThongBao,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                return;
            }

            int maTK = Convert.ToInt32(dgvDanhSachTaiKhoan.SelectedRows[Const.viTriDauTien].Cells["mataikhoan"].Value);

            if (taiKhoanBUS.xoa(maTK))
            {
                MessageBox.Show(Const.xoaThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.xoaThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachTaiKhoan.DataSource = LayDanhSachTaiKhoan();
            lamMoi();
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

            if(txtDienThoai.Text.Length >= 10 && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Const.khoangTrang) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Const.khoangTrang) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Const.khoangTrang) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTimKiemHoTen_TextChanged(object sender, EventArgs e)
        {
            if (!radHoten.Checked)
            {
                return;
            }

            string hoTen = txtTimKiemHoTen.Text;

            dgvDanhSachTaiKhoan.DataSource = layDanhSachTheoHoTen(hoTen);
        }
    }
}
