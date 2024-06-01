using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimGiaTriTrungBinh
{
    
    public class TinhTrungBinh_Ngoc28_Vien53
    {
        public static double CalculateAverage(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("Danh sách không được rỗng");
            }

            double sum = numbers.Sum();
            double average = sum / numbers.Count;
            return average;
        }
       


    }
}
