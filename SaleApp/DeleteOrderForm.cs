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
    public partial class DeleteOrderForm : Form
    {
        public DeleteOrderForm()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.welcomeForm.Show();
        }

        private void BrowseAllButton_Click(object sender, EventArgs e)
        {
            using (SalesEntities dbContext = new SalesEntities())
            {
                var orders = from o in dbContext.Orders
                             orderby o.OrderID
                             select new
                             {
                                 o.OrderID,
                                 o.Date,
                                 o.Product,
                                 o.UnitPrice,
                                 o.Quantity,
                                 o.TotalPrice,
                                 o.Customer.Name,
                                 o.Employee.UserName
                             };
                if (orders.Any())
                {
                    OrdersDataGrid.DataSource = orders.ToList();
                }
                else
                {
                    MessageBox.Show("No orders found in the databse!", "Sales Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FindOrderButton_Click(object sender, EventArgs e)
        {
            using (SalesEntities dbContext = new SalesEntities())
            {
                var orderId = int.Parse(OrderIdTextBox.Text);
                var order = from o in dbContext.Orders
                            where o.OrderID == orderId
                            select new
                            {
                                o.OrderID,
                                o.Date,
                                o.Product,
                                o.UnitPrice,
                                o.Quantity,
                                o.TotalPrice,
                                o.Customer.Name,
                                o.Employee.UserName
                            };

                if (!order.Any())
                {
                    MessageBox.Show(string.Format("Order {0} not found in the databse!", orderId), "Sales Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    OrdersDataGrid.DataSource = order.ToList();
                    MessageBox.Show(string.Format("Order {0} successfully found in the databse!", orderId), "Sales Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            using (SalesEntities dbContext = new SalesEntities())
            {
                var orderId = int.Parse(OrderIdTextBox.Text);
                var order = from o in dbContext.Orders
                            where o.OrderID == orderId
                            select o;
                dbContext.Orders.Remove(order.First());
                dbContext.SaveChanges();
                MessageBox.Show(string.Format("Order {0} successfully deleted!", OrderIdTextBox.Text), "Sales Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrdersDataGrid.DataSource = null;
                OrdersDataGrid.Rows.Clear();
            }
        }
    }
}
