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
        int newBudget = 0;
        public InputBudgetAlertForm()
        {
            InitializeComponent();
        }

        private void BudgetInputTextBox_TextChanged(object sender, EventArgs e)
        {
            // Get the user input from the TextBox
            newBudget = Convert.ToInt32(BudgetInputTextBox.Text);
        }

        private void BudgetInputButton_Click(object sender, EventArgs e)
        {
            // Send user input to methods in Form1
            Form1.Instance.InputBudget(newBudget);
            Form1.Instance.InputRemainingBudget(newBudget);

            // Close the InputBudgetAlert Form
            this.Close();
        }
    }
}
