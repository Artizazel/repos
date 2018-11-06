using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblGameOver.Location = new Point(1000000, 1);
        }

        Random rndY = new Random();

        int Health = 4;
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Location = new Point(10000, 1);
            lblMaximise.Location = new Point(10000, 1);
            timer1.Start();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Health = Health + 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.Beep();
            timer1.Interval = 1500;

            Random rndX = new Random();

            button1.Location = new Point(rndX.Next(1, 1800), rndY.Next(1, 990));

            Health = Health - 1;

            if (Health == 2)
            {
                lblLife1.Text = "[  ]";
            }
            else if (Health == 1)
            {
                lblLife2.Text = "[  ]";
            }
            else if (Health == 0 )
            {
                lblLife3.Text = "[  ]";
                timer1.Stop();
                lblGameOver.Location = new Point(750, 400);
                button1.Location = new Point(100000000, 1);
            }


        }

        private void lblMaximise_Click(object sender, EventArgs e)
        {

        }

        private void lblLife1_Click(object sender, EventArgs e)
        {

        }

        private void lblLife2_Click(object sender, EventArgs e)
        {

        }

        private void lblLife3_Click(object sender, EventArgs e)
        {

        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {

        }
    }
}
