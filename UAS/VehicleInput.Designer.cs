namespace UAS
{
    partial class VehicleInput
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
            this.labelVin = new System.Windows.Forms.Label();
            this.txtStnk = new System.Windows.Forms.DateTimePicker();
            this.stnk_exp = new System.Windows.Forms.Label();
            this.bpkb_exp = new System.Windows.Forms.Label();
            this.txtBpkb = new System.Windows.Forms.DateTimePicker();
            this.txtProvider = new System.Windows.Forms.ComboBox();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uas_projectDataSet = new UAS.uas_projectDataSet();
            this.providersTableAdapter = new UAS.uas_projectDataSetTableAdapters.providersTableAdapter();
            this.labelProvider = new System.Windows.Forms.Label();
            this.labelVehicleType = new System.Windows.Forms.Label();
            this.txtVehicleType = new System.Windows.Forms.ComboBox();
            this.mastervehicletypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_vehicle_typesTableAdapter = new UAS.uas_projectDataSetTableAdapters.master_vehicle_typesTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uas_projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastervehicletypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVin
            // 
            this.labelVin.AutoSize = true;
            this.labelVin.Location = new System.Drawing.Point(27, 73);
            this.labelVin.Name = "labelVin";
            this.labelVin.Size = new System.Drawing.Size(25, 13);
            this.labelVin.TabIndex = 1;
            this.labelVin.Text = "VIN";
            // 
            // txtStnk
            // 
            this.txtStnk.Location = new System.Drawing.Point(138, 119);
            this.txtStnk.Name = "txtStnk";
            this.txtStnk.Size = new System.Drawing.Size(200, 20);
            this.txtStnk.TabIndex = 2;
            // 
            // stnk_exp
            // 
            this.stnk_exp.AutoSize = true;
            this.stnk_exp.Location = new System.Drawing.Point(27, 125);
            this.stnk_exp.Name = "stnk_exp";
            this.stnk_exp.Size = new System.Drawing.Size(74, 13);
            this.stnk_exp.TabIndex = 3;
            this.stnk_exp.Text = "STNK Expired";
            // 
            // bpkb_exp
            // 
            this.bpkb_exp.AutoSize = true;
            this.bpkb_exp.Location = new System.Drawing.Point(27, 176);
            this.bpkb_exp.Name = "bpkb_exp";
            this.bpkb_exp.Size = new System.Drawing.Size(73, 13);
            this.bpkb_exp.TabIndex = 5;
            this.bpkb_exp.Text = "BPKB Expired";
            // 
            // txtBpkb
            // 
            this.txtBpkb.Location = new System.Drawing.Point(138, 170);
            this.txtBpkb.Name = "txtBpkb";
            this.txtBpkb.Size = new System.Drawing.Size(200, 20);
            this.txtBpkb.TabIndex = 4;
            // 
            // txtProvider
            // 
            this.txtProvider.DataSource = this.providersBindingSource;
            this.txtProvider.DisplayMember = "name";
            this.txtProvider.FormattingEnabled = true;
            this.txtProvider.Location = new System.Drawing.Point(545, 120);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(200, 21);
            this.txtProvider.TabIndex = 6;
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
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Location = new System.Drawing.Point(435, 123);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(46, 13);
            this.labelProvider.TabIndex = 7;
            this.labelProvider.Text = "Provider";
            // 
            // labelVehicleType
            // 
            this.labelVehicleType.AutoSize = true;
            this.labelVehicleType.Location = new System.Drawing.Point(435, 176);
            this.labelVehicleType.Name = "labelVehicleType";
            this.labelVehicleType.Size = new System.Drawing.Size(69, 13);
            this.labelVehicleType.TabIndex = 9;
            this.labelVehicleType.Text = "Vehicle Type";
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.DataSource = this.mastervehicletypesBindingSource;
            this.txtVehicleType.DisplayMember = "name";
            this.txtVehicleType.FormattingEnabled = true;
            this.txtVehicleType.Location = new System.Drawing.Point(545, 173);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.Size = new System.Drawing.Size(200, 21);
            this.txtVehicleType.TabIndex = 8;
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
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(30, 251);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(715, 69);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save !";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_onClick);
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(138, 72);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(200, 20);
            this.txtVin.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(545, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 23;
            // 
            // txtCode
            // 
            this.txtCode.AutoSize = true;
            this.txtCode.Location = new System.Drawing.Point(434, 74);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(53, 13);
            this.txtCode.TabIndex = 22;
            this.txtCode.Text = "Code Bus";
            // 
            // VehicleInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelVehicleType);
            this.Controls.Add(this.txtVehicleType);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.txtProvider);
            this.Controls.Add(this.bpkb_exp);
            this.Controls.Add(this.txtBpkb);
            this.Controls.Add(this.stnk_exp);
            this.Controls.Add(this.txtStnk);
            this.Controls.Add(this.labelVin);
            this.Name = "VehicleInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleInput";
            this.Load += new System.EventHandler(this.VehicleInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uas_projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastervehicletypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVin;
        private System.Windows.Forms.DateTimePicker txtStnk;
        private System.Windows.Forms.Label stnk_exp;
        private System.Windows.Forms.Label bpkb_exp;
        private System.Windows.Forms.DateTimePicker txtBpkb;
        private System.Windows.Forms.ComboBox txtProvider;
        private uas_projectDataSet uas_projectDataSet;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private uas_projectDataSetTableAdapters.providersTableAdapter providersTableAdapter;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Label labelVehicleType;
        private System.Windows.Forms.ComboBox txtVehicleType;
        private System.Windows.Forms.BindingSource mastervehicletypesBindingSource;
        private uas_projectDataSetTableAdapters.master_vehicle_typesTableAdapter master_vehicle_typesTableAdapter;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtCode;
    }
}