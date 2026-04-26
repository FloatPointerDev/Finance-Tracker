using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace FinanceTracker
{
    // Form1 displays all the data the user inputted
    public partial class Form1 : Form
    {
        public static Form1? Instance { get; set; }
        bool isEnabled = false;
        public double setRemainingBudget;
        public double totalBudget;
        public bool remainingBudgetTooLow = false;
        public int sessionId;

        public Form1()
        {
            // Initialise Form1 and set Form1 object instance to this
            InitializeComponent();
            Instance = this;

            // Declare SQL queries and database name
            string createSession = $"CREATE TABLE session (\r\nsessionId INT PRIMARY KEY AUTO_INCREMENT,\r\nbudget INT NOT NULL,\r\nsessionDate DATE\r\n);";
            string createExpenses = $"CREATE TABLE expenses (\r\nexpensesId INT PRIMARY KEY AUTO_INCREMENT,\r\nexpenseName varchar(64),\r\nexpenseCost INT NOT NULL,\r\nsessionId INT,\r\nCONSTRAINT fk_session\r\nFOREIGN KEY (sessionId) REFERENCES session (sessionId));";
            string DBname = "FinanceTracker";
            string getTotalSessionsQuery = "SELECT COUNT(sessionId) FROM session;";
            DataTable totalSessions = new();

            // Input SQL queries into XAMPP database
            SQL.CreateDatabase(DBname);
            SQL.CreateTable(DBname, createSession);
            SQL.CreateTable(DBname, createExpenses);
            totalSessions = SQL.RunSelect(DBname, getTotalSessionsQuery);

            if (totalSessions != null)
            {
                SessionGet sessionMenu = new();
                sessionMenu.Show();
                sessionId = 0;
            }
        }

        public void SetSessionId(int getId)
        {
            sessionId = getId;

            string budgetQuery = $"SELECT budget FROM session WHERE sessionid = {sessionId};";
            string expenseQuery = $"SELECT expenseName, expenseCost FROM expenses WHERE sessionId = {sessionId};";
            SQL.LoadSessionData("FinanceTracker", budgetQuery, expenseQuery);
            SQL.FindMax(sessionId);

            string errorMsg = $"{sessionId}";
            throw_error error = new();
            error.Show();
            error.SetError(errorMsg);
        }

        // Create new ExpensesForm object
        public ExpensesForm f3 = new();
        private void EditExpensesButton_Click(object sender, EventArgs e)
        {
            if (isEnabled == true)
            {
                // Display new ExpensesForm object
                f3.Show();
            } 
            else
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
            DateTime today = DateTime.Now; // Fetch today's date
            string insertSession = $"INSERT INTO session (sessionId, budget, sessionDate) VALUES ({sessionId}, {totalBudget}, '{today:yyyy-MM-dd}');";

            // Send to SQL database with script
            SQL.SaveExpenses("FinanceTracker", insertSession);

            for (int i = 0; i < ExpensesForm.Instance.expenseNameList.Count; i++)
            {
                // Create expenses insert query
                string insertExpenses = $"INSERT INTO expenses (expenseName, ExpenseCost, sessionId) VALUES ('{ExpensesForm.Instance.expenseNameList[i]}', {ExpensesForm.Instance.expenseCostList[i]}, {sessionId});";
                SQL.SaveExpenses("FinanceTracker", insertExpenses); // Send to table FinanceTracker
            }

            this.Close(); // End program
        }

        public void InputBudget(double setBudget)
        {
            // Set total budget from input from InputBudgetAlertForm
            totalBudget = setBudget;
            TotalBudget.Text = "Total Budget: " + setBudget.ToString();
            isEnabled = true;
            DisplayRemainingBudget.Text = "Remaining Budget: " + setBudget.ToString();
        }

        public void InputRemainingBudget(List<string> expenseCostList)
        {
            setRemainingBudget = totalBudget;
            // Set remaining budget from InputBudgetAlertForm
            for (int i = 0; i < expenseCostList.Count; i++)
            {
                setRemainingBudget -= Double.Parse(expenseCostList[i]);
            }

            // Display remaining budget
            DisplayRemainingBudget.Text = "Remaining Budget: " + setRemainingBudget.ToString();

            // Check if within 10% of maximum
            if (setRemainingBudget <= 0)
            {
                // Inform user their budget has went over the maximum
                string errorMsg = "Warning: Your budget has gone over the maximum";
                throw_error error = new();
                error.Show();
                error.SetError(errorMsg);

                remainingBudgetTooLow = true;

                ExpensesForm.Instance.RemainingBudgetTooLowMethod(remainingBudgetTooLow);

            }
            else if (setRemainingBudget <= totalBudget * 0.1)
            {
                // Declare and initialise warning to user and display using template message window
                string errorMsg = "Warning: Your budget is within 10% of the maximum";
                throw_error error = new();
                error.Show();
                error.SetError(errorMsg);
            }
        }

        private void NewBudget_Click(object sender, EventArgs e)
        {
            // Create new InputBudgetAlertForm object
            InputBudgetAlertForm f2 = new();
            f2.Show(this);
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
                // string dropCommand = $"CREATE DATABASE IF NOT EXISTS `{databaseName}`;";
                // MySqlCommand drop = new(dropCommand, conn);
                // drop.ExecuteNonQuery();

                // Create Database
                string createCommand = $"CREATE DATABASE IF NOT EXISTS `{databaseName}`";
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

        public static DataTable RunSelect(string databaseName, string query)
        {
            string connStr = $"Server={server};Port={port};Database={databaseName};" + $"Uid={userID};Pwd={password};";
            MySqlConnection conn = new(connStr);
            DataTable? dt = new();
            try
            {
                conn.Open();
                MySqlCommand cmd = new(query, conn);
                MySqlDataAdapter adapter = new(cmd);
                adapter.Fill(dt);

                if (dt.Rows.Count <= 0)
                {
                    return dt = null;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("RunSelect error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }

        public static void LoadSessionData(string databaseName, string query, string expensesQuery)
        {
            DataTable sessionDT = SQL.RunSelect(databaseName, query);

            if (sessionDT != null && sessionDT.Rows.Count > 0)
            {
                double loadedBudget = Convert.ToDouble(sessionDT.Rows[0]["budget"]);
                Form1.Instance.InputBudget(loadedBudget);
            }

            DataTable expensesDT = SQL.RunSelect(databaseName, expensesQuery);

            if (expensesDT != null)
            {
                ExpensesForm.Instance.expenseNameList.Clear();
                ExpensesForm.Instance.expenseCostList.Clear();

                foreach (DataRow row in expensesDT.Rows)
                {
                    string name = row["expenseName"].ToString();
                    string cost = row["expenseCost"].ToString();

                    ExpensesForm.Instance.AddToList(name, cost);
                }

                ExpensesForm.Instance.AddToLabels();

                Form1.Instance.InputRemainingBudget(ExpensesForm.Instance.expenseCostList);
            }
        }

        public static void FindMax(int id)
        {
            // In hindsight, a lot easier to just have the queries in the methods, like this
            // But its a bit late to change that...
            string findMaxQuery = $"SELECT MAX(sessionId) FROM session;";
            DataTable findMaxTable = SQL.RunSelect("FinanceTracker", findMaxQuery);

            if (findMaxTable != null && findMaxTable.Rows.Count > 0)
            {
                id = Convert.ToInt32(findMaxTable.Rows[0]) + 1;
            }
        }
    }
}