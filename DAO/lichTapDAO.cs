using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class lichTapDAO
    {
        static QuanLyPhongGymNTNEntities db = new QuanLyPhongGymNTNEntities();

        public List<lichTapDTO> LoadTatCa()
        {
            List<lichTapDTO>lst = db.LICHTAPs.Where(d => d.XOA == false).Select(u => new lichTapDTO
            {
                MATHETAP = u.MATHETAP,
                TENKHACHHANG = u.THETAP.TAIKHOAN.HOTEN,
                THUHAI = u.THUHAI,
                THUBA = u.THUBA,
                THUTU = u.THUTU,
                THUNAM = u.THUNAM,
                THUSAU = u.THUSAU,
                THUBAY = u.THUBAY,
                CHUNHAT = u.CHUNHAT,
            }).ToList();

            foreach ( lichTapDTO lt in lst)
            {
                lichSuGoiTapDTO lsgt = lichSuGoiTapDAO.layLichSuGoiTap(lt.MATHETAP).FirstOrDefault();
                if(lsgt!=null)
                    lt.TENPT = lsgt.tenPT;
            }

            return lst;
        }

        public List<lichTapDTO> LoadTheoHoTen(string hoTen)
        {
            List<lichTapDTO> lstKQ = new List<lichTapDTO>();

            List<lichTapDTO> lst = db.LICHTAPs.Where(d => d.XOA == false).Select(u => new lichTapDTO
            {
                MATHETAP = u.MATHETAP,
                TENKHACHHANG = u.THETAP.TAIKHOAN.HOTEN,
                THUHAI = u.THUHAI,
                THUBA = u.THUBA,
                THUTU = u.THUTU,
                THUNAM = u.THUNAM,
                THUSAU = u.THUSAU,
                THUBAY = u.THUBAY,
                CHUNHAT = u.CHUNHAT,
            }).ToList();

            foreach (lichTapDTO lt in lst)
            {
                if (lt.TENKHACHHANG.Equals(hoTen))
                {
                    lichSuGoiTapDTO lsgt = lichSuGoiTapDAO.layLichSuGoiTap(lt.MATHETAP).FirstOrDefault();
                    if (lsgt != null)
                        lt.TENPT = lsgt.tenPT;
                    lstKQ.Add(lt);
                }
            }

            return lstKQ;
        }

        public List<lichTapDTO> LoadTheoPT(int maPT)
        {
            List<lichTapDTO> lstKQ = new List<lichTapDTO>();

            List<lichTapDTO> lst = db.LICHTAPs.Where(d => d.XOA == false).Select(u => new lichTapDTO
            {
                MATHETAP = u.MATHETAP,
                TENKHACHHANG = u.THETAP.TAIKHOAN.HOTEN,
                THUHAI = u.THUHAI,
                THUBA = u.THUBA,
                THUTU = u.THUTU,
                THUNAM = u.THUNAM,
                THUSAU = u.THUSAU,
                THUBAY = u.THUBAY,
                CHUNHAT = u.CHUNHAT,
            }).ToList();

            foreach (lichTapDTO lt in lst)
            {
                lichSuGoiTapDTO lsgt = lichSuGoiTapDAO.layLichSuGoiTap(lt.MATHETAP).FirstOrDefault();
                if (lsgt != null)
                {
                    lt.TENPT = lsgt.tenPT;

                    if (lsgt.maPT == maPT)
                    {
                        lstKQ.Add(lt);
                    }
                }
            }

            return lstKQ;
        }

        public List<lichTapDTO> LoadTheoKhachHang(int maKhachHang)
        {
            int maTheTap = theTapDAO.layMaTheTap(maKhachHang);

            List<lichTapDTO> lstKQ = new List<lichTapDTO>();

            List<lichTapDTO> lst = db.LICHTAPs.Where(d => d.XOA == false).Select(u => new lichTapDTO
            {
                MATHETAP = u.MATHETAP,
                TENKHACHHANG = u.THETAP.TAIKHOAN.HOTEN,
                THUHAI = u.THUHAI,
                THUBA = u.THUBA,
                THUTU = u.THUTU,
                THUNAM = u.THUNAM,
                THUSAU = u.THUSAU,
                THUBAY = u.THUBAY,
                CHUNHAT = u.CHUNHAT,
            }).ToList();

            foreach (lichTapDTO lt in lst)
            {
                lichSuGoiTapDTO lsgt = lichSuGoiTapDAO.layLichSuGoiTap(lt.MATHETAP).FirstOrDefault();
                if (lsgt != null)
                {
                    lt.TENPT = lsgt.tenPT;

                    if (lt.MATHETAP == maTheTap)
                    {
                        lstKQ.Add(lt);
                    }
                }
            }

            return lstKQ;
        }

        public bool ThemLichTap(int maTaiKhoan)
        {
            int maTheTap = theTapDAO.layMaTheTap(maTaiKhoan);
            LICHTAP LT = db.LICHTAPs.FirstOrDefault(d => d.MATHETAP == maTheTap);

            if (LT == null)
            {
                LT = new LICHTAP()
                {
                    MATHETAP = maTheTap,
                    XOA = false
                };
                db.LICHTAPs.Add(LT);
            }
            else
            {
                LT.XOA = false;
            }
            return db.SaveChanges()>0;
        }

        public bool Luu(lichTapDTO lichTap)
        {
            LICHTAP LT = db.LICHTAPs.FirstOrDefault(u => u.MATHETAP == lichTap.MATHETAP);
            LT.THUHAI = lichTap.THUHAI;
            LT.THUBA = lichTap.THUBA;
            LT.THUTU = lichTap.THUTU;
            LT.THUNAM = lichTap.THUNAM;
            LT.THUSAU = lichTap.THUSAU;
            LT.THUBAY = lichTap.THUBAY;
            LT.CHUNHAT = lichTap.CHUNHAT;

            return db.SaveChanges() > 0;
        }

        public bool XoaLich(int maTaiKhoan)
        {
            int maTheTap = theTapDAO.layMaTheTap(maTaiKhoan);

            LICHTAP LT = db.LICHTAPs.FirstOrDefault(u=>u.MATHETAP == maTheTap);
            if(LT!=null)
                LT.XOA = true;
            
            return db.SaveChanges()>0;
        }
    }
}
