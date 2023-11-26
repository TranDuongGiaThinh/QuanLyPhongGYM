using DTO;
using BUS;
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
    public partial class frmDangKyGoiTap : Form
    {
        int maKhachHang;
        goiTapDTO goiTap;

        double tongTien;

        public frmDangKyGoiTap(int makh, goiTapDTO gt)
        {
            InitializeComponent();

            this.maKhachHang = makh;
            this.goiTap = gt;

            dtpNgayHetHan.Enabled = false;
        }

        private void frmDangKyGoiTap_Load(object sender, EventArgs e)
        {
            cbbLoaiGoiTap.DataSource = loaiGoiTapBUS.layDanhSachLoaiGoiTap();
            cbbLoaiGoiTap.DisplayMember = "tenloaigoitap";
            cbbLoaiGoiTap.ValueMember = "maloaigoitap";

            cbbPT.DataSource = taiKhoanBUS.layDanhSachTheoLoaiTaiKhoan(Const.maPT);
            cbbPT.DisplayMember = "hoten";
            cbbPT.ValueMember = "mataikhoan";

            lblTenGoiTap.Text = goiTap.tenGoiTap;
            lblTenMonTap.Text = monTapBUS.layTenMonTap(goiTap.maMonTap);
            lblGiaGoi.Text = goiTap.giaGoiTap.ToString();

            if (cbbLoaiGoiTap.Items.Count != Const.khongCoGiaTri)
                cbbLoaiGoiTap.SelectedIndex = Const.viTriDauTien;

            if (cbbPT.Items.Count != Const.khongCoGiaTri)
                cbbPT.SelectedIndex = Const.viTriDauTien;

            dtpNgayDangKy.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now;

            chkChonPT.Checked = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maTheTap = theTapBUS.layMaTheTap(maKhachHang);

            lichSuGoiTapDTO lsgt = new lichSuGoiTapDTO
            {
                maGoiTap = goiTap.maGoiTap,
                maLoaiGoiTap = Convert.ToInt32(cbbLoaiGoiTap.SelectedValue),
                ngayDangKy = dtpNgayDangKy.Value,
                ngayHetHan =dtpNgayHetHan.Value
            };

            if(chkChonPT.Checked)
                lsgt.maPT = Convert.ToInt32(cbbPT.SelectedValue);

            if (lichSuGoiTapBUS.them(lsgt, maTheTap))
            {
                MessageBox.Show(Const.themThanhCong, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Const.themThatBai, Const.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tinhTien(object sender, EventArgs e)
        {
            loaiGoiTapDTO lgt = (loaiGoiTapDTO) cbbLoaiGoiTap.SelectedItem;
            double thoiGianGoi = lgt.thoiGian;

            dtpNgayHetHan.Value = dtpNgayDangKy.Value.AddDays(thoiGianGoi);

            if (chkChonPT.Checked)
            {
                tongTien = (goiTap.giaGoiTap + (Const.luongPTBuoi * thoiGianGoi));
            }
            else
            {
                tongTien = goiTap.giaGoiTap +(Const.giaTapThuong*thoiGianGoi);
            }

            lblTongTien.Text = tongTien.ToString();
        }
    }
}
