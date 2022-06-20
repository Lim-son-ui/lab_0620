using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M02_HelloForm :Form
    {
        public Frm_M02_HelloForm()
        {
            // todo 稍後再做
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;

            System.Windows.Forms.MessageBox.Show("Hello, " + Name);
            // hello form
            MessageBox.Show(UseStatic.StaticCount.ToString());
        }

        private void Frm_M02_HelloForm_Load(object sender, EventArgs e)
        {

        }
    }
}
