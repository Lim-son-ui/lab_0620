using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    partial class MyFirstClass
    {
        public void Method06()
        {
            MessageBox.Show("Method06 Partial Class");
        }
    }

    public class Member
    {
        public string Name;
        public int Age;
    }

    public class UseStatic
    {
        public int InstanceCount;
        public static int StaticCount;
    }

    public enum UserRole:byte
    {
        Admin,
        User = 2,
        User2
    }
}
