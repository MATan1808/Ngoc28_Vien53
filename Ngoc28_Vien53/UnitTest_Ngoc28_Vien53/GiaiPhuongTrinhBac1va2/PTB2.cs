using System;

namespace GiaiPhuongTrinhBac1va2
{
    public class PTB2_Ngoc28_Vien53
    {
        // Phương thức giải phương trình bậc 2 ax^2 + bx + c = 0
        public static Tuple<double, double> GiaiPhuongTrinhBac2(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("Hệ số 'a' không thể bằng 0");
            }

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return Tuple.Create(x1, x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return Tuple.Create(x, x);
            }
            else
            {
                throw new ArgumentException("Phương trình vô nghiệm");
            }
        }
    }
}
