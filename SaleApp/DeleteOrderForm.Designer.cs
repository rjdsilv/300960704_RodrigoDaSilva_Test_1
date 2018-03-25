namespace SaleApp
{
    partial class DeleteOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.DeleteOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderIdTextBox = new System.Windows.Forms.TextBox();
            this.OrderIdLabel = new System.Windows.Forms.Label();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.FindOrderButton = new System.Windows.Forms.Button();
            this.BrowseAllButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.OrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteOrderGroupBox
            // 
            this.DeleteOrderGroupBox.Controls.Add(this.OrderIdTextBox);
            this.DeleteOrderGroupBox.Controls.Add(this.OrderIdLabel);
            this.DeleteOrderGroupBox.Controls.Add(this.DeleteOrderButton);
            this.DeleteOrderGroupBox.Controls.Add(this.FindOrderButton);
            this.DeleteOrderGroupBox.Location = new System.Drawing.Point(186, 193);
            this.DeleteOrderGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteOrderGroupBox.Name = "DeleteOrderGroupBox";
            this.DeleteOrderGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.DeleteOrderGroupBox.Size = new System.Drawing.Size(282, 81);
            this.DeleteOrderGroupBox.TabIndex = 2;
            this.DeleteOrderGroupBox.TabStop = false;
            this.DeleteOrderGroupBox.Text = " Delete Order ";
            // 
            // OrderIdTextBox
            // 
            this.OrderIdTextBox.Location = new System.Drawing.Point(68, 23);
            this.OrderIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.Size = new System.Drawing.Size(210, 20);
            this.OrderIdTextBox.TabIndex = 3;
            // 
            // OrderIdLabel
            // 
            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.Location = new System.Drawing.Point(11, 25);
            this.OrderIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(53, 13);
            this.OrderIdLabel.TabIndex = 2;
            this.OrderIdLabel.Text = "Order ID: ";
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Location = new System.Drawing.Point(199, 58);
            this.DeleteOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(79, 19);
            this.DeleteOrderButton.TabIndex = 1;
            this.DeleteOrderButton.Text = "Delete Order";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // FindOrderButton
            // 
            this.FindOrderButton.Location = new System.Drawing.Point(4, 58);
            this.FindOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.FindOrderButton.Name = "FindOrderButton";
            this.FindOrderButton.Size = new System.Drawing.Size(66, 19);
            this.FindOrderButton.TabIndex = 0;
            this.FindOrderButton.Text = "Find Order";
            this.FindOrderButton.UseVisualStyleBackColor = true;
            this.FindOrderButton.Click += new System.EventHandler(this.FindOrderButton_Click);
            // 
            // BrowseAllButton
            // 
            this.BrowseAllButton.Location = new System.Drawing.Point(133, 310);
            this.BrowseAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseAllButton.Name = "BrowseAllButton";
            this.BrowseAllButton.Size = new System.Drawing.Size(93, 19);
            this.BrowseAllButton.TabIndex = 3;
            this.BrowseAllButton.Text = "Browse All";
            this.BrowseAllButton.UseVisualStyleBackColor = true;
            this.BrowseAllButton.Click += new System.EventHandler(this.BrowseAllButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(412, 310);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(2);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(93, 19);
            this.FinishButton.TabIndex = 4;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // OrdersDataGrid
            // 
            this.OrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGrid.Location = new System.Drawing.Point(9, 10);
            this.OrdersDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.RowTemplate.Height = 24;
            this.OrdersDataGrid.Size = new System.Drawing.Size(634, 179);
            this.OrdersDataGrid.TabIndex = 5;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(SaleApp.Order);
            // 
            // DeleteOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 336);
            this.Controls.Add(this.OrdersDataGrid);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.BrowseAllButton);
            this.Controls.Add(this.DeleteOrderGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeleteOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Order Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteOrderForm_FormClosed);
            this.DeleteOrderGroupBox.ResumeLayout(false);
            this.DeleteOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.GroupBox DeleteOrderGroupBox;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button FindOrderButton;
        private System.Windows.Forms.Label OrderIdLabel;
        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.Windows.Forms.Button BrowseAllButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.DataGridView OrdersDataGrid;
    }
}