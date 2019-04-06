using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Database_Management_System.User_Controls;

namespace Bank_Database_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Banks_UC bank_UC = new Banks_UC();
        Branches_UC branches_UC = new Branches_UC();
        Accounts_UC accounts_UC = new Accounts_UC();
        Customers_UC customers_UC = new Customers_UC();
        Loans_UC loans_UC = new Loans_UC();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(bank_UC);
            bank_UC.Dock = DockStyle.Fill;
            bank_UC.BringToFront();
            bank_UC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(branches_UC);
            branches_UC.Dock = DockStyle.Fill;
            branches_UC.BringToFront();
            branches_UC.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(accounts_UC);
            accounts_UC.Dock = DockStyle.Fill;
            accounts_UC.BringToFront();
            accounts_UC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(customers_UC);
            customers_UC.Dock = DockStyle.Fill;
            customers_UC.BringToFront();
            customers_UC.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(loans_UC);
            loans_UC.Dock = DockStyle.Fill;
            loans_UC.BringToFront();
            loans_UC.Show();
        }
    }
}
