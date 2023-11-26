using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class goiTapBUS
    {
        public static List<goiTapDTO> layDanhSachGoiTap()
        {
            return goiTapDAO.layDanhSachGoiTap();
        }

        public static bool daTonTai(string tenGoiTap)
        {
            return goiTapDAO.daTonTai(tenGoiTap);
        }

        public static bool daTonTai(string tenGoiTapMoi, int maGoiTap)
        {
            return goiTapDAO.daTonTai(tenGoiTapMoi, maGoiTap);
        }

        public static bool dangSuDung(int maGoiTap)
        {
            return goiTapDAO.dangSuDung(maGoiTap);
        }

        public static goiTapDTO layGoiTap(int maGoiTap)
        {
            return goiTapDAO.layGoiTap(maGoiTap);
        }

        public static bool them(goiTapDTO goiTap)
        {
            return goiTapDAO.them(goiTap);
        }

        public static bool sua(goiTapDTO goiTap, int maGoiTap)
        {
            return goiTapDAO.sua(goiTap, maGoiTap);
        }

        public static bool xoa(int maGoiTap)
        {
            return goiTapDAO.xoa(maGoiTap);
        }
    }
}
