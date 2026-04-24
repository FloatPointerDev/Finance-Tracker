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
        public int sessionId;
        public string getSessions = "SELECT COUNT(sessionId) FROM session;";
        public SessionGet()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Form1.Instance.SetSessionId(sessionId);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sessionId = int.Parse(textBox1.Text);
        }
    }
}
