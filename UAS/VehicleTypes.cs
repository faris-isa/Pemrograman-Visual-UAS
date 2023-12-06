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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using UAS.Properties;

namespace UAS
{
    public partial class VehicleTypes : Form
    {
        public static VehicleTypes instance;
        public Label labelUsername, labelProvider;
        public Boolean editable = false;
        public VehicleTypes()
        {
            InitializeComponent();
            instance = this;
            labelUsername = labelUsernameDashboard;
            labelProvider = labelProviderDashboard;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonColorChangeonClick(Button btn1, Button btn2, Button btn3, Button btn4 )
        {
            btn1.BackColor = Color.FromArgb(155, 190, 200);
            btn2.BackColor = Color.FromArgb(22, 72, 99);
            btn3.BackColor = Color.FromArgb(22, 72, 99);
            btn4.BackColor = Color.FromArgb(22, 72, 99);
        }

        private void vehicleTypesClick(object sender, EventArgs e)
        {
            buttonColorChangeonClick(vehicleTypeButton, vehiclesButton, providersButton, usersButton);
            this.master_vehicle_typesTableAdapter.Fill(this.uas_projectDataSet.master_vehicle_types);
        }

        private void vehiclesClick(object sender, EventArgs e)
        {
            buttonColorChangeonClick(vehiclesButton, vehicleTypeButton, providersButton, usersButton);
            Vehicles vehicle = new Vehicles();
            Vehicles.instance.labelUsername.Text = this.labelUsername.Text;
            Vehicles.instance.labelProvider.Text = this.labelProvider.Text;
            vehicle.Show();
            this.Hide();
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
            vehicleTypePanel.Hide();
        }
        private void logoutButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void HomepageLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uas_projectDataSet.master_vehicle_types' table. You can move, or remove it, as needed.
            this.master_vehicle_typesTableAdapter.Fill(this.uas_projectDataSet.master_vehicle_types);
            master_vehicle_typesDataGridView.ReadOnly = true;
            buttonColorChangeonClick(vehicleTypeButton, vehiclesButton, providersButton, usersButton);
            vehicleTypePanel.Show();
        }

        private void RefreshData()
        {
            try
            {
                // Reload the data into the DataGridView
                this.master_vehicle_typesTableAdapter.Fill(this.uas_projectDataSet.master_vehicle_types);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing data: " + ex.Message, "Error");
            }
        }


        private void ClearTextBoxes()
        {
            txtCode.Text = "";
            txtName.Text = "";
        }

        private void saveVehicleType(object sender, EventArgs e)
        {

            if(editable)
            {
                try
                {
                    string udpatedId = txtId.Text.Trim();
                    string updatedCode = txtCode.Text.Trim();
                    string updatedName = txtName.Text.Trim();

                    using (SqlConnection conn = new SqlConnection(Settings.Default.uas_projectConnectionString))
                    {
                        conn.Open();

                        string query = "UPDATE master_vehicle_types " +
                            "SET code = @updatedCode, name = @updatedName, updated_at = GETDATE() "+
                            " WHERE id = @vehicleTypeId;";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@updatedCode", updatedCode);
                            command.Parameters.AddWithValue("@updatedName", updatedName);
                            command.Parameters.AddWithValue("@vehicleTypeId", udpatedId);

                            // Execute the UPDATE query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully!", "Success");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update record.", "Error");
                            }

                        }
                    }

                    ClearTextBoxes();
                    editable = false;
                    saveButton.Text = "Save !";
                    labelId.Visible = false;
                    txtId.Visible = false;
                    RefreshData();
                }
                catch (Exception ex)
                {
                    HandleError(ex, "An error occurred while saving the vehicle type.");
                }

            } else
            {
                try
                {
                    string code = txtCode.Text.Trim();
                    string name = txtName.Text.Trim();

                    using (SqlConnection conn = new SqlConnection(Settings.Default.uas_projectConnectionString))
                    {
                        conn.Open();

                        string query = "INSERT INTO master_vehicle_types" +
                                        "(id, code, name, created_at, updated_at, deleted_at)" +
                                        "VALUES " +
                                        "( NEWID(), @code, @name, GETDATE(), GETDATE(), NULL )";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@code", code);
                            command.Parameters.AddWithValue("@name", name);

                            // Execute the INSERT query
                            int rowsAffected = command.ExecuteNonQuery();

                            ShowInsertResultMessage(rowsAffected);
                        }
                    }

                    ClearTextBoxes();
                    RefreshData();
                }
                catch (Exception ex)
                {
                    HandleError(ex, "An error occurred while saving the vehicle type.");
                }
            }
        }
        private void ShowInsertResultMessage(int rowsAffected)
        {
            if (rowsAffected > 0)
            {
                MessageBox.Show("Record inserted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to insert record.", "Error");
            }
        }

        private void HandleError(Exception ex, string errorMessage)
        {
            // Log the error for debugging purposes
            // LogError(ex);

            MessageBox.Show(errorMessage + "\nDetails: " + ex.Message, "Error");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (master_vehicle_typesDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row data
                    DataGridViewRow selectedRow = master_vehicle_typesDataGridView.SelectedRows[0];
                    string id = selectedRow.Cells["idGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name
                    string code = selectedRow.Cells["codeGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name
                    string name = selectedRow.Cells["nameGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name

                    // Populate the form with the selected data
                    txtId.Text = id;
                    txtCode.Text = code;
                    txtName.Text = name;

                    // Disable the "New" fields, enable the "Edit" fields
                    labelId.Visible = true;
                    txtId.Visible = true;
                    txtCode.Enabled = false;
                    txtName.Enabled = false;
                    //btnSaveChanges.Enabled = true;

                    saveButton.Text = "Update !";
                    editable = true;

                    txtCode.Enabled = true;
                    txtName.Enabled = true;
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (master_vehicle_typesDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row data
                    DataGridViewRow selectedRow = master_vehicle_typesDataGridView.SelectedRows[0];
                    string id = selectedRow.Cells["idGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name

                    // Confirm with the user before deleting
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Perform the deletion
                        using (SqlConnection conn = new SqlConnection(Settings.Default.uas_projectConnectionString))
                        {
                            conn.Open();

                            string query = "DELETE FROM master_vehicle_types WHERE id = @vehicleTypeId";

                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@vehicleTypeId", id);

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
    }

    
}
