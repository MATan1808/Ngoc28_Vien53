using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KiemTraDauVaoEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        private void kiemtra_Click(object sender, EventArgs e)
        {
            string email = nhap.Text;
            if (IsValidEmail(email))
            {
                kq.Text = "Email hợp lệ.";
              
            }
            else
            {
                kq.Text = "Email không hợp lệ.";
                
            }
        }
    }
}
