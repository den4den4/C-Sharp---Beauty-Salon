namespace Final_project___Salon
{
    partial class ReportForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblStatMessage = new System.Windows.Forms.Label();
            this.comboBoxStat = new System.Windows.Forms.ComboBox();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtPickerTo = new System.Windows.Forms.DateTimePicker();
            this.dtPickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btnPrintStatistic = new System.Windows.Forms.Button();
            this.btnSaveStatistic = new System.Windows.Forms.Button();
            this.dataGridStat = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtPickerTTList = new System.Windows.Forms.DateTimePicker();
            this.lblTimeTableMessage = new System.Windows.Forms.Label();
            this.lblServiceMessage = new System.Windows.Forms.Label();
            this.lblCustomersMessage = new System.Windows.Forms.Label();
            this.lblEmpMessage = new System.Windows.Forms.Label();
            this.btnCustomersPrint = new System.Windows.Forms.Button();
            this.btnServicesPrint = new System.Windows.Forms.Button();
            this.btnTimeTablePrint = new System.Windows.Forms.Button();
            this.btnEmployeePrint = new System.Windows.Forms.Button();
            this.btnCustomersSave = new System.Windows.Forms.Button();
            this.btnTimeTableSave = new System.Windows.Forms.Button();
            this.btnEmployeeSave = new System.Windows.Forms.Button();
            this.btnServicesSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.checkBoxSendMail = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblChecksMessage = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSaveCheck = new System.Windows.Forms.Button();
            this.dataGridChecks = new System.Windows.Forms.DataGridView();
            this.tabReport = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStat)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecks)).BeginInit();
            this.tabReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1022, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Reports";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.tabPage4.Controls.Add(this.lblStatMessage);
            this.tabPage4.Controls.Add(this.comboBoxStat);
            this.tabPage4.Controls.Add(this.btnYear);
            this.tabPage4.Controls.Add(this.btnMonth);
            this.tabPage4.Controls.Add(this.btnWeek);
            this.tabPage4.Controls.Add(this.lblTo);
            this.tabPage4.Controls.Add(this.lblFrom);
            this.tabPage4.Controls.Add(this.dtPickerTo);
            this.tabPage4.Controls.Add(this.dtPickerFrom);
            this.tabPage4.Controls.Add(this.btnPrintStatistic);
            this.tabPage4.Controls.Add(this.btnSaveStatistic);
            this.tabPage4.Controls.Add(this.dataGridStat);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(1014, 567);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Statistics";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // lblStatMessage
            // 
            this.lblStatMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatMessage.AutoSize = true;
            this.lblStatMessage.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(28)))), ((int)(((byte)(8)))));
            this.lblStatMessage.Location = new System.Drawing.Point(326, 502);
            this.lblStatMessage.Name = "lblStatMessage";
            this.lblStatMessage.Size = new System.Drawing.Size(21, 25);
            this.lblStatMessage.TabIndex = 13;
            this.lblStatMessage.Text = "-";
            // 
            // comboBoxStat
            // 
            this.comboBoxStat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxStat.FormattingEnabled = true;
            this.comboBoxStat.Items.AddRange(new object[] {
            "Services Income",
            "Customers Report",
            "Employees Report"});
            this.comboBoxStat.Location = new System.Drawing.Point(794, 19);
            this.comboBoxStat.Name = "comboBoxStat";
            this.comboBoxStat.Size = new System.Drawing.Size(200, 24);
            this.comboBoxStat.TabIndex = 4;
            this.comboBoxStat.Text = "Select Report Type";
            this.comboBoxStat.SelectedIndexChanged += new System.EventHandler(this.comboBoxStat_SelectedIndexChanged);
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnYear.Location = new System.Drawing.Point(614, 19);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(70, 25);
            this.btnYear.TabIndex = 12;
            this.btnYear.Text = "year";
            this.btnYear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnMonth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMonth.Location = new System.Drawing.Point(536, 19);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(70, 25);
            this.btnMonth.TabIndex = 11;
            this.btnMonth.Text = "month";
            this.btnMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnWeek.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWeek.Location = new System.Drawing.Point(462, 19);
            this.btnWeek.Margin = new System.Windows.Forms.Padding(1);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(70, 25);
            this.btnWeek.TabIndex = 10;
            this.btnWeek.Text = "week";
            this.btnWeek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWeek.UseVisualStyleBackColor = false;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTo.Location = new System.Drawing.Point(294, 24);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 19);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.Location = new System.Drawing.Point(123, 24);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(48, 19);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "From";
            // 
            // dtPickerTo
            // 
            this.dtPickerTo.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtPickerTo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtPickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerTo.Location = new System.Drawing.Point(328, 23);
            this.dtPickerTo.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtPickerTo.Name = "dtPickerTo";
            this.dtPickerTo.Size = new System.Drawing.Size(92, 23);
            this.dtPickerTo.TabIndex = 7;
            this.dtPickerTo.ValueChanged += new System.EventHandler(this.dtPickerTo_ValueChanged);
            // 
            // dtPickerFrom
            // 
            this.dtPickerFrom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtPickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerFrom.Location = new System.Drawing.Point(177, 24);
            this.dtPickerFrom.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtPickerFrom.Name = "dtPickerFrom";
            this.dtPickerFrom.Size = new System.Drawing.Size(91, 23);
            this.dtPickerFrom.TabIndex = 6;
            this.dtPickerFrom.ValueChanged += new System.EventHandler(this.dtPickerFrom_ValueChanged);
            // 
            // btnPrintStatistic
            // 
            this.btnPrintStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnPrintStatistic.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnPrintStatistic.Location = new System.Drawing.Point(166, 488);
            this.btnPrintStatistic.Name = "btnPrintStatistic";
            this.btnPrintStatistic.Size = new System.Drawing.Size(154, 36);
            this.btnPrintStatistic.TabIndex = 5;
            this.btnPrintStatistic.Text = "Print";
            this.btnPrintStatistic.UseVisualStyleBackColor = false;
            this.btnPrintStatistic.Click += new System.EventHandler(this.btnPrintStatistic_Click);
            // 
            // btnSaveStatistic
            // 
            this.btnSaveStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnSaveStatistic.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnSaveStatistic.Location = new System.Drawing.Point(6, 488);
            this.btnSaveStatistic.Name = "btnSaveStatistic";
            this.btnSaveStatistic.Size = new System.Drawing.Size(154, 36);
            this.btnSaveStatistic.TabIndex = 4;
            this.btnSaveStatistic.Text = "Save";
            this.btnSaveStatistic.UseVisualStyleBackColor = false;
            this.btnSaveStatistic.Click += new System.EventHandler(this.btnSaveStatistic_Click);
            // 
            // dataGridStat
            // 
            this.dataGridStat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.dataGridStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridStat.Location = new System.Drawing.Point(3, 50);
            this.dataGridStat.Name = "dataGridStat";
            this.dataGridStat.RowHeadersWidth = 51;
            this.dataGridStat.Size = new System.Drawing.Size(1008, 432);
            this.dataGridStat.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.tabPage2.Controls.Add(this.dtPickerTTList);
            this.tabPage2.Controls.Add(this.lblTimeTableMessage);
            this.tabPage2.Controls.Add(this.lblServiceMessage);
            this.tabPage2.Controls.Add(this.lblCustomersMessage);
            this.tabPage2.Controls.Add(this.lblEmpMessage);
            this.tabPage2.Controls.Add(this.btnCustomersPrint);
            this.tabPage2.Controls.Add(this.btnServicesPrint);
            this.tabPage2.Controls.Add(this.btnTimeTablePrint);
            this.tabPage2.Controls.Add(this.btnEmployeePrint);
            this.tabPage2.Controls.Add(this.btnCustomersSave);
            this.tabPage2.Controls.Add(this.btnTimeTableSave);
            this.tabPage2.Controls.Add(this.btnEmployeeSave);
            this.tabPage2.Controls.Add(this.btnServicesSave);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1014, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lists";
            // 
            // dtPickerTTList
            // 
            this.dtPickerTTList.CalendarFont = new System.Drawing.Font("Narkisim", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtPickerTTList.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtPickerTTList.Location = new System.Drawing.Point(428, 387);
            this.dtPickerTTList.Name = "dtPickerTTList";
            this.dtPickerTTList.Size = new System.Drawing.Size(137, 20);
            this.dtPickerTTList.TabIndex = 16;
            // 
            // lblTimeTableMessage
            // 
            this.lblTimeTableMessage.AutoSize = true;
            this.lblTimeTableMessage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimeTableMessage.ForeColor = System.Drawing.Color.Red;
            this.lblTimeTableMessage.Location = new System.Drawing.Point(105, 419);
            this.lblTimeTableMessage.Name = "lblTimeTableMessage";
            this.lblTimeTableMessage.Size = new System.Drawing.Size(0, 15);
            this.lblTimeTableMessage.TabIndex = 15;
            // 
            // lblServiceMessage
            // 
            this.lblServiceMessage.AutoSize = true;
            this.lblServiceMessage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lblServiceMessage.ForeColor = System.Drawing.Color.Red;
            this.lblServiceMessage.Location = new System.Drawing.Point(105, 316);
            this.lblServiceMessage.Name = "lblServiceMessage";
            this.lblServiceMessage.Size = new System.Drawing.Size(0, 15);
            this.lblServiceMessage.TabIndex = 14;
            // 
            // lblCustomersMessage
            // 
            this.lblCustomersMessage.AutoSize = true;
            this.lblCustomersMessage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomersMessage.ForeColor = System.Drawing.Color.Red;
            this.lblCustomersMessage.Location = new System.Drawing.Point(105, 202);
            this.lblCustomersMessage.Name = "lblCustomersMessage";
            this.lblCustomersMessage.Size = new System.Drawing.Size(0, 15);
            this.lblCustomersMessage.TabIndex = 13;
            // 
            // lblEmpMessage
            // 
            this.lblEmpMessage.AutoSize = true;
            this.lblEmpMessage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmpMessage.ForeColor = System.Drawing.Color.Red;
            this.lblEmpMessage.Location = new System.Drawing.Point(105, 96);
            this.lblEmpMessage.Name = "lblEmpMessage";
            this.lblEmpMessage.Size = new System.Drawing.Size(0, 15);
            this.lblEmpMessage.TabIndex = 12;
            // 
            // btnCustomersPrint
            // 
            this.btnCustomersPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnCustomersPrint.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnCustomersPrint.Location = new System.Drawing.Point(268, 161);
            this.btnCustomersPrint.Name = "btnCustomersPrint";
            this.btnCustomersPrint.Size = new System.Drawing.Size(154, 36);
            this.btnCustomersPrint.TabIndex = 4;
            this.btnCustomersPrint.Text = "Print";
            this.btnCustomersPrint.UseVisualStyleBackColor = false;
            this.btnCustomersPrint.Click += new System.EventHandler(this.btnCustomersPrint_Click);
            // 
            // btnServicesPrint
            // 
            this.btnServicesPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnServicesPrint.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnServicesPrint.Location = new System.Drawing.Point(268, 277);
            this.btnServicesPrint.Name = "btnServicesPrint";
            this.btnServicesPrint.Size = new System.Drawing.Size(154, 36);
            this.btnServicesPrint.TabIndex = 6;
            this.btnServicesPrint.Text = "Print";
            this.btnServicesPrint.UseVisualStyleBackColor = false;
            this.btnServicesPrint.Click += new System.EventHandler(this.btnServicesPrint_Click);
            // 
            // btnTimeTablePrint
            // 
            this.btnTimeTablePrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnTimeTablePrint.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnTimeTablePrint.Location = new System.Drawing.Point(268, 380);
            this.btnTimeTablePrint.Name = "btnTimeTablePrint";
            this.btnTimeTablePrint.Size = new System.Drawing.Size(154, 36);
            this.btnTimeTablePrint.TabIndex = 8;
            this.btnTimeTablePrint.Text = "Print";
            this.btnTimeTablePrint.UseVisualStyleBackColor = false;
            this.btnTimeTablePrint.Click += new System.EventHandler(this.btnTimeTablePrint_Click);
            // 
            // btnEmployeePrint
            // 
            this.btnEmployeePrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnEmployeePrint.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnEmployeePrint.Location = new System.Drawing.Point(268, 57);
            this.btnEmployeePrint.Name = "btnEmployeePrint";
            this.btnEmployeePrint.Size = new System.Drawing.Size(154, 36);
            this.btnEmployeePrint.TabIndex = 2;
            this.btnEmployeePrint.Text = "Print";
            this.btnEmployeePrint.UseVisualStyleBackColor = false;
            this.btnEmployeePrint.Click += new System.EventHandler(this.btnEmployeePrint_Click);
            // 
            // btnCustomersSave
            // 
            this.btnCustomersSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnCustomersSave.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnCustomersSave.Location = new System.Drawing.Point(108, 161);
            this.btnCustomersSave.Name = "btnCustomersSave";
            this.btnCustomersSave.Size = new System.Drawing.Size(154, 36);
            this.btnCustomersSave.TabIndex = 3;
            this.btnCustomersSave.Text = "Save";
            this.btnCustomersSave.UseVisualStyleBackColor = false;
            this.btnCustomersSave.Click += new System.EventHandler(this.btnCustomersSave_Click);
            // 
            // btnTimeTableSave
            // 
            this.btnTimeTableSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnTimeTableSave.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnTimeTableSave.Location = new System.Drawing.Point(108, 380);
            this.btnTimeTableSave.Name = "btnTimeTableSave";
            this.btnTimeTableSave.Size = new System.Drawing.Size(154, 36);
            this.btnTimeTableSave.TabIndex = 7;
            this.btnTimeTableSave.Text = "Save";
            this.btnTimeTableSave.UseVisualStyleBackColor = false;
            this.btnTimeTableSave.Click += new System.EventHandler(this.btnTimeTableSave_Click);
            // 
            // btnEmployeeSave
            // 
            this.btnEmployeeSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnEmployeeSave.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnEmployeeSave.Location = new System.Drawing.Point(108, 57);
            this.btnEmployeeSave.Name = "btnEmployeeSave";
            this.btnEmployeeSave.Size = new System.Drawing.Size(154, 36);
            this.btnEmployeeSave.TabIndex = 1;
            this.btnEmployeeSave.Text = "Save";
            this.btnEmployeeSave.UseVisualStyleBackColor = false;
            this.btnEmployeeSave.Click += new System.EventHandler(this.btnEmployeeSave_Click);
            // 
            // btnServicesSave
            // 
            this.btnServicesSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnServicesSave.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnServicesSave.Location = new System.Drawing.Point(108, 277);
            this.btnServicesSave.Name = "btnServicesSave";
            this.btnServicesSave.Size = new System.Drawing.Size(154, 36);
            this.btnServicesSave.TabIndex = 5;
            this.btnServicesSave.Text = "Save";
            this.btnServicesSave.UseVisualStyleBackColor = false;
            this.btnServicesSave.Click += new System.EventHandler(this.btnServicesSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(104, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(104, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Services";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(104, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emloyees";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.checkBoxSendMail);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.lblChecksMessage);
            this.tabPage1.Controls.Add(this.textBoxFilter);
            this.tabPage1.Controls.Add(this.btnPrint);
            this.tabPage1.Controls.Add(this.btnSaveCheck);
            this.tabPage1.Controls.Add(this.dataGridChecks);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Checks";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnRefresh.Location = new System.Drawing.Point(6, 360);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(45, 24);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "R";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // checkBoxSendMail
            // 
            this.checkBoxSendMail.AutoSize = true;
            this.checkBoxSendMail.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxSendMail.Location = new System.Drawing.Point(12, 533);
            this.checkBoxSendMail.Name = "checkBoxSendMail";
            this.checkBoxSendMail.Size = new System.Drawing.Size(175, 23);
            this.checkBoxSendMail.TabIndex = 24;
            this.checkBoxSendMail.Text = "Send To Customer";
            this.checkBoxSendMail.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(896, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Price";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(648, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "Service";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.76316F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.23684F));
            this.tableLayoutPanel2.Controls.Add(this.lblPrice, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblService, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(645, 494);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 33);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(222, 1);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 31);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.lblService.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblService.Location = new System.Drawing.Point(4, 1);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(84, 24);
            this.lblService.TabIndex = 13;
            this.lblService.Text = "Service";
            // 
            // lblChecksMessage
            // 
            this.lblChecksMessage.AutoSize = true;
            this.lblChecksMessage.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblChecksMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(28)))), ((int)(((byte)(8)))));
            this.lblChecksMessage.Location = new System.Drawing.Point(8, 411);
            this.lblChecksMessage.Name = "lblChecksMessage";
            this.lblChecksMessage.Size = new System.Drawing.Size(0, 22);
            this.lblChecksMessage.TabIndex = 5;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(8, 24);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter.TabIndex = 4;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnPrint.Location = new System.Drawing.Point(171, 491);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(154, 36);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSaveCheck
            // 
            this.btnSaveCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnSaveCheck.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnSaveCheck.Location = new System.Drawing.Point(11, 491);
            this.btnSaveCheck.Name = "btnSaveCheck";
            this.btnSaveCheck.Size = new System.Drawing.Size(154, 36);
            this.btnSaveCheck.TabIndex = 1;
            this.btnSaveCheck.Text = "Save";
            this.btnSaveCheck.UseVisualStyleBackColor = false;
            this.btnSaveCheck.Click += new System.EventHandler(this.btnSaveCheck_Click);
            // 
            // dataGridChecks
            // 
            this.dataGridChecks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridChecks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.dataGridChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChecks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridChecks.Location = new System.Drawing.Point(3, 50);
            this.dataGridChecks.Name = "dataGridChecks";
            this.dataGridChecks.RowHeadersWidth = 51;
            this.dataGridChecks.Size = new System.Drawing.Size(1008, 304);
            this.dataGridChecks.TabIndex = 2;
            this.dataGridChecks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChecks_CellClick);
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.tabPage1);
            this.tabReport.Controls.Add(this.tabPage2);
            this.tabReport.Controls.Add(this.tabPage4);
            this.tabReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReport.Location = new System.Drawing.Point(0, 33);
            this.tabReport.Name = "tabReport";
            this.tabReport.SelectedIndex = 0;
            this.tabReport.Size = new System.Drawing.Size(1022, 593);
            this.tabReport.TabIndex = 1;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1022, 626);
            this.Controls.Add(this.tabReport);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStat)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecks)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtPickerTo;
        private System.Windows.Forms.DateTimePicker dtPickerFrom;
        private System.Windows.Forms.Button btnPrintStatistic;
        private System.Windows.Forms.Button btnSaveStatistic;
        private System.Windows.Forms.DataGridView dataGridStat;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtPickerTTList;
        private System.Windows.Forms.Label lblTimeTableMessage;
        private System.Windows.Forms.Label lblServiceMessage;
        private System.Windows.Forms.Label lblCustomersMessage;
        private System.Windows.Forms.Label lblEmpMessage;
        private System.Windows.Forms.Button btnCustomersPrint;
        private System.Windows.Forms.Button btnServicesPrint;
        private System.Windows.Forms.Button btnTimeTablePrint;
        private System.Windows.Forms.Button btnEmployeePrint;
        private System.Windows.Forms.Button btnCustomersSave;
        private System.Windows.Forms.Button btnTimeTableSave;
        private System.Windows.Forms.Button btnEmployeeSave;
        private System.Windows.Forms.Button btnServicesSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridChecks;
        private System.Windows.Forms.Label lblChecksMessage;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSaveCheck;
        private System.Windows.Forms.TabControl tabReport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox comboBoxStat;
        private System.Windows.Forms.Label lblStatMessage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.CheckBox checkBoxSendMail;
    }
}