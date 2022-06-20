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
    public partial class Frm_M15 : Form
    {
        public Frm_M15()
        {
            InitializeComponent();
        }

        private void btn_value_Click(object sender, EventArgs e)
        {
            int A = 100;
            MessageBox.Show(A.ToString());
        

            int B = A;
            B = 200;

            MessageBox.Show("A: " + A + " , B:" + B);
        }

        private void txt_reference_Click(object sender, EventArgs e)
        {
            TextBox tb = txt_refer;
            tb.Text = "Referencd Type";
            tb.BackColor = Color.LightBlue;
            tb.ForeColor = Color.Maroon;

            tb.Location = new Point(120, 100);
        }

        private void butt_str_Click(object sender, EventArgs e)
        {
            string strA = "AAA", strB = "BBB";
            MessageBox.Show("A: " + strA + " ,B:" + strB);

            strB = strA;
            strB = "String BBB";
        }
    }
}
