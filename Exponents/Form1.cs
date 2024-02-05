using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/**************************************
 * Name:
 * Date:
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class UxMainForm : Form
    {
        public UxMainForm()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int num;
            int resultsquare;
            int resultcube;
            // INPUT
            try
            {
                num = Convert.ToInt32(UxInputTextBox.Text);
                resultsquare = System.Convert.ToInt32(Math.Pow(num, 2));
                resultcube = System.Convert.ToInt32(Math.Pow(num, 3));


                UxGoButton.Enabled = false;


                UxResultBox.Text = (resultsquare).ToString();
                UxResultCube.Text = (resultcube).ToString();
            }
            catch(Exception ex) 
            {
                UxResultBox.Text = "That is NOT an integer";
                UxResultCube.Text = "Please reset and try again";
            }

            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */

            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */

            // OUTPUT
            // set the output to visible

            // turn the Go button off
        }

        

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            // turn the output to invisible
            // turn the Go button back on
            UxInputTextBox.Text = "";
            UxResultBox.Text = "";
            UxResultCube.Text = "";

            UxGoButton.Enabled = true;
        }

        private void UxMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
