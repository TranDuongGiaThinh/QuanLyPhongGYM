using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class taiKhoanBUS
    {
        public static void taoTaiKhoanSuperAdmin()
        {
            taiKhoanDAO.taoTaiKhoanSuperAdmin();
        }

        public static List<taiKhoanDTO> layDanhSachTacCa()
        {
            return taiKhoanDAO.layDanhSachTacCa();
        }

        public static List<taiKhoanDTO> layDanhSachKhongCoAdmin()
        {
            return taiKhoanDAO.layDanhSachKhongCoAdmin();
        }

        public static List<taiKhoanDTO> layDanhSachTheoLoaiTaiKhoan(int loaiTaiKhoan)
        {
            return taiKhoanDAO.layDanhSachTheoLoaiTaiKhoan(loaiTaiKhoan);
        }

        public static List<taiKhoanDTO> layDanhSachTatCaTheoTrangThai(bool khoa)
        {
            return taiKhoanDAO.layDanhSachTatCaTheoTrangThai(khoa);
        }

        public static List<taiKhoanDTO> layDanhSachTheoTrangThaiKhongCoAdmin(bool khoa)
        {
            return taiKhoanDAO.layDanhSachTheoTrangThaiKhongCoAdmin(khoa);
        }

        public static List<taiKhoanDTO> layDanhSachTatCaTheoHoTen(string hoTen)
        {
            return taiKhoanDAO.layDanhSachTatCaTheoHoTen(hoTen);
        }

        public static List<taiKhoanDTO> layDanhSachTheoHoTenKhongCoAdmin(string hoTen)
        {
            return taiKhoanDAO.layDanhSachTheoHoTenKhongCoAdmin(hoTen);
        }

        public static int demSoTaiKhoan()
        {
            return taiKhoanDAO.demSoTaiKhoan();
        }

        public static taiKhoanDTO layTaiKhoan(int maTaiKhoan)
        {
            return taiKhoanDAO.layTaiKhoan(maTaiKhoan);
        }

        public static string layHoTen(int maTK)
        {
            return taiKhoanDAO.layHoTen(maTK);
        }

        public static string[] layTatCaHoTen()
        {
            return taiKhoanDAO.layTatCaHoTen();
        }

        public static string[] layTatCaHoTenKhongCoAdmin()
        {
            return taiKhoanDAO.layTatCaHoTenKhongCoAdmin();
        }

        public static int layMaTaiKhoan(string tenDangNhap, string matKhau)
        {
            return taiKhoanDAO.layMaTaiKhoan(tenDangNhap, matKhau);
        }

        public static bool taiKhoanHopLe(string tenDangNhap, string matKhau)
        {
            return taiKhoanDAO.taiKhoanHopLe(tenDangNhap, matKhau);
        }

        public static bool chuaDoiMatKhau(string tenDangNhap, string matKhau)
        {
            return taiKhoanDAO.taiKhoanHopLe(tenDangNhap, matKhau);
        }

        public static int layMaLoaiTaiKhoan(int maTK)
        {
            return taiKhoanDAO.layMaLoaiTaiKhoan(maTK);
        }

        public static bool daTonTai(string tenDangNhap)
        {
            return taiKhoanDAO.daTonTai(tenDangNhap);
        }

        public static bool them(taiKhoanDTO tk)
        {
            return taiKhoanDAO.them(tk);
        }

        public static bool sua(taiKhoanDTO tk, int maTK)
        {
            return taiKhoanDAO.sua(tk, maTK);
        }

        public static bool doiMatKhau(string matKhau, int maTK)
        {
            return taiKhoanDAO.doiMatKhau(matKhau, maTK);
        }

        public static bool khoa(int maTK)
        {
            return taiKhoanDAO.khoa(maTK);
        }

        public static bool moKhoa(int maTK)
        {
            return taiKhoanDAO.moKhoa(maTK);
        }

        public static bool xoa(int maTK)
        {
            return taiKhoanDAO.xoa(maTK);
        }
    }
}
