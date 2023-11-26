using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DTO
{
    public class taiKhoanDTO
    {
        public int maTaiKhoan { set; get; }
        public string tenDangNhap { set; get; }
        public string matKhau { set; get; }
        public int maLoaiTaiKhoan { set; get; }
        public string tenLoaiTaiKhoan { set; get; }
        public string pathHinhAnh { set; get; }
        public Image hinhAnh { set; get; }
        public string hoTen { set; get; }
        public string email { set; get; }
        public string diaChi { set; get; }
        public string dienThoai { set; get; }
        public DateTime ngaySinh { set; get; }
        public string strGioiTinh { set; get; }
        public string ghiChu { set; get; }
        public string strTrangThai { set; get; }
    }
}
