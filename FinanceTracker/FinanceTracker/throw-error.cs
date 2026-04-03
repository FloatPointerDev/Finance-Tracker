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
    /* This is a template error pop-up window
    its easier than making a new error window for every purpose 
    The message gets passed from a variable set in one of the other forms */
    public partial class throw_error : Form
    {
        public throw_error()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Close error window once user understands and wishes to proceed
            this.Close();
        }

        public void SetError(string error)
        {
            // Set the error message so the user understands what went wrong
            label1.Text = error;
        }
    }
}
