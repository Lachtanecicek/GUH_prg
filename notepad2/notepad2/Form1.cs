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

namespace notepad2
{
    public partial class Form1 : Form
    {
        string soubor = "☼♫♀";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oProgramuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad v2.0\nFilip Švehla\n2022",
                "Notepad v2.0",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void konecToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void konecToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            if(MessageBox.Show("Opravdu chcete program ukončit?",
                "Konec",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void písmoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fontDialog1.Font;
        }

        private void písmoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void barvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void pozadíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
                richTextBox1.BackColor = colorDialog2.Color;
        }

        private void otevřítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Textové soubory|*.txt|Všechny soubory|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                soubor = openFileDialog1.FileName;
            }
        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName != soubor)
            {
                saveFileDialog1.Filter = "Textové soubory|*.txt|Všechny soubory|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Uložit jako...
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(richTextBox1.Text);
                    sw.Close();
                    soubor = saveFileDialog1.FileName;
                }
            }
            else
            {
                // Uložit
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(richTextBox1);
                sw.Close();
                soubor = openFileDialog1.FileName;
            }
        }
    }
}
