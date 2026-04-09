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
    
    public partial class AddExpensesForm : Form
    {
        // Declare and initialise variables to be passed into ExpensesForm
        string expenseName = "";
        string expenseCost = "";
        public AddExpensesForm()
        {
            InitializeComponent();
        }

        private void AddExpensesNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddExpensesCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Get the user input from the TextBox
            expenseName = AddExpensesNameTextBox.Text;
            expenseCost = AddExpensesCostTextBox.Text;

            // Check if:
            // - Name is too long
            // - Name is too short
            // - Cost is empty
            if (expenseName.Length >= 65)
            {
                // Send error message explaining name field is too long
                string errorMsg = "Error: Expense name is too long, please pick an expense name 64 characters or less";
               throw_error error = new();
               error.Show();
               error.SetError(errorMsg);
            }
            else if (expenseName.Length <= 0)
            {
                // Send error message explaining name field needs to be filled in
                string errorMsg = "Error: Expense name is too short, please pick an expense name longer than 0 characters";
                throw_error error = new();
                error.Show();
                error.SetError(errorMsg);
            }
            else if (expenseCost.Length <= 0)
            {
                // Send error message explaining cost field needs to be filled in
                string errorMsg = "Error: Please input an expense cost";
                throw_error error = new();
                error.Show();
                error.SetError(errorMsg);
            }
            else
            {
                // Pass user input into AddToList method in ExpensesForm
                ExpensesForm.Instance.AddToList(expenseName, expenseCost);
                ExpensesForm.Instance.AddToLabels();
                this.Hide();
            }
        }
    }
}
