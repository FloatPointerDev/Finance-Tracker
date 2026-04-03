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
                    label3.Text = "Please set the expense name 64 characters or less";
                } while (expenseName.Length > 64);
            } 
            else
            {
                // Pass user input into AddToList method in ExpensesForm
                ExpensesForm.instance.AddToList(expenseName, expenseCost);
                ExpensesForm.AddToListView(expenseName, expenseCost);
                this.Close();
            }
        }
    }
}
