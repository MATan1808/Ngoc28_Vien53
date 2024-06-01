using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimGiaTriTrungBinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_Click(object sender, EventArgs e)
        {
            double a,b,c;
            double ketqua;
            a = double.Parse(soa.Text);
            b = double.Parse(sob.Text);
            c = double.Parse(soc.Text);
            List<int> numbers = new List<int> { (int)a, (int)b, (int)c };
            ketqua = TinhTrungBinh_Ngoc28_Vien53.CalculateAverage(numbers);
            kq.Text = ketqua.ToString();
        }
    }
}
