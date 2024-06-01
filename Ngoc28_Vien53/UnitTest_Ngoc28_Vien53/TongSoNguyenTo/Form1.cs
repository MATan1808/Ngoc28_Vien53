using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TongSoNguyenTo
{
    public partial class danhsach : Form
    {
        public danhsach()
        {
            InitializeComponent();
        }

        private void tinhtong_Click(object sender, EventArgs e)
        {
            danhsachnguyento.Items.Clear();
            sum.Text = "Sum: ";

            if (int.TryParse(batdau.Text, out int start) && int.TryParse(ketthuc.Text, out int end))
            {
                try
                {
                    var calculator = new TongNT();
                    int sum = calculator.SumOfPrimes(start, end);
                    for (int i = start; i <= end; i++)
                    {
                        if (calculator.IsPrime(i))
                        {
                            danhsachnguyento.Items.Add(i);
                        }
                    }
                    tong.Text = "Sum: " + sum;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for start and end.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
 }

