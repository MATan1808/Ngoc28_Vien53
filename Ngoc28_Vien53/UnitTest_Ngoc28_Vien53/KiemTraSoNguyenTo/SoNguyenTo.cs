using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraSoNguyenTo
{
    public class SoNguyenTo_Ngoc28_Vien53
    {
        public bool NguyenTo(int n)
        {
            // Kiểm tra nếu số nhỏ hơn hoặc bằng 1
            if (n <= 1)
                return false;
            // Duyệt qua các số từ 2 đến căn bậc hai của n
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                // Nếu n chia hết cho i, nghĩa là n không phải là số nguyên tố
                if (n % i == 0)
                    return false;
            }
            // Nếu không có số nào chia hết cho n, nghĩa là n là số nguyên tố
            return true;
        }
    }
}
