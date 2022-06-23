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

    //public class Stati
    //{
    //    public string[] stu = new string[4];

    //}
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Stati        //陣列結構 儲存同一學生輸入成績
        {
            public string[] stu_grade;
        }Stati st;          //無須實作new出一個


        private void button1_Click(object sender, EventArgs e)      //儲存輸入資料
        { 
            st.stu_grade = new string[4]; 
            st.stu_grade[0] = textBox1.Text;
            st.stu_grade[1] = textBox2.Text;
            st.stu_grade[2] = textBox3.Text;
            st.stu_grade[3] = textBox4.Text;

        }

        private void button2_Click(object sender, EventArgs e)  //顯示儲存內容
        {
            textBox6.Text = "姓名:" + st.stu_grade[0] + "\r\n" +
                            "國文:" + st.stu_grade[1] + "\r\n" +
                            "英文:" + st.stu_grade[2] + "\r\n" +
                            "數學:" + st.stu_grade[3] + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)  //最高分最低分
        {
            int max = 0, min = 0, max_count = 0 ,min_count = 0;
            int[] score = new int[3];
            string[] course = new string[3] { "國文", "英文", "數學" };

            for (int i = 0; i < 3; i++)        //將字串轉為數字
            {
                score[i] = Convert.ToInt32(st.stu_grade[i+1]);
            }


            for (int j=0; j < 3 ; j++)
            {
                if (j == 0) max = min = score[j];
                else
                {
                    if (max < score[j]) { 
                        max = score[j];
                        max_count = j;
                    }
                    if (min > score[j])
                    {
                        min = score[j];
                        min_count = j;
                    }
                }
            }

            textBox7.Text = "最高科目成績為:" + course[max_count]+ "" + max +"\r\n"+
                            "最低科目成績為:" + course[min_count] + "" + min + "\r\n";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }

    //class 
}
