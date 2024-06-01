namespace Bai_2_28_KimNgoc
{
    public class Power_Ngoc28_Vien53
    {

        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return n * Power(x, n - 1);
            else
                return Power(x, n + 1) / x;
        }



    }
}
