using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{   
    public partial class Form1 : Form
    {
        public int a = 0;
        public int b = 1;
        public int c = 0;
        public int x;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
             x = Convert.ToInt32(numericUpDown1.Value);
            if (x == 0)
            {
                label2.Text = "0";
            }
            if (x == 1)
            {
                label2.Text = "0";
            }
            if (x == 2 | x == 3)
            {
                label2.Text = "1";
            }
            if (x > 3)
            {
                c = 1;
                a = 0;
                b = 1;
                for (int i = 2; i < x; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    label2.Text = Convert.ToString(c);
                }
            }
        }
    }
}
