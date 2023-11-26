using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongGymNTN
{
    class Const
    {
        public static int khongTimThay = 0;
        public static int viTriDauTien = 0;
        public static int khongCoGiaTri = 0;

        public static int maSuperAdmin = 1;
        public static int maAdmin = 2;
        public static int maPT = 3;
        public static int maKhachHang = 4;

        public static int trangThaiHoatDong = 0;
        public static int trangThaiBiKhoa = 1;


        public static string tenSuperAdmin = "SuperAdmin";
        public static string matKhauSuperAdmin = "123";

        public static string duLieutrong = "Vui lòng nhập liệu!";
        public static string chuaChonDoiTuong = "Vui lòng chọn một đối tượng!";

        public static string dangNhapThatBai = "Sai thông tin đăng nhập!";
        public static string dangNhapThanhCong = "Đăng nhập thành công!";

        public static string themThanhCong = "Thêm thành công!";
        public static string themThatBai = "Thêm thất bại!";

        public static string suaThanhCong = "Sửa thành công!";
        public static string suaThatBai = "Sửa thất bại!";

        public static string xoaThanhCong = "Xóa thành công!";
        public static string xoaThatBai = "Xóa thất bại!";

        public static string luuThanhCong = "Lưu thành công!";
        public static string luuThatBai = "Lưu thất bại!";

        public static string khoaThanhCong = "Khóa thành công!";
        public static string khoaThatBai = "Khóa thất bại!";

        public static string moKhoaThanhCong = "Mở khóa thành công!";
        public static string moKhoaThatBai = "Mỏ khóa thất bại!";

        public static string thongTinDaCo = "Thông tin đã tồn tại!";

        public static string messThongBao = "Thông báo";

        public static string xacNhanXoa = "Bạn có muốn xóa không?";
        public static string xacNhanKhoa = "Bạn có muốn khóa không?";
        public static string xacNhanMoKhoa = "Bạn có muốn mở khóa không?";
        public static string xacNhanThoat = "Bạn có muốn thoát không?";
        
        public static string thayDoiMatKhauChoLanDauMoApp = "Đây là lần đăng nhập đầu tiên, bạn hãy thay đổi mật khẩu cho " +
            "tài khoản SuperAdmin (mật khẩu mặt định là: "+matKhauSuperAdmin+")";
        public static string matKhauKChinhXac = "Mật khẩu không chính xác!";

        public static string xacNhanXoaBangLienQuan = "Nếu xóa đối tượng, các dữ liệu liên quan đến đối tượng cũng sẽ được xóa! ";


        #region THÔNG TIN CÁ NHÂN
        public static string thongBaoTTCN = "THÔNG BÁO ! ";
        public static string xacNhanSuaTTCN = "Bạn có muốn sửa thông tin cá nhân không  không?";
        public static string thongBaoSuaTTCNTC = "Bạn đã cập nhật thành công thông tin cá nhân!";
        public static string thongBaoSuaTTCNTB = "Bạn chưa cập nhật thành công thông tin cá nhân!";
        #endregion
    }
}
