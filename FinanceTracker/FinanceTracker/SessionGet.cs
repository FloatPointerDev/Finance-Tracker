using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;

namespace FinanceTracker
{
    public partial class SessionGet : Form
    {
        // Initialise session ID and query
        public int sessionId;
        public string getTotalSessionsQuery = "SELECT COUNT(sessionId) FROM session;";
        public string getSessions = "SELECT sessionId, sessionDate FROM session;";
        public DataTable sessionDataTable = new();
        public DataTable totalSessions = new();
        public SessionGet()
        {
            InitializeComponent();
            sessionDataTable = SQL.RunSelect("FinanceTracker", getSessions);
            totalSessions = SQL.RunSelect("FinanceTracker", getTotalSessionsQuery);

            if (totalSessions != null && totalSessions.Rows.Count > 0)
            {
                var count = totalSessions.Rows[0][0];
                label1.Text = $"You have {count} previous sessions";
            }

            if (sessionDataTable != null)
            {
                listBox1.Items.Clear();
                foreach (DataRow row in sessionDataTable.Rows)
                {
                    string display = $"ID: {row["sessionId"]} / Date: {row["sessionDate"]}";
                    listBox1.Items.Add(display);
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            // session ID from textbox as int
            sessionId = int.Parse(textBox1.Text);

            // Send session ID to Form1 and close
            Form1.Instance.SetSessionId(sessionId);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
