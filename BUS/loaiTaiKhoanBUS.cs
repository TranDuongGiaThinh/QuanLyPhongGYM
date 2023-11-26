using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class loaiTaiKhoanBUS
    {
        public static List<loaiTaiKhoanDTO> layDanhSachLoaiTaiKhoan()
        {
            return loaiTaiKhoanDAO.layDanhSachLoaiTaiKhoan();
        }
        public static List<loaiTaiKhoanDTO> layDanhSachKhongCoSuperAdmin()
        {
            return loaiTaiKhoanDAO.layDanhSachKhongCoSuperAdmin();
        }

        public static List<loaiTaiKhoanDTO> layDanhSachKhongCoAdmin()
        {
            return loaiTaiKhoanDAO.layDanhSachKhongCoAdmin();
        }

        public static string layTenLoaiTaiKhoan(int maLTK)
        {
            return loaiTaiKhoanDAO.layTenLoaiTaiKhoan(maLTK);
        }

        public static bool daTonTai(string tenLTK)
        {
            return loaiTaiKhoanDAO.daTonTai(tenLTK);
        }

        public static bool daTonTai(string tenLTK, int maLTK)
        {
            return loaiTaiKhoanDAO.daTonTai(tenLTK, maLTK);
        }

        public static bool them(loaiTaiKhoanDTO ltk)
        {
            return loaiTaiKhoanDAO.them(ltk);
        }

        public static bool sua(loaiTaiKhoanDTO ltk, int maLTK)
        {
            return loaiTaiKhoanDAO.sua(ltk, maLTK);
        }

        public static bool xoa(int maLTK)
        {
            return loaiTaiKhoanDAO.xoa(maLTK);
        }
    }
}
