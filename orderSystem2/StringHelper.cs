using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace orderSystem2
{
    class StringHelper
    {
        public static string Tosha256(string pwd)
        {
            //https://www.cnblogs.com/yn-yinian/archive/2017/09/11/7503601.html

            StringBuilder sb = new StringBuilder();
            SHA256 sha256 = SHA256.Create();
            byte[] data = Encoding.UTF8.GetBytes(pwd);
            data = sha256.ComputeHash(data);
            foreach (var item in data)
            {
                sb.Append(item.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
