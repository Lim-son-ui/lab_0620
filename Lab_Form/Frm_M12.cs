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
    public partial class Frm_M12 : Form
    {
        public Frm_M12()
        {
            InitializeComponent();
        }

        int count = 0;
        private void btn_Math_Click(object sender, EventArgs e)
        {
            
            count += 1;
            label_count.Text = "Count:" + count;
        }

        private void label_count_Click(object sender, EventArgs e)
        {
            
        }

        private void text_plus_Click(object sender, EventArgs e)
        {
            int i = count++;
            
            label_count.Text = "Count: " + count;

            MessageBox.Show(i.ToString());
        }

        private void btn_locovar_Click(object sender, EventArgs e)
        {
            int a = 0;

            if (true)
            {
                int x = 100;
                x = 101;
                a = x;
            }
            
            int i = a;
            MessageBox.Show(i.ToString());
        }
        
        UseStatic us = new UseStatic();
        private void btn_instance_Click(object sender, EventArgs e)
        {
            us.InstanceCount++;
            label1.Text = "Instance Count:" + us.InstanceCount;
        }

        private void btn_static_count_Click(object sender, EventArgs e)
        {
            UseStatic.StaticCount++;
            label2.Text = "Static Count:" + UseStatic.StaticCount;
        }

        private void btn_frm_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frm = new Frm_M02_HelloForm();
            frm.Show();
        }
    }
}
