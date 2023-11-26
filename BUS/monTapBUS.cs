using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class monTapBUS
    {
        public static List<monTapDTO> load()
        {
            return monTapDAO.load();
        }

        public static string layTenMonTap(int maMonTap)
        {
            return monTapDAO.layTenMonTap(maMonTap);
        }

        public static bool daTonTai(string tenMonTap)
        {
            return monTapDAO.daTonTai(tenMonTap);
        }

        public static bool them(monTapDTO monTap)
        {
            return monTapDAO.them(monTap);
        }

        public static bool sua(monTapDTO monTap, int maMonTap)
        {
            return monTapDAO.sua(monTap, maMonTap);
        }

        public static bool xoa(int maMonTap)
        {
            return monTapDAO.xoa(maMonTap);
        }
    }
}
