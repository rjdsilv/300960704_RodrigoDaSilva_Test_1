namespace SaleApp
{
    partial class JoiningTablesForm
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
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.QuestionsComboBox = new System.Windows.Forms.ComboBox();
            this.FinishButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.Size = new System.Drawing.Size(776, 304);
            this.ResultsDataGridView.TabIndex = 0;
            // 
            // QuestionsComboBox
            // 
            this.QuestionsComboBox.FormattingEnabled = true;
            this.QuestionsComboBox.Items.AddRange(new object[] {
            "List of users which added and order today",
            "List of users which deal with Canadian accounts"});
            this.QuestionsComboBox.Location = new System.Drawing.Point(204, 322);
            this.QuestionsComboBox.Name = "QuestionsComboBox";
            this.QuestionsComboBox.Size = new System.Drawing.Size(399, 21);
            this.QuestionsComboBox.TabIndex = 1;
            this.QuestionsComboBox.SelectedIndexChanged += new System.EventHandler(this.QuestionsComboBox_SelectedIndexChanged);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(359, 355);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 2;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // JoiningTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.QuestionsComboBox);
            this.Controls.Add(this.ResultsDataGridView);
            this.Name = "JoiningTablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JoiningTablesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JoiningTablesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.ComboBox QuestionsComboBox;
        private System.Windows.Forms.Button FinishButton;
    }
}