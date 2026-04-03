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
            // Get the user input from the TextBox
            expenseName = AddExpensesNameTextBox.Text;
        }

        private void AddExpensesCostTextBox_TextChanged(object sender, EventArgs e)
        {
            // Get the user input from the TextBox
            expenseCost = AddExpensesCostTextBox.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Check if name length is greater than 64 characters
            if (expenseName.Length > 64)
            {
                do
                {
                    // The expense name length is too long for the database
                    string errorMsg = "Error: Expense name is too long, please pick an expense name 64 characters or less";
                    throw_error error = new();
                    error.Show();
                    error.SetError(errorMsg);
                } while (expenseName.Length > 64);
            } 
            else if (string.IsNullOrEmpty(expenseName))
            {
                // You know you need to name the expense, right?
                string errorMsg = "Error: Please name the expense";
                throw_error error = new();
                error.Show();
                error.SetError(errorMsg);
            }
            else if (string.IsNullOrEmpty(expenseCost))
            {
                // Oopsie Doopsie, you forgot to set the cost
                string errorMsg = "Error: Please please set the cost";
                throw_error error = new();
                error.Show();
                error.SetError(errorMsg);
            }
            else
            {
                // Pass user input into AddToList method in ExpensesForm
                ExpensesForm.Instance.AddToList(expenseName, expenseCost);
                ExpensesForm.Instance.AddToLabels();
                this.Close();
            }
        }
    }
}
