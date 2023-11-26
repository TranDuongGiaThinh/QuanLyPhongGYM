using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class theTapBUS
    {
        public static List<theTapDTO> loadTatCa()
        {
            return theTapDAO.loadTatCa();
        }

        public static List<theTapDTO> loadTheHetHan()
        {
            return theTapDAO.loadTheHetHan();
        }

        public static List<theTapDTO> loadTheoTrangThai(bool trangThai)
        {
            return theTapDAO.loadTheoTrangThai(trangThai);
        }

        public static theTapDTO layTheTap(int maTheTap)
        {
            return theTapDAO.layTheTap(maTheTap);
        }

        public static int layMaTheTap(int maKhachHang)
        {
            return theTapDAO.layMaTheTap(maKhachHang);
        }

        public static bool khoa(int maTheTap)
        {
            return theTapDAO.khoa(maTheTap);
        }

        public static bool moKhoa(int maTheTap)
        {
            return theTapDAO.moKhoa(maTheTap);
        }

        public static bool xoa(int maTheTap)
        {
            return theTapDAO.xoa(maTheTap);
        }
    }
}
