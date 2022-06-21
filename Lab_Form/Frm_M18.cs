using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M18 : Form
    {
        public Frm_M18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int Role = 0;

            if(Role == (int)UserRole.Admin)
            {
                btn_product.Enabled = true;
            }
            else
            {
                btn_product.Enabled = false;
            }

            //UserRole Role = UserRole.Admin;

            //if(Role == UserRole.Admin)
            //{
            //    btn_product.Enabled = true;
            //}
            //else
            //{
            //    btn_product.Enabled = false;
            //}

            //switch (Role)
            //{
            //    case UserRole.Admin:
            //        btn_product.Enabled = true;
            //        break;
            //    case UserRole.User:
            //        btn_product.Enabled = false;
            //        break;
            //}
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Role = 0;

            //if(Role == 0)
            //{
            //    btn_product.Enabled = true;
            //}
            //else
            //{
            //    btn_product.Enabled = false;}

            int Admin = 0, User = 2;
            Admin = 1;

            if(Role == Admin)
            {
                btn_product.Enabled = true;
            }

            else
            {
                btn_product.Enabled = false;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Role = 0;

            const int Admin = 0, User = 2;
            //Admin = 1;

            if(Role == Admin)
            {
                btn_product.Enabled = true;
            }

            else
            {
                btn_product.Enabled = false;
            }
        }
    }
}
