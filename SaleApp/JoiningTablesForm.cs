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
    public partial class JoiningTablesForm : Form
    {
        public JoiningTablesForm()
        {
            InitializeComponent();
        }

        private void QuestionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SalesEntities dbContext = new SalesEntities())
            {
                ComboBox cb = sender as ComboBox;
                ResultsDataGridView.DataSource = null;
                ResultsDataGridView.Rows.Clear();

                if (cb.SelectedIndex == 0)
                {
                    var users = from emp in dbContext.Employees
                                join ord in dbContext.Orders on emp.EmployeeID equals ord.EmployeeID
                                where ord.Date >= DateTime.Today
                                select new
                                {
                                    emp.EmployeeID,
                                    emp.UserName,
                                    ord.OrderID,
                                    ord.Date,
                                    ord.Product,
                                    ord.Quantity,
                                    ord.UnitPrice,
                                    ord.TotalPrice,
                                    ord.Customer.Name
                                };
                    ResultsDataGridView.DataSource = users.ToList();
                }
                else
                {
                    var users = from emp in dbContext.Employees
                                join ord in dbContext.Orders on emp.EmployeeID equals ord.EmployeeID
                                join acc in dbContext.Customers on ord.CustomerID equals acc.CustomerID
                                where acc.ShipCountry == "Canada"
                                select new
                                {
                                    emp.EmployeeID,
                                    emp.UserName,
                                    ord.OrderID,
                                    ord.Date,
                                    ord.Product,
                                    ord.Quantity,
                                    ord.UnitPrice,
                                    ord.TotalPrice,
                                    ord.Customer.Name,
                                    ord.Customer.ShipCountry
                                };
                    ResultsDataGridView.DataSource = users.ToList();
                }
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JoiningTablesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.welcomeForm.Show();
        }
    }
}
