namespace SaleApp
{
    partial class AddOrderForm
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label productLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label totalPriceLabel;
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.AddAnotherOrderButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            customerIDLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            productLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            totalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(12, 9);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(89, 17);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 94);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 17);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(12, 65);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(66, 17);
            orderIDLabel.TabIndex = 7;
            orderIDLabel.Text = "Order ID:";
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new System.Drawing.Point(12, 123);
            productLabel.Name = "productLabel";
            productLabel.Size = new System.Drawing.Size(61, 17);
            productLabel.TabIndex = 9;
            productLabel.Text = "Product:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(12, 151);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(65, 17);
            quantityLabel.TabIndex = 11;
            quantityLabel.Text = "Quantity:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(12, 179);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(73, 17);
            unitPriceLabel.TabIndex = 15;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 37);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 19;
            nameLabel.Text = "Name:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(109, 6);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(302, 22);
            this.customerIDTextBox.TabIndex = 2;
            this.customerIDTextBox.Leave += new System.EventHandler(this.customerIDTextBox_Leave);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(109, 90);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(302, 22);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Enabled = false;
            this.orderIDTextBox.Location = new System.Drawing.Point(109, 62);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(302, 22);
            this.orderIDTextBox.TabIndex = 8;
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(109, 120);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(302, 22);
            this.productTextBox.TabIndex = 10;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(109, 148);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(302, 22);
            this.quantityTextBox.TabIndex = 12;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(109, 176);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(302, 22);
            this.unitPriceTextBox.TabIndex = 16;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(109, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(302, 22);
            this.nameTextBox.TabIndex = 20;
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Location = new System.Drawing.Point(15, 249);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(96, 23);
            this.PlaceOrderButton.TabIndex = 21;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // AddAnotherOrderButton
            // 
            this.AddAnotherOrderButton.Location = new System.Drawing.Point(140, 249);
            this.AddAnotherOrderButton.Name = "AddAnotherOrderButton";
            this.AddAnotherOrderButton.Size = new System.Drawing.Size(142, 23);
            this.AddAnotherOrderButton.TabIndex = 22;
            this.AddAnotherOrderButton.Text = "Add Another Order";
            this.AddAnotherOrderButton.UseVisualStyleBackColor = true;
            this.AddAnotherOrderButton.Click += new System.EventHandler(this.AddAnotherOrderButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(315, 249);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(96, 23);
            this.FinishButton.TabIndex = 23;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new System.Drawing.Point(12, 207);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new System.Drawing.Size(80, 17);
            totalPriceLabel.TabIndex = 24;
            totalPriceLabel.Text = "Total Price:";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Enabled = false;
            this.totalPriceTextBox.Location = new System.Drawing.Point(109, 204);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(302, 22);
            this.totalPriceTextBox.TabIndex = 25;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 287);
            this.Controls.Add(totalPriceLabel);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.AddAnotherOrderButton);
            this.Controls.Add(this.PlaceOrderButton);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(productLabel);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Name = "AddOrderForm";
            this.Text = "AddOrderFormcs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddOrderForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Button AddAnotherOrderButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.TextBox totalPriceTextBox;
    }
}