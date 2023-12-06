namespace UAS
{
    partial class VehicleTypes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label nameLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProviderDashboard = new System.Windows.Forms.Label();
            this.labelUsernameDashboard = new System.Windows.Forms.Label();
            this.vehicleTypeButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.providersButton = new System.Windows.Forms.Button();
            this.vehiclesButton = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.master_vehicle_typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uas_projectDataSet = new UAS.uas_projectDataSet();
            this.master_vehicle_typesTableAdapter = new UAS.uas_projectDataSetTableAdapters.master_vehicle_typesTableAdapter();
            this.tableAdapterManager = new UAS.uas_projectDataSetTableAdapters.TableAdapterManager();
            this.vehicleTypePanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.master_vehicle_typesDataGridView = new System.Windows.Forms.DataGridView();
            this.dashboardHeader = new System.Windows.Forms.Label();
            this.idGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_vehicle_typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uas_projectDataSet)).BeginInit();
            this.vehicleTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_vehicle_typesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(48, 144);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(32, 13);
            codeLabel.TabIndex = 7;
            codeLabel.Text = "Code";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(238, 144);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(35, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.labelProviderDashboard);
            this.panel1.Controls.Add(this.labelUsernameDashboard);
            this.panel1.Controls.Add(this.vehicleTypeButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.usersButton);
            this.panel1.Controls.Add(this.providersButton);
            this.panel1.Controls.Add(this.vehiclesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 460);
            this.panel1.TabIndex = 0;
            // 
            // labelProviderDashboard
            // 
            this.labelProviderDashboard.AutoSize = true;
            this.labelProviderDashboard.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProviderDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.labelProviderDashboard.Location = new System.Drawing.Point(69, 83);
            this.labelProviderDashboard.Name = "labelProviderDashboard";
            this.labelProviderDashboard.Size = new System.Drawing.Size(63, 19);
            this.labelProviderDashboard.TabIndex = 7;
            this.labelProviderDashboard.Text = "label2";
            // 
            // labelUsernameDashboard
            // 
            this.labelUsernameDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsernameDashboard.AutoSize = true;
            this.labelUsernameDashboard.Font = new System.Drawing.Font("Noto Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.labelUsernameDashboard.Location = new System.Drawing.Point(27, 51);
            this.labelUsernameDashboard.Name = "labelUsernameDashboard";
            this.labelUsernameDashboard.Size = new System.Drawing.Size(116, 32);
            this.labelUsernameDashboard.TabIndex = 6;
            this.labelUsernameDashboard.Text = "label1";
            this.labelUsernameDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vehicleTypeButton
            // 
            this.vehicleTypeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
            this.vehicleTypeButton.FlatAppearance.BorderSize = 0;
            this.vehicleTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleTypeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTypeButton.ForeColor = System.Drawing.Color.White;
            this.vehicleTypeButton.Location = new System.Drawing.Point(0, 133);
            this.vehicleTypeButton.Name = "vehicleTypeButton";
            this.vehicleTypeButton.Size = new System.Drawing.Size(200, 30);
            this.vehicleTypeButton.TabIndex = 5;
            this.vehicleTypeButton.Text = "Vehicles Type";
            this.vehicleTypeButton.UseVisualStyleBackColor = false;
            this.vehicleTypeButton.Click += new System.EventHandler(this.vehicleTypesClick);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(0, 430);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(200, 30);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButtonClick);
            // 
            // usersButton
            // 
            this.usersButton.FlatAppearance.BorderSize = 0;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.Location = new System.Drawing.Point(0, 231);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(200, 30);
            this.usersButton.TabIndex = 3;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersClick);
            // 
            // providersButton
            // 
            this.providersButton.FlatAppearance.BorderSize = 0;
            this.providersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.providersButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providersButton.ForeColor = System.Drawing.Color.White;
            this.providersButton.Location = new System.Drawing.Point(0, 198);
            this.providersButton.Name = "providersButton";
            this.providersButton.Size = new System.Drawing.Size(200, 30);
            this.providersButton.TabIndex = 2;
            this.providersButton.Text = "Providers";
            this.providersButton.UseVisualStyleBackColor = true;
            this.providersButton.Click += new System.EventHandler(this.providersClick);
            // 
            // vehiclesButton
            // 
            this.vehiclesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
            this.vehiclesButton.FlatAppearance.BorderSize = 0;
            this.vehiclesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiclesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesButton.ForeColor = System.Drawing.Color.White;
            this.vehiclesButton.Location = new System.Drawing.Point(0, 166);
            this.vehiclesButton.Name = "vehiclesButton";
            this.vehiclesButton.Size = new System.Drawing.Size(200, 30);
            this.vehiclesButton.TabIndex = 1;
            this.vehiclesButton.Text = "Vehicles";
            this.vehiclesButton.UseVisualStyleBackColor = false;
            this.vehiclesButton.Click += new System.EventHandler(this.vehiclesClick);
            // 
            // X
            // 
            this.X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.X.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.X.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.X.FlatAppearance.BorderSize = 0;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.Red;
            this.X.Location = new System.Drawing.Point(934, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(29, 34);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.button1_Click);
            // 
            // master_vehicle_typesBindingSource
            // 
            this.master_vehicle_typesBindingSource.DataMember = "master_vehicle_types";
            this.master_vehicle_typesBindingSource.DataSource = this.uas_projectDataSet;
            // 
            // uas_projectDataSet
            // 
            this.uas_projectDataSet.DataSetName = "uas_projectDataSet";
            this.uas_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // master_vehicle_typesTableAdapter
            // 
            this.master_vehicle_typesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.master_vehicle_typesTableAdapter = this.master_vehicle_typesTableAdapter;
            this.tableAdapterManager.providersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UAS.uas_projectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.vehiclesTableAdapter = null;
            // 
            // vehicleTypePanel
            // 
            this.vehicleTypePanel.Controls.Add(this.labelId);
            this.vehicleTypePanel.Controls.Add(this.txtId);
            this.vehicleTypePanel.Controls.Add(this.deleteButton);
            this.vehicleTypePanel.Controls.Add(this.editButton);
            this.vehicleTypePanel.Controls.Add(this.txtName);
            this.vehicleTypePanel.Controls.Add(this.txtCode);
            this.vehicleTypePanel.Controls.Add(nameLabel);
            this.vehicleTypePanel.Controls.Add(codeLabel);
            this.vehicleTypePanel.Controls.Add(this.saveButton);
            this.vehicleTypePanel.Controls.Add(this.master_vehicle_typesDataGridView);
            this.vehicleTypePanel.Controls.Add(this.dashboardHeader);
            this.vehicleTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleTypePanel.Location = new System.Drawing.Point(200, 0);
            this.vehicleTypePanel.Name = "vehicleTypePanel";
            this.vehicleTypePanel.Size = new System.Drawing.Size(762, 460);
            this.vehicleTypePanel.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightPink;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(580, 139);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 75);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.PeachPuff;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(437, 140);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(137, 75);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(279, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(95, 141);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(132, 20);
            this.txtCode.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(51, 177);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(358, 38);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save !";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveVehicleType);
            // 
            // master_vehicle_typesDataGridView
            // 
            this.master_vehicle_typesDataGridView.AutoGenerateColumns = false;
            this.master_vehicle_typesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.master_vehicle_typesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGridViewTextBoxColumn,
            this.codeGridViewTextBoxColumn,
            this.nameGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.master_vehicle_typesDataGridView.DataSource = this.master_vehicle_typesBindingSource;
            this.master_vehicle_typesDataGridView.Location = new System.Drawing.Point(51, 240);
            this.master_vehicle_typesDataGridView.Name = "master_vehicle_typesDataGridView";
            this.master_vehicle_typesDataGridView.Size = new System.Drawing.Size(659, 220);
            this.master_vehicle_typesDataGridView.TabIndex = 1;
            // 
            // dashboardHeader
            // 
            this.dashboardHeader.AutoSize = true;
            this.dashboardHeader.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardHeader.Location = new System.Drawing.Point(45, 51);
            this.dashboardHeader.Name = "dashboardHeader";
            this.dashboardHeader.Size = new System.Drawing.Size(249, 32);
            this.dashboardHeader.TabIndex = 0;
            this.dashboardHeader.Text = "Vehicle Type List";
            // 
            // idGridViewTextBoxColumn
            // 
            this.idGridViewTextBoxColumn.DataPropertyName = "id";
            this.idGridViewTextBoxColumn.HeaderText = "id";
            this.idGridViewTextBoxColumn.Name = "idGridViewTextBoxColumn";
            // 
            // codeGridViewTextBoxColumn
            // 
            this.codeGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeGridViewTextBoxColumn.HeaderText = "code";
            this.codeGridViewTextBoxColumn.Name = "codeGridViewTextBoxColumn";
            // 
            // nameGridViewTextBoxColumn
            // 
            this.nameGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameGridViewTextBoxColumn.HeaderText = "name";
            this.nameGridViewTextBoxColumn.Name = "nameGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "created_at";
            this.dataGridViewTextBoxColumn4.HeaderText = "created_at";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "updated_at";
            this.dataGridViewTextBoxColumn5.HeaderText = "updated_at";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "deleted_at";
            this.dataGridViewTextBoxColumn6.HeaderText = "deleted_at";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(95, 108);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(314, 20);
            this.txtId.TabIndex = 14;
            this.txtId.Visible = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(51, 108);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 15;
            this.labelId.Text = "ID";
            this.labelId.Visible = false;
            // 
            // VehicleTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 460);
            this.Controls.Add(this.X);
            this.Controls.Add(this.vehicleTypePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehicleTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomepageLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_vehicle_typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uas_projectDataSet)).EndInit();
            this.vehicleTypePanel.ResumeLayout(false);
            this.vehicleTypePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_vehicle_typesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button vehiclesButton;
        private System.Windows.Forms.Button providersButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button vehicleTypeButton;
        private System.Windows.Forms.Label labelUsernameDashboard;
        private uas_projectDataSet uas_projectDataSet;
        private System.Windows.Forms.BindingSource master_vehicle_typesBindingSource;
        private uas_projectDataSetTableAdapters.master_vehicle_typesTableAdapter master_vehicle_typesTableAdapter;
        private uas_projectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel vehicleTypePanel;
        private System.Windows.Forms.Label dashboardHeader;
        private System.Windows.Forms.Label labelProviderDashboard;
        private System.Windows.Forms.DataGridView master_vehicle_typesDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelId;
    }
}