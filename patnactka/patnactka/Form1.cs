using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patnactka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DateTime start = new DateTime();
        private void button1_Click(object sender, EventArgs e)
        {
            Button kamen = (Button)sender;
            Point bod = new Point();
            bod = kamen.Location;
            if ((bod.X - 80) == button1.Location.X & bod.Y == button1.Location.Y ^ 
                (bod.X + 80) == button1.Location.X & bod.Y == button1.Location.Y ^            // Podmínka:
                (bod.Y - 80) == button1.Location.Y & bod.X == button1.Location.X ^ 
                (bod.Y + 80) == button1.Location.Y & bod.X == button1.Location.X)          // Je vedle tebe volno?
            {
                kamen.Location = button1.Location;             //Prohození dvou kamenů
                button1.Location = bod;                        //
            }







            /*  Button kamen = (Button)sender;
            Point bod = new Point();
            bod = kamen.Location;
            if ((bod.X - 86) == button1.Location.X ^ (bod.X + 86) == button1.Location.X ^ 
                (bod.Y + 86) == button1.Location.Y ^ (bod.Y - 86) == button1.Location.Y)
            {
                kamen.Location = button1.Location;
                button1.Location = bod;                 //prohozeni
            } */
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button[] zamichat = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, kamenn };
            Random random = new Random();
            for (int i = 0; i <= 5000; i++)
            {
                int tlacitko = random.Next(0, 16);
                button1_Click(zamichat[tlacitko], e);
            }
            start = DateTime.Now;
            timer1.Enabled = true;
        }

        private void konecToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opravdu chcete program ukončit?",
                "Konec",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string cas = "";
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            TimeSpan ts = new TimeSpan();
            ts = dt - start;
            if (ts.Seconds < 10 && ts.Minutes < 10)
            {
                cas = "0"+ts.Minutes + ":0" + ts.Seconds + ":" + ts.Milliseconds / 10;
            }
            
            if (ts.Seconds >= 10 && ts.Minutes < 10)
            {
                cas = "0"+ts.Minutes + ":" + ts.Seconds + ":" + ts.Milliseconds / 10;
            }
            
            if (ts.Seconds >= 10 && ts.Minutes >= 10)
            {
                cas = ts.Minutes + ":" + ts.Seconds + ":" + ts.Milliseconds / 10;
            }
            
            if (ts.Seconds < 10 && ts.Minutes >= 10)
            {
                cas = "0"+ts.Minutes + ":0" + ts.Seconds + ":" + ts.Milliseconds / 10;
            }
            
            label1.Text = cas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
