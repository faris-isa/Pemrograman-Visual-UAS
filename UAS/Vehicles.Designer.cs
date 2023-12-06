namespace UAS
{
    partial class Vehicles
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
            this.X = new System.Windows.Forms.Button();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.vinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codebusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codebusproviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnkexpiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bpkbexpiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provideridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uas_projectDataSet = new UAS.uas_projectDataSet();
            this.vehiclesTableAdapter = new UAS.uas_projectDataSetTableAdapters.vehiclesTableAdapter();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uas_projectDataSet)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.X.Location = new System.Drawing.Point(1201, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(29, 34);
            this.X.TabIndex = 2;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.button1_Click);
            // 
            // vehicleDataGridView
            // 
            this.vehicleDataGridView.AutoGenerateColumns = false;
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vinDataGridViewTextBoxColumn,
            this.codebusDataGridViewTextBoxColumn,
            this.codebusproviderDataGridViewTextBoxColumn,
            this.stnkexpiredDataGridViewTextBoxColumn,
            this.bpkbexpiredDataGridViewTextBoxColumn,
            this.typeidDataGridViewTextBoxColumn,
            this.provideridDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn,
            this.deletedatDataGridViewTextBoxColumn});
            this.vehicleDataGridView.DataSource = this.vehiclesBindingSource;
            this.vehicleDataGridView.Location = new System.Drawing.Point(234, 231);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.Size = new System.Drawing.Size(946, 150);
            this.vehicleDataGridView.TabIndex = 3;
            // 
            // vinDataGridViewTextBoxColumn
            // 
            this.vinDataGridViewTextBoxColumn.DataPropertyName = "vin";
            this.vinDataGridViewTextBoxColumn.HeaderText = "vin";
            this.vinDataGridViewTextBoxColumn.Name = "vinDataGridViewTextBoxColumn";
            // 
            // codebusDataGridViewTextBoxColumn
            // 
            this.codebusDataGridViewTextBoxColumn.DataPropertyName = "code_bus";
            this.codebusDataGridViewTextBoxColumn.HeaderText = "code_bus";
            this.codebusDataGridViewTextBoxColumn.Name = "codebusDataGridViewTextBoxColumn";
            // 
            // codebusproviderDataGridViewTextBoxColumn
            // 
            this.codebusproviderDataGridViewTextBoxColumn.DataPropertyName = "code_bus_provider";
            this.codebusproviderDataGridViewTextBoxColumn.HeaderText = "code_bus_provider";
            this.codebusproviderDataGridViewTextBoxColumn.Name = "codebusproviderDataGridViewTextBoxColumn";
            // 
            // stnkexpiredDataGridViewTextBoxColumn
            // 
            this.stnkexpiredDataGridViewTextBoxColumn.DataPropertyName = "stnk_expired";
            this.stnkexpiredDataGridViewTextBoxColumn.HeaderText = "stnk_expired";
            this.stnkexpiredDataGridViewTextBoxColumn.Name = "stnkexpiredDataGridViewTextBoxColumn";
            // 
            // bpkbexpiredDataGridViewTextBoxColumn
            // 
            this.bpkbexpiredDataGridViewTextBoxColumn.DataPropertyName = "bpkb_expired";
            this.bpkbexpiredDataGridViewTextBoxColumn.HeaderText = "bpkb_expired";
            this.bpkbexpiredDataGridViewTextBoxColumn.Name = "bpkbexpiredDataGridViewTextBoxColumn";
            // 
            // typeidDataGridViewTextBoxColumn
            // 
            this.typeidDataGridViewTextBoxColumn.DataPropertyName = "type_id";
            this.typeidDataGridViewTextBoxColumn.HeaderText = "type_id";
            this.typeidDataGridViewTextBoxColumn.Name = "typeidDataGridViewTextBoxColumn";
            // 
            // provideridDataGridViewTextBoxColumn
            // 
            this.provideridDataGridViewTextBoxColumn.DataPropertyName = "provider_id";
            this.provideridDataGridViewTextBoxColumn.HeaderText = "provider_id";
            this.provideridDataGridViewTextBoxColumn.Name = "provideridDataGridViewTextBoxColumn";
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
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "vehicles";
            this.vehiclesBindingSource.DataSource = this.uas_projectDataSet;
            // 
            // uas_projectDataSet
            // 
            this.uas_projectDataSet.DataSetName = "uas_projectDataSet";
            this.uas_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightPink;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(1050, 147);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 75);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.PeachPuff;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(417, 148);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(137, 75);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonAddNew.FlatAppearance.BorderSize = 0;
            this.buttonAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNew.Location = new System.Drawing.Point(234, 148);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(166, 74);
            this.buttonAddNew.TabIndex = 20;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 450);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.vehicleDataGridView);
            this.Controls.Add(this.X);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VehicleLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uas_projectDataSet)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private uas_projectDataSet uas_projectDataSet;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private uas_projectDataSetTableAdapters.vehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codebusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codebusproviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stnkexpiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bpkbexpiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provideridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button buttonAddNew;
    }
}