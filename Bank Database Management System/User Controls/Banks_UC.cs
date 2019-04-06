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
    public partial class Banks_UC : UserControl
    {
        public Banks_UC()
        {
            InitializeComponent();
            bankDatagridview();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\BankDatabase.mdf\";Integrated Security=True");

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IDTextField.Text != "" && NameTextField.Text != "")
            {
                using (SqlCommand cmd = new SqlCommand("addBank", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", IDTextField.Text);
                    cmd.Parameters.AddWithValue("@name", NameTextField.Text);
                    cmd.Parameters.AddWithValue("@address", AddressTextField.Text);

                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        StatusLabel.Text = "Successfully added";
                        StatusLabel.Show();
                        IDTextField.Text = "";
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
                    bankDatagridview();
                }
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("searchBank", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (SearchIDTextField.Text != "")
                    {                        
                        cmd.Parameters.AddWithValue("@id", SearchIDTextField.Text);

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

        public void bankDatagridview()
        {
            using (SqlCommand cmd = new SqlCommand("viewBank", con))
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
                    }
                }
            }            
        }

        private void Banks_UC_MouseClick(object sender, MouseEventArgs e)
        {
            IDTextField.Text = "";
            NameTextField.Text = "";
            AddressTextField.Text = "";
            SearchIDTextField.Text = "";
            StatusLabel.Hide();

            bankDatagridview();

        }

        private void Banks_UC_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
