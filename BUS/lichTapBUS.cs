using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Net.Http.Headers;

namespace BUS
{
    public class lichTapBUS
    {
        lichTapDAO ltDAO = new lichTapDAO();

        public List<lichTapDTO> LoadTatCa()
        {
            return ltDAO.LoadTatCa();
        }

        public List<lichTapDTO> LoadTheoHoTen(String hoTen)
        {
            return ltDAO.LoadTheoHoTen(hoTen);
        }

        public List<lichTapDTO> LoadTheoPT(int maPT)
        {
            return ltDAO.LoadTheoPT(maPT);
        }

        public List<lichTapDTO> LoadTheoKhachHang(int maKhachHang)
        {
            return ltDAO.LoadTheoKhachHang(maKhachHang);
        }

        public bool ThemLichTap(int maTaiKhoan)
        {
            return ltDAO.ThemLichTap(maTaiKhoan);
        }

        public bool Luu(lichTapDTO lichTap)
        {
            return ltDAO.Luu(lichTap);
        }

        public bool XoaLich(int maTaiKhoan)
        {
            return ltDAO.XoaLich(maTaiKhoan);
        }
    }
}
