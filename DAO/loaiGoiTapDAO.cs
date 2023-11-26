using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class loaiGoiTapDAO
    {
        static QuanLyPhongGymNTNEntities db = new QuanLyPhongGymNTNEntities();

        public static List<loaiGoiTapDTO> layDanhSachLoaiGoiTap()
        {
            List<loaiGoiTapDTO> lst = db.LOAIGOITAPs.Where(u=>u.XOA == false).Select(u => new loaiGoiTapDTO
            {
                maLoaiGoiTap = u.MALOAIGOITAP,
                tenLoaiGoiTap = u.TENLOAIGOITAP,
                thoiGian = u.THOIGIAN
            }).ToList();

            return lst;
        }

        public static bool datontai(string tenLoaiGoiTap)
        {
            LOAIGOITAP kq = db.LOAIGOITAPs.FirstOrDefault(u => u.TENLOAIGOITAP.Equals(tenLoaiGoiTap));

            return kq!=null;
        }

        public static bool datontai(string tenLoaiGoiTap, int maLoaiGoiTap)
        {
            LOAIGOITAP kq = db.LOAIGOITAPs.FirstOrDefault(u => u.TENLOAIGOITAP.Equals(tenLoaiGoiTap)
                && u.MALOAIGOITAP != maLoaiGoiTap);

            return kq != null;
        }

        public static bool dangSuDung(int maLoaiGoiTap)
        {
            LICHSUGOITAP lsgt = db.LICHSUGOITAPs.FirstOrDefault(u => u.MALOAIGOITAP == maLoaiGoiTap && u.XOA == false);

            return lsgt != null;
        }

        public static int layThoiGianGoiTap(int maGoiTap)
        {
            LOAIGOITAP kq = db.LOAIGOITAPs.FirstOrDefault(u => u.MALOAIGOITAP == maGoiTap);
            
            return kq.THOIGIAN;
        }

        public static bool them(loaiGoiTapDTO loaiGoiTap)
        {
            LOAIGOITAP LoaiGoiTap = new LOAIGOITAP
            {
                TENLOAIGOITAP = loaiGoiTap.tenLoaiGoiTap,
                THOIGIAN = loaiGoiTap.thoiGian,
                XOA = false
            };

            db.LOAIGOITAPs.Add(LoaiGoiTap);

            return db.SaveChanges() > Const.khongCoGiaTri;
        }

        public static bool sua(loaiGoiTapDTO loaiGoiTap, int maLoaiGoiTap)
        {
            LOAIGOITAP LoaiGoiTap = db.LOAIGOITAPs.SingleOrDefault(u => u.MALOAIGOITAP.Equals(maLoaiGoiTap));

            LoaiGoiTap.TENLOAIGOITAP = loaiGoiTap.tenLoaiGoiTap;
            LoaiGoiTap.THOIGIAN = loaiGoiTap.thoiGian;

            return db.SaveChanges() > Const.khongCoGiaTri;
        }

        public static bool xoa(int maLoaiGoiTap)
        {
            LOAIGOITAP LoaiGoiTap = db.LOAIGOITAPs.SingleOrDefault(u => u.MALOAIGOITAP.Equals(maLoaiGoiTap));

            LoaiGoiTap.XOA = true;

            return db.SaveChanges() > Const.khongCoGiaTri;
        }
    }
}
