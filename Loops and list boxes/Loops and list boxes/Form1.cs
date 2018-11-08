using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops_and_list_boxes
{
    public partial class Numbers : Form
    {
        public Numbers()
        {
            InitializeComponent();
        }

        private void GenerateNumbers(string minString, string maxString)
        {
            try
            {
                int min = Convert.ToInt32(minString);
                int max = Convert.ToInt32(maxString);

                for (int i = min; i <= max; i++)
                {
                    lstNumbers.Items.Add("Number " + i);
                }
            }
            catch
            {
                
            }
        }

        private void GenerateNumbersBack(string minString, string maxString)
        {
            try
            {
                int min = Convert.ToInt32(minString);
                int max = Convert.ToInt32(maxString);

                for (int i = min; i >= max; i--)
                {
                    lstNumbers.Items.Add("Number " + i);
                }
            }
            catch
            {

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            GenerateNumbers(txtMin.Text, textMax.Text);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            GenerateNumbersBack(textMax.Text, txtMin.Text);
        }
    }
}
