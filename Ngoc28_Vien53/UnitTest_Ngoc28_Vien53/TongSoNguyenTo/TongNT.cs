using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongSoNguyenTo
{
    public class TongNT
    {
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        // Hàm tính tổng các số nguyên tố trong một khoảng cho trước
        public int SumOfPrimes(int start, int end)
        {
            if (start > end)
                throw new ArgumentException("Start must be less than or equal to end.");

            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
