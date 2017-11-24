using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoop1_Click(object sender, EventArgs e)
        {
            //Use a loop to display numbers from 100 to 1020 on our label
            //For loop structure: Start number, condition for continuing, Increment
            lblLoop1.Text = "";
            //counter++ is the same as counter = counter + 1
            for (Int32 counter = 100; counter <= 120; counter++)
            {
                // add the current number on to the end of the label text
                lblLoop1.Text += counter + " ";
            }

        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            lblLoop1.Text = "";
            Int32 counter = 100;
            while (counter <= 120)
            {
                lblLoop1.Text += counter + " ";
                //Add one to the counter
                counter++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Capture x and y as variabes
            Int32 x = Convert.ToInt32(txtX.Text);
            Int32 y = Convert.ToInt32(txtY.Text);
            //Send x and y to theAddNumbers method and display the result
            Int32 result = AddNumbers(x, y);
            lblSum.Text = Convert.ToString(result);
        }
        //Method accepts 2 integer inputs and returns another integer back
        private Int32 AddNumbers(Int32 x, Int32 y)
        {
            Int32 sum = x + y;
            return sum;
        }
    }
}
