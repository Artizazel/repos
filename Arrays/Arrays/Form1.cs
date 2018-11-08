using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }


        private void GenerateArray(string rowsString, string colsString)
        {
            int rows = Convert.ToInt32(rowsString);
            int cols = Convert.ToInt32(colsString);
            int grid = rows * cols;
            string output = "";

            int[,] numArray = new int[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    numArray[i, j] = (i+1) * (j+1);
                }
            }



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    output = output + numArray[i, j];
                }
                lstNumbers.Items.Add(output);
            }




        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            
            GenerateArray(txtRows.Text, txtCols.Text);

            
        }

        private void txtRows_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCols_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
