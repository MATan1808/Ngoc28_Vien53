using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XetHocBong
{
    public class HocBong
    {
        public static bool xetHocBong(double d1, double d2, double d3, double diemRl)
        {
            double DiemTb = (d1 + d2 + d3) / 3;

            if (diemRl > 80 && DiemTb > 8.5)
            {
                return true;
            }

            return false;
        }


    }
}
