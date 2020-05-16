namespace Car_Rental_System
{
    partial class My_Rent_Request
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberplateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivercontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deparatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdreqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_Rental_SystemDataSet1 = new Car_Rental_System.Car_Rental_SystemDataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.brandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberplateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivercontDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deparatureDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svreqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_Rental_SystemDataSet2 = new Car_Rental_System.Car_Rental_SystemDataSet2();
            this.sdreqTableAdapter = new Car_Rental_System.Car_Rental_SystemDataSet1TableAdapters.sdreqTableAdapter();
            this.svreqTableAdapter = new Car_Rental_System.Car_Rental_SystemDataSet2TableAdapters.svreqTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdreqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_Rental_SystemDataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svreqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_Rental_SystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1186, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(137, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 445);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sedan_Requests";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.numberplateDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.driverDataGridViewTextBoxColumn,
            this.drivercontDataGridViewTextBoxColumn,
            this.deparatureDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.startdtDataGridViewTextBoxColumn,
            this.enddtDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sdreqBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberplateDataGridViewTextBoxColumn
            // 
            this.numberplateDataGridViewTextBoxColumn.DataPropertyName = "Numberplate";
            this.numberplateDataGridViewTextBoxColumn.HeaderText = "Numberplate";
            this.numberplateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberplateDataGridViewTextBoxColumn.Name = "numberplateDataGridViewTextBoxColumn";
            this.numberplateDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverDataGridViewTextBoxColumn
            // 
            this.driverDataGridViewTextBoxColumn.DataPropertyName = "Driver";
            this.driverDataGridViewTextBoxColumn.HeaderText = "Driver";
            this.driverDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverDataGridViewTextBoxColumn.Name = "driverDataGridViewTextBoxColumn";
            this.driverDataGridViewTextBoxColumn.Width = 125;
            // 
            // drivercontDataGridViewTextBoxColumn
            // 
            this.drivercontDataGridViewTextBoxColumn.DataPropertyName = "Drivercont";
            this.drivercontDataGridViewTextBoxColumn.HeaderText = "Drivercont";
            this.drivercontDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.drivercontDataGridViewTextBoxColumn.Name = "drivercontDataGridViewTextBoxColumn";
            this.drivercontDataGridViewTextBoxColumn.Width = 125;
            // 
            // deparatureDataGridViewTextBoxColumn
            // 
            this.deparatureDataGridViewTextBoxColumn.DataPropertyName = "Deparature";
            this.deparatureDataGridViewTextBoxColumn.HeaderText = "Deparature";
            this.deparatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deparatureDataGridViewTextBoxColumn.Name = "deparatureDataGridViewTextBoxColumn";
            this.deparatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // startdtDataGridViewTextBoxColumn
            // 
            this.startdtDataGridViewTextBoxColumn.DataPropertyName = "Startdt";
            this.startdtDataGridViewTextBoxColumn.HeaderText = "Startdt";
            this.startdtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startdtDataGridViewTextBoxColumn.Name = "startdtDataGridViewTextBoxColumn";
            this.startdtDataGridViewTextBoxColumn.Width = 125;
            // 
            // enddtDataGridViewTextBoxColumn
            // 
            this.enddtDataGridViewTextBoxColumn.DataPropertyName = "Enddt";
            this.enddtDataGridViewTextBoxColumn.HeaderText = "Enddt";
            this.enddtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enddtDataGridViewTextBoxColumn.Name = "enddtDataGridViewTextBoxColumn";
            this.enddtDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sdreqBindingSource
            // 
            this.sdreqBindingSource.DataMember = "sdreq";
            this.sdreqBindingSource.DataSource = this.car_Rental_SystemDataSet1;
            // 
            // car_Rental_SystemDataSet1
            // 
            this.car_Rental_SystemDataSet1.DataSetName = "Car_Rental_SystemDataSet1";
            this.car_Rental_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Suv_Requests";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn1,
            this.numberplateDataGridViewTextBoxColumn1,
            this.colorDataGridViewTextBoxColumn1,
            this.driverDataGridViewTextBoxColumn1,
            this.drivercontDataGridViewTextBoxColumn1,
            this.deparatureDataGridViewTextBoxColumn1,
            this.destinationDataGridViewTextBoxColumn1,
            this.startdtDataGridViewTextBoxColumn1,
            this.enddtDataGridViewTextBoxColumn1,
            this.usernameDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.svreqBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(892, 407);
            this.dataGridView2.TabIndex = 0;
            // 
            // brandDataGridViewTextBoxColumn1
            // 
            this.brandDataGridViewTextBoxColumn1.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn1.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn1.Name = "brandDataGridViewTextBoxColumn1";
            this.brandDataGridViewTextBoxColumn1.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn1
            // 
            this.modelDataGridViewTextBoxColumn1.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn1.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn1.Name = "modelDataGridViewTextBoxColumn1";
            this.modelDataGridViewTextBoxColumn1.Width = 125;
            // 
            // numberplateDataGridViewTextBoxColumn1
            // 
            this.numberplateDataGridViewTextBoxColumn1.DataPropertyName = "Numberplate";
            this.numberplateDataGridViewTextBoxColumn1.HeaderText = "Numberplate";
            this.numberplateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.numberplateDataGridViewTextBoxColumn1.Name = "numberplateDataGridViewTextBoxColumn1";
            this.numberplateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn1
            // 
            this.colorDataGridViewTextBoxColumn1.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn1.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn1.Name = "colorDataGridViewTextBoxColumn1";
            this.colorDataGridViewTextBoxColumn1.Width = 125;
            // 
            // driverDataGridViewTextBoxColumn1
            // 
            this.driverDataGridViewTextBoxColumn1.DataPropertyName = "Driver";
            this.driverDataGridViewTextBoxColumn1.HeaderText = "Driver";
            this.driverDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.driverDataGridViewTextBoxColumn1.Name = "driverDataGridViewTextBoxColumn1";
            this.driverDataGridViewTextBoxColumn1.Width = 125;
            // 
            // drivercontDataGridViewTextBoxColumn1
            // 
            this.drivercontDataGridViewTextBoxColumn1.DataPropertyName = "Drivercont";
            this.drivercontDataGridViewTextBoxColumn1.HeaderText = "Drivercont";
            this.drivercontDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.drivercontDataGridViewTextBoxColumn1.Name = "drivercontDataGridViewTextBoxColumn1";
            this.drivercontDataGridViewTextBoxColumn1.Width = 125;
            // 
            // deparatureDataGridViewTextBoxColumn1
            // 
            this.deparatureDataGridViewTextBoxColumn1.DataPropertyName = "Deparature";
            this.deparatureDataGridViewTextBoxColumn1.HeaderText = "Deparature";
            this.deparatureDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.deparatureDataGridViewTextBoxColumn1.Name = "deparatureDataGridViewTextBoxColumn1";
            this.deparatureDataGridViewTextBoxColumn1.Width = 125;
            // 
            // destinationDataGridViewTextBoxColumn1
            // 
            this.destinationDataGridViewTextBoxColumn1.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn1.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.destinationDataGridViewTextBoxColumn1.Name = "destinationDataGridViewTextBoxColumn1";
            this.destinationDataGridViewTextBoxColumn1.Width = 125;
            // 
            // startdtDataGridViewTextBoxColumn1
            // 
            this.startdtDataGridViewTextBoxColumn1.DataPropertyName = "Startdt";
            this.startdtDataGridViewTextBoxColumn1.HeaderText = "Startdt";
            this.startdtDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.startdtDataGridViewTextBoxColumn1.Name = "startdtDataGridViewTextBoxColumn1";
            this.startdtDataGridViewTextBoxColumn1.Width = 125;
            // 
            // enddtDataGridViewTextBoxColumn1
            // 
            this.enddtDataGridViewTextBoxColumn1.DataPropertyName = "Enddt";
            this.enddtDataGridViewTextBoxColumn1.HeaderText = "Enddt";
            this.enddtDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.enddtDataGridViewTextBoxColumn1.Name = "enddtDataGridViewTextBoxColumn1";
            this.enddtDataGridViewTextBoxColumn1.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            this.usernameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // svreqBindingSource
            // 
            this.svreqBindingSource.DataMember = "svreq";
            this.svreqBindingSource.DataSource = this.car_Rental_SystemDataSet2;
            // 
            // car_Rental_SystemDataSet2
            // 
            this.car_Rental_SystemDataSet2.DataSetName = "Car_Rental_SystemDataSet2";
            this.car_Rental_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sdreqTableAdapter
            // 
            this.sdreqTableAdapter.ClearBeforeFill = true;
            // 
            // svreqTableAdapter
            // 
            this.svreqTableAdapter.ClearBeforeFill = true;
            // 
            // My_Rent_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1330, 789);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "My_Rent_Request";
            this.Text = "My_Rent_Request";
            this.Load += new System.EventHandler(this.My_Rent_Request_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdreqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_Rental_SystemDataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svreqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_Rental_SystemDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Car_Rental_SystemDataSet1 car_Rental_SystemDataSet1;
        private System.Windows.Forms.BindingSource sdreqBindingSource;
        private Car_Rental_SystemDataSet1TableAdapters.sdreqTableAdapter sdreqTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberplateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivercontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deparatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private Car_Rental_SystemDataSet2 car_Rental_SystemDataSet2;
        private System.Windows.Forms.BindingSource svreqBindingSource;
        private Car_Rental_SystemDataSet2TableAdapters.svreqTableAdapter svreqTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberplateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivercontDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deparatureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
    }
}