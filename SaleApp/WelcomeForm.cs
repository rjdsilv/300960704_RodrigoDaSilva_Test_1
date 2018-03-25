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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddAccountForm addAccountForm = new AddAccountForm();
            addAccountForm.ShowDialog();
        }

        private void WelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.ShowDialog();
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            Hide();
            DeleteOrderForm deleteOrderForm = new DeleteOrderForm();
            deleteOrderForm.ShowDialog();
        }

        private void QuestionsButton_Click(object sender, EventArgs e)
        {
            Hide();
            JoiningTablesForm joiningTablesForm = new JoiningTablesForm();
            joiningTablesForm.ShowDialog();
        }
    }
}
