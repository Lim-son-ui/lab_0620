using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Stati
        {
            public string name;
            //public string name_store;
            public string chinese;
            //public string chinese_store;
            public string english;
            //public string english_store;
            public string math;
            //public string math_store;
        }

        Stati st;
        private void button1_Click(object sender, EventArgs e)      //儲存輸入資料
        {
            st.name = textBox1.Text;
            st.chinese = textBox2.Text;
            st.english = textBox3.Text;
            st.math = textBox4.Text;
        }

        private void button2_Click(object sender, EventArgs e)  //顯示儲存內容
        {
            textBox6.Text = "姓名:" + st.name + "\r\n" +
                            "國文:" + st.chinese + "\r\n" +
                            "英文:" + st.english + "\r\n" +
                            "數學:" + st.math + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)  //最高分最低分
        {
            int max, min;
            max = min = 
            
            textBox7.Text = "最高科目成績為:";
        }
    }
}
