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
    public partial class Frm_M16 : Form
    {
        public Frm_M16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Dec = 10;
            MessageBox.Show(Dec.ToString());
            ByValueType(Dec);
            MessageBox.Show(Dec.ToString());
        }

        void ByValueType(decimal d)
        {
            d = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Member mem1 = new Member();
            mem1.Name = "aaa";
            mem1.Age = 20;
            ByReferenceType(mem1);
            MessageBox.Show(mem1.Name + "," + mem1.Age);    */

            int[] mem1 = new int[5];
            mem1[0] = 1;
            mem1[1] = 3;
            ByArrayType(mem1);
            MessageBox.Show(mem1[0] + "," + mem1[1]);
        }

         void ByArrayType(int[] arr){
            arr[0] = 3;
            arr[1] = 7;
         }

        void ByReferenceType(Member member)
        {
            member.Age = 30;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal dec = 10;
            MessageBox.Show(dec.ToString());
            Byref(ref dec);
            MessageBox.Show(dec.ToString());
        }

       
        void Byref(ref decimal d)   //為雙向  強制將參數視為參考型別 變動參數值會影響原變數
        {
            d = 1000;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            Byout(out a);
            MessageBox.Show(a.ToString());
        }

        void Byout(out int Age)         //為單向 可將多個回傳值傳給指定變數
        {
            Age = 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ch1 = MyParams("國文", 80, 90, 70);
            MessageBox.Show(ch1);

            string math = MyParams("數學" ,60, 70, 80, 90);
            MessageBox.Show(math);

            string english = MyParams("英文", 60, 70, 80, 90,46,79,67);
            MessageBox.Show(english);
        }

        string MyParams(string Course, params int[] Score)
        {
            int Total = 0;
            for(int i = 0; i < Score.Length; i++)
            {
                Total += Score[i];
            }

            return Course + "得總成績" + Total;
        }
    }
}
