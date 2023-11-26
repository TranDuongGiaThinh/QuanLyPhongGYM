using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Const
    {
        #region giá trị số
        public static int khongTimThay = 0;
        public static int viTriDauTien = 0;
        public static int khongCoGiaTri = 0;
        #endregion

        #region loại tài khoản 
        public static int maSuperAdmin = 1;
        public static int maAdmin = 2;
        public static int maPT = 3;
        public static int maKhachHang = 4;
        #endregion


        #region trạng thái hoạt động 
        public static int iTrangThaiHoatDong = 0;
        public static int iTrangThaiBiKhoa = 1;

        public static string strTrangThaiHoatDong = "Hoạt động";
        public static string strTrangThaiBiKhoa = "Bị Khóa";
        #endregion

        #region tài khoản spAdmin
        public static string tenDangNhapSuperAdmin = "SuperAdmin";
        public static string matKhauSuperAdmin = "123";
        public static string moTaLoaiSuperAdmin = "Người sở hữu hệ thống";
        #endregion

        #region tài khoản Admin
        public static string tenLoaiAdmin = "Admin";
        public static string moTaLoaiAdmin = "Người quản trị";
        #endregion

        #region cbbPT
        public static string tenLoaiPT = "PT";
        public static string moTaLoaiPT = "Huấn luyện viên";
        #endregion

        #region cbb khách hàng
        public static string tenLoaiKhachHang = "Khách hàng";
        public static string moTaLoaiKhachHang = "Khách hàng";
        #endregion

        #region Kiểm tra khoảng trắng
        public static char khoangTrang = ' ';
        #endregion

        #region Giới tính
        public static string gioiTinhNam = "Nam";
        public static string gioiTinhNu = "Nữ";
        #endregion

        #region Nhập liệu
        public static string duLieutrong = "Vui lòng nhập liệu!";
        public static string chuaChonDoiTuong = "Vui lòng chọn một đối tượng!";
        #endregion

        #region Đăng nhập
        public static string dangNhapThatBai = "Sai thông tin đăng nhập!";
        public static string dangNhapThanhCong = "Đăng nhập thành công!";
        #endregion

        #region path mặc định
        public static string anhMacDinh = "../../../avatar/avtMacDinh.jpg";
        #endregion

        #region Thêm
        public static string themThanhCong = "Thêm thành công!";
        public static string themThatBai = "Thêm thất bại!";
        #endregion

        #region Sửa
        public static string suaThanhCong = "Sửa thành công!";
        public static string suaThatBai = "Sửa thất bại!";
        #endregion

        #region Xóa
        public static string xoaThanhCong = "Xóa thành công!";
        public static string xoaThatBai = "Xóa thất bại!";
        #endregion

        #region Lưu
        public static string luuThanhCong = "Lưu thành công!";
        public static string luuThatBai = "Lưu thất bại!";
        #endregion

        #region Khóa
        public static string khoaThanhCong = "Khóa thành công!";
        public static string khoaThatBai = "Khóa thất bại!";
        #endregion

        #region mở  Khóa
        public static string moKhoaThanhCong = "Mở khóa thành công!";
        public static string moKhoaThatBai = "Mỏ khóa thất bại!";
        #endregion

        #region Kiểm tra thông tin tồn tại 
        public static string thongTinDaTonTai = "Thông tin đã tồn tại!";
        #endregion

        #region các thông báo xác nhận
        public static string ThongBao = "Thông báo";

        public static string xacNhanXoa = "Bạn có muốn xóa không?";
        public static string xacNhanKhoa = "Bạn có muốn khóa không?";
        public static string xacNhanMoKhoa = "Bạn có muốn mở khóa không?";
        public static string xacNhanThoat = "Bạn có muốn thoát không?";
        #endregion

        #region các  cảnh báo
        public static string emailKhongDungDinhDang = "Email không hợp lệ!";

        public static string yeuCauThayDoiMatKhau = "Bạn đang sử dụng mật khẩu mặc định, hãy thay đổi mật khẩu để tăng tính bảo mật!";
        public static string matKhauKhongChinhXac = "Mật khẩu không chính xác!";

        public static string khongTheXoa = "Đối tượng này đang được sử dụng, không thể xóa!";
        public static string xacNhanXoaBangLienQuan = "Nếu xóa đối tượng, các dữ liệu liên quan đến đối tượng cũng sẽ được xóa! ";
        #endregion



        #region THÔNG TIN CÁ NHÂN
        public static string thongBaoTTCN = "THÔNG BÁO ! ";
        public static string xacNhanSuaTTCN = "Bạn có muốn sửa thông tin cá nhân không  không?";
        public static string thongBaoSuaTTCNTC = "Bạn đã cập nhật thành công thông tin cá nhân!";
        public static string thongBaoSuaTTCNTB = "Bạn chưa cập nhật thành công thông tin cá nhân!";
        public static string thongBaoChuaNhapHoTen = "Bạn chưa Nhập Họ Tên!";
        public static string thongBaoChuaNhapEmail = "Bạn chưa Nhập Email!";
        public static string thongBaoChuaNhapDiaChi = "Bạn chưa Nhập Địa Chỉ!";
        public static string thongBaoChuaNhapDT = "Bạn chưa Nhập Số Diện Thoại!";
        #endregion

        #region Đăng ký gói
        public static int luongPTBuoi = 30000;
        public static int luongPTThang = 20000000;
        public static int giaTapThuong = 15000;
        #endregion
    }
}
