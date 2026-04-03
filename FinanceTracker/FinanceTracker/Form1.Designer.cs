namespace FinanceTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EditExpensesButton = new Button();
            SaveButton = new Button();
            DisplayRemainingBudget = new Label();
            TotalBudget = new Label();
            listBox1 = new ListBox();
            NewBudget = new Button();
            SuspendLayout();
            // 
            // EditExpensesButton
            // 
            EditExpensesButton.Location = new Point(379, 94);
            EditExpensesButton.Name = "EditExpensesButton";
            EditExpensesButton.Size = new Size(115, 39);
            EditExpensesButton.TabIndex = 0;
            EditExpensesButton.Text = "Edit Expenses";
            EditExpensesButton.UseVisualStyleBackColor = true;
            EditExpensesButton.Click += EditExpensesButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(256, 94);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(117, 39);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DisplayRemainingBudget
            // 
            DisplayRemainingBudget.AutoSize = true;
            DisplayRemainingBudget.Location = new Point(256, 27);
            DisplayRemainingBudget.Name = "DisplayRemainingBudget";
            DisplayRemainingBudget.Size = new Size(108, 15);
            DisplayRemainingBudget.TabIndex = 2;
            DisplayRemainingBudget.Text = "Remaining Budget:";
            // 
            // TotalBudget
            // 
            TotalBudget.AutoSize = true;
            TotalBudget.Location = new Point(256, 56);
            TotalBudget.Name = "TotalBudget";
            TotalBudget.Size = new Size(80, 15);
            TotalBudget.TabIndex = 3;
            TotalBudget.Text = "Total Budget: ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(256, 145);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(238, 274);
            listBox1.TabIndex = 4;
            // 
            // NewBudget
            // 
            NewBudget.Location = new Point(690, 415);
            NewBudget.Name = "NewBudget";
            NewBudget.Size = new Size(98, 23);
            NewBudget.TabIndex = 5;
            NewBudget.Text = "New Budget";
            NewBudget.UseVisualStyleBackColor = true;
            NewBudget.Click += NewBudget_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NewBudget);
            Controls.Add(listBox1);
            Controls.Add(TotalBudget);
            Controls.Add(DisplayRemainingBudget);
            Controls.Add(SaveButton);
            Controls.Add(EditExpensesButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditExpensesButton;
        private Button SaveButton;
        private Label DisplayRemainingBudget;
        private Label TotalBudget;
        private ListBox listBox1;
        private Button NewBudget;
    }
}
