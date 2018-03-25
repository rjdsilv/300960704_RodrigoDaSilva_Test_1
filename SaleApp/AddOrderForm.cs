using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void customerIDTextBox_Leave(object sender, EventArgs e)
        {
            using (SalesEntities dbContext = new SalesEntities())
            {
                var customerId = int.Parse(customerIDTextBox.Text);
                var customer = from cust in dbContext.Customers
                               where cust.CustomerID == customerId
                               select cust;

                if (!customer.Any())
                {
                    MessageBox.Show(string.Format("Customer {0} does not exist in the databse!", customerIDTextBox.Text),
                        "Sales Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Manager.customer = customer.First();
                    nameTextBox.Text = Manager.customer.Name;
                }
            }
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            using (SalesEntities dbContext = new SalesEntities())
            {
                int quantity = int.Parse(quantityTextBox.Text);
                decimal unitPrice = decimal.Parse(unitPriceTextBox.Text);

                Order order = new Order
                {
                    CustomerID = Manager.customer.CustomerID,
                    Date = dateDateTimePicker.Value,
                    EmployeeID = Manager.employee.EmployeeID,
                    Product = productTextBox.Text,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    TotalPrice = quantity * unitPrice,
                };

                var totalPrice = unitPrice * quantity;
                dbContext.Orders.Add(order);
                dbContext.SaveChanges();
                orderIDTextBox.Text = order.OrderID.ToString();
                totalPriceTextBox.Text = totalPrice.ToString();
                MessageBox.Show(string.Format("Order {0} successfully registered!", orderIDTextBox.Text), "Sales Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddAnotherOrderButton_Click(object sender, EventArgs e)
        {
            customerIDTextBox.Text = "";
            nameTextBox.Text = "";
            orderIDTextBox.Text = "";
            productTextBox.Text = "";
            quantityTextBox.Text = "";
            unitPriceTextBox.Text = "";
            totalPriceTextBox.Text = "";
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.welcomeForm.Show();
        }
    }
}
