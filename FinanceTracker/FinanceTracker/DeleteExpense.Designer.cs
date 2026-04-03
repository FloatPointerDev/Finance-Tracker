namespace FinanceTracker
{
    partial class DeleteExpense
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
            label1 = new Label();
            DeleteExpenseTextBox = new TextBox();
            Button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Expense Name";
            // 
            // DeleteExpenseTextBox
            // 
            DeleteExpenseTextBox.Location = new Point(102, 17);
            DeleteExpenseTextBox.Name = "DeleteExpenseTextBox";
            DeleteExpenseTextBox.Size = new Size(324, 23);
            DeleteExpenseTextBox.TabIndex = 1;
            // 
            // Button1
            // 
            Button1.Location = new Point(102, 46);
            Button1.Name = "Button1";
            Button1.Size = new Size(129, 39);
            Button1.TabIndex = 2;
            Button1.Text = "Send";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // DeleteExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button1);
            Controls.Add(DeleteExpenseTextBox);
            Controls.Add(label1);
            Name = "DeleteExpense";
            Text = "DeleteExpense";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DeleteExpenseTextBox;
        private Button Button1;
    }
}