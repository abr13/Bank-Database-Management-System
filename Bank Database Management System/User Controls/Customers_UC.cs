using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank_Database_Management_System.User_Controls
{
    public partial class Customers_UC : UserControl
    {
        public Customers_UC()
        {
            InitializeComponent();
            customerDatagridview();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\BankDatabase.mdf\";Integrated Security=True");

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CustIDTextField.Text != "" && CustNameTextField.Text != "" && AddressTextField.Text!="")
            {
                using (SqlCommand cmd = new SqlCommand("addCust", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@cid", CustIDTextField.Text);
                    cmd.Parameters.AddWithValue("@name", CustNameTextField.Text);
                    cmd.Parameters.AddWithValue("@phone", PhoneTextField.Text);
                    cmd.Parameters.AddWithValue("@address", AddressTextField.Text);

                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        StatusLabel.Text = "Successfully Added";
                        StatusLabel.Show();
                        CustIDTextField.Text = "";
                        CustNameTextField.Text = "";
                        PhoneTextField.Text = "";
                        AddressTextField.Text = "";
                    }
                    catch (Exception x)
                    {
                        StatusLabel.Text = "Error!";
                        StatusLabel.Show();
                        MessageBox.Show("" + x);
                    }
                    con.Close();
                    customerDatagridview();
                }
            }
            else
            {
                MessageBox.Show("Value is empty!");
            }
        }
        public void customerDatagridview()
        {
            using (SqlCommand cmd = new SqlCommand("viewCustomers", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    using (DataSet ds = new DataSet())
                    {
                        da.Fill(ds);

                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("" + er);
                        }
                        con.Close();

                        dataGridView1.DataSource = ds.Tables[0];

                        this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        //this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        //this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
        }

        private void Customers_UC_MouseClick(object sender, MouseEventArgs e)
        {
            StatusLabel.Hide();
            CustIDTextField.Text = "";
            CustNameTextField.Text = "";
            PhoneTextField.Text = "";
            AddressTextField.Text = "";
            SearchCustIDTextField.Text = "";

            customerDatagridview();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("deleteCustomer", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cid", SearchCustIDTextField.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception x)
                {
                    StatusLabel.Text = "Error!";
                    StatusLabel.Show();
                    MessageBox.Show("" + x);
                }
                con.Close();
                customerDatagridview();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("searchCustomer", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (SearchCustIDTextField.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@cid", SearchCustIDTextField.Text);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                da.Fill(ds);

                                con.Open();
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception er)
                                {
                                    MessageBox.Show("" + er);
                                }
                                con.Close();

                                dataGridView1.DataSource = ds.Tables[0];

                                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                                //this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                //this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Value is empty!");
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("" + er);
            }
        }

    }
}
