namespace FinanceTracker
{
    partial class AddExpensesForm
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
            button1 = new Button();
            AddExpensesNameTextBox = new TextBox();
            AddExpensesCostTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 70);
            button1.Name = "button1";
            button1.Size = new Size(192, 54);
            button1.TabIndex = 0;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // AddExpensesNameTextBox
            // 
            AddExpensesNameTextBox.Location = new Point(102, 12);
            AddExpensesNameTextBox.Name = "AddExpensesNameTextBox";
            AddExpensesNameTextBox.Size = new Size(347, 23);
            AddExpensesNameTextBox.TabIndex = 1;
            // 
            // AddExpensesCostTextBox
            // 
            AddExpensesCostTextBox.Location = new Point(102, 41);
            AddExpensesCostTextBox.Name = "AddExpensesCostTextBox";
            AddExpensesCostTextBox.Size = new Size(347, 23);
            AddExpensesCostTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Expense Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 127);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // AddExpensesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddExpensesCostTextBox);
            Controls.Add(AddExpensesNameTextBox);
            Controls.Add(button1);
            Name = "AddExpensesForm";
            Text = "AddExpensesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox AddExpensesNameTextBox;
        private TextBox AddExpensesCostTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}