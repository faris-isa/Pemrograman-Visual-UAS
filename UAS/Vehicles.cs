using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UAS.Properties;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace UAS
{
    public partial class Vehicles : Form
    {
        public static Vehicles instance;
        public System.Windows.Forms.Label labelUsername, labelProvider;
        public Vehicles()
        {
            InitializeComponent();
            instance = this;
            labelUsername = labelUsernameDashboard;
            labelProvider = labelProviderDashboard;
        }

        public void RefreshData()
        {
            try
            {
                // Reload the data into the DataGridView
                this.vehiclesTableAdapter.Fill(this.uas_projectDataSet.vehicles);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing data: " + ex.Message, "Error");
            }
        }

        private void VehicleLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uas_projectDataSet.vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.uas_projectDataSet.vehicles);
            // TODO: This line of code loads data into the 'uas_projectDataSet.master_vehicle_types' table. You can move, or remove it, as needed.
            //this.master_vehicle_typesTableAdapter.Fill(this.uas_projectDataSet.master_vehicle_types);
            //master_vehicle_typesDataGridView.ReadOnly = true;
            buttonColorChangeonClick(vehiclesButton, vehicleTypeButton, providersButton, usersButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonColorChangeonClick(Button btn1, Button btn2, Button btn3, Button btn4)
        {
            btn1.BackColor = Color.FromArgb(155, 190, 200);
            btn2.BackColor = Color.FromArgb(22, 72, 99);
            btn3.BackColor = Color.FromArgb(22, 72, 99);
            btn4.BackColor = Color.FromArgb(22, 72, 99);
        }

        private void vehicleTypesClick(object sender, EventArgs e)
        {
            buttonColorChangeonClick(vehicleTypeButton, vehiclesButton, providersButton, usersButton);
            VehicleTypes types= new VehicleTypes();
            VehicleTypes.instance.labelUsername.Text = this.labelUsername.Text;
            VehicleTypes.instance.labelProvider.Text = this.labelProvider.Text;
            types.Show();
        }

        private void providersClick(object sender, EventArgs e)
        {
            buttonColorChangeonClick(providersButton, vehicleTypeButton, vehiclesButton, usersButton);
            Providers provider = new Providers();
            Providers.instance.labelUsername.Text = this.labelUsername.Text;
            Providers.instance.labelProvider.Text = this.labelProvider.Text;
            provider.Show();
            this.Hide();

        }

        private void usersClick(object sender, EventArgs e)
        {
            buttonColorChangeonClick(usersButton, vehicleTypeButton, vehiclesButton, providersButton);
            //vehicleTypePanel.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehicleDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row data
                    DataGridViewRow selectedRow = vehicleDataGridView.SelectedRows[0];
                    string vin = selectedRow.Cells["vinDataGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name

                    // Confirm with the user before deleting
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Perform the deletion
                        using (SqlConnection conn = new SqlConnection(Settings.Default.uas_projectConnectionString))
                        {
                            conn.Open();

                            string query = "DELETE FROM providers WHERE id = @deletedVin";

                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@deletedVin", vin);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record deleted successfully!", "Success");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to delete record.", "Error");
                                }
                            }
                        }

                        // Refresh the data after deletion
                        RefreshData();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehicleDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row data
                    DataGridViewRow selectedRow = vehicleDataGridView.SelectedRows[0];
                    string vin = selectedRow.Cells["vinDataGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name
                    string code = selectedRow.Cells["codebusDataGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name
                    string stnk = selectedRow.Cells["stnkexpiredDataGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name
                    string bpkb = selectedRow.Cells["bpkbexpiredDataGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name
                    string type_id = selectedRow.Cells["typeidDataGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name
                    string provider = selectedRow.Cells["provideridDataGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name

                    //txtVin.Text = vin;
                    //txtCode.Text = code;
                    //txtStnk.Text = stnk;
                    //txtBpkb.Text = bpkb;
                    //txtVehicleType.Text = vehicle_type;
                    //txtProvider.Text = provider;

                    VehicleInput vehicle_input = new VehicleInput();
                    vehicle_input.saveButtonText = "Update !";
                    vehicle_input.editable = true;
                    vehicle_input.setForm(vin, code, stnk, bpkb, type_id, provider);
                    vehicle_input.Show();
                }
                else
                {
                    MessageBox.Show("Please select a record to edit.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            VehicleInput vehicle_input = new VehicleInput();
            vehicle_input.saveButtonText = "Save !";
            vehicle_input.Show();
        }

        private void logoutButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
