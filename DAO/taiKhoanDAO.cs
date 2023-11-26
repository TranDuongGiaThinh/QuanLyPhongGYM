using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DTO;

namespace DAO
{
    public class taiKhoanDAO
    {
        static QuanLyPhongGymNTNEntities db = new QuanLyPhongGymNTNEntities();
        
        public static void taoTaiKhoanSuperAdmin()
        {
            loaiTaiKhoanDAO.taoDanhSachLoaiTaiKhoan();

            TAIKHOAN TK = new TAIKHOAN
            {
                TENDANGNHAP = Const.tenDangNhapSuperAdmin,
                MALOAITAIKHOAN = Const.maSuperAdmin,
                HOTEN = Const.tenDangNhapSuperAdmin,
                GIOITINH = true,
                KHOA = false,
                XOA = false
            };

            TK.MATKHAU = utils.GetMD5(Const.matKhauSuperAdmin);

            db.TAIKHOANs.Add(TK);
            db.SaveChanges();
        }
        public static  List<taiKhoanDTO> layDanhSachTacCa()
        {
            List<taiKhoanDTO> lst = db.TAIKHOANs.Where(u=>u.XOA == false && u.MALOAITAIKHOAN != Const.maSuperAdmin).Select(u => new taiKhoanDTO
            {
                maTaiKhoan = u.MATAIKHOAN,
                tenDangNhap = u.TENDANGNHAP,
                maLoaiTaiKhoan = u.MALOAITAIKHOAN,
                tenLoaiTaiKhoan = u.LOAITAIKHOAN.TENLOAITAIKHOAN,
                pathHinhAnh = u.ANH,
                hoTen = u.HOTEN,
                email = u.EMAIL,
                diaChi = u.DIACHI,
                dienThoai = u.DIENTHOAI,
                ngaySinh = u.NGAYSINH.Value,
                strGioiTinh = u.GIOITINH.Value? Const.gioiTinhNam: Const.gioiTinhNu,
                ghiChu = u.GHICHU,
                strTrangThai = u.KHOA?Const.strTrangThaiBiKhoa:Const.strTrangThaiHoatDong
            }).ToList();

            foreach (taiKhoanDTO tk in lst)
            {
                if (!string.IsNullOrEmpty(tk.pathHinhAnh))
                {
                    tk.hinhAnh = utils.chuyenAnh(tk.pathHinhAnh);
                }
            }

            return lst;
        }
        public static List<taiKhoanDTO> layDanhSachKhongCoAdmin()
        {
            List<taiKhoanDTO> lst = db.TAIKHOANs.Where(u => u.XOA == false 
                && u.MALOAITAIKHOAN != Const.maSuperAdmin
                && u.MALOAITAIKHOAN != Const.maAdmin).Select(u => new taiKhoanDTO
            {
                maTaiKhoan = u.MATAIKHOAN,
                tenDangNhap = u.TENDANGNHAP,
                maLoaiTaiKhoan = u.MALOAITAIKHOAN,
                tenLoaiTaiKhoan = u.LOAITAIKHOAN.TENLOAITAIKHOAN,
                pathHinhAnh = u.ANH,
                hoTen = u.HOTEN,
                email = u.EMAIL,
                diaChi = u.DIACHI,
                dienThoai = u.DIENTHOAI,
                ngaySinh = u.NGAYSINH.Value,
                strGioiTinh = u.GIOITINH.Value ? Const.gioiTinhNam : Const.gioiTinhNu,
                ghiChu = u.GHICHU,
                strTrangThai = u.KHOA ? Const.strTrangThaiBiKhoa : Const.strTrangThaiHoatDong
            }).ToList();

            foreach (taiKhoanDTO tk in lst)
            {
                if (!string.IsNullOrEmpty(tk.pathHinhAnh))
                {
                    tk.hinhAnh = utils.chuyenAnh(tk.pathHinhAnh);
                }
            }

            return lst;
        }

        public static List<taiKhoanDTO> layDanhSachTheoLoaiTaiKhoan(int loaiTaiKhoan)
        {
            List<taiKhoanDTO> lst = db.TAIKHOANs.Where(u => u.MALOAITAIKHOAN == loaiTaiKhoan && u.XOA == false && u.MALOAITAIKHOAN != Const.maSuperAdmin).Select(u => new taiKhoanDTO
            {
                maTaiKhoan = u.MATAIKHOAN,
                tenDangNhap = u.TENDANGNHAP,
                maLoaiTaiKhoan = u.MALOAITAIKHOAN,
                tenLoaiTaiKhoan = u.LOAITAIKHOAN.TENLOAITAIKHOAN,
                pathHinhAnh = u.ANH,
                hoTen = u.HOTEN,
                email = u.EMAIL,
                diaChi = u.DIACHI,
                dienThoai = u.DIENTHOAI,
                ngaySinh = u.NGAYSINH.Value,
                strGioiTinh = u.GIOITINH.Value ? Const.gioiTinhNam : Const.gioiTinhNu,
                ghiChu = u.GHICHU,
                strTrangThai = u.KHOA ? Const.strTrangThaiBiKhoa : Const.strTrangThaiHoatDong
            }).ToList();

            foreach (taiKhoanDTO tk in lst)
            {
                if (!string.IsNullOrEmpty(tk.pathHinhAnh))
                {
                    tk.hinhAnh = utils.chuyenAnh(tk.pathHinhAnh);
                }
            }

            return lst;
        }

        public static List<taiKhoanDTO> layDanhSachTatCaTheoTrangThai(bool khoa)
        {
            List<taiKhoanDTO> lst = db.TAIKHOANs.Where(u=>u.KHOA == khoa && u.XOA == false && u.MALOAITAIKHOAN != Const.maSuperAdmin).Select(u => new taiKhoanDTO
            {
                maTaiKhoan = u.MATAIKHOAN,
                tenDangNhap = u.TENDANGNHAP,
                maLoaiTaiKhoan = u.MALOAITAIKHOAN,
                tenLoaiTaiKhoan = u.LOAITAIKHOAN.TENLOAITAIKHOAN,
                pathHinhAnh = u.ANH,
                hoTen = u.HOTEN,
                email = u.EMAIL,
                diaChi = u.DIACHI,
                dienThoai = u.DIENTHOAI,
                ngaySinh = u.NGAYSINH.Value,
                strGioiTinh = u.GIOITINH.Value ? Const.gioiTinhNam : Const.gioiTinhNu,
                ghiChu = u.GHICHU,
                strTrangThai = u.KHOA ? Const.strTrangThaiBiKhoa : Const.strTrangThaiHoatDong
            }).ToList();

            foreach (taiKhoanDTO tk in lst)
            {
                if (!string.IsNullOrEmpty(tk.pathHinhAnh))
                {
                    tk.hinhAnh = utils.chuyenAnh(tk.pathHinhAnh);
                }
            }

            return lst;
        }

        public static List<taiKhoanDTO> layDanhSachTheoTrangThaiKhongCoAdmin(bool khoa)
        {
            List<taiKhoanDTO> lst = db.TAIKHOANs.Where(u => u.KHOA == khoa && u.XOA == false 
                && u.MALOAITAIKHOAN != Const.maSuperAdmin && u.MALOAITAIKHOAN != Const.maAdmin).
                Select(u => new taiKhoanDTO
            {
                maTaiKhoan = u.MATAIKHOAN,
                tenDangNhap = u.TENDANGNHAP,
                maLoaiTaiKhoan = u.MALOAITAIKHOAN,
                tenLoaiTaiKhoan = u.LOAITAIKHOAN.TENLOAITAIKHOAN,
                pathHinhAnh = u.ANH,
                hoTen = u.HOTEN,
                email = u.EMAIL,
                diaChi = u.DIACHI,
                dienThoai = u.DIENTHOAI,
                ngaySinh = u.NGAYSINH.Value,
                strGioiTinh = u.GIOITINH.Value ? Const.gioiTinhNam : Const.gioiTinhNu,
                ghiChu = u.GHICHU,
                strTrangThai = u.KHOA ? Const.strTrangThaiBiKhoa : Const.strTrangThaiHoatDong
            }).ToList();

            foreach (taiKhoanDTO tk in lst)
            {
                if (!string.IsNullOrEmpty(tk.pathHinhAnh))
                {
                    tk.hinhAnh = utils.chuyenAnh(tk.pathHinhAnh);
                }
            }

            return lst;
        }

        public static List<taiKhoanDTO> layDanhSachTatCaTheoHoTen(string hoTen)
        {
            List<taiKhoanDTO> lst = db.TAIKHOANs.Where(u => u.HOTEN == hoTen && u.XOA == false 
                && u.MALOAITAIKHOAN != Const.maSuperAdmin && u.KHOA == false)
                .Select(u => new taiKhoanDTO
            {
                maTaiKhoan = u.MATAIKHOAN,
                tenDangNhap = u.TENDANGNHAP,
                maLoaiTaiKhoan = u.MALOAITAIKHOAN,
                tenLoaiTaiKhoan = u.LOAITAIKHOAN.TENLOAITAIKHOAN,
                pathHinhAnh = u.ANH,
                hoTen = u.HOTEN,
                email = u.EMAIL,
                diaChi = u.DIACHI,
                dienThoai = u.DIENTHOAI,
                ngaySinh = u.NGAYSINH.Value,
                strGioiTinh = u.GIOITINH.Value ? Const.gioiTinhNam : Const.gioiTinhNu,
                ghiChu = u.GHICHU,
                strTrangThai = u.KHOA ? Const.strTrangThaiBiKhoa : Const.strTrangThaiHoatDong
            }).ToList();

            foreach (taiKhoanDTO tk in lst)
            {
                if (!string.IsNullOrEmpty(tk.pathHinhAnh))
                {
                    tk.hinhAnh = utils.chuyenAnh(tk.pathHinhAnh);
                }
            }

            return lst;
        }

        public static List<taiKhoanDTO> layDanhSachTheoHoTenKhongCoAdmin(string hoTen)
        {
            List<taiKhoanDTO> lst = db.TAIKHOANs.Where(u => u.HOTEN == hoTen && u.XOA == false
                && u.MALOAITAIKHOAN != Const.maSuperAdmin && u.MALOAITAIKHOAN != Const.maAdmin && u.KHOA == false)
                .Select(u => new taiKhoanDTO
                {
                    maTaiKhoan = u.MATAIKHOAN,
                    tenDangNhap = u.TENDANGNHAP,
                    maLoaiTaiKhoan = u.MALOAITAIKHOAN,
                    tenLoaiTaiKhoan = u.LOAITAIKHOAN.TENLOAITAIKHOAN,
                    pathHinhAnh = u.ANH,
                    hoTen = u.HOTEN,
                    email = u.EMAIL,
                    diaChi = u.DIACHI,
                    dienThoai = u.DIENTHOAI,
                    ngaySinh = u.NGAYSINH.Value,
                    strGioiTinh = u.GIOITINH.Value ? Const.gioiTinhNam : Const.gioiTinhNu,
                    ghiChu = u.GHICHU,
                    strTrangThai = u.KHOA ? Const.strTrangThaiBiKhoa : Const.strTrangThaiHoatDong
                }).ToList();

            foreach (taiKhoanDTO tk in lst)
            {
                if (!string.IsNullOrEmpty(tk.pathHinhAnh))
                {
                    tk.hinhAnh = utils.chuyenAnh(tk.pathHinhAnh);
                }
            }

            return lst;
        }

        public static taiKhoanDTO layTaiKhoan(int maTaiKhoan)
        {
            TAIKHOAN tk = db.TAIKHOANs.FirstOrDefault(u => u.MATAIKHOAN == maTaiKhoan);

            taiKhoanDTO taiKhoan = new taiKhoanDTO
            {
                maTaiKhoan = tk.MATAIKHOAN,
                maLoaiTaiKhoan = tk.MALOAITAIKHOAN,
                tenLoaiTaiKhoan = tk.LOAITAIKHOAN.TENLOAITAIKHOAN,
                pathHinhAnh = tk.ANH,
                hoTen = tk.HOTEN,
                email = tk.EMAIL,
                diaChi = tk.DIACHI,
                dienThoai = tk.DIENTHOAI,
                ngaySinh = tk.NGAYSINH.Value,
                strGioiTinh = tk.GIOITINH.Value ? Const.gioiTinhNam : Const.gioiTinhNu,
                ghiChu = tk.GHICHU,
                strTrangThai = tk.KHOA ? Const.strTrangThaiBiKhoa : Const.strTrangThaiHoatDong
            };

            if (taiKhoan.pathHinhAnh != null) 
            {
                taiKhoan.hinhAnh = utils.chuyenAnh(taiKhoan.pathHinhAnh);
            }

            return taiKhoan;
        }

        public static int demSoTaiKhoan()
        {
            return db.TAIKHOANs.Count(u => u.XOA == false);
        }

        public static string layHoTen(int maTK)
        {
            TAIKHOAN kq = db.TAIKHOANs.FirstOrDefault(u => u.MATAIKHOAN == maTK);

            return kq.HOTEN;
        }

        public static string[] layTatCaHoTen()
        {
            List<string> lstHoTen = new List<string>();

            List<taiKhoanDTO> lst = db.TAIKHOANs.Where(u => u.XOA == false && u.KHOA == false && u.MALOAITAIKHOAN != Const.maSuperAdmin).Select(u => new taiKhoanDTO
            {
                hoTen = u.HOTEN
            }).ToList();

            foreach (taiKhoanDTO tk in lst)
            {
                lstHoTen.Add(tk.hoTen);
            }

            return lstHoTen.ToArray();
        }

        public static string[] layTatCaHoTenKhongCoAdmin()
        {
            List<string> lstHoTen = new List<string>();

            List<taiKhoanDTO> lst = db.TAIKHOANs.Where(u => u.XOA == false && u.KHOA == false 
                && u.MALOAITAIKHOAN != Const.maSuperAdmin
                && u.MALOAITAIKHOAN != Const.maAdmin).Select(u => new taiKhoanDTO
            {
                hoTen = u.HOTEN
            }).ToList();

            foreach (taiKhoanDTO tk in lst)
            {
                lstHoTen.Add(tk.hoTen);
            }

            return lstHoTen.ToArray();
        }

        public static bool taiKhoanHopLe(string tenDangNhap, string matKhau)
        {
            string matKhauMaHoa = utils.GetMD5(matKhau);

            TAIKHOAN kq = db.TAIKHOANs.FirstOrDefault(u => u.TENDANGNHAP.Equals(tenDangNhap) && u.MATKHAU.Equals(matKhauMaHoa) && u.XOA == false && u.KHOA == false);

            return kq != null;
        }

        public static bool chuaDoiMatKhau(string tenDangNhap, string matKhau)
        {
            string matKhauMaHoa = utils.GetMD5(matKhau);

            TAIKHOAN kq = db.TAIKHOANs.FirstOrDefault(u => u.TENDANGNHAP.Equals(tenDangNhap) && u.MATKHAU.Equals(matKhauMaHoa) && u.XOA == false && u.KHOA == false);

            return kq != null;
        }

        public static int layMaTaiKhoan(string tenDangNhap, string matKhau)
        {
            string matKhauMaHoa = utils.GetMD5(matKhau);

            TAIKHOAN kq = db.TAIKHOANs.FirstOrDefault(u => u.TENDANGNHAP.Equals(tenDangNhap) && u.MATKHAU.Equals(matKhauMaHoa)
                        && u.XOA == false && u.KHOA == false);

            return kq == null ? Const.khongCoGiaTri : kq.MATAIKHOAN;
        }

        public static int layMaLoaiTaiKhoan(int maTK)
        {
            TAIKHOAN kq = db.TAIKHOANs.FirstOrDefault(u => u.MATAIKHOAN == maTK);

            return kq.MALOAITAIKHOAN;
        }
        
        public static bool daTonTai(string tenDangNhap)
        {
            TAIKHOAN tk = db.TAIKHOANs.FirstOrDefault(u => u.TENDANGNHAP.Equals(tenDangNhap));

            return tk != null;
        }

        public static bool them(taiKhoanDTO tk)
        {
            TAIKHOAN TK = new TAIKHOAN
            {
                TENDANGNHAP = tk.tenDangNhap,
                MATKHAU = utils.GetMD5(tk.matKhau),
                MALOAITAIKHOAN = tk.maLoaiTaiKhoan,
                ANH = tk.pathHinhAnh,
                HOTEN = tk.hoTen,
                EMAIL = tk.email,
                DIACHI = tk.diaChi,
                DIENTHOAI = tk.dienThoai,
                NGAYSINH = tk.ngaySinh,
                GHICHU = tk.ghiChu,
                KHOA = false
            };
            if (tk.strGioiTinh != null)
                TK.GIOITINH = tk.strGioiTinh.Equals(Const.gioiTinhNam);

            db.TAIKHOANs.Add(TK);

            int luu = db.SaveChanges(); 

            if (tk.maLoaiTaiKhoan == Const.maKhachHang)
            {
                theTapDAO.them(TK.MATAIKHOAN);
            }

            return luu > Const.khongCoGiaTri;
        }

        public static bool sua(taiKhoanDTO tk, int maTK)
        {
            TAIKHOAN TK = db.TAIKHOANs.SingleOrDefault(u => u.MATAIKHOAN.Equals(maTK));

            TK.HOTEN = tk.hoTen;
            TK.ANH = tk.pathHinhAnh;
            TK.MALOAITAIKHOAN = tk.maLoaiTaiKhoan;
            TK.EMAIL = tk.email;
            TK.DIACHI = tk.diaChi;
            TK.DIENTHOAI = tk.dienThoai;
            TK.NGAYSINH = tk.ngaySinh;
            TK.GIOITINH = tk.strGioiTinh.Equals(Const.gioiTinhNam);
            TK.GHICHU = tk.ghiChu;

            if (tk.maLoaiTaiKhoan == Const.maKhachHang)
            {
                if (db.THETAPs.FirstOrDefault(u => u.MAKHACHHANG == maTK) == null)
                {
                    theTapDAO.them(TK.MATAIKHOAN);
                }
                else if (db.THETAPs.FirstOrDefault(u => u.MAKHACHHANG == maTK && u.XOA == true) != null)
                {
                    theTapDAO.huyXoa(theTapDAO.layMaTheTap(maTK));
                }
            }
            else
            {
                if (db.THETAPs.FirstOrDefault(u => u.MAKHACHHANG == maTK) != null)
                {
                    theTapDAO.xoa(theTapDAO.layMaTheTap(maTK));
                }
            }

            return db.SaveChanges() > Const.khongCoGiaTri;
        }

        public static bool doiMatKhau(string matKhau, int maTK)
        {
            TAIKHOAN TK = db.TAIKHOANs.SingleOrDefault(u => u.MATAIKHOAN.Equals(maTK));

            TK.MATKHAU = utils.GetMD5(matKhau);

            return db.SaveChanges() > Const.khongCoGiaTri;
        }

        public static bool khoa(int maTK)
        {
            TAIKHOAN TK = db.TAIKHOANs.SingleOrDefault(u => u.MATAIKHOAN.Equals(maTK));

            TK.KHOA = true;

            return db.SaveChanges() > Const.khongCoGiaTri;
        }

        public static bool moKhoa(int maTK)
        {
            TAIKHOAN TK = db.TAIKHOANs.SingleOrDefault(u => u.MATAIKHOAN.Equals(maTK));

            TK.KHOA = false;

            return db.SaveChanges() > Const.khongCoGiaTri;
        }

        public static bool xoa(int maTK)
        {
            TAIKHOAN TK = db.TAIKHOANs.SingleOrDefault(u => u.MATAIKHOAN.Equals(maTK));

            TK.XOA = true;

            theTapDTO theTap = theTapDAO.layTheTap(theTapDAO.layMaTheTap(maTK));
            theTapDAO.xoa(theTap.maTheTap);

            return db.SaveChanges() > Const.khongCoGiaTri;
        }
    }
}
