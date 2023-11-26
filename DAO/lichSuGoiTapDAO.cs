using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class lichSuGoiTapDAO
    {
        static QuanLyPhongGymNTNEntities db = new QuanLyPhongGymNTNEntities();

        public static List<lichSuGoiTapDTO> layLichSuGoiTap(int maTheTap)
        {
            List<lichSuGoiTapDTO> lst = db.LICHSUGOITAPs.Where(u =>u.MATHETAP == maTheTap && u.XOA == false).Select(u => new lichSuGoiTapDTO
            {
                maGoiTap = u.MAGOITAP,
                tenGoiTap = u.GOITAP.TENGOITAP,
                tenLoaiGoitap = u.LOAIGOITAP.TENLOAIGOITAP,
                maPT = u.MAPT!=null?u.MAPT.Value:0,
                ngayDangKy = u.NGAYDANGKY,
                ngayHetHan = u.NGAYHETHAN
            }).ToList();

            foreach (lichSuGoiTapDTO lsgt in lst)
            {
                if (lsgt.maPT != 0)
                    lsgt.tenPT = taiKhoanDAO.layHoTen(lsgt.maPT);
            }

            return lst;
        }

        public static List<lichSuGoiTapDTO> layLichSuGoiTapTheokhoangThoiGian(bool timTheoNgayDangKy, DateTime ngayBatDau, DateTime ngaKetThuc)
        {
            List<lichSuGoiTapDTO> lst;

            if (timTheoNgayDangKy)
            {
                lst = db.LICHSUGOITAPs.Where(u => u.XOA == false
                    && u.NGAYDANGKY >= ngayBatDau && u.NGAYDANGKY < ngaKetThuc)
                    .Select(u => new lichSuGoiTapDTO
                    {
                        maGoiTap = u.MAGOITAP,
                        tenGoiTap = u.GOITAP.TENGOITAP,
                        tenLoaiGoitap = u.LOAIGOITAP.TENLOAIGOITAP,
                        maPT = u.MAPT.Value,
                        ngayDangKy = u.NGAYDANGKY,
                        ngayHetHan = u.NGAYHETHAN
                    }).ToList();
            }
            else
            {
                lst = db.LICHSUGOITAPs.Where(u => u.XOA == false
                && u.NGAYHETHAN >= ngayBatDau && u.NGAYHETHAN < ngaKetThuc)
                .Select(u => new lichSuGoiTapDTO
                {
                    maGoiTap = u.MAGOITAP,
                    tenGoiTap = u.GOITAP.TENGOITAP,
                    tenLoaiGoitap = u.LOAIGOITAP.TENLOAIGOITAP,
                    maPT = u.MAPT.Value,
                    ngayDangKy = u.NGAYDANGKY,
                    ngayHetHan = u.NGAYHETHAN
                }).ToList();
            }

            foreach (lichSuGoiTapDTO lsgt in lst)
            {
                if (lsgt.maPT != 0)
                    lsgt.tenPT = taiKhoanDAO.layHoTen(lsgt.maPT);
            }

            return lst;
        }

        public static bool them(lichSuGoiTapDTO lsgt, int maTheTap)
        {
            LICHSUGOITAP LSGT = new LICHSUGOITAP
            {
                MATHETAP = maTheTap,
                MAGOITAP = lsgt.maGoiTap,
                MALOAIGOITAP = lsgt.maLoaiGoiTap,
                MAPT = lsgt.maPT,
                NGAYDANGKY = lsgt.ngayDangKy,
                NGAYHETHAN = lsgt.ngayHetHan,
                XOA = false
            };

            db.LICHSUGOITAPs.Add(LSGT);

            theTapDAO.moKhoa(maTheTap);

            try
            {
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public static string layHoTen(int maTheTap)
        {
            return theTapDAO.layHoTen(maTheTap);
        }

        public static bool xoa(int maTheTap)
        {
            List<LICHSUGOITAP> lst = db.LICHSUGOITAPs.Where(u => u.MATHETAP == maTheTap).ToList();
            
            if (lst != null)
                foreach(LICHSUGOITAP lsgt in lst)
                    lsgt.XOA = true;

            return db.SaveChanges() > 0;
        }
    }
}