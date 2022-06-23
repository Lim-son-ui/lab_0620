using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        parama para = new parama();

        void calcu()     //統一運算  總分  平均  最低   最高
        {
            
            for (int i = 0; i < 3; i++)
            {
                para.sum += para.score[para.stu_num,i];
                if (i == 0) para.min = para.max = para.score[para.stu_num,0];

                else
                {
                    if (para.max < para.score[para.stu_num,i]) para.max = para.score[para.stu_num,i];
                    if (para.min > para.score[para.stu_num,i]) para.min = para.score[para.stu_num,i];
                }
            }

            //int avg_out;
            para.avg = para.sum / 3;
            para.avg = Math.Round(para.avg, 1, MidpointRounding.AwayFromZero);

        }
        private void button1_Click(object sender, EventArgs e)      //插入字串所加入的新值
        {

            string name;
            
            name = textBox1.Text;                                   //名字
            para.score[para.stu_num,0] = Convert.ToInt32(textBox2.Text);              //國文
            para.score[para.stu_num,1] = Convert.ToInt32(textBox3.Text);              //英文
            para.score[para.stu_num,2] = Convert.ToInt32(textBox4.Text);              //數學

            calcu();

            print();
            //textBox5.Text += $"\r\n{textBox1.Text.PadRight(15)}{textBox2.Text.PadLeft(20)}{textBox3.Text.PadLeft(20)}{textBox4.Text.PadLeft(20)}"+
            //                $"{para.sum.ToString().PadLeft(20)}{para.avg.ToString().PadLeft(20)}{para.min.ToString().PadLeft(20)}" +
            //                $"{para.max.ToString().PadLeft(20)}";

            para.stu_num++;
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        void print()        //隨機生成的列表  所以textbox不會輸入
        {
            textBox5.Text += $"\r\n{textBox1.Text.PadRight(15)}{para.score[para.stu_num,0].ToString().PadLeft(20)}{para.score[para.stu_num,1].ToString().PadLeft(20)}" +
                $"{para.score[para.stu_num,2].ToString().PadLeft(20)}{para.sum.ToString().PadLeft(20)}{para.avg.ToString().PadLeft(20)}{para.min.ToString().PadLeft(20)}" +
                $"{para.max.ToString().PadLeft(20)}";

        }
        private void button2_Click(object sender, EventArgs e)
        {       //姓名  國文分數   英文分數   數學分數  各科名字 

            //int[] score = new int[3];

            ////1.名字根據  排序 顯示出數字  2.隨機出三科分數   3.透過calcu算出剩餘

            //for (int i = 0; i < 20; i++) //放入隨機參數
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Random rd = new Random();
            //        int rd_num = rd.Next(0, 100);
            //        para.score[i, j];
            //        para.score[i,j] = rd_num;
            //    }
                
            //}

            //calcu();
            //print();

            //MessageBox.Show(rd_num.ToString());


        }
    }
}
