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

namespace UAS
{
    public partial class VehicleInput : Form
    {
        public static VehicleInput instance;
        public string saveButtonText = "Save !";
        public Boolean editable = false;
        public VehicleInput()
        {
            InitializeComponent();
            saveButton.Text = saveButtonText;
        }

        private void VehicleInput_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uas_projectDataSet.master_vehicle_types' table. You can move, or remove it, as needed.
            this.master_vehicle_typesTableAdapter.Fill(this.uas_projectDataSet.master_vehicle_types);
            // TODO: This line of code loads data into the 'uas_projectDataSet.providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.uas_projectDataSet.providers);

        }

        public void setForm(string vin, string code, string stnk, string bpkb, string vehicle_type, string provider)
        {
            txtVin.Text = vin;
            txtVin.ReadOnly = true;
            txtCode.Text = code;
            txtStnk.Text = stnk;
            txtBpkb.Text = bpkb;
            txtVehicleType.Text = vehicle_type;
            txtProvider.Text = provider;
        }

        private void ClearTextBoxes()
        {
            txtVin.Text = "";
            txtVin.ReadOnly = false;
            txtCode.Text = "";
            txtStnk.Text = "";
            txtBpkb.Text = "";
            txtVehicleType.Text = "";
            txtProvider.Text = "";
        }

        private void saveButton_onClick(object sender, EventArgs e)
        {

            if (editable)
            {
                try
                {
                    string updatedVin = txtVin.Text.Trim();
                    string updatedCode = txtCode.Text.Trim();
                    string updatedStnk = txtStnk.Text.Trim();
                    string updatedBpkb = txtBpkb.Text.Trim();
                    // Get vehicle type ID
                    Guid updatedVehicleType = GetGuidFromDataRowView(txtVehicleType.SelectedValue, "id", "Invalid vehicle type value");

                    // Get provider ID
                    Guid updatedProvider = GetGuidFromDataRowView(txtProvider.SelectedValue, "id", "Invalid provider value");

                    using (SqlConnection conn = new SqlConnection(Settings.Default.uas_projectConnectionString))
                    {
                        conn.Open();

                        //"(vin, code_bus, stnk_expired, bpbk_expired, type_id, provider_id, created_at, updated_at, deleted_at)" +

                        string query = "UPDATE providers " +
                            "SET code_bus = @updatedCode, stnk_expired = @updatedStnk, bpkb_expired = @updatedBpkb, type_id = @updatedVehicleType, " + 
                            "provider_id = @updatedProvider, updated_at = GETDATE() " +
                            " WHERE vin = @updatedVin;";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@updatedVin", updatedVin);
                            command.Parameters.AddWithValue("@updatedCode", updatedCode);
                            command.Parameters.AddWithValue("@updatedStnk", updatedStnk);
                            command.Parameters.AddWithValue("@updatedBpkb", updatedBpkb);
                            command.Parameters.AddWithValue("@updatedVehicleType", updatedVehicleType);
                            command.Parameters.AddWithValue("@updatedProvider", updatedProvider);

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
                    Vehicles vhc = new Vehicles();
                    vhc.RefreshData();
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
                    string vin = txtVin.Text.Trim();
                    string code = txtCode.Text.Trim();
                    string stnk = txtStnk.Text.Trim();
                    string bpkb = txtBpkb.Text.Trim();

                    // Get vehicle type ID
                    Guid vehicleTypeId = GetGuidFromDataRowView(txtVehicleType.SelectedValue, "id", "Invalid vehicle type value");

                    // Get provider ID
                    Guid providerId = GetGuidFromDataRowView(txtProvider.SelectedValue, "id", "Invalid provider value");

                    using (SqlConnection conn = new SqlConnection(Settings.Default.uas_projectConnectionString))
                    {
                        conn.Open();

                        string query = "INSERT INTO vehicles" +
                                        "(vin, code_bus, stnk_expired, bpkb_expired, type_id, provider_id, created_at, updated_at, deleted_at)" +
                                        "VALUES " +
                                        "( @vin, @code_bus, @stnk_exp, @bpkb_exp, @type_id, @provider_id, GETDATE(), GETDATE(), NULL )";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@vin", vin);
                            command.Parameters.AddWithValue("@code_bus", code);
                            command.Parameters.AddWithValue("@stnk_exp", stnk);
                            command.Parameters.AddWithValue("@bpkb_exp", bpkb);
                            command.Parameters.AddWithValue("@type_id", vehicleTypeId);
                            command.Parameters.AddWithValue("@provider_id", providerId);

                            // Execute the INSERT query
                            int rowsAffected = command.ExecuteNonQuery();

                            ShowInsertResultMessage(rowsAffected);
                        }
                    }

                    ClearTextBoxes();
                    Vehicles vhc = new Vehicles();
                    vhc.RefreshData();
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

        private Guid GetGuidFromDataRowView(object selectedValue, string columnName, string errorMessage)
        {
            if (selectedValue != null && selectedValue != DBNull.Value)
            {
                string columnValue = ((DataRowView)selectedValue)[columnName].ToString();
                if (Guid.TryParse(columnValue, out Guid result))
                {
                    return result;
                }
                else
                {
                    MessageBox.Show($"{errorMessage}: {columnValue}", "Error");
                    throw new ArgumentException(errorMessage);
                }
            }
            else
            {
                MessageBox.Show("SelectedValue is null or DBNull.", "Error");
                throw new ArgumentException("SelectedValue is null or DBNull.");
            }
        }
    }
}
