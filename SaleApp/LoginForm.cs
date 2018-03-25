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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (SalesEntities dbContext = new SalesEntities())
            {
                var login = from emp in dbContext.Employees
                            where emp.UserName == UserNameTextBox.Text && emp.Password == PasswordTextBox.Text
                            select emp;

                if (!login.Any())
                {
                    MessageBox.Show("User Name or Password invalid!", "Sales Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // SHOW THE WELCOME WINDOW
                    Hide();
                    Manager.employee = login.First();
                    Manager.welcomeForm = new WelcomeForm();
                    Manager.welcomeForm.ShowDialog();
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (SalesEntities dbContext = new SalesEntities())
            {
                dbContext.Employees.Add(
                    new Employee
                    {
                        UserName = UserNameTextBox.Text,
                        Password = PasswordTextBox.Text
                    }
                );

                dbContext.SaveChanges();
                MessageBox.Show(string.Format("User {0} successfully registered!", UserNameTextBox.Text), "Sales Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
