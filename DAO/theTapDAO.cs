using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class theTapDAO
    {
        static QuanLyPhongGymNTNEntities db = new QuanLyPhongGymNTNEntities();

        public static List<theTapDTO> loadTatCa()
        {
            List<theTapDTO> lstKetQua = new List<theTapDTO>();
            List<theTapDTO> lst = db.THETAPs.Where(u => u.XOA == false).Select(u => new theTapDTO
            {
                maTheTap = u.MATHETAP,
                tenKhachHang = u.TAIKHOAN.HOTEN,
                khoa = u.KHOA
            }).ToList();

            foreach (theTapDTO theTap in lst)
            {
                if (db.LICHSUGOITAPs.FirstOrDefault(z => z.MATHETAP == theTap.maTheTap && z.XOA == false) == null)
                {
                    lstKetQua.Add(theTap);
                    continue;
                }

                DateTime ngayHetHanLonNhat = Convert.ToDateTime(db.LICHSUGOITAPs.Where(z => z.MATHETAP == theTap.maTheTap && z.XOA == false).Max(u => u.NGAYHETHAN));

                LICHSUGOITAP lsgt = db.LICHSUGOITAPs.FirstOrDefault(u => u.NGAYHETHAN.Day == ngayHetHanLonNhat.Day
                        && u.NGAYHETHAN.Month == ngayHetHanLonNhat.Month
                        && u.NGAYHETHAN.Year == ngayHetHanLonNhat.Year
                        && u.MATHETAP == theTap.maTheTap && u.XOA == false);

                if (lsgt != null)
                {
                    theTap.tenGoiTap = lsgt.GOITAP.TENGOITAP;
                    theTap.ngayDangKy = lsgt.NGAYDANGKY;
                    theTap.ngayHetHan = lsgt.NGAYHETHAN;

                    if (ngayHetHanLonNhat < DateTime.Now)
                    {
                        THETAP tt = db.THETAPs.FirstOrDefault(u => u.MATHETAP == theTap.maTheTap);
                        tt.KHOA = true;
                        db.SaveChanges();

                        theTap.khoa = true;
                    }
                }

                lstKetQua.Add(theTap);
            }

            return lstKetQua;
        }

        public static List<theTapDTO> loadTheHetHan()
        {
            List<theTapDTO> lstKetQua = new List<theTapDTO>();
            List<theTapDTO> lst = db.THETAPs.Where(u => u.XOA == false).Select(u => new theTapDTO
            {
                maTheTap = u.MATHETAP,
                tenKhachHang = u.TAIKHOAN.HOTEN,
                khoa = u.KHOA
            }).ToList();

            foreach (theTapDTO theTap in lst)
            {
                if (db.LICHSUGOITAPs.FirstOrDefault(z => z.MATHETAP == theTap.maTheTap && z.XOA == false) == null)
                {
                    continue;
                }

                DateTime ngayHetHanLonNhat = Convert.ToDateTime(db.LICHSUGOITAPs.Where(z => z.MATHETAP == theTap.maTheTap && z.XOA == false).Max(u => u.NGAYHETHAN));

                LICHSUGOITAP lsgt = db.LICHSUGOITAPs.FirstOrDefault(u => u.NGAYHETHAN.Day == ngayHetHanLonNhat.Day
                        && u.NGAYHETHAN.Month == ngayHetHanLonNhat.Month
                        && u.NGAYHETHAN.Year == ngayHetHanLonNhat.Year
                        && u.MATHETAP == theTap.maTheTap && u.XOA == false);

                if (lsgt != null)
                {
                    theTap.tenGoiTap = lsgt.GOITAP.TENGOITAP;
                    theTap.ngayDangKy = lsgt.NGAYDANGKY;
                    theTap.ngayHetHan = lsgt.NGAYHETHAN;

                    if (ngayHetHanLonNhat < DateTime.Now)
                    {
                        THETAP tt = db.THETAPs.FirstOrDefault(u => u.MATHETAP == theTap.maTheTap);
                        tt.KHOA = true;
                        db.SaveChanges();

                        theTap.khoa = true;
                        lstKetQua.Add(theTap);
                    }
                }
            }

            return lstKetQua;
        }

        public static List<theTapDTO> loadTheoTrangThai(bool trangThai)
        {
            List<theTapDTO> lstKetQua = new List<theTapDTO>();
            List<theTapDTO> lst = db.THETAPs.Where(u => u.XOA == false && u.KHOA == trangThai).Select(u => new theTapDTO
            {
                maTheTap = u.MATHETAP,
                tenKhachHang = u.TAIKHOAN.HOTEN,
                khoa = u.KHOA
            }).ToList();

            foreach (theTapDTO theTap in lst)
            {
                if (db.LICHSUGOITAPs.FirstOrDefault(z => z.MATHETAP == theTap.maTheTap && z.XOA == false) == null)
                {
                    lstKetQua.Add(theTap);
                    continue;
                }

                DateTime ngayHetHanLonNhat = Convert.ToDateTime(db.LICHSUGOITAPs.Where(z => z.MATHETAP == theTap.maTheTap && z.XOA == false).Max(u => u.NGAYHETHAN));

                LICHSUGOITAP lsgt = db.LICHSUGOITAPs.FirstOrDefault(u => u.NGAYHETHAN.Day == ngayHetHanLonNhat.Day
                        && u.NGAYHETHAN.Month == ngayHetHanLonNhat.Month
                        && u.NGAYHETHAN.Year == ngayHetHanLonNhat.Year
                        && u.MATHETAP == theTap.maTheTap && u.XOA == false);

                if (lsgt != null)
                {
                    theTap.tenGoiTap = lsgt.GOITAP.TENGOITAP;
                    theTap.ngayDangKy = lsgt.NGAYDANGKY;
                    theTap.ngayHetHan = lsgt.NGAYHETHAN;

                    if (ngayHetHanLonNhat < DateTime.Now)
                    {
                        THETAP tt = db.THETAPs.FirstOrDefault(u => u.MATHETAP == theTap.maTheTap);
                        tt.KHOA = true;
                        db.SaveChanges();

                        theTap.khoa = true;
                    }
                }

                lstKetQua.Add(theTap);
            }

            return lstKetQua;
        }

        public static theTapDTO layTheTap(int maTheTap)
        {
            THETAP theTap = db.THETAPs.FirstOrDefault(u => u.MATHETAP == maTheTap && u.XOA == false);

            if (theTap == null)
                return null;

            theTapDTO kq = new theTapDTO
            {
                maTheTap = theTap.MATHETAP,
                pathAnh = theTap.TAIKHOAN.ANH,
                tenKhachHang = theTap.TAIKHOAN.HOTEN,
                diaChi = theTap.TAIKHOAN.DIACHI,
                soDienThoai = theTap.TAIKHOAN.DIENTHOAI
            };

            return kq;
        }

        public static int layMaTheTap(int maKhachHang)
        {
            THETAP theTap = db.THETAPs.FirstOrDefault(u => u.MAKHACHHANG == maKhachHang);

            return theTap != null ? theTap.MATHETAP : Const.khongCoGiaTri;
        }

        public static string layHoTen(int maTheTap)
        {
            THETAP theTap = db.THETAPs.FirstOrDefault(u => u.MATHETAP == maTheTap);

            return theTap != null ? taiKhoanDAO.layHoTen(theTap.MAKHACHHANG) : "";
        }

        public static bool khoa(int maTheTap)
        {
            THETAP theTap = db.THETAPs.FirstOrDefault(u => u.MATHETAP == maTheTap);

            theTap.KHOA = true;

            return db.SaveChanges() > 0;
        }

        public static bool moKhoa(int maTheTap)
        {
            THETAP theTap = db.THETAPs.FirstOrDefault(u => u.MATHETAP == maTheTap);

            theTap.KHOA = false;

            return db.SaveChanges() > 0;
        }

        public static void them(int maTaiKhoan)
        {
            THETAP theTap = new THETAP
            {
                MAKHACHHANG = maTaiKhoan,
                KHOA = true,
                XOA = false
            };

            db.THETAPs.Add(theTap);

            db.SaveChanges();
        }

        public static bool xoa(int maTheTap)
        {
            THETAP theTap = db.THETAPs.FirstOrDefault(u => u.MATHETAP == maTheTap);

            theTap.XOA = true;

            lichTapDAO lt = new lichTapDAO();
            lt.XoaLich(theTap.MAKHACHHANG);

            lichSuGoiTapDAO.xoa(maTheTap);

            return db.SaveChanges() > 0;
        }

        public static bool huyXoa(int maTheTap)
        {
            THETAP theTap = db.THETAPs.FirstOrDefault(u => u.MATHETAP == maTheTap);

            theTap.XOA = false;

            return db.SaveChanges() > 0;
        }
    }
}
