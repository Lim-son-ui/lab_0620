using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        Stati st = new Stati();

        void print()
        {
            if (st.beer_count > 0 ) {
                st.print_dr += "啤酒Beer X" + st.beer_count + "共NT$" + st.beer_price + "元\r\n";
            }
            if (st.teequila_count > 0) {
                st.print_dr += "龍舌蘭Teequila X" + st.teequila_count + "共NT$" + st.teequila_price + "元\r\n";
            }
            if (st.whisky_count > 0) {
                st.print_dr += "威士忌Whisky X" + st.whisky_count + "共NT$" + st.whisky_price + "元\r\n";
            }
            if (st.wine_count > 0)
            {
                st.print_dr += "紅酒Wine X" + st.wine_count + "共NT$" + st.wine_price + "元\r\n";
            }

            textBox6.Text = st.print_dr;
        }

        private void pic2_Click(object sender, EventArgs e)     //酒品按鈕  啤酒
        {
            st.total_price += 120;
            st.beer_price += 120;
            st.beer_count += 1;
            textBox3.Text = "NT$"+ st.total_price.ToString();
            st.print_dr = null;
            print();
            //textBox6.Text = "啤酒Beer X"+ st.beer_count + "共NT$" + st.beer_price +"元";
        }

        private void pic3_Click(object sender, EventArgs e)     //酒品按鈕  龍舌蘭
        {
            st.total_price += 350;
            st.teequila_price += 350;
            st.teequila_count += 1;
            textBox3.Text = "NT$" + st.total_price.ToString();
            st.print_dr = null;
            print();
            //textBox6.Text = "龍舌蘭Teequila X" + st.teequila_count + "共NT$" + st.teequila_price + "元";
            //textBox6.Text = "350";
        }

        private void pic1_Click(object sender, EventArgs e)     //酒品按鈕  威士忌
        {
            st.total_price += 180;
            st.whisky_price += 180;
            st.whisky_count += 1;
            textBox3.Text = "NT$" + st.total_price.ToString();
            st.print_dr = null;
            print();
            //textBox6.Text = "威士忌Whisky X" + st.whisky_count + "共NT$" + st.whisky_price + "元";
            //textBox6.Text = "180";
        }

        private void pic4_Click(object sender, EventArgs e)     //酒品按鈕  紅酒
        {
            st.total_price += 320;
            st.wine_price += 320;
            st.wine_count += 1;
            textBox3.Text = "NT$" + st.total_price.ToString();
            st.print_dr = null;
            print();
            //textBox6.Text = "紅酒Wine X" + st.wine_count + "共NT$" + st.wine_price + "元";
            //textBox6.Text = "320";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //現金  原價加總
            MessageBox.Show("總金額:NT$" + st.total_price.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //信用卡  * 0.9
            double a = (st.total_price) * 0.9;
            //st.total_price *= 0.9;
            MessageBox.Show("總金額:NT$" + a.ToString());
        }
        void Clear()
        {
             st.beer_price = 0;
             st.beer_count = 0;
             st.teequila_price = 0;
             st.teequila_count = 0;
             st.whisky_price = 0;
             st.whisky_count = 0;
             st.wine_price = 0;
             st.wine_count = 0;
    }
        private void button3_Click_1(object sender, EventArgs e)
        {       //清除內容
            
            st.total_price = 0;
            textBox3.Text = "NT$" + st.total_price.ToString();
            textBox6.Text = "尚未點餐";
            Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
