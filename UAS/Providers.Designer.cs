namespace UAS
{
    partial class Providers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProviderDashboard = new System.Windows.Forms.Label();
            this.labelUsernameDashboard = new System.Windows.Forms.Label();
            this.vehicleTypeButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.providersButton = new System.Windows.Forms.Button();
            this.vehiclesButton = new System.Windows.Forms.Button();
            this.providersDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uas_projectDataSet = new UAS.uas_projectDataSet();
            this.uasprojectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mastervehicletypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_vehicle_typesTableAdapter = new UAS.uas_projectDataSetTableAdapters.master_vehicle_typesTableAdapter();
            this.providersTableAdapter = new UAS.uas_projectDataSetTableAdapters.providersTableAdapter();
            this.dashboardHeader = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uas_projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uasprojectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastervehicletypesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 2;
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
            this.logoutButton.Location = new System.Drawing.Point(0, 420);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(200, 30);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
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
            // providersDataGridView
            // 
            this.providersDataGridView.AutoGenerateColumns = false;
            this.providersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn,
            this.deletedatDataGridViewTextBoxColumn});
            this.providersDataGridView.DataSource = this.providersBindingSource;
            this.providersDataGridView.Location = new System.Drawing.Point(222, 245);
            this.providersDataGridView.Name = "providersDataGridView";
            this.providersDataGridView.Size = new System.Drawing.Size(543, 150);
            this.providersDataGridView.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            // 
            // deletedatDataGridViewTextBoxColumn
            // 
            this.deletedatDataGridViewTextBoxColumn.DataPropertyName = "deleted_at";
            this.deletedatDataGridViewTextBoxColumn.HeaderText = "deleted_at";
            this.deletedatDataGridViewTextBoxColumn.Name = "deletedatDataGridViewTextBoxColumn";
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "providers";
            this.providersBindingSource.DataSource = this.uas_projectDataSet;
            // 
            // uas_projectDataSet
            // 
            this.uas_projectDataSet.DataSetName = "uas_projectDataSet";
            this.uas_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uasprojectDataSetBindingSource
            // 
            this.uasprojectDataSetBindingSource.DataSource = this.uas_projectDataSet;
            this.uasprojectDataSetBindingSource.Position = 0;
            // 
            // mastervehicletypesBindingSource
            // 
            this.mastervehicletypesBindingSource.DataMember = "master_vehicle_types";
            this.mastervehicletypesBindingSource.DataSource = this.uas_projectDataSet;
            // 
            // master_vehicle_typesTableAdapter
            // 
            this.master_vehicle_typesTableAdapter.ClearBeforeFill = true;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // dashboardHeader
            // 
            this.dashboardHeader.AutoSize = true;
            this.dashboardHeader.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardHeader.Location = new System.Drawing.Point(216, 50);
            this.dashboardHeader.Name = "dashboardHeader";
            this.dashboardHeader.Size = new System.Drawing.Size(201, 32);
            this.dashboardHeader.TabIndex = 4;
            this.dashboardHeader.Text = "Providers List";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(279, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(219, 144);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Nama";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightPink;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(635, 144);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 75);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.PeachPuff;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(492, 145);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(137, 75);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(221, 181);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(235, 38);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save !";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_onClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(279, 108);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(177, 20);
            this.txtId.TabIndex = 17;
            this.txtId.Visible = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(219, 108);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 18;
            this.labelId.Text = "ID";
            this.labelId.Visible = false;
            // 
            // Providers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dashboardHeader);
            this.Controls.Add(this.providersDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Providers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Providers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Providers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uas_projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uasprojectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastervehicletypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProviderDashboard;
        private System.Windows.Forms.Label labelUsernameDashboard;
        private System.Windows.Forms.Button vehicleTypeButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button providersButton;
        private System.Windows.Forms.Button vehiclesButton;
        private System.Windows.Forms.DataGridView providersDataGridView;
        private System.Windows.Forms.BindingSource uasprojectDataSetBindingSource;
        private uas_projectDataSet uas_projectDataSet;
        private System.Windows.Forms.BindingSource mastervehicletypesBindingSource;
        private uas_projectDataSetTableAdapters.master_vehicle_typesTableAdapter master_vehicle_typesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private uas_projectDataSetTableAdapters.providersTableAdapter providersTableAdapter;
        private System.Windows.Forms.Label dashboardHeader;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelId;
    }
}