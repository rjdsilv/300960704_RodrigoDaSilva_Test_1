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
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.welcomeForm.Show();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            using (SalesEntities dbContext = new SalesEntities())
            {
                Customer cust = new Customer
                {
                    Name = nameTextBox.Text,
                    ShipAddress = shipAddressTextBox.Text,
                    ShipCity = shipCityTextBox.Text,
                    ShipCountry = shipCountryTextBox.Text
                };

                dbContext.Customers.Add(cust);

                dbContext.SaveChanges();
                customerIDTextBox.Text = cust.CustomerID.ToString();
                MessageBox.Show(string.Format("Customer {0} successfully registered!", nameTextBox.Text), "Sales Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddAnotherAccountButton_Click(object sender, EventArgs e)
        {
            customerIDTextBox.Text = "";
            nameTextBox.Text = "";
            shipAddressTextBox.Text = "";
            shipCityTextBox.Text = "";
            shipCountryTextBox.Text = "";
        }
    }
}
