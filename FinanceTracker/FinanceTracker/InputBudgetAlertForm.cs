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
        public InputBudgetAlertForm()
        {
            InitializeComponent();
        }

        private void BudgetInputTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void BudgetInputButton_Click(object sender, EventArgs e)
        {
            // Initialise variables
            double newBudget = Convert.ToDouble(BudgetInputTextBox.Text);

            // Send user input to methods in Form1
            Form1.Instance.InputBudget(newBudget);

            // Close the InputBudgetAlert Form
            this.Close();
        }
    }
}