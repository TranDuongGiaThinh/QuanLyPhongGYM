using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class lichSuGoiTapBUS
    {
        public static List<lichSuGoiTapDTO> layLichSuGoiTap(int maTheTap)
        {
            return lichSuGoiTapDAO.layLichSuGoiTap(maTheTap);
        }

        public static List<lichSuGoiTapDTO> layLichSuGoiTapTheokhoangThoiGian(bool timTheoNgayDangKy, DateTime ngayBatDau, DateTime ngaKetThuc)
        {
            return lichSuGoiTapDAO.layLichSuGoiTapTheokhoangThoiGian(timTheoNgayDangKy, ngayBatDau, ngaKetThuc);
        }

        public static bool them(lichSuGoiTapDTO lsgt, int maTheTap)
        {
            return lichSuGoiTapDAO.them(lsgt, maTheTap);
        }

        public static string layHoTen(int maTheTap)
        {
            return lichSuGoiTapDAO.layHoTen(maTheTap);
        }
    }
}
