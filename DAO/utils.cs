using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class utils
    {
        public static string GetMD5(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {
                sbHash.Append(String.Format("{0:x2}", b));
            }
            return sbHash.ToString();
        }

        public static Image chuyenAnh(string pathAnh)
        {
            if (pathAnh == null)
                return null;

            byte[] byteAnh = File.ReadAllBytes(string.Format(@"{0}", pathAnh));

            using (MemoryStream ms = new MemoryStream(byteAnh))
            {
                Image img = Image.FromStream(ms);
                return img;
            }
        }
    }
}
