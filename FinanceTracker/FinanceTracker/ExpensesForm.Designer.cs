namespace FinanceTracker
{
    partial class ExpensesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddExpense = new Button();
            DeleteExpenses = new Button();
            SaveExpense = new Button();
            EditExpense = new Button();
            SuspendLayout();
            // 
            // AddExpense
            // 
            AddExpense.Location = new Point(12, 12);
            AddExpense.Name = "AddExpense";
            AddExpense.Size = new Size(111, 71);
            AddExpense.TabIndex = 0;
            AddExpense.Text = "Add Expense";
            AddExpense.UseVisualStyleBackColor = true;
            AddExpense.Click += AddExpense_Click;
            // 
            // DeleteExpenses
            // 
            DeleteExpenses.Location = new Point(129, 12);
            DeleteExpenses.Name = "DeleteExpenses";
            DeleteExpenses.Size = new Size(111, 71);
            DeleteExpenses.TabIndex = 1;
            DeleteExpenses.Text = "Delete Expense";
            DeleteExpenses.UseVisualStyleBackColor = true;
            DeleteExpenses.Click += DeleteExpenses_Click;
            // 
            // SaveExpense
            // 
            SaveExpense.Location = new Point(246, 12);
            SaveExpense.Name = "SaveExpense";
            SaveExpense.Size = new Size(108, 71);
            SaveExpense.TabIndex = 2;
            SaveExpense.Text = "Save Expense";
            SaveExpense.UseVisualStyleBackColor = true;
            SaveExpense.Click += SaveExpense_Click;
            // 
            // EditExpense
            // 
            EditExpense.Location = new Point(360, 12);
            EditExpense.Name = "EditExpense";
            EditExpense.Size = new Size(108, 71);
            EditExpense.TabIndex = 3;
            EditExpense.Text = "Edit Expense";
            EditExpense.UseVisualStyleBackColor = true;
            EditExpense.Click += EditExpense_Click;
            // 
            // ExpensesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 495);
            Controls.Add(EditExpense);
            Controls.Add(SaveExpense);
            Controls.Add(DeleteExpenses);
            Controls.Add(AddExpense);
            Name = "ExpensesForm";
            Text = "ExpensesForm";
            ResumeLayout(false);
        }

        #endregion

        private Button AddExpense;
        private Button DeleteExpenses;
        private Button SaveExpense;
        private Button EditExpense;
    }
}