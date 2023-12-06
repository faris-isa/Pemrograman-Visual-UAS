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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace UAS
{
    public partial class Providers : Form
    {
        public static Providers instance;
        public Label labelUsername, labelProvider;
        public Boolean editable = false;

        private void Providers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uas_projectDataSet.providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.uas_projectDataSet.providers);
            providersDataGridView.ReadOnly = true;
            buttonColorChangeonClick(providersButton, vehicleTypeButton, vehiclesButton, usersButton);

        }

        public Providers()
        {
            InitializeComponent();
            instance = this;
            labelUsername = labelUsernameDashboard;
            labelProvider = labelProviderDashboard;
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
            VehicleTypes types = new VehicleTypes();
            VehicleTypes.instance.labelUsername.Text = this.labelUsername.Text;
            VehicleTypes.instance.labelProvider.Text = this.labelProvider.Text;
            types.Show();
            this.Hide();
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

        private void usersClick(object sender, EventArgs e)
        {
            buttonColorChangeonClick(usersButton, vehicleTypeButton, vehiclesButton, providersButton);
        }

        private void RefreshData()
        {
            try
            {
                // Reload the data into the DataGridView
                this.providersTableAdapter.Fill(this.uas_projectDataSet.providers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing data: " + ex.Message, "Error");
            }
        }

        private void ClearTextBoxes()
        {
            txtName.Text = "";
        }

        private void saveButton_onClick(object sender, EventArgs e)
        {

            if (editable)
            {
                try
                {
                    string udpatedId = txtId.Text.Trim();
                    string updatedName = txtName.Text.Trim();

                    using (SqlConnection conn = new SqlConnection(Settings.Default.uas_projectConnectionString))
                    {
                        conn.Open();

                        string query = "UPDATE providers " +
                            "SET name = @updatedName, updated_at = GETDATE() " +
                            " WHERE id = @updatedId;";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@updatedName", updatedName);
                            command.Parameters.AddWithValue("@updatedId", udpatedId);

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

            }
            else
            {
                try
                {
                    string name = txtName.Text.Trim();

                    using (SqlConnection conn = new SqlConnection(Settings.Default.uas_projectConnectionString))
                    {
                        conn.Open();

                        string query = "INSERT INTO providers" +
                                        "(id, name, created_at, updated_at, deleted_at)" +
                                        "VALUES " +
                                        "( NEWID(), @name, GETDATE(), GETDATE(), NULL )";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
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

        //nameDataGridViewTextBoxColumn

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (providersDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row data
                    DataGridViewRow selectedRow = providersDataGridView.SelectedRows[0];
                    string id = selectedRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name
                    string name = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name

                    // Populate the form with the selected data
                    txtId.Text = id;
                    txtName.Text = name;

                    // Disable the "New" fields, enable the "Edit" fields
                    labelId.Visible = true;
                    txtId.Visible = true;
                    txtName.Enabled = false;
                    //btnSaveChanges.Enabled = true;

                    saveButton.Text = "Update !";
                    editable = true;

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
                if (providersDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row data
                    DataGridViewRow selectedRow = providersDataGridView.SelectedRows[0];
                    string id = selectedRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString(); // Replace with the actual column name

                    // Confirm with the user before deleting
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Perform the deletion
                        using (SqlConnection conn = new SqlConnection(Settings.Default.uas_projectConnectionString))
                        {
                            conn.Open();

                            string query = "DELETE FROM providers WHERE id = @deletedId";

                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@deletedId", id);

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
