namespace FinanceTracker
{
    partial class EditExpensesForm
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
            Button1 = new Button();
            ExpensesNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SetNewCost = new TextBox();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(102, 70);
            Button1.Name = "Button1";
            Button1.Size = new Size(191, 53);
            Button1.TabIndex = 0;
            Button1.Text = "Send";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // ExpensesNameTextBox
            // 
            ExpensesNameTextBox.Location = new Point(102, 12);
            ExpensesNameTextBox.Name = "ExpensesNameTextBox";
            ExpensesNameTextBox.Size = new Size(327, 23);
            ExpensesNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Expense Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 3;
            label2.Text = "Set New Cost";
            // 
            // SetNewCost
            // 
            SetNewCost.Location = new Point(102, 41);
            SetNewCost.Name = "SetNewCost";
            SetNewCost.Size = new Size(327, 23);
            SetNewCost.TabIndex = 4;
            // 
            // EditExpensesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SetNewCost);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ExpensesNameTextBox);
            Controls.Add(Button1);
            Name = "EditExpensesForm";
            Text = "EditExpensesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button1;
        private TextBox ExpensesNameTextBox;
        private Label label1;
        private Label label2;
        private TextBox SetNewCost;
    }
}