using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class monTapDAO
    {
        static QuanLyPhongGymNTNEntities db = new QuanLyPhongGymNTNEntities();

        public static List<monTapDTO> load()
        {
            List<monTapDTO> lst = db.MONTAPs.Where(u=>u.XOA == false).Select(u => new monTapDTO
            {
                maMonTap = u.MAMONTAP,
                tenMonTap = u.TENMONTAP,
                ghiChu = u.GHICHU
            }).ToList();

            return lst;
        }

        public static string layTenMonTap(int maMonTap)
        {
            MONTAP kq = db.MONTAPs.FirstOrDefault(u => u.XOA == false && u.MAMONTAP == maMonTap);
            
            return kq==null?"":kq.TENMONTAP;
        }

        public static bool daTonTai(string tenMonTap)
        {
            MONTAP MonTap = db.MONTAPs.FirstOrDefault(u => u.TENMONTAP.Equals(tenMonTap));

            return MonTap != null;
        }

        public static bool them(monTapDTO monTap)
        {
            MONTAP MonTap = new MONTAP
            {
                TENMONTAP = monTap.tenMonTap,
                GHICHU = monTap.ghiChu,
                XOA = false
            };

            db.MONTAPs.Add(MonTap);

            return db.SaveChanges() > 0;
        }

        public static bool sua(monTapDTO monTap, int maMonTap)
        {
            MONTAP MonTap = db.MONTAPs.FirstOrDefault(u => u.MAMONTAP == maMonTap);

            MonTap.TENMONTAP = monTap.tenMonTap;
            MonTap.GHICHU = monTap.ghiChu;

            return db.SaveChanges() > 0;
        }

        public static bool xoa(int maMonTap)
        {
            MONTAP MonTap = db.MONTAPs.FirstOrDefault(u => u.MAMONTAP == maMonTap);

            MonTap.XOA = true;

            return db.SaveChanges() > 0;
        }
    }
}
