using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class MyFirstClass
    {
        void Method01()
        {
            MessageBox.Show("Method01");
        }

        private void Method02() 
        {
            MessageBox.Show("Method02");
        }

        internal void Method03()
        {
            MessageBox.Show("Method03 internal");
        }

        public void Method04()
        {
            MessageBox.Show("Method04 public");
        }

        public void Method05()
        {
            Method01();
            Method02();
        }

        //string STR;
    }
}
