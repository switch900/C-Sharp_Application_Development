using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelResult.Text = string.Empty;
        }

        /// <summary>
        /// Validates that information entered in text boxes is a valid date when clicked using DateValidator class.
        /// Modifies labelResult's tooltip tag depending on validation.
        /// Formats labelResult's output depending on validation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheckDate_Click(object sender, EventArgs e)
        {
            if (sender == buttonCheckDate)
            {
                if (DateValidator.Validate(textBoxYear.Text, textBoxMonth.Text, textBoxDay.Text).Equals(true))
                {
                    labelResult.ForeColor = Color.Green;
                    labelResult.Text = "Valid";
                    toolTip1.SetToolTip(labelResult, "Entered Date is Valid");
                }
                else
                {
                    displayError("Invalid");
                    toolTip1.SetToolTip(labelResult, "Entered Date is NOT Valid");
                }
            }
            else
            {
                displayError("Invalid");
                toolTip1.SetToolTip(labelResult, "Entered Date is NOT Valid");
            }
        }

        private void displayError(string errorMessage)
        {
            labelResult.ForeColor = Color.Red;
            labelResult.Text = errorMessage;
        }
  
        private void textBoxYear_Enter(object sender, EventArgs e)
        {
            textBoxYear.Focus();
            textBoxYear.SelectAll();
        }

        private void textBoxMonth_Enter(object sender, EventArgs e)
        {
            textBoxMonth.Focus();
            textBoxMonth.SelectAll();
        }

        private void textBoxDay_Enter(object sender, EventArgs e)
        {
            textBoxDay.Focus();
            textBoxDay.SelectAll();
        }
    }
}