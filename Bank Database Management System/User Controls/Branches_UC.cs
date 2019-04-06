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
    public partial class Branches_UC : UserControl
    {
        public Branches_UC()
        {
            InitializeComponent();
            branchDatagridview();
        }

         SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\BankDatabase.mdf\";Integrated Security=True");

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextField.Text != "" && BranchIDTextField.Text != "")
            {
                using (SqlCommand cmd = new SqlCommand("AddBranch", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@bid", BranchIDTextField.Text);
                    cmd.Parameters.AddWithValue("@address", AddressTextField.Text);
                    cmd.Parameters.AddWithValue("@name", NameTextField.Text);
                    cmd.Parameters.AddWithValue("@bankid", BidTextField.Text);

                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        StatusLabel.Text = "Successfully added";
                        StatusLabel.Show();
                        BranchIDTextField.Text = "";
                        NameTextField.Text = "";
                        AddressTextField.Text = "";
                    }
                    catch (Exception x)
                    {
                        StatusLabel.Text = "Error!";
                        StatusLabel.Show();
                        MessageBox.Show("" + x);
                    }
                    con.Close();
                    branchDatagridview();
                }
            }
            else
            {
                MessageBox.Show("Value is empty!");
            }

        }

        public void branchDatagridview()
        {
            using (SqlCommand cmd = new SqlCommand("viewBranch", con))
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
                        this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        //this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        //this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("searchBranch", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (SearchBranchIDTextField.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@bid", SearchBranchIDTextField.Text);

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
                                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                //this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                                //this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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

        private void Branches_UC_MouseClick(object sender, MouseEventArgs e)
        {
            BranchIDTextField.Text = "";
            AddressTextField.Text = "";
            NameTextField.Text = "";
            SearchBranchIDTextField.Text = "";
            StatusLabel.Hide();

            branchDatagridview();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("deleteBranch", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@bid", SearchBranchIDTextField.Text);

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
                branchDatagridview();
            }
        }
    }
}
