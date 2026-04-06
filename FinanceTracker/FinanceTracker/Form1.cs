using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace FinanceTracker
{
    // Form1 displays all the data the user inputted
    public partial class Form1 : Form
    {
        public static Form1 Instance { get; set; }
        bool isEnabled = false;
        public int sessionId = 1;
        public Form1()
        {
            // Initialise Form1 and set Form1 object instance to this
            InitializeComponent();
            Instance = this;

            // Declare SQL queries and database name
            string createSession = $"CREATE TABLE session (\r\nsessionId INT PRIMARY KEY,\r\nbudget INT NOT NULL,\r\nsessionDate DATE\r\n);";
            string createExpenses = $"CREATE TABLE expenses (\r\nexpensesId INT PRIMARY KEY AUTO_INCREMENT,\r\nexpenseName varchar(64),\r\nexpenseCost INT NOT NULL,\r\nsessionId INT,\r\nCONSTRAINT fk_session\r\nFOREIGN KEY (sessionId) REFERENCES session (sessionId));";
            string DBname = "FinanceTracker";

            // Input SQL queries into XAMPP database
            SQL.CreateDatabase(DBname);
            SQL.CreateTable(DBname, createSession);
            SQL.CreateTable(DBname, createExpenses);


        }

        // Create a new object of ExpensesForm
        public ExpensesForm f3 = new();
        private void EditExpensesButton_Click(object sender, EventArgs e)
        {
            if (isEnabled == true)
            {
                // Display new ExpensesForm object
                f3.Show();
            } else
            {
                // Declare and initialise error message with error and display to user using template error window
                string errorMsg = "Error: Please set a budget first";
                throw_error error = new();
                error.Show();
                error.SetError(errorMsg);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InputBudget(int setBudget)
        {
            // Set total budget from input from InputBudgetAlertForm
            TotalBudget.Text = "Total Budget: " + setBudget.ToString();
            isEnabled = true;
        }

        public void InputRemainingBudget(int setBudget)
        {
            // Set remaining budget from input from InputBudgetAlertForm
            for (int i = 0; i < f3.expenseCostList.Count; i++)
            {
                setBudget -= Int32.Parse(f3.expenseCostList[i]);
            }
            DisplayRemainingBudget.Text = "Remaining Budget: " + setBudget.ToString();
        }

        private void NewBudget_Click(object sender, EventArgs e)
        {
            // Create an object of InputBudgetAlertForm
            InputBudgetAlertForm f2 = new();
            f2.Show(this);
        }

        public void SendToForm1()
        {
            List<string> expenseNameList = ExpensesForm.Instance.expenseNameList;
            List<string> expenseCostList = ExpensesForm.Instance.expenseCostList;
        }
    }

    public class SQL
    {
        // declare database connection variables
        static readonly string server = "localhost";
        static readonly int port = 3306;
        static readonly string userID = "root";
        static readonly string password = "";
        public static void CreateDatabase(string databaseName)
        {
            // Connect to database and establish database connection object
            string connStr = $"Server={server};Port={port};Uid={userID};Pwd={password};";
            MySqlConnection conn = new(connStr);

            try
            {
                conn.Open();

                // Drop database if exists
                string dropCommand = $"DROP DATABASE IF EXISTS `{databaseName}`;";
                MySqlCommand drop = new(dropCommand, conn);
                drop.ExecuteNonQuery();

                // Create Database
                string createCommand = $"CREATE DATABASE `{databaseName}`";
                MySqlCommand create = new(createCommand, conn);
                create.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("CreateDatabase error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    // Close database connection
                    conn.Close();
                }
            }
        }

        public static void CreateTable(string databaseName, string query)
        {
            // Connect to database and establish connection object
            string connStr = $"Server={server};Port={port};Database={databaseName};Uid={userID};Pwd={password};";
            MySqlConnection conn = new(connStr);

            try
            {
                // Open database connection
                conn.Open();

                // Create table and fields
                MySqlCommand command = new(query, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("RunQuery Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    // Close database connection
                    conn.Close();
                }
            }
        }

        public static void SaveExpenses(string databaseName, string query)
        {
            // Connect to database and establish database connection object
            string connStr = $"Server={server};Port={port};Database={databaseName};Uid={userID};Pwd={password};";
            MySqlConnection conn = new(connStr);

            try
            {
                conn.Open();

                // Create Database
                MySqlCommand command = new(query, conn);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("CreateDatabase error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    // Close database connection
                    conn.Close();
                }
            }
        }

    }
}
