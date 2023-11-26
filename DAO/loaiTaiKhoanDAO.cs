using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class loaiTaiKhoanDAO
    {
        static QuanLyPhongGymNTNEntities db = new QuanLyPhongGymNTNEntities();
        
        public static void taoDanhSachLoaiTaiKhoan()
        {
            LOAITAIKHOAN ltkSuperAdmin = new LOAITAIKHOAN
            {
                MALOAITAIKHOAN = Const.maSuperAdmin,
                TENLOAITAIKHOAN = Const.tenDangNhapSuperAdmin,
                MOTA = Const.moTaLoaiSuperAdmin,
                XOA = false
            };

            db.LOAITAIKHOANs.Add(ltkSuperAdmin);

            LOAITAIKHOAN ltkAdmin = new LOAITAIKHOAN
            {
                MALOAITAIKHOAN = Const.maAdmin,
                TENLOAITAIKHOAN = Const.tenLoaiAdmin,
                MOTA = Const.moTaLoaiAdmin,
                XOA = false
            };

            db.LOAITAIKHOANs.Add(ltkAdmin);

            LOAITAIKHOAN ltkPT = new LOAITAIKHOAN
            {
                MALOAITAIKHOAN = Const.maPT,
                TENLOAITAIKHOAN = Const.tenLoaiPT,
                MOTA = Const.moTaLoaiPT,
                XOA = false
            };

            db.LOAITAIKHOANs.Add(ltkPT);

            LOAITAIKHOAN ltkKhachHang = new LOAITAIKHOAN
            {
                MALOAITAIKHOAN = Const.maKhachHang,
                TENLOAITAIKHOAN = Const.tenLoaiKhachHang,
                MOTA = Const.moTaLoaiKhachHang,
                XOA = false
            };

            db.LOAITAIKHOANs.Add(ltkKhachHang);

            db.SaveChanges();
        }

        public static List<loaiTaiKhoanDTO> layDanhSachLoaiTaiKhoan()
        {
            List<loaiTaiKhoanDTO> lst = db.LOAITAIKHOANs.Where(u=>u.XOA==false).Select(u => new loaiTaiKhoanDTO
            {
                maLoaiTaiKhoan = u.MALOAITAIKHOAN,
                tenLoaiTaiKhoan = u.TENLOAITAIKHOAN,
                moTa = u.MOTA
            }).ToList();

            return lst;
        }

        public static List<loaiTaiKhoanDTO> layDanhSachKhongCoSuperAdmin()
        {
            List<loaiTaiKhoanDTO> lst = db.LOAITAIKHOANs.Where(u => u.XOA == false && u.MALOAITAIKHOAN != Const.maSuperAdmin).Select(u => new loaiTaiKhoanDTO
            {
                maLoaiTaiKhoan = u.MALOAITAIKHOAN,
                tenLoaiTaiKhoan = u.TENLOAITAIKHOAN,
                moTa = u.MOTA
            }).ToList();

            return lst;
        }
        
        public static List<loaiTaiKhoanDTO> layDanhSachKhongCoAdmin()
        {
            List<loaiTaiKhoanDTO> lst = db.LOAITAIKHOANs.Where(u => u.XOA == false 
                 && u.MALOAITAIKHOAN != Const.maSuperAdmin && u.MALOAITAIKHOAN != Const.maAdmin)
                .Select(u => new loaiTaiKhoanDTO
            {
                maLoaiTaiKhoan = u.MALOAITAIKHOAN,
                tenLoaiTaiKhoan = u.TENLOAITAIKHOAN,
                moTa = u.MOTA
            }).ToList();

            return lst;
        }

        public static string layTenLoaiTaiKhoan(int maLTK)
        {
            loaiTaiKhoanDTO kq = db.LOAITAIKHOANs.Where(u=>u.MALOAITAIKHOAN == maLTK && u.XOA == false).Select(u => new loaiTaiKhoanDTO
            {
                tenLoaiTaiKhoan = u.TENLOAITAIKHOAN
            }).FirstOrDefault();

            return kq.tenLoaiTaiKhoan;
        }

        public static bool daTonTai(string tenLTK)
        {
            LOAITAIKHOAN ltk = db.LOAITAIKHOANs.FirstOrDefault(u => u.TENLOAITAIKHOAN.Equals(tenLTK));

            return ltk != null;
        }

        public static bool daTonTai(string tenLTK, int maLoaiTaiKhoan)
        {
            LOAITAIKHOAN ltk = db.LOAITAIKHOANs.FirstOrDefault(u => u.TENLOAITAIKHOAN.Equals(tenLTK) && u.MALOAITAIKHOAN != maLoaiTaiKhoan);

            return ltk != null;
        }

        public static bool them(loaiTaiKhoanDTO ltk)
        {
            LOAITAIKHOAN LTK = new LOAITAIKHOAN
            {
                TENLOAITAIKHOAN = ltk.tenLoaiTaiKhoan,
                MOTA = ltk.moTa,
                XOA = false
            };

            db.LOAITAIKHOANs.Add(LTK);

            return db.SaveChanges() > Const.khongCoGiaTri;
        }

        public static bool sua(loaiTaiKhoanDTO ltk, int maLTK)
        {
            LOAITAIKHOAN LTK = db.LOAITAIKHOANs.SingleOrDefault(u => u.MALOAITAIKHOAN.Equals(maLTK));

            LTK.TENLOAITAIKHOAN = ltk.tenLoaiTaiKhoan;
            LTK.MOTA = ltk.moTa;

            return db.SaveChanges() > Const.khongCoGiaTri;
        }

        public static bool xoa(int maLTK)
        {
            LOAITAIKHOAN LTK = db.LOAITAIKHOANs.SingleOrDefault(u => u.MALOAITAIKHOAN.Equals(maLTK));

            LTK.XOA = true;

            return db.SaveChanges() > Const.khongCoGiaTri;
        }
    }
}
