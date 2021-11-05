using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderSystem2
{
    class GlobalVar
    {
        public static user NowUser = new user();
        public static productData NowProduct = new productData();
        public static DateTime orderTime = DateTime.Now;

    }
}
