using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace html_to_text
{
    public partial class Form1 : Form
    {
        string soubor = "☼♫♀";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "HTML soubory|*.html";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                soubor = openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         //f(MessageBox.Show("Opravdu chcete program ukončit?",
             // "Konec",
             // MessageBoxButtons.YesNo,
             // MessageBoxIcon.Question,
             // MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = String.Empty;
            string pom;
            bool zapisuj = true;
            foreach(string ret in richTextBox1.Lines)
            {
                pom = String.Empty;
                foreach(char znak in ret)
                {
                    if(zapisuj)
                    {
                        if (znak.ToString() == "<")
                        {
                            zapisuj = false;
                        }
                        else pom = pom + znak.ToString();
                    }
                    else
                        if(znak.ToString() == ">")
                        {
                            zapisuj = true;
                        }
                }
                richTextBox2.AppendText(pom+"\n");
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Textové soubory|*.txt|Všechny soubory|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(richTextBox2.Text);
                sw.Close();
            }
        }
    }
}
