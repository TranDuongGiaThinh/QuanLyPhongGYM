using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class goiTapDAO
    {
        static QuanLyPhongGymNTNEntities db = new QuanLyPhongGymNTNEntities();

        public static List<goiTapDTO> layDanhSachGoiTap()
        {
            List<goiTapDTO> lst = db.GOITAPs.Where(u=>u.XOA == false).Select(u => new goiTapDTO
            {
                maGoiTap = u.MAGOITAP,
                tenGoiTap = u.TENGOITAP,
                maMonTap = u.MAMONTAP,
                tenMonTap = u.MONTAP.TENMONTAP,
                giaGoiTap = u.GIAGOITAP,
                ghiChu = u.GHICHU
            }).ToList();

            return lst;
        }

        public static goiTapDTO layGoiTap(int maGoiTap)
        {
            GOITAP goiTap = db.GOITAPs.FirstOrDefault(u => u.MAGOITAP == maGoiTap);

            goiTapDTO kq = new goiTapDTO
            {
                maGoiTap = goiTap.MAGOITAP,
                tenGoiTap = goiTap.TENGOITAP,
                maMonTap = goiTap.MAMONTAP,
                tenMonTap = goiTap.MONTAP.TENMONTAP,
                giaGoiTap = goiTap.GIAGOITAP,
                ghiChu = goiTap.GHICHU
            };

            return kq;
        }

        public static bool daTonTai(string tenGoiTap)
        {
            GOITAP GoiTap = db.GOITAPs.FirstOrDefault(u => u.TENGOITAP.Equals(tenGoiTap));

            return GoiTap != null;
        }

        public static bool daTonTai(string tenGoiTapMoi, int maGoitap)
        {
            GOITAP GoiTap = db.GOITAPs.FirstOrDefault(u => u.TENGOITAP.Equals(tenGoiTapMoi)
                && maGoitap != u.MAGOITAP);

            return GoiTap != null;
        }

        public static bool dangSuDung(int maGoitap)
        {
            LICHSUGOITAP lsgt = db.LICHSUGOITAPs.FirstOrDefault(u => u.MAGOITAP == maGoitap && u.XOA == false);

            return lsgt != null;
        }

        public static bool them(goiTapDTO goiTap)
        {
            GOITAP GoiTap = new GOITAP
            {
                TENGOITAP = goiTap.tenGoiTap,
                MAMONTAP = goiTap.maMonTap,
                GIAGOITAP = goiTap.giaGoiTap,
                GHICHU = goiTap.ghiChu,
                XOA = false
            };

            db.GOITAPs.Add(GoiTap);

            return db.SaveChanges() > Const.khongCoGiaTri;
        }

        public static bool sua(goiTapDTO goiTap, int maGoiTap)
        {
            GOITAP GoiTap = db.GOITAPs.SingleOrDefault(u => u.MAGOITAP.Equals(maGoiTap));

            GoiTap.TENGOITAP = goiTap.tenGoiTap;
            GoiTap.MAMONTAP = goiTap.maMonTap;
            GoiTap.GIAGOITAP = goiTap.giaGoiTap;
            GoiTap.GHICHU = goiTap.ghiChu;

            return db.SaveChanges() > Const.khongCoGiaTri;
        }

        public static bool xoa(int maGoiTap)
        {
            GOITAP TK = db.GOITAPs.SingleOrDefault(u => u.MAGOITAP.Equals(maGoiTap));

            TK.XOA = true;

            return db.SaveChanges() > Const.khongCoGiaTri;
        }
    }
}
