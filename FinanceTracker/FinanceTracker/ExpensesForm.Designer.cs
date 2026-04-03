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
            label1 = new Label();
            label2 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 139);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 4;
            label1.Text = "Expense:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 139);
            label2.Name = "label2";
            label2.Size = new Size(66, 32);
            label2.TabIndex = 5;
            label2.Text = "Cost:";
            // 
            // ExpensesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 495);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EditExpense);
            Controls.Add(SaveExpense);
            Controls.Add(DeleteExpenses);
            Controls.Add(AddExpense);
            Name = "ExpensesForm";
            Text = "ExpensesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddExpense;
        private Button DeleteExpenses;
        private Button SaveExpense;
        private Button EditExpense;
        private Label label1;
        private Label label2;
    }
}