using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class lichSuGoiTapDTO
    {
        public int maGoiTap { set; get; }
        public int maLoaiGoiTap { set; get; }
        public string tenGoiTap { set; get; }
        public string tenLoaiGoitap { set; get; }
        public int maPT { set; get; }
        public string tenPT { set; get; }
        public DateTime ngayDangKy { set; get; }
        public DateTime ngayHetHan { set; get; }
    }
}
