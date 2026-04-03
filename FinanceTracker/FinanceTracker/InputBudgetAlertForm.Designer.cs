namespace FinanceTracker
{
    partial class InputBudgetAlertForm
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
            InputBudgetLabel = new Label();
            BudgetInputButton = new Button();
            BudgetInputTextBox = new TextBox();
            SuspendLayout();
            // 
            // InputBudgetLabel
            // 
            InputBudgetLabel.AutoSize = true;
            InputBudgetLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputBudgetLabel.Location = new Point(89, 9);
            InputBudgetLabel.Name = "InputBudgetLabel";
            InputBudgetLabel.Size = new Size(250, 32);
            InputBudgetLabel.TabIndex = 0;
            InputBudgetLabel.Text = "Please Input A Budget";
            // 
            // BudgetInputButton
            // 
            BudgetInputButton.Location = new Point(354, 141);
            BudgetInputButton.Name = "BudgetInputButton";
            BudgetInputButton.Size = new Size(88, 32);
            BudgetInputButton.TabIndex = 1;
            BudgetInputButton.Text = "Send";
            BudgetInputButton.UseVisualStyleBackColor = true;
            BudgetInputButton.Click += BudgetInputButton_Click;
            // 
            // BudgetInputTextBox
            // 
            BudgetInputTextBox.Location = new Point(89, 82);
            BudgetInputTextBox.Name = "BudgetInputTextBox";
            BudgetInputTextBox.Size = new Size(353, 23);
            BudgetInputTextBox.TabIndex = 2;
            BudgetInputTextBox.TextChanged += BudgetInputTextBox_TextChanged;
            // 
            // InputBudgetAlertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 231);
            Controls.Add(BudgetInputTextBox);
            Controls.Add(BudgetInputButton);
            Controls.Add(InputBudgetLabel);
            Name = "InputBudgetAlertForm";
            Text = "InputBudgetAlertForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InputBudgetLabel;
        private Button BudgetInputButton;
        private TextBox BudgetInputTextBox;
    }
}