using Lab_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Consloe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#!");
            Console.Write("請輸入姓名: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);

            MyFirstClass mc = new MyFirstClass();
            mc.Method04();

            Console.ReadKey();
        }
    }
}
