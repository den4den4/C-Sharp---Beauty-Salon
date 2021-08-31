namespace Final_project___Salon
{
    partial class CustomerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CustomerUpdateButton = new System.Windows.Forms.Button();
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
            this.SearchCustomerButton = new System.Windows.Forms.Button();
            this.SearchCustomerTextBox = new System.Windows.Forms.TextBox();
            this.CustomerDeleteButton = new System.Windows.Forms.Button();
            this.InsertCustomerButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1047, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Client Manager";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerDataGridView.Location = new System.Drawing.Point(461, 50);
            this.CustomerDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.RowHeadersWidth = 51;
            this.CustomerDataGridView.RowTemplate.Height = 24;
            this.CustomerDataGridView.Size = new System.Drawing.Size(586, 588);
            this.CustomerDataGridView.TabIndex = 2;
            this.CustomerDataGridView.DoubleClick += new System.EventHandler(this.CustomerDataGridView_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.panel3.Controls.Add(this.CustomerUpdateButton);
            this.panel3.Controls.Add(this.BirthDateTimePicker);
            this.panel3.Controls.Add(this.MailTextBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.FirstNameTextBox);
            this.panel3.Controls.Add(this.LastNameTextBox);
            this.panel3.Controls.Add(this.PhoneTextBox);
            this.panel3.Controls.Add(this.AppartmentTextBox);
            this.panel3.Controls.Add(this.StreetTextBox);
            this.panel3.Controls.Add(this.HouseTextBox);
            this.panel3.Controls.Add(this.CityTextBox);
            this.panel3.Controls.Add(this.SearchCustomerButton);
            this.panel3.Controls.Add(this.SearchCustomerTextBox);
            this.panel3.Controls.Add(this.CustomerDeleteButton);
            this.panel3.Controls.Add(this.InsertCustomerButton);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 588);
            this.panel3.TabIndex = 5;
            // 
            // CustomerUpdateButton
            // 
            this.CustomerUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.CustomerUpdateButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.CustomerUpdateButton.Location = new System.Drawing.Point(151, 532);
            this.CustomerUpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerUpdateButton.Name = "CustomerUpdateButton";
            this.CustomerUpdateButton.Size = new System.Drawing.Size(99, 42);
            this.CustomerUpdateButton.TabIndex = 27;
            this.CustomerUpdateButton.Text = "Update";
            this.CustomerUpdateButton.UseVisualStyleBackColor = false;
            this.CustomerUpdateButton.Click += new System.EventHandler(this.CustomerUpdateButton_Click);
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.CustomFormat = "yyyy-mm-dd";
            this.BirthDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateTimePicker.Location = new System.Drawing.Point(151, 246);
            this.BirthDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirthDateTimePicker.MaxDate = new System.DateTime(2050, 4, 1, 0, 0, 0, 0);
            this.BirthDateTimePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.ShowUpDown = true;
            this.BirthDateTimePicker.Size = new System.Drawing.Size(137, 28);
            this.BirthDateTimePicker.TabIndex = 26;
            this.BirthDateTimePicker.Value = new System.DateTime(2002, 4, 1, 0, 0, 0, 0);
            // 
            // MailTextBox
            // 
            this.MailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.MailTextBox.Location = new System.Drawing.Point(151, 453);
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
            this.label8.Location = new System.Drawing.Point(21, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label11.Location = new System.Drawing.Point(21, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "House";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label10.Location = new System.Drawing.Point(21, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Appartment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label9.Location = new System.Drawing.Point(21, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label7.Location = new System.Drawing.Point(21, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label6.Location = new System.Drawing.Point(21, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label5.Location = new System.Drawing.Point(21, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label4.Location = new System.Drawing.Point(21, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label3.Location = new System.Drawing.Point(21, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Street";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.FirstNameTextBox.Location = new System.Drawing.Point(151, 177);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(263, 28);
            this.FirstNameTextBox.TabIndex = 14;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.LastNameTextBox.Location = new System.Drawing.Point(151, 212);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(263, 28);
            this.LastNameTextBox.TabIndex = 13;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.PhoneTextBox.Location = new System.Drawing.Point(151, 418);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(263, 28);
            this.PhoneTextBox.TabIndex = 11;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // AppartmentTextBox
            // 
            this.AppartmentTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.AppartmentTextBox.Location = new System.Drawing.Point(149, 384);
            this.AppartmentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppartmentTextBox.Name = "AppartmentTextBox";
            this.AppartmentTextBox.Size = new System.Drawing.Size(263, 28);
            this.AppartmentTextBox.TabIndex = 10;
            this.AppartmentTextBox.TextChanged += new System.EventHandler(this.AppartmentTextBox_TextChanged);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.StreetTextBox.Location = new System.Drawing.Point(151, 315);
            this.StreetTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(263, 28);
            this.StreetTextBox.TabIndex = 9;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // HouseTextBox
            // 
            this.HouseTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.HouseTextBox.Location = new System.Drawing.Point(151, 350);
            this.HouseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HouseTextBox.Name = "HouseTextBox";
            this.HouseTextBox.Size = new System.Drawing.Size(263, 28);
            this.HouseTextBox.TabIndex = 8;
            this.HouseTextBox.TextChanged += new System.EventHandler(this.HouseTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.CityTextBox.Location = new System.Drawing.Point(151, 281);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(263, 28);
            this.CityTextBox.TabIndex = 7;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // SearchCustomerButton
            // 
            this.SearchCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.SearchCustomerButton.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.SearchCustomerButton.Location = new System.Drawing.Point(293, 79);
            this.SearchCustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCustomerButton.Name = "SearchCustomerButton";
            this.SearchCustomerButton.Size = new System.Drawing.Size(120, 28);
            this.SearchCustomerButton.TabIndex = 5;
            this.SearchCustomerButton.Text = "Search";
            this.SearchCustomerButton.UseVisualStyleBackColor = false;
            this.SearchCustomerButton.Click += new System.EventHandler(this.SearchCustomerButton_Click);
            // 
            // SearchCustomerTextBox
            // 
            this.SearchCustomerTextBox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.SearchCustomerTextBox.Location = new System.Drawing.Point(25, 79);
            this.SearchCustomerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCustomerTextBox.Name = "SearchCustomerTextBox";
            this.SearchCustomerTextBox.Size = new System.Drawing.Size(263, 28);
            this.SearchCustomerTextBox.TabIndex = 3;
            this.SearchCustomerTextBox.TextChanged += new System.EventHandler(this.SearchCustomerTextBox_TextChanged);
            // 
            // CustomerDeleteButton
            // 
            this.CustomerDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.CustomerDeleteButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.CustomerDeleteButton.Location = new System.Drawing.Point(293, 532);
            this.CustomerDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerDeleteButton.Name = "CustomerDeleteButton";
            this.CustomerDeleteButton.Size = new System.Drawing.Size(100, 42);
            this.CustomerDeleteButton.TabIndex = 1;
            this.CustomerDeleteButton.Text = "Delete ";
            this.CustomerDeleteButton.UseVisualStyleBackColor = false;
            this.CustomerDeleteButton.Click += new System.EventHandler(this.CustomerDeleteButton_Click);
            // 
            // InsertCustomerButton
            // 
            this.InsertCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.InsertCustomerButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.InsertCustomerButton.Location = new System.Drawing.Point(12, 532);
            this.InsertCustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertCustomerButton.Name = "InsertCustomerButton";
            this.InsertCustomerButton.Size = new System.Drawing.Size(99, 42);
            this.InsertCustomerButton.TabIndex = 0;
            this.InsertCustomerButton.Text = "Insert ";
            this.InsertCustomerButton.UseVisualStyleBackColor = false;
            this.InsertCustomerButton.Click += new System.EventHandler(this.InsertCustomerButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 588);
            this.panel2.TabIndex = 1;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1047, 638);
            this.Controls.Add(this.CustomerDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CustomerUpdateButton;
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
        private System.Windows.Forms.Button SearchCustomerButton;
        private System.Windows.Forms.TextBox SearchCustomerTextBox;
        private System.Windows.Forms.Button CustomerDeleteButton;
        private System.Windows.Forms.Button InsertCustomerButton;
        private System.Windows.Forms.Panel panel2;
    }
}