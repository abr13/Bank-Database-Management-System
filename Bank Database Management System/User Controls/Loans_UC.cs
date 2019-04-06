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
    public partial class Loans_UC : UserControl
    {
        public Loans_UC()
        {
            InitializeComponent();
            loanDatagridview();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\BankDatabase.mdf\";Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (LoanNoTextField.Text != "" && AmtTextField.Text != "" && BranchNoTextfield.Text!=""&&TypeTextField.Text!=""&&CustIdTextField.Text!="")
            {
                using (SqlCommand cmd = new SqlCommand("addLoan", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@lid", LoanNoTextField.Text);
                    cmd.Parameters.AddWithValue("@amt", AmtTextField.Text);
                    cmd.Parameters.AddWithValue("@bid", BranchNoTextfield.Text);
                    cmd.Parameters.AddWithValue("@type", TypeTextField.Text); 
                    cmd.Parameters.AddWithValue("@cid", CustIdTextField.Text);

                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        StatusLabel.Text = "Successfully added";
                        StatusLabel.Show();
                        LoanNoTextField.Text = "";
                        AmtTextField.Text = "";
                        BranchNoTextfield.Text = "";
                        TypeTextField.Text = "";
                        CustIdTextField.Text = "";
                    }
                    catch (Exception x)
                    {
                        StatusLabel.Text = "Error!";
                        StatusLabel.Show();
                        MessageBox.Show("" + x);
                    }
                    con.Close();
                    loanDatagridview();
                }
            }

        }

        public void loanDatagridview()
        {
            using (SqlCommand cmd = new SqlCommand("viewLoan", con))
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

                        this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        //this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        //this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
        }


        private void Loans_UC_MouseClick(object sender, MouseEventArgs e)
        {
            StatusLabel.Hide();
            LoanNoTextField.Text = "";
            AmtTextField.Text = "";
            BranchNoTextfield.Text = "";
            TypeTextField.Text = "";
            CustIdTextField.Text = "";

            loanDatagridview();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("searchLoan", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (SearchLoanTextField.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@lid", SearchLoanTextField.Text);

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

                                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                //this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                //this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
