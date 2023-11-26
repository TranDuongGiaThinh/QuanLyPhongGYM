using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class loaiGoiTapBUS
    {
        public static List<loaiGoiTapDTO> layDanhSachLoaiGoiTap()
        {
            return loaiGoiTapDAO.layDanhSachLoaiGoiTap();
        }

        public static int layThoiGianGoiTap(int maGoiTap)
        {
            return loaiGoiTapDAO.layThoiGianGoiTap(maGoiTap);
        }

        public static bool datontai(string tenLoaiGoiTap)
        {
            return loaiGoiTapDAO.datontai(tenLoaiGoiTap);
        }

        public static bool datontai(string tenLoaiGoiTap, int maLoaiGoiTap)
        {
            return loaiGoiTapDAO.datontai(tenLoaiGoiTap, maLoaiGoiTap);
        }

        public static bool dangSuDung(int maLoaiGoiTap)
        {
            return loaiGoiTapDAO.dangSuDung(maLoaiGoiTap);
        }

        public static bool them(loaiGoiTapDTO loaiGoiTap)
        {
            return loaiGoiTapDAO.them(loaiGoiTap);
        }

        public static bool sua(loaiGoiTapDTO loaiGoiTap, int maLoaiGoiTap)
        {
            return loaiGoiTapDAO.sua(loaiGoiTap,maLoaiGoiTap);
        }

        public static bool xoa(int maLoaiGoiTap)
        {
            return loaiGoiTapDAO.xoa(maLoaiGoiTap);
        }
    }
}
