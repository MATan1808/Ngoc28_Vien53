using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPhuongTrinhBac1va2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(soa.Text);
            double b = double.Parse(sob.Text);
            double c = double.Parse(soc.Text);

            // Tính delta
            double delta = b * b - 4 * a * c;

            // Kiểm tra điều kiện để giải phương trình
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                MessageBox.Show($"Phương trình có hai nghiệm: x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                MessageBox.Show($"Phương trình có nghiệm kép: x = {x}");
            }
            else
            {
                MessageBox.Show("Phương trình vô nghiệm");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PTB1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

