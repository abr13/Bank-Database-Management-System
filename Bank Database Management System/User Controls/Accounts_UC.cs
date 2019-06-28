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
    public partial class Accounts_UC : UserControl
    {
        public Accounts_UC()
        {
            InitializeComponent();
            accountDatagridview();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\BankDatabase.mdf\";Integrated Security=True");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("searchAccount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (SearchAccTextField.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@accno", SearchAccTextField.Text);

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
                                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AccNoTextField.Text != "" && TypeTextField.Text != "" && BalTextField.Text!="" && Br_idtextfield.Text!=""&& cust_idtextfield.Text!="")
            {
                using (SqlCommand cmd = new SqlCommand("addAccount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@accNo", AccNoTextField.Text);
                    cmd.Parameters.AddWithValue("@type", TypeTextField.Text);
                    cmd.Parameters.AddWithValue("@bal", BalTextField.Text);
                    cmd.Parameters.AddWithValue("@br_id", Br_idtextfield.Text);
                    cmd.Parameters.AddWithValue("@cid", cust_idtextfield.Text);

                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        StatusLabel.Text = "Successfully added";
                        StatusLabel.Show();
                        AccNoTextField.Text = "";
                        TypeTextField.Text = "";
                        BalTextField.Text = "";
                        cust_idtextfield.Text = "";
                        Br_idtextfield.Text = "";

                    }
                    catch (Exception x)
                    {
                        StatusLabel.Text = "Error!";
                        StatusLabel.Show();
                        MessageBox.Show("" + x);
                    }
                    con.Close();
                    accountDatagridview();
                }
            }
            else
            {
                MessageBox.Show("Values cannot be empty!");
            }
        }

        public void accountDatagridview()
        {
            using (SqlCommand cmd = new SqlCommand("viewAccount", con))
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
                        this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
        }

        private void Accounts_UC_MouseClick(object sender, MouseEventArgs e)
        {
            AccNoTextField.Text = "";
            TypeTextField.Text = "";
            BalTextField.Text = "";
            SearchAccTextField.Text = "";
            StatusLabel.Hide();

            accountDatagridview();
        }

    }
}
