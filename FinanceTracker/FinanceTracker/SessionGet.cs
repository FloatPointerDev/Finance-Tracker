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
            label1.Text = $"You have {totalSessions} previous sessions";

            if (sessionDataTable != null)
            {
                for (int i = 0; i < sessionDataTable.Rows.Count; i++)
                {
                    listBox1.Text = sessionDataTable.ToString();
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
