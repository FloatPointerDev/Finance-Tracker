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

    public partial class ExpensesForm : Form
    {
        // Initialise object of ExpensesForm and create 2 lists to store user input
        public static ExpensesForm instance;
        public List<string> expenseNameList = [];
        public List<string> expenseCostList = [];

        public ExpensesForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void EditExpense_Click(object sender, EventArgs e)
        {
            // Create new object of EditExpensesForm and display
            EditExpensesForm f5 = new();
            f5.Show();
        }

        private void SaveExpense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteExpenses_Click(object sender, EventArgs e)
        {
            // Create new object of DeleteExpense and display
            DeleteExpense f6 = new();
            f6.Show();
        }

        private void AddExpense_Click(object sender, EventArgs e)
        {
            // Create new object of AddExpensesForm and display
            AddExpensesForm f4 = new();
            f4.Show();
        }

        public void AddToList(string expenseName, string expenseCost)
        {
            // Add user input passed from AddExpensesForm into lists
            expenseNameList.Add(expenseName);
            expenseCostList.Add(expenseCost);
        }

        public void DeleteFromList(string expenseName, string expenseCost)
        {
            // Loop for entire list
            for (int i = 0; i < expenseNameList.Count; i++)
            {
                // If specified element is discovered
                if (expenseName == expenseNameList[i] && expenseCost == expenseCostList[i])
                {
                    // Remove specified element from the list and terminate
                    expenseNameList.RemoveAt(i);
                    expenseCostList.RemoveAt(i);
                    break;
                }
            }
        }

        public void ModifyList(string expenseName, string expenseCost)
        {
            // Loop for entire list
            for (int i = 0; i < expenseNameList.Count; i++)
            {
                // If specified element is discovered
                if (expenseName == expenseNameList[i] && expenseCost == expenseCostList[i])
                {
                    // Remove specified element from the list and terminate
                    expenseNameList.RemoveAt(i);
                    expenseCostList.RemoveAt(i);
                    break;
                }
            }
        }

        public static void AddToListView(string expenseNameList, string expenseCostList)
        {

        }
    }
}
