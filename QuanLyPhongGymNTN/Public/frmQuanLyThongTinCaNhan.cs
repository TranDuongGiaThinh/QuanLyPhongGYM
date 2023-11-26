using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QuanLyPhongGymNTN.Public
{
    public partial class frmQuanLyThongTinCaNhan : Form
    {
        int maTaiKhoan;

        public frmQuanLyThongTinCaNhan(int maTaiKhoan)
        {
            InitializeComponent();

            this.maTaiKhoan = maTaiKhoan;
            LoadTTCN(maTaiKhoan);
        }

        public void LoadTTCN(int maTaiKhoan)
        {
            taiKhoanDTO taiKhoan = taiKhoanBUS.layTaiKhoan(maTaiKhoan);

            ptbAnh.Image = taiKhoan.hinhAnh;
            ptbAnh.ImageLocation = taiKhoan.pathHinhAnh;
            txtHoTen.Text = taiKhoan.hoTen;
            txtEmail.Text = taiKhoan.email;
            txtDiaChi.Text = taiKhoan.diaChi;
            txtDienThoai.Text = taiKhoan.dienThoai;
            dtpNgaySinh.Text = taiKhoan.ngaySinh.ToString();
            if (taiKhoan.strGioiTinh == "Nam") 
                { radNam.Checked = true; }
            else 
                { radNu.Checked = true; }
            txtGhiChu.Text = taiKhoan.ghiChu;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (!r.IsMatch(txtEmail.Text))
            {
                MessageBox.Show(Const.emailKhongDungDinhDang, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtEmail.Select();

                return;
            }

            taiKhoanDTO tk = new taiKhoanDTO
            {
                pathHinhAnh = ptbAnh.ImageLocation,
                maLoaiTaiKhoan = Const.maKhachHang,
                hoTen = txtHoTen.Text,
                email = txtEmail.Text,
                diaChi = txtDiaChi.Text,
                dienThoai = txtDienThoai.Text,
                ngaySinh = dtpNgaySinh.Value,
                strGioiTinh = radNam.Checked?"Nam":"Nữ",
                ghiChu = txtGhiChu.Text
            };

            if (taiKhoanBUS.sua(tk, maTaiKhoan))
            {
                //suathanhcong
                MessageBox.Show(Const.thongBaoSuaTTCNTC, Const.thongBaoTTCN, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //thatbai
                MessageBox.Show(Const.thongBaoSuaTTCNTB, Const.thongBaoTTCN, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            LoadTTCN(maTaiKhoan);
        }

        // lọc file ảnh
        private void ptbAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();//tạo đối tượng kết nối
            openFile.Filter = "Picture file (.png,.jpg)|*.png;*.jpg";//hiện những file có đuôi .png và .jpg
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                ptbAnh.Image = Image.FromFile(openFile.FileName);
                ptbAnh.ImageLocation = openFile.FileName;
                ptbAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            } 
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(Const.thongBaoChuaNhapHoTen, Const.thongBaoTTCN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(Const.thongBaoChuaNhapEmail, Const.thongBaoTTCN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(Const.thongBaoChuaNhapDiaChi, Const.thongBaoTTCN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void txtDienThoai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(Const.thongBaoChuaNhapDT, Const.thongBaoTTCN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
