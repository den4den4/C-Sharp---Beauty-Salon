namespace Final_project___Salon
{
    partial class EmployeeWorkerForm
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
            this.EmpLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EmpPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.StartWorkDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EmployeeUpdateButton = new System.Windows.Forms.Button();
            this.BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.AppartmentTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.HouseTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.SearchEmployeeButton = new System.Windows.Forms.Button();
            this.SearchEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeDeleteButton = new System.Windows.Forms.Button();
            this.InsertEmployeeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.EmpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpLabel
            // 
            this.EmpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.EmpLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmpLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.EmpLabel.Location = new System.Drawing.Point(0, 0);
            this.EmpLabel.Name = "EmpLabel";
            this.EmpLabel.Size = new System.Drawing.Size(1223, 41);
            this.EmpLabel.TabIndex = 8;
            this.EmpLabel.Text = "Employee Manager";
            this.EmpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmployeeDataGridView);
            this.panel1.Controls.Add(this.EmpPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 688);
            this.panel1.TabIndex = 9;
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(443, 0);
            this.EmployeeDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.RowHeadersWidth = 51;
            this.EmployeeDataGridView.RowTemplate.Height = 24;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(780, 688);
            this.EmployeeDataGridView.TabIndex = 7;
            this.EmployeeDataGridView.DoubleClick += new System.EventHandler(this.EmployeeDataGridView_DoubleClick_1);
            // 
            // EmpPanel
            // 
            this.EmpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.EmpPanel.Controls.Add(this.label2);
            this.EmpPanel.Controls.Add(this.label1);
            this.EmpPanel.Controls.Add(this.SalaryTextBox);
            this.EmpPanel.Controls.Add(this.StartWorkDateTimePicker);
            this.EmpPanel.Controls.Add(this.EmployeeUpdateButton);
            this.EmpPanel.Controls.Add(this.BirthDateTimePicker);
            this.EmpPanel.Controls.Add(this.MailTextBox);
            this.EmpPanel.Controls.Add(this.label8);
            this.EmpPanel.Controls.Add(this.label11);
            this.EmpPanel.Controls.Add(this.label10);
            this.EmpPanel.Controls.Add(this.label9);
            this.EmpPanel.Controls.Add(this.label7);
            this.EmpPanel.Controls.Add(this.label6);
            this.EmpPanel.Controls.Add(this.label5);
            this.EmpPanel.Controls.Add(this.label4);
            this.EmpPanel.Controls.Add(this.label3);
            this.EmpPanel.Controls.Add(this.FirstNameTextBox);
            this.EmpPanel.Controls.Add(this.LastNameTextBox);
            this.EmpPanel.Controls.Add(this.PhoneTextBox);
            this.EmpPanel.Controls.Add(this.AppartmentTextBox);
            this.EmpPanel.Controls.Add(this.StreetTextBox);
            this.EmpPanel.Controls.Add(this.HouseTextBox);
            this.EmpPanel.Controls.Add(this.CityTextBox);
            this.EmpPanel.Controls.Add(this.SearchEmployeeButton);
            this.EmpPanel.Controls.Add(this.SearchEmployeeTextBox);
            this.EmpPanel.Controls.Add(this.EmployeeDeleteButton);
            this.EmpPanel.Controls.Add(this.InsertEmployeeButton);
            this.EmpPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EmpPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpPanel.Name = "EmpPanel";
            this.EmpPanel.Size = new System.Drawing.Size(443, 688);
            this.EmpPanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label2.Location = new System.Drawing.Point(21, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label1.Location = new System.Drawing.Point(21, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Start work";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.SalaryTextBox.Location = new System.Drawing.Point(149, 322);
            this.SalaryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(263, 28);
            this.SalaryTextBox.TabIndex = 29;
            this.SalaryTextBox.TextChanged += new System.EventHandler(this.SalaryTextBox_TextChanged);
            // 
            // StartWorkDateTimePicker
            // 
            this.StartWorkDateTimePicker.CustomFormat = "yyyy-mm-dd";
            this.StartWorkDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.StartWorkDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartWorkDateTimePicker.Location = new System.Drawing.Point(149, 288);
            this.StartWorkDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartWorkDateTimePicker.MaxDate = new System.DateTime(2050, 4, 1, 0, 0, 0, 0);
            this.StartWorkDateTimePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.StartWorkDateTimePicker.Name = "StartWorkDateTimePicker";
            this.StartWorkDateTimePicker.ShowUpDown = true;
            this.StartWorkDateTimePicker.Size = new System.Drawing.Size(137, 28);
            this.StartWorkDateTimePicker.TabIndex = 28;
            this.StartWorkDateTimePicker.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // EmployeeUpdateButton
            // 
            this.EmployeeUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.EmployeeUpdateButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.EmployeeUpdateButton.Location = new System.Drawing.Point(172, 592);
            this.EmployeeUpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeUpdateButton.Name = "EmployeeUpdateButton";
            this.EmployeeUpdateButton.Size = new System.Drawing.Size(99, 42);
            this.EmployeeUpdateButton.TabIndex = 27;
            this.EmployeeUpdateButton.Text = "Update";
            this.EmployeeUpdateButton.UseVisualStyleBackColor = false;
            this.EmployeeUpdateButton.Click += new System.EventHandler(this.EmployeeUpdateButton_Click_1);
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.CustomFormat = "yyyy-mm-dd";
            this.BirthDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateTimePicker.Location = new System.Drawing.Point(151, 254);
            this.BirthDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirthDateTimePicker.MinDate = new System.DateTime(1919, 12, 1, 0, 0, 0, 0);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.ShowUpDown = true;
            this.BirthDateTimePicker.Size = new System.Drawing.Size(137, 28);
            this.BirthDateTimePicker.TabIndex = 26;
            this.BirthDateTimePicker.Value = new System.DateTime(2002, 6, 19, 0, 0, 0, 0);
            // 
            // MailTextBox
            // 
            this.MailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.MailTextBox.Location = new System.Drawing.Point(149, 529);
            this.MailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(263, 28);
            this.MailTextBox.TabIndex = 25;
            this.MailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MailTextBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label8.Location = new System.Drawing.Point(21, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label11.Location = new System.Drawing.Point(21, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "House";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label10.Location = new System.Drawing.Point(21, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Appartment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label9.Location = new System.Drawing.Point(21, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label7.Location = new System.Drawing.Point(21, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label6.Location = new System.Drawing.Point(21, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label5.Location = new System.Drawing.Point(21, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label4.Location = new System.Drawing.Point(21, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label3.Location = new System.Drawing.Point(21, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Street";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.FirstNameTextBox.Location = new System.Drawing.Point(151, 185);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(263, 28);
            this.FirstNameTextBox.TabIndex = 14;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.LastNameTextBox.Location = new System.Drawing.Point(149, 219);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(263, 28);
            this.LastNameTextBox.TabIndex = 13;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.PhoneTextBox.Location = new System.Drawing.Point(149, 495);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(263, 28);
            this.PhoneTextBox.TabIndex = 11;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // AppartmentTextBox
            // 
            this.AppartmentTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.AppartmentTextBox.Location = new System.Drawing.Point(149, 460);
            this.AppartmentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppartmentTextBox.Name = "AppartmentTextBox";
            this.AppartmentTextBox.Size = new System.Drawing.Size(263, 28);
            this.AppartmentTextBox.TabIndex = 10;
            this.AppartmentTextBox.TextChanged += new System.EventHandler(this.AppartmentTextBox_TextChanged);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.StreetTextBox.Location = new System.Drawing.Point(151, 391);
            this.StreetTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(263, 28);
            this.StreetTextBox.TabIndex = 9;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // HouseTextBox
            // 
            this.HouseTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.HouseTextBox.Location = new System.Drawing.Point(151, 426);
            this.HouseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HouseTextBox.Name = "HouseTextBox";
            this.HouseTextBox.Size = new System.Drawing.Size(263, 28);
            this.HouseTextBox.TabIndex = 8;
            this.HouseTextBox.TextChanged += new System.EventHandler(this.HouseTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.CityTextBox.Location = new System.Drawing.Point(151, 357);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(263, 28);
            this.CityTextBox.TabIndex = 7;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // SearchEmployeeButton
            // 
            this.SearchEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.SearchEmployeeButton.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.SearchEmployeeButton.Location = new System.Drawing.Point(293, 79);
            this.SearchEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchEmployeeButton.Name = "SearchEmployeeButton";
            this.SearchEmployeeButton.Size = new System.Drawing.Size(120, 28);
            this.SearchEmployeeButton.TabIndex = 5;
            this.SearchEmployeeButton.Text = "Search";
            this.SearchEmployeeButton.UseVisualStyleBackColor = false;
            this.SearchEmployeeButton.Click += new System.EventHandler(this.SearchEmployeeButton_Click);
            // 
            // SearchEmployeeTextBox
            // 
            this.SearchEmployeeTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.SearchEmployeeTextBox.Location = new System.Drawing.Point(25, 79);
            this.SearchEmployeeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchEmployeeTextBox.Name = "SearchEmployeeTextBox";
            this.SearchEmployeeTextBox.Size = new System.Drawing.Size(263, 28);
            this.SearchEmployeeTextBox.TabIndex = 3;
            this.SearchEmployeeTextBox.TextChanged += new System.EventHandler(this.SearchEmployeeTextBox_TextChanged_1);
            // 
            // EmployeeDeleteButton
            // 
            this.EmployeeDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.EmployeeDeleteButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.EmployeeDeleteButton.Location = new System.Drawing.Point(315, 592);
            this.EmployeeDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeDeleteButton.Name = "EmployeeDeleteButton";
            this.EmployeeDeleteButton.Size = new System.Drawing.Size(100, 42);
            this.EmployeeDeleteButton.TabIndex = 1;
            this.EmployeeDeleteButton.Text = "Delete ";
            this.EmployeeDeleteButton.UseVisualStyleBackColor = false;
            this.EmployeeDeleteButton.Click += new System.EventHandler(this.EmployeeDeleteButton_Click_1);
            // 
            // InsertEmployeeButton
            // 
            this.InsertEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.InsertEmployeeButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.InsertEmployeeButton.Location = new System.Drawing.Point(25, 592);
            this.InsertEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertEmployeeButton.Name = "InsertEmployeeButton";
            this.InsertEmployeeButton.Size = new System.Drawing.Size(99, 42);
            this.InsertEmployeeButton.TabIndex = 0;
            this.InsertEmployeeButton.Text = "Insert ";
            this.InsertEmployeeButton.UseVisualStyleBackColor = false;
            this.InsertEmployeeButton.Click += new System.EventHandler(this.InsertEmployeeButton_Click);
            // 
            // EmployeeWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1223, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmpLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeWorkerForm";
            this.Text = "EmployeeWorkerForm";
            this.Load += new System.EventHandler(this.EmployeeWorkerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.EmpPanel.ResumeLayout(false);
            this.EmpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label EmpLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel EmpPanel;
        private System.Windows.Forms.Button EmployeeUpdateButton;
        private System.Windows.Forms.DateTimePicker BirthDateTimePicker;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox AppartmentTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox HouseTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Button SearchEmployeeButton;
        private System.Windows.Forms.TextBox SearchEmployeeTextBox;
        private System.Windows.Forms.Button EmployeeDeleteButton;
        private System.Windows.Forms.Button InsertEmployeeButton;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.DateTimePicker StartWorkDateTimePicker;
    }
}