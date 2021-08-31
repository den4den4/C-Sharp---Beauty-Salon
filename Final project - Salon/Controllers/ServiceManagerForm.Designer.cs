namespace Final_project___Salon
{
    partial class ServiceManagerForm
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
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.servicePanel = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblExecutingTime = new System.Windows.Forms.Label();
            this.textBoxExecutingTime = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.btnServiceUpdate = new System.Windows.Forms.Button();
            this.btnServiceDel = new System.Windows.Forms.Button();
            this.btnServiceInsert = new System.Windows.Forms.Button();
            this.btnSearchService = new System.Windows.Forms.Button();
            this.textBoxSearchService = new System.Windows.Forms.TextBox();
            this.servicesDataGrid = new System.Windows.Forms.DataGridView();
            this.servicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.ServiceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServiceLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.ServiceLabel.Location = new System.Drawing.Point(0, 0);
            this.ServiceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(993, 41);
            this.ServiceLabel.TabIndex = 9;
            this.ServiceLabel.Text = "Services Manager";
            this.ServiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // servicePanel
            // 
            this.servicePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.servicePanel.Controls.Add(this.ClearButton);
            this.servicePanel.Controls.Add(this.lblWarning);
            this.servicePanel.Controls.Add(this.lblExecutingTime);
            this.servicePanel.Controls.Add(this.textBoxExecutingTime);
            this.servicePanel.Controls.Add(this.lblServiceName);
            this.servicePanel.Controls.Add(this.lblPrice);
            this.servicePanel.Controls.Add(this.textBoxServiceName);
            this.servicePanel.Controls.Add(this.textBoxPrice);
            this.servicePanel.Controls.Add(this.btnServiceUpdate);
            this.servicePanel.Controls.Add(this.btnServiceDel);
            this.servicePanel.Controls.Add(this.btnServiceInsert);
            this.servicePanel.Controls.Add(this.btnSearchService);
            this.servicePanel.Controls.Add(this.textBoxSearchService);
            this.servicePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.servicePanel.Location = new System.Drawing.Point(0, 41);
            this.servicePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Size = new System.Drawing.Size(388, 561);
            this.servicePanel.TabIndex = 11;
            this.servicePanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.servicePanel_MouseDoubleClick);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ClearButton.Location = new System.Drawing.Point(308, 253);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 34);
            this.ClearButton.TabIndex = 42;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(28)))), ((int)(((byte)(8)))));
            this.lblWarning.Location = new System.Drawing.Point(12, 223);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(15, 19);
            this.lblWarning.TabIndex = 41;
            this.lblWarning.Text = "*";
            // 
            // lblExecutingTime
            // 
            this.lblExecutingTime.AutoSize = true;
            this.lblExecutingTime.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblExecutingTime.Location = new System.Drawing.Point(26, 180);
            this.lblExecutingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExecutingTime.Name = "lblExecutingTime";
            this.lblExecutingTime.Size = new System.Drawing.Size(111, 19);
            this.lblExecutingTime.TabIndex = 38;
            this.lblExecutingTime.Text = "Executing Time";
            // 
            // textBoxExecutingTime
            // 
            this.textBoxExecutingTime.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.textBoxExecutingTime.Location = new System.Drawing.Point(138, 180);
            this.textBoxExecutingTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxExecutingTime.Name = "textBoxExecutingTime";
            this.textBoxExecutingTime.Size = new System.Drawing.Size(198, 24);
            this.textBoxExecutingTime.TabIndex = 6;
            this.textBoxExecutingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxExecutingTime.TextChanged += new System.EventHandler(this.textBoxExecutingTime_TextChanged);
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblServiceName.Location = new System.Drawing.Point(26, 124);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(51, 19);
            this.lblServiceName.TabIndex = 34;
            this.lblServiceName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblPrice.Location = new System.Drawing.Point(26, 152);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 19);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Price";
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.textBoxServiceName.Location = new System.Drawing.Point(138, 124);
            this.textBoxServiceName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(198, 24);
            this.textBoxServiceName.TabIndex = 4;
            this.textBoxServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxServiceName.TextChanged += new System.EventHandler(this.textBoxServiceName_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.textBoxPrice.Location = new System.Drawing.Point(138, 152);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(198, 24);
            this.textBoxPrice.TabIndex = 5;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // btnServiceUpdate
            // 
            this.btnServiceUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnServiceUpdate.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnServiceUpdate.Location = new System.Drawing.Point(116, 253);
            this.btnServiceUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnServiceUpdate.Name = "btnServiceUpdate";
            this.btnServiceUpdate.Size = new System.Drawing.Size(74, 34);
            this.btnServiceUpdate.TabIndex = 8;
            this.btnServiceUpdate.Text = "Update";
            this.btnServiceUpdate.UseVisualStyleBackColor = false;
            this.btnServiceUpdate.Click += new System.EventHandler(this.btnServiceUpdate_Click);
            // 
            // btnServiceDel
            // 
            this.btnServiceDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.btnServiceDel.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnServiceDel.Location = new System.Drawing.Point(216, 253);
            this.btnServiceDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnServiceDel.Name = "btnServiceDel";
            this.btnServiceDel.Size = new System.Drawing.Size(75, 34);
            this.btnServiceDel.TabIndex = 9;
            this.btnServiceDel.Text = "Delete ";
            this.btnServiceDel.UseVisualStyleBackColor = false;
            this.btnServiceDel.Click += new System.EventHandler(this.btnServiceDel_Click);
            // 
            // btnServiceInsert
            // 
            this.btnServiceInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnServiceInsert.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnServiceInsert.Location = new System.Drawing.Point(11, 253);
            this.btnServiceInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnServiceInsert.Name = "btnServiceInsert";
            this.btnServiceInsert.Size = new System.Drawing.Size(74, 34);
            this.btnServiceInsert.TabIndex = 7;
            this.btnServiceInsert.Text = "Insert ";
            this.btnServiceInsert.UseVisualStyleBackColor = false;
            this.btnServiceInsert.Click += new System.EventHandler(this.btnServiceInsert_Click);
            // 
            // btnSearchService
            // 
            this.btnSearchService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.btnSearchService.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.btnSearchService.Location = new System.Drawing.Point(230, 29);
            this.btnSearchService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchService.Name = "btnSearchService";
            this.btnSearchService.Size = new System.Drawing.Size(90, 23);
            this.btnSearchService.TabIndex = 2;
            this.btnSearchService.Text = "Search";
            this.btnSearchService.UseVisualStyleBackColor = false;
            this.btnSearchService.Click += new System.EventHandler(this.btnSearchService_Click);
            // 
            // textBoxSearchService
            // 
            this.textBoxSearchService.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.textBoxSearchService.Location = new System.Drawing.Point(29, 29);
            this.textBoxSearchService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearchService.Name = "textBoxSearchService";
            this.textBoxSearchService.Size = new System.Drawing.Size(198, 24);
            this.textBoxSearchService.TabIndex = 1;
            this.textBoxSearchService.TextChanged += new System.EventHandler(this.textBoxSearchService_TextChanged);
            // 
            // servicesDataGrid
            // 
            this.servicesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.servicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesDataGrid.Location = new System.Drawing.Point(388, 41);
            this.servicesDataGrid.Name = "servicesDataGrid";
            this.servicesDataGrid.RowHeadersWidth = 51;
            this.servicesDataGrid.Size = new System.Drawing.Size(605, 561);
            this.servicesDataGrid.TabIndex = 12;
            this.servicesDataGrid.DoubleClick += new System.EventHandler(this.servicesDataGrid_DoubleClick);
            // 
            // ServiceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(993, 602);
            this.Controls.Add(this.servicesDataGrid);
            this.Controls.Add(this.servicePanel);
            this.Controls.Add(this.ServiceLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ServiceManagerForm";
            this.Text = "ServiceManagerForm";
            this.Load += new System.EventHandler(this.ServiceManagerForm_Load);
            this.servicePanel.ResumeLayout(false);
            this.servicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ServiceLabel;
        private System.Windows.Forms.Panel servicePanel;
        private System.Windows.Forms.Button btnSearchService;
        private System.Windows.Forms.TextBox textBoxSearchService;
        private System.Windows.Forms.Button btnServiceUpdate;
        private System.Windows.Forms.Button btnServiceDel;
        private System.Windows.Forms.Button btnServiceInsert;
        private System.Windows.Forms.Label lblExecutingTime;
        private System.Windows.Forms.TextBox textBoxExecutingTime;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.DataGridView servicesDataGrid;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button ClearButton;
    }
}