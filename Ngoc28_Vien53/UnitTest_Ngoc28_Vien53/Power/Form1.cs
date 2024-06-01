using System;
using System.Windows.Forms;

namespace Bai_2_28_KimNgoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bang_Click(object sender, EventArgs e)
        {
            int n;
            double x, ketQua;
            n = int.Parse(son.Text);
            x = double.Parse(sox.Text);
            ketQua = Power_28_KimNgoc.Power(x, n);
            kq.Text = ketQua.ToString();
        }
    }
}
