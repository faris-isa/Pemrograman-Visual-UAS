using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS.Properties;

namespace UAS
{
    public partial class Login : Form
    {
        public static Login instance;
        public TextBox username;

        public Login()
        {
            InitializeComponent();
            instance = this;
            username = txtUsername;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    string username = txtUsername.Text.Trim();
                    string password = txtPassword.Text.Trim();

                    using (SqlConnection conn = new SqlConnection(Settings.Default.uas_projectConnectionString))
                    {
                        conn.Open();

                        string query = "SELECT u.*, p.name AS provider_name " +
                                       "FROM users u " +
                                       "LEFT JOIN providers p ON u.provider_id = p.id " +
                                       "WHERE u.username = @username AND u.password = @password";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            using (SqlDataAdapter sda = new SqlDataAdapter(command))
                            {
                                DataTable dta = new DataTable();
                                sda.Fill(dta);

                                if (dta.Rows.Count == 1)
                                {
                                    VehicleTypes homepage = new VehicleTypes();
                                    this.Hide();

                                    string providerId = dta.Rows[0]["provider_id"].ToString();

                                    // Check if providerId is null
                                    if (string.IsNullOrEmpty(providerId))
                                    {
                                        VehicleTypes.instance.labelProvider.Text = "admin";
                                    }
                                    else
                                    {
                                        // Set provider name
                                        string providerName = dta.Rows[0]["provider_name"].ToString();
                                        VehicleTypes.instance.labelProvider.Text = providerName;
                                    }

                                    VehicleTypes.instance.labelUsername.Text = username;
                                    homepage.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Wrong username/password, Try Again!", "Error");
                                }
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions appropriately (e.g., log the exception, show an error message)
                    MessageBox.Show("An error occurred: " + ex.Message, "Error");
                }
            }
        }


        private bool isValid()
        {
            if(txtUsername.Text.TrimStart() == string.Empty) {
                MessageBox.Show("Enter Valid Username !", "Error");
                return false;
            } else if (txtPassword.Text.TrimStart() == string.Empty) {
                MessageBox.Show("Enter Valid Password !", "Error");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
