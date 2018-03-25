namespace SaleApp
{
    partial class WelcomeForm
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.QuestionsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(10, 11);
            this.QuestionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(150, 13);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "What do you want to do?";
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(12, 40);
            this.AddAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(139, 24);
            this.AddAccountButton.TabIndex = 1;
            this.AddAccountButton.Text = "Add an Account";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(12, 69);
            this.AddOrderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(139, 24);
            this.AddOrderButton.TabIndex = 2;
            this.AddOrderButton.Text = "Add an Order";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Location = new System.Drawing.Point(12, 98);
            this.DeleteOrderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(139, 24);
            this.DeleteOrderButton.TabIndex = 3;
            this.DeleteOrderButton.Text = "Delete an Order";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // QuestionsButton
            // 
            this.QuestionsButton.Location = new System.Drawing.Point(12, 128);
            this.QuestionsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuestionsButton.Name = "QuestionsButton";
            this.QuestionsButton.Size = new System.Drawing.Size(139, 24);
            this.QuestionsButton.TabIndex = 4;
            this.QuestionsButton.Text = "Questions";
            this.QuestionsButton.UseVisualStyleBackColor = true;
            this.QuestionsButton.Click += new System.EventHandler(this.QuestionsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(155, 81);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(139, 24);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 162);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.QuestionsButton);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.QuestionLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WelcomeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button QuestionsButton;
        private System.Windows.Forms.Button ExitButton;
    }
}