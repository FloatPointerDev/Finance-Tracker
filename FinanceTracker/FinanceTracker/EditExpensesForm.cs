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
    public partial class EditExpensesForm : Form
    {
        // Declare and initialise variables to be passed into ExpensesForm
        string expenseName = "";
        string expenseCost = "";

        public EditExpensesForm()
        {
            InitializeComponent();
        }

        private void ExpensesNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Get the user input from the TextBox
            expenseName = ExpensesNameTextBox.Text;
        }

        private void SetNewCost_TextChanged(object sender, EventArgs e)
        {
            // Get the user input from the TextBox
            expenseCost = SetNewCost.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Pass user input into AddToList method in ExpensesForm
            ExpensesForm.Instance.ModifyList(expenseName, expenseCost);
            this.Close();
        }
    }
}
