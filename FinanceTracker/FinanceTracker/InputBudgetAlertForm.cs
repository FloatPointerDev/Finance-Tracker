using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class InputBudgetAlertForm : Form
    {
        // Declare and initialise newBudget variable
        double newBudget;
        public InputBudgetAlertForm()
        {
            InitializeComponent();
        }

        private void BudgetInputTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the user input from the TextBox
                newBudget = Convert.ToDouble(BudgetInputTextBox.Text);
            }
            catch (Exception)
            {
                // This fixes a bug regarding pressing backspace after filling something in
                // However, I'm not sure what to put here
            }
        }

        private void BudgetInputButton_Click(object sender, EventArgs e)
        {
            // Send user input to methods in Form1
            Form1.Instance.InputBudget(newBudget);

            // Close the InputBudgetAlert Form
            this.Hide();
        }
    }
}
