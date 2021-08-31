
namespace Final_project___Salon
{
    partial class TimetableInputForm
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
            this.AddRecordPanel = new System.Windows.Forms.Panel();
            this.textBoxCustomerSearch = new System.Windows.Forms.TextBox();
            this.comboEmployees = new System.Windows.Forms.ComboBox();
            this.comboCustomers = new System.Windows.Forms.ComboBox();
            this.comBoxFreeTime = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.ErrorChoiseLabel = new System.Windows.Forms.Label();
            this.btnCleanServices = new System.Windows.Forms.Button();
            this.btnRemoveService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.listBoxServicesFromDB = new System.Windows.Forms.ListBox();
            this.listBoxServices = new System.Windows.Forms.ListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EmployeeFullNameLabel = new System.Windows.Forms.Label();
            this.CustomerFullNameLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateOperationPicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AddRecordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddRecordPanel
            // 
            this.AddRecordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.AddRecordPanel.Controls.Add(this.textBoxCustomerSearch);
            this.AddRecordPanel.Controls.Add(this.comboEmployees);
            this.AddRecordPanel.Controls.Add(this.comboCustomers);
            this.AddRecordPanel.Controls.Add(this.comBoxFreeTime);
            this.AddRecordPanel.Controls.Add(this.lblTotal);
            this.AddRecordPanel.Controls.Add(this.ErrorChoiseLabel);
            this.AddRecordPanel.Controls.Add(this.btnCleanServices);
            this.AddRecordPanel.Controls.Add(this.btnRemoveService);
            this.AddRecordPanel.Controls.Add(this.btnAddService);
            this.AddRecordPanel.Controls.Add(this.listBoxServicesFromDB);
            this.AddRecordPanel.Controls.Add(this.listBoxServices);
            this.AddRecordPanel.Controls.Add(this.CancelButton);
            this.AddRecordPanel.Controls.Add(this.AddButton);
            this.AddRecordPanel.Controls.Add(this.EmployeeFullNameLabel);
            this.AddRecordPanel.Controls.Add(this.CustomerFullNameLabel);
            this.AddRecordPanel.Controls.Add(this.TimeLabel);
            this.AddRecordPanel.Controls.Add(this.DateOperationPicker);
            this.AddRecordPanel.Controls.Add(this.DateLabel);
            this.AddRecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddRecordPanel.Location = new System.Drawing.Point(0, 0);
            this.AddRecordPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AddRecordPanel.Name = "AddRecordPanel";
            this.AddRecordPanel.Size = new System.Drawing.Size(586, 595);
            this.AddRecordPanel.TabIndex = 0;
            // 
            // textBoxCustomerSearch
            // 
            this.textBoxCustomerSearch.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.textBoxCustomerSearch.Location = new System.Drawing.Point(412, 142);
            this.textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            this.textBoxCustomerSearch.Size = new System.Drawing.Size(133, 24);
            this.textBoxCustomerSearch.TabIndex = 81;
            this.textBoxCustomerSearch.TextChanged += new System.EventHandler(this.textBoxCustomerSearch_TextChanged);
            // 
            // comboEmployees
            // 
            this.comboEmployees.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.comboEmployees.FormattingEnabled = true;
            this.comboEmployees.Location = new System.Drawing.Point(258, 170);
            this.comboEmployees.Name = "comboEmployees";
            this.comboEmployees.Size = new System.Drawing.Size(148, 27);
            this.comboEmployees.TabIndex = 80;
            this.comboEmployees.SelectedIndexChanged += new System.EventHandler(this.comboEmployees_SelectedIndexChanged);
            // 
            // comboCustomers
            // 
            this.comboCustomers.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.comboCustomers.FormattingEnabled = true;
            this.comboCustomers.Location = new System.Drawing.Point(258, 142);
            this.comboCustomers.Name = "comboCustomers";
            this.comboCustomers.Size = new System.Drawing.Size(148, 27);
            this.comboCustomers.TabIndex = 79;
            this.comboCustomers.SelectedIndexChanged += new System.EventHandler(this.comboCustomers_SelectedIndexChanged);
            // 
            // comBoxFreeTime
            // 
            this.comBoxFreeTime.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.comBoxFreeTime.FormattingEnabled = true;
            this.comBoxFreeTime.Location = new System.Drawing.Point(258, 73);
            this.comBoxFreeTime.Name = "comBoxFreeTime";
            this.comBoxFreeTime.Size = new System.Drawing.Size(128, 27);
            this.comBoxFreeTime.TabIndex = 78;
            this.comBoxFreeTime.Text = "Select Time";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(28)))), ((int)(((byte)(8)))));
            this.lblTotal.Location = new System.Drawing.Point(25, 545);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 19);
            this.lblTotal.TabIndex = 77;
            this.lblTotal.Text = "*";
            // 
            // ErrorChoiseLabel
            // 
            this.ErrorChoiseLabel.AutoSize = true;
            this.ErrorChoiseLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.ErrorChoiseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(28)))), ((int)(((byte)(8)))));
            this.ErrorChoiseLabel.Location = new System.Drawing.Point(161, 261);
            this.ErrorChoiseLabel.Name = "ErrorChoiseLabel";
            this.ErrorChoiseLabel.Size = new System.Drawing.Size(0, 22);
            this.ErrorChoiseLabel.TabIndex = 76;
            // 
            // btnCleanServices
            // 
            this.btnCleanServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.btnCleanServices.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCleanServices.Location = new System.Drawing.Point(258, 300);
            this.btnCleanServices.Name = "btnCleanServices";
            this.btnCleanServices.Size = new System.Drawing.Size(71, 42);
            this.btnCleanServices.TabIndex = 75;
            this.btnCleanServices.Text = "clean";
            this.btnCleanServices.UseVisualStyleBackColor = false;
            this.btnCleanServices.Click += new System.EventHandler(this.btnCleanServices_Click);
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnRemoveService.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveService.Location = new System.Drawing.Point(258, 471);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(71, 42);
            this.btnRemoveService.TabIndex = 74;
            this.btnRemoveService.Text = ">>";
            this.btnRemoveService.UseVisualStyleBackColor = false;
            this.btnRemoveService.Click += new System.EventHandler(this.btnRemoveService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btnAddService.Location = new System.Drawing.Point(258, 423);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(71, 42);
            this.btnAddService.TabIndex = 73;
            this.btnAddService.Text = "<<";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // listBoxServicesFromDB
            // 
            this.listBoxServicesFromDB.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.listBoxServicesFromDB.FormattingEnabled = true;
            this.listBoxServicesFromDB.ItemHeight = 19;
            this.listBoxServicesFromDB.Location = new System.Drawing.Point(347, 300);
            this.listBoxServicesFromDB.Name = "listBoxServicesFromDB";
            this.listBoxServicesFromDB.Size = new System.Drawing.Size(227, 213);
            this.listBoxServicesFromDB.TabIndex = 72;
            // 
            // listBoxServices
            // 
            this.listBoxServices.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.ItemHeight = 19;
            this.listBoxServices.Location = new System.Drawing.Point(12, 300);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.Size = new System.Drawing.Size(227, 213);
            this.listBoxServices.TabIndex = 71;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(347, 209);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(109, 37);
            this.CancelButton.TabIndex = 70;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(130, 209);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(109, 37);
            this.AddButton.TabIndex = 68;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EmployeeFullNameLabel
            // 
            this.EmployeeFullNameLabel.AutoSize = true;
            this.EmployeeFullNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.EmployeeFullNameLabel.Location = new System.Drawing.Point(119, 173);
            this.EmployeeFullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeFullNameLabel.Name = "EmployeeFullNameLabel";
            this.EmployeeFullNameLabel.Size = new System.Drawing.Size(127, 20);
            this.EmployeeFullNameLabel.TabIndex = 65;
            this.EmployeeFullNameLabel.Text = "Employee name";
            // 
            // CustomerFullNameLabel
            // 
            this.CustomerFullNameLabel.AutoSize = true;
            this.CustomerFullNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.CustomerFullNameLabel.Location = new System.Drawing.Point(119, 145);
            this.CustomerFullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerFullNameLabel.Name = "CustomerFullNameLabel";
            this.CustomerFullNameLabel.Size = new System.Drawing.Size(125, 20);
            this.CustomerFullNameLabel.TabIndex = 64;
            this.CustomerFullNameLabel.Text = "Customer name";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TimeLabel.Location = new System.Drawing.Point(162, 80);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(40, 20);
            this.TimeLabel.TabIndex = 61;
            this.TimeLabel.Text = "Time";
            // 
            // DateOperationPicker
            // 
            this.DateOperationPicker.CustomFormat = "yyyy-mm-dd";
            this.DateOperationPicker.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.DateOperationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOperationPicker.Location = new System.Drawing.Point(258, 42);
            this.DateOperationPicker.Margin = new System.Windows.Forms.Padding(2);
            this.DateOperationPicker.MaxDate = new System.DateTime(2050, 4, 1, 0, 0, 0, 0);
            this.DateOperationPicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.DateOperationPicker.Name = "DateOperationPicker";
            this.DateOperationPicker.ShowUpDown = true;
            this.DateOperationPicker.Size = new System.Drawing.Size(128, 24);
            this.DateOperationPicker.TabIndex = 59;
            this.DateOperationPicker.Value = new System.DateTime(2021, 7, 26, 0, 0, 0, 0);
            this.DateOperationPicker.ValueChanged += new System.EventHandler(this.DateOperationPicker_ValueChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.DateLabel.Location = new System.Drawing.Point(161, 47);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(45, 20);
            this.DateLabel.TabIndex = 58;
            this.DateLabel.Text = "Date";
            // 
            // TimetableInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 595);
            this.Controls.Add(this.AddRecordPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimetableInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add record ";
            this.AddRecordPanel.ResumeLayout(false);
            this.AddRecordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddRecordPanel;
        private System.Windows.Forms.Label EmployeeFullNameLabel;
        private System.Windows.Forms.Label CustomerFullNameLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.DateTimePicker DateOperationPicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button btnCleanServices;
        private System.Windows.Forms.Button btnRemoveService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ListBox listBoxServicesFromDB;
        private System.Windows.Forms.ListBox listBoxServices;
        private System.Windows.Forms.Label ErrorChoiseLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox comBoxFreeTime;
        private System.Windows.Forms.ComboBox comboEmployees;
        private System.Windows.Forms.ComboBox comboCustomers;
        private System.Windows.Forms.TextBox textBoxCustomerSearch;
    }
}