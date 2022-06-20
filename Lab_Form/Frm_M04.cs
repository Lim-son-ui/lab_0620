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
    public partial class Frm_M04 : Form
    {
        public Frm_M04()
        {
            InitializeComponent();
        }

        private void btnOpenHelloForm_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm helloForm = new Frm_M02_HelloForm();
            helloForm.Show();
        }     

        private void button1_Click(object sender, EventArgs e)
        {
            MyFirstMethod();
        }

        void MyFirstMethod()
        {
            MessageBox.Show("My First Method");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyFirstClass mc = new MyFirstClass();
            //mc.Method01();
            //mc.Method02();
            mc.Method03();
            mc.Method04();
        }

        string BirthYear(int Age)
        {
            int birthYear = DateTime.Now.Year - Age;

            string result = "出生年為 " + birthYear + " 年"; 

            return result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           string birth = BirthYear(100);

            MessageBox.Show(birth);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyFirstClass mc = new MyFirstClass();
            mc.Method05();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyFirstClass mc = new MyFirstClass();
            mc.Method06();
        }


    }
}
