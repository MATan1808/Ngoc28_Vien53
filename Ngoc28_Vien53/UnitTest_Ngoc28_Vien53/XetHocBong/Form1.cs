using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XetHocBong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double TinhDiemTrungBinh(double d1, double d2, double d3)
        {
            return (d1 + d2 + d3) / 3;
        }

        public static bool XetHocBong(double d1, double d2, double d3, double diemRl)
        {
            double diemTb = TinhDiemTrungBinh(d1, d2, d3);

            if (diemRl > 80 && diemTb > 8.5)
            {
                return true;
            }

            return false;
        }
        private void ktra_Click(object sender, EventArgs e)
        {

            double d1 = double.Parse(diem1.Text);
            double d2 = double.Parse(diem2.Text);
            double d3 = double.Parse(diem3.Text);
            double diemRl = double.Parse(renluyen.Text);
          
            bool result = XetHocBong(d1, d2, d3, diemRl);

            if (result)
            {
                kq.Text = "Bạn được học bổng";
            }
            else
            {
                kq.Text = "Bạn không được học bổng";
            }
            double diemTb = TinhDiemTrungBinh(d1, d2, d3);
            dtb.Text += diemTb.ToString();



        }
    }
}
