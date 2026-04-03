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
    public partial class DeleteExpense : Form
    {
        public string expenseName = "";
        public string expenseCost = "";
        public DeleteExpense()
        {
            InitializeComponent();
        }

        private void DeleteExpenseTextBox_TextChanged(object sender, EventArgs e)
        {
            // Get the user input from the TextBox
            expenseName = DeleteExpenseTextBox.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Pass user input into AddToList method in ExpensesForm
            ExpensesForm.instance.DeleteFromList(expenseName, expenseCost);
            this.Close();
        }
    }
}
