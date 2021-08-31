namespace Final_project___Salon
{
    partial class Scueduling
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ShoByPayingComboBox = new System.Windows.Forms.ComboBox();
            this.ShowByPayingLabel = new System.Windows.Forms.Label();
            this.SearchByCalendarblWarning = new System.Windows.Forms.Label();
            this.SearchStringLblWarning = new System.Windows.Forms.Label();
            this.EmployeeLblWarning = new System.Windows.Forms.Label();
            this.EmployeeFullNameComboBox = new System.Windows.Forms.ComboBox();
            this.EmployeeFullNameLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SearchByDateButton = new System.Windows.Forms.Button();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SearchTimetableButton = new System.Windows.Forms.Button();
            this.SearchTimetableTextBox = new System.Windows.Forms.TextBox();
            this.InsertTimetableButton = new System.Windows.Forms.Button();
            this.BasketLabel = new System.Windows.Forms.Label();
            this.BasketPanelMain = new System.Windows.Forms.Panel();
            this.NotPaidPanel = new System.Windows.Forms.Panel();
            this.NotPaidLabel = new System.Windows.Forms.Label();
            this.BasketTextBox = new System.Windows.Forms.TextBox();
            this.ResultBasketPanel = new System.Windows.Forms.Panel();
            this.TotalSumLabel = new System.Windows.Forms.Label();
            this.TotalSumStaticLabel = new System.Windows.Forms.Label();
            this.EstimateTimeLabel = new System.Windows.Forms.Label();
            this.estimatestatilabel = new System.Windows.Forms.Label();
            this.ButtonBasketPanel = new System.Windows.Forms.Panel();
            this.AddBasketButton = new System.Windows.Forms.Button();
            this.CleanBasketButton = new System.Windows.Forms.Button();
            this.ClientNamePanel = new System.Windows.Forms.Panel();
            this.CustomerNameLabelFromStringArray = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TimetableDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.BasketPanelMain.SuspendLayout();
            this.NotPaidPanel.SuspendLayout();
            this.ResultBasketPanel.SuspendLayout();
            this.ButtonBasketPanel.SuspendLayout();
            this.ClientNamePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimetableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.MainPanel);
            this.panel1.Controls.Add(this.BasketLabel);
            this.panel1.Controls.Add(this.BasketPanelMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 993);
            this.panel1.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.InsertTimetableButton);
            this.MainPanel.Controls.Add(this.ShoByPayingComboBox);
            this.MainPanel.Controls.Add(this.ShowByPayingLabel);
            this.MainPanel.Controls.Add(this.SearchByCalendarblWarning);
            this.MainPanel.Controls.Add(this.SearchStringLblWarning);
            this.MainPanel.Controls.Add(this.EmployeeLblWarning);
            this.MainPanel.Controls.Add(this.EmployeeFullNameComboBox);
            this.MainPanel.Controls.Add(this.EmployeeFullNameLabel);
            this.MainPanel.Controls.Add(this.CancelButton);
            this.MainPanel.Controls.Add(this.SearchByDateButton);
            this.MainPanel.Controls.Add(this.MonthCalendar);
            this.MainPanel.Controls.Add(this.SearchTimetableButton);
            this.MainPanel.Controls.Add(this.SearchTimetableTextBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(589, 712);
            this.MainPanel.TabIndex = 73;
            // 
            // ShoByPayingComboBox
            // 
            this.ShoByPayingComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.ShoByPayingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShoByPayingComboBox.FormattingEnabled = true;
            this.ShoByPayingComboBox.Items.AddRange(new object[] {
            "payed",
            "not payed"});
            this.ShoByPayingComboBox.Location = new System.Drawing.Point(317, 355);
            this.ShoByPayingComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShoByPayingComboBox.Name = "ShoByPayingComboBox";
            this.ShoByPayingComboBox.Size = new System.Drawing.Size(217, 28);
            this.ShoByPayingComboBox.TabIndex = 95;
            this.ShoByPayingComboBox.Text = "select records";
            this.ShoByPayingComboBox.SelectedIndexChanged += new System.EventHandler(this.ShoByPayingComboBox_SelectedIndexChanged);
            // 
            // ShowByPayingLabel
            // 
            this.ShowByPayingLabel.AutoSize = true;
            this.ShowByPayingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ShowByPayingLabel.Location = new System.Drawing.Point(27, 359);
            this.ShowByPayingLabel.Name = "ShowByPayingLabel";
            this.ShowByPayingLabel.Size = new System.Drawing.Size(227, 24);
            this.ShowByPayingLabel.TabIndex = 94;
            this.ShowByPayingLabel.Text = "Show schedule by paying";
            // 
            // SearchByCalendarblWarning
            // 
            this.SearchByCalendarblWarning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchByCalendarblWarning.AutoSize = true;
            this.SearchByCalendarblWarning.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.SearchByCalendarblWarning.ForeColor = System.Drawing.Color.Red;
            this.SearchByCalendarblWarning.Location = new System.Drawing.Point(52, 286);
            this.SearchByCalendarblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchByCalendarblWarning.Name = "SearchByCalendarblWarning";
            this.SearchByCalendarblWarning.Size = new System.Drawing.Size(16, 17);
            this.SearchByCalendarblWarning.TabIndex = 93;
            this.SearchByCalendarblWarning.Text = "*";
            // 
            // SearchStringLblWarning
            // 
            this.SearchStringLblWarning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchStringLblWarning.AutoSize = true;
            this.SearchStringLblWarning.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.SearchStringLblWarning.ForeColor = System.Drawing.Color.Red;
            this.SearchStringLblWarning.Location = new System.Drawing.Point(52, 44);
            this.SearchStringLblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchStringLblWarning.Name = "SearchStringLblWarning";
            this.SearchStringLblWarning.Size = new System.Drawing.Size(16, 17);
            this.SearchStringLblWarning.TabIndex = 92;
            this.SearchStringLblWarning.Text = "*";
            // 
            // EmployeeLblWarning
            // 
            this.EmployeeLblWarning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmployeeLblWarning.AutoSize = true;
            this.EmployeeLblWarning.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.EmployeeLblWarning.ForeColor = System.Drawing.Color.Red;
            this.EmployeeLblWarning.Location = new System.Drawing.Point(43, 450);
            this.EmployeeLblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeLblWarning.Name = "EmployeeLblWarning";
            this.EmployeeLblWarning.Size = new System.Drawing.Size(16, 17);
            this.EmployeeLblWarning.TabIndex = 91;
            this.EmployeeLblWarning.Text = "*";
            // 
            // EmployeeFullNameComboBox
            // 
            this.EmployeeFullNameComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.EmployeeFullNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeFullNameComboBox.FormattingEnabled = true;
            this.EmployeeFullNameComboBox.Location = new System.Drawing.Point(317, 410);
            this.EmployeeFullNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeFullNameComboBox.Name = "EmployeeFullNameComboBox";
            this.EmployeeFullNameComboBox.Size = new System.Drawing.Size(217, 28);
            this.EmployeeFullNameComboBox.TabIndex = 90;
            this.EmployeeFullNameComboBox.Text = "select name";
            this.EmployeeFullNameComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeFullNameComboBox_SelectedIndexChanged);
            // 
            // EmployeeFullNameLabel
            // 
            this.EmployeeFullNameLabel.AutoSize = true;
            this.EmployeeFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeFullNameLabel.Location = new System.Drawing.Point(23, 410);
            this.EmployeeFullNameLabel.Name = "EmployeeFullNameLabel";
            this.EmployeeFullNameLabel.Size = new System.Drawing.Size(260, 24);
            this.EmployeeFullNameLabel.TabIndex = 89;
            this.EmployeeFullNameLabel.Text = "Show schedule by employee ";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.CancelButton.Location = new System.Drawing.Point(303, 308);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(261, 37);
            this.CancelButton.TabIndex = 88;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SearchByDateButton
            // 
            this.SearchByDateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.SearchByDateButton.Location = new System.Drawing.Point(31, 308);
            this.SearchByDateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchByDateButton.Name = "SearchByDateButton";
            this.SearchByDateButton.Size = new System.Drawing.Size(236, 37);
            this.SearchByDateButton.TabIndex = 87;
            this.SearchByDateButton.Text = "Search by date ";
            this.SearchByDateButton.UseVisualStyleBackColor = false;
            this.SearchByDateButton.Click += new System.EventHandler(this.SearchByDateButton_Click);
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.MonthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.MonthCalendar.Location = new System.Drawing.Point(55, 70);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 86;
            // 
            // SearchTimetableButton
            // 
            this.SearchTimetableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.SearchTimetableButton.Location = new System.Drawing.Point(413, 16);
            this.SearchTimetableButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTimetableButton.Name = "SearchTimetableButton";
            this.SearchTimetableButton.Size = new System.Drawing.Size(151, 28);
            this.SearchTimetableButton.TabIndex = 85;
            this.SearchTimetableButton.Text = "Search";
            this.SearchTimetableButton.UseVisualStyleBackColor = false;
            this.SearchTimetableButton.Click += new System.EventHandler(this.SearchTimetableButton_Click);
            // 
            // SearchTimetableTextBox
            // 
            this.SearchTimetableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTimetableTextBox.Location = new System.Drawing.Point(46, 14);
            this.SearchTimetableTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTimetableTextBox.Name = "SearchTimetableTextBox";
            this.SearchTimetableTextBox.Size = new System.Drawing.Size(303, 28);
            this.SearchTimetableTextBox.TabIndex = 84;
            this.SearchTimetableTextBox.TextChanged += new System.EventHandler(this.SearchTimetableTextBox_TextChanged);
            // 
            // InsertTimetableButton
            // 
            this.InsertTimetableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.InsertTimetableButton.Location = new System.Drawing.Point(27, 469);
            this.InsertTimetableButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertTimetableButton.Name = "InsertTimetableButton";
            this.InsertTimetableButton.Size = new System.Drawing.Size(513, 38);
            this.InsertTimetableButton.TabIndex = 83;
            this.InsertTimetableButton.Text = "Insert";
            this.InsertTimetableButton.UseVisualStyleBackColor = false;
            this.InsertTimetableButton.Click += new System.EventHandler(this.InsertTimetableButton_Click);
            // 
            // BasketLabel
            // 
            this.BasketLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BasketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BasketLabel.Location = new System.Drawing.Point(0, 712);
            this.BasketLabel.Name = "BasketLabel";
            this.BasketLabel.Size = new System.Drawing.Size(589, 28);
            this.BasketLabel.TabIndex = 2;
            this.BasketLabel.Text = "Basket by customer ";
            this.BasketLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BasketPanelMain
            // 
            this.BasketPanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BasketPanelMain.Controls.Add(this.NotPaidPanel);
            this.BasketPanelMain.Controls.Add(this.BasketTextBox);
            this.BasketPanelMain.Controls.Add(this.ResultBasketPanel);
            this.BasketPanelMain.Controls.Add(this.ButtonBasketPanel);
            this.BasketPanelMain.Controls.Add(this.ClientNamePanel);
            this.BasketPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BasketPanelMain.Location = new System.Drawing.Point(0, 740);
            this.BasketPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BasketPanelMain.Name = "BasketPanelMain";
            this.BasketPanelMain.Size = new System.Drawing.Size(589, 253);
            this.BasketPanelMain.TabIndex = 72;
            // 
            // NotPaidPanel
            // 
            this.NotPaidPanel.Controls.Add(this.NotPaidLabel);
            this.NotPaidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotPaidPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.NotPaidPanel.Location = new System.Drawing.Point(0, 48);
            this.NotPaidPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NotPaidPanel.Name = "NotPaidPanel";
            this.NotPaidPanel.Size = new System.Drawing.Size(585, 30);
            this.NotPaidPanel.TabIndex = 7;
            // 
            // NotPaidLabel
            // 
            this.NotPaidLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotPaidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotPaidLabel.Location = new System.Drawing.Point(0, 0);
            this.NotPaidLabel.Name = "NotPaidLabel";
            this.NotPaidLabel.Size = new System.Drawing.Size(585, 30);
            this.NotPaidLabel.TabIndex = 0;
            this.NotPaidLabel.Text = "Not paid services:";
            this.NotPaidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BasketTextBox
            // 
            this.BasketTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BasketTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BasketTextBox.Location = new System.Drawing.Point(0, 78);
            this.BasketTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BasketTextBox.Multiline = true;
            this.BasketTextBox.Name = "BasketTextBox";
            this.BasketTextBox.ReadOnly = true;
            this.BasketTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BasketTextBox.Size = new System.Drawing.Size(585, 83);
            this.BasketTextBox.TabIndex = 5;
            // 
            // ResultBasketPanel
            // 
            this.ResultBasketPanel.Controls.Add(this.TotalSumLabel);
            this.ResultBasketPanel.Controls.Add(this.TotalSumStaticLabel);
            this.ResultBasketPanel.Controls.Add(this.EstimateTimeLabel);
            this.ResultBasketPanel.Controls.Add(this.estimatestatilabel);
            this.ResultBasketPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResultBasketPanel.Location = new System.Drawing.Point(0, 161);
            this.ResultBasketPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultBasketPanel.Name = "ResultBasketPanel";
            this.ResultBasketPanel.Size = new System.Drawing.Size(585, 46);
            this.ResultBasketPanel.TabIndex = 6;
            // 
            // TotalSumLabel
            // 
            this.TotalSumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalSumLabel.Location = new System.Drawing.Point(416, 0);
            this.TotalSumLabel.Name = "TotalSumLabel";
            this.TotalSumLabel.Size = new System.Drawing.Size(169, 46);
            this.TotalSumLabel.TabIndex = 4;
            this.TotalSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalSumStaticLabel
            // 
            this.TotalSumStaticLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TotalSumStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TotalSumStaticLabel.Location = new System.Drawing.Point(299, 0);
            this.TotalSumStaticLabel.Name = "TotalSumStaticLabel";
            this.TotalSumStaticLabel.Size = new System.Drawing.Size(117, 46);
            this.TotalSumStaticLabel.TabIndex = 3;
            this.TotalSumStaticLabel.Text = "Total sum:";
            this.TotalSumStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EstimateTimeLabel
            // 
            this.EstimateTimeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EstimateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EstimateTimeLabel.Location = new System.Drawing.Point(155, 0);
            this.EstimateTimeLabel.Name = "EstimateTimeLabel";
            this.EstimateTimeLabel.Size = new System.Drawing.Size(144, 46);
            this.EstimateTimeLabel.TabIndex = 2;
            this.EstimateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // estimatestatilabel
            // 
            this.estimatestatilabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.estimatestatilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.estimatestatilabel.Location = new System.Drawing.Point(0, 0);
            this.estimatestatilabel.Name = "estimatestatilabel";
            this.estimatestatilabel.Size = new System.Drawing.Size(155, 46);
            this.estimatestatilabel.TabIndex = 0;
            this.estimatestatilabel.Text = "Estimate time:";
            this.estimatestatilabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonBasketPanel
            // 
            this.ButtonBasketPanel.Controls.Add(this.AddBasketButton);
            this.ButtonBasketPanel.Controls.Add(this.CleanBasketButton);
            this.ButtonBasketPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonBasketPanel.Location = new System.Drawing.Point(0, 207);
            this.ButtonBasketPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBasketPanel.Name = "ButtonBasketPanel";
            this.ButtonBasketPanel.Size = new System.Drawing.Size(585, 42);
            this.ButtonBasketPanel.TabIndex = 4;
            // 
            // AddBasketButton
            // 
            this.AddBasketButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddBasketButton.Enabled = false;
            this.AddBasketButton.Location = new System.Drawing.Point(0, 0);
            this.AddBasketButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBasketButton.Name = "AddBasketButton";
            this.AddBasketButton.Size = new System.Drawing.Size(125, 42);
            this.AddBasketButton.TabIndex = 0;
            this.AddBasketButton.Text = "Pay";
            this.AddBasketButton.UseVisualStyleBackColor = true;
            this.AddBasketButton.Click += new System.EventHandler(this.AddBasketButton_Click);
            // 
            // CleanBasketButton
            // 
            this.CleanBasketButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CleanBasketButton.Location = new System.Drawing.Point(449, 0);
            this.CleanBasketButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CleanBasketButton.Name = "CleanBasketButton";
            this.CleanBasketButton.Size = new System.Drawing.Size(136, 42);
            this.CleanBasketButton.TabIndex = 1;
            this.CleanBasketButton.Text = "Drop basket";
            this.CleanBasketButton.UseVisualStyleBackColor = true;
            this.CleanBasketButton.Click += new System.EventHandler(this.CleanBasketButton_Click);
            // 
            // ClientNamePanel
            // 
            this.ClientNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientNamePanel.Controls.Add(this.CustomerNameLabelFromStringArray);
            this.ClientNamePanel.Controls.Add(this.ClientNameLabel);
            this.ClientNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientNamePanel.Location = new System.Drawing.Point(0, 0);
            this.ClientNamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientNamePanel.Name = "ClientNamePanel";
            this.ClientNamePanel.Size = new System.Drawing.Size(585, 48);
            this.ClientNamePanel.TabIndex = 2;
            // 
            // CustomerNameLabelFromStringArray
            // 
            this.CustomerNameLabelFromStringArray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerNameLabelFromStringArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.CustomerNameLabelFromStringArray.Location = new System.Drawing.Point(299, 0);
            this.CustomerNameLabelFromStringArray.Name = "CustomerNameLabelFromStringArray";
            this.CustomerNameLabelFromStringArray.Size = new System.Drawing.Size(284, 46);
            this.CustomerNameLabelFromStringArray.TabIndex = 1;
            this.CustomerNameLabelFromStringArray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ClientNameLabel.Location = new System.Drawing.Point(0, 0);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(299, 46);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Customer name:";
            this.ClientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1741, 62);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1741, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timetable";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TimetableDataGridView);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1741, 993);
            this.panel3.TabIndex = 3;
            // 
            // TimetableDataGridView
            // 
            this.TimetableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TimetableDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.TimetableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimetableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimetableDataGridView.Location = new System.Drawing.Point(589, 0);
            this.TimetableDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimetableDataGridView.Name = "TimetableDataGridView";
            this.TimetableDataGridView.RowHeadersWidth = 51;
            this.TimetableDataGridView.RowTemplate.Height = 24;
            this.TimetableDataGridView.Size = new System.Drawing.Size(1152, 993);
            this.TimetableDataGridView.TabIndex = 2;
            this.TimetableDataGridView.Click += new System.EventHandler(this.TimetableDataGridView_Click);
            this.TimetableDataGridView.DoubleClick += new System.EventHandler(this.TimetableDataGridView_DoubleClick);
            // 
            // Scueduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1741, 1055);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Scueduling";
            this.Text = "Scueduling";
            this.panel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.BasketPanelMain.ResumeLayout(false);
            this.BasketPanelMain.PerformLayout();
            this.NotPaidPanel.ResumeLayout(false);
            this.ResultBasketPanel.ResumeLayout(false);
            this.ButtonBasketPanel.ResumeLayout(false);
            this.ClientNamePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimetableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView TimetableDataGridView;
        private System.Windows.Forms.Label BasketLabel;
        private System.Windows.Forms.Panel BasketPanelMain;
        private System.Windows.Forms.Panel ClientNamePanel;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Button CleanBasketButton;
        private System.Windows.Forms.Button AddBasketButton;
        private System.Windows.Forms.Label CustomerNameLabelFromStringArray;
        private System.Windows.Forms.Panel ResultBasketPanel;
        private System.Windows.Forms.Label estimatestatilabel;
        private System.Windows.Forms.TextBox BasketTextBox;
        private System.Windows.Forms.Panel ButtonBasketPanel;
        private System.Windows.Forms.Panel NotPaidPanel;
        private System.Windows.Forms.Label NotPaidLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label SearchByCalendarblWarning;
        private System.Windows.Forms.Label SearchStringLblWarning;
        private System.Windows.Forms.Label EmployeeLblWarning;
        private System.Windows.Forms.ComboBox EmployeeFullNameComboBox;
        private System.Windows.Forms.Label EmployeeFullNameLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SearchByDateButton;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.Button SearchTimetableButton;
        private System.Windows.Forms.TextBox SearchTimetableTextBox;
        private System.Windows.Forms.Button InsertTimetableButton;
        private System.Windows.Forms.Label EstimateTimeLabel;
        private System.Windows.Forms.Label TotalSumLabel;
        private System.Windows.Forms.Label TotalSumStaticLabel;
        private System.Windows.Forms.ComboBox ShoByPayingComboBox;
        private System.Windows.Forms.Label ShowByPayingLabel;
    }
}