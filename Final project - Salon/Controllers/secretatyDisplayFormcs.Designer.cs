namespace Final_project___Salon
{
    partial class secretaryDisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(secretaryDisplayForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.BurgerMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.ServiceManagerPictureBox = new System.Windows.Forms.PictureBox();
            this.ServiceManagerButton = new System.Windows.Forms.Button();
            this.ClientsPictureBox = new System.Windows.Forms.PictureBox();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.SchuedulingPictureBox = new System.Windows.Forms.PictureBox();
            this.ScuedulingButton = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.SettingsPictureBox = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.LogOutPictureBox = new System.Windows.Forms.PictureBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.HomePictureBox = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.WorkspaceMainPanel = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BurgerMenuPictureBox)).BeginInit();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceManagerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchuedulingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.panelHeader.Controls.Add(this.BurgerMenuPictureBox);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1443, 37);
            this.panelHeader.TabIndex = 2;
            // 
            // BurgerMenuPictureBox
            // 
            this.BurgerMenuPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BurgerMenuPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BurgerMenuPictureBox.Image")));
            this.BurgerMenuPictureBox.Location = new System.Drawing.Point(135, 3);
            this.BurgerMenuPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BurgerMenuPictureBox.Name = "BurgerMenuPictureBox";
            this.BurgerMenuPictureBox.Size = new System.Drawing.Size(31, 32);
            this.BurgerMenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BurgerMenuPictureBox.TabIndex = 4;
            this.BurgerMenuPictureBox.TabStop = false;
            this.BurgerMenuPictureBox.Click += new System.EventHandler(this.BurgerMenuPictureBox_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Secretary Dashboard";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.panelSidebar.Controls.Add(this.ServiceManagerPictureBox);
            this.panelSidebar.Controls.Add(this.ServiceManagerButton);
            this.panelSidebar.Controls.Add(this.ClientsPictureBox);
            this.panelSidebar.Controls.Add(this.ClientsButton);
            this.panelSidebar.Controls.Add(this.SchuedulingPictureBox);
            this.panelSidebar.Controls.Add(this.ScuedulingButton);
            this.panelSidebar.Controls.Add(this.pictureBox7);
            this.panelSidebar.Controls.Add(this.SettingsPictureBox);
            this.panelSidebar.Controls.Add(this.SettingsButton);
            this.panelSidebar.Controls.Add(this.LogOutPictureBox);
            this.panelSidebar.Controls.Add(this.logOutButton);
            this.panelSidebar.Controls.Add(this.HomePictureBox);
            this.panelSidebar.Controls.Add(this.homeButton);
            this.panelSidebar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 37);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(166, 724);
            this.panelSidebar.TabIndex = 3;
            // 
            // ServiceManagerPictureBox
            // 
            this.ServiceManagerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServiceManagerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ServiceManagerPictureBox.Image")));
            this.ServiceManagerPictureBox.Location = new System.Drawing.Point(6, 263);
            this.ServiceManagerPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceManagerPictureBox.Name = "ServiceManagerPictureBox";
            this.ServiceManagerPictureBox.Size = new System.Drawing.Size(30, 32);
            this.ServiceManagerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ServiceManagerPictureBox.TabIndex = 24;
            this.ServiceManagerPictureBox.TabStop = false;
            this.ServiceManagerPictureBox.Click += new System.EventHandler(this.ServiceManagerPictureBox_Click);
            // 
            // ServiceManagerButton
            // 
            this.ServiceManagerButton.BackColor = System.Drawing.Color.White;
            this.ServiceManagerButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ServiceManagerButton.Location = new System.Drawing.Point(47, 262);
            this.ServiceManagerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceManagerButton.Name = "ServiceManagerButton";
            this.ServiceManagerButton.Size = new System.Drawing.Size(109, 32);
            this.ServiceManagerButton.TabIndex = 21;
            this.ServiceManagerButton.Text = "Services";
            this.ServiceManagerButton.UseVisualStyleBackColor = false;
            this.ServiceManagerButton.Click += new System.EventHandler(this.ServiceManagerButton_Click);
            // 
            // ClientsPictureBox
            // 
            this.ClientsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClientsPictureBox.Image")));
            this.ClientsPictureBox.Location = new System.Drawing.Point(6, 150);
            this.ClientsPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientsPictureBox.Name = "ClientsPictureBox";
            this.ClientsPictureBox.Size = new System.Drawing.Size(30, 32);
            this.ClientsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClientsPictureBox.TabIndex = 20;
            this.ClientsPictureBox.TabStop = false;
            this.ClientsPictureBox.Click += new System.EventHandler(this.ClientsPictureBox_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.BackColor = System.Drawing.Color.White;
            this.ClientsButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ClientsButton.Location = new System.Drawing.Point(47, 150);
            this.ClientsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(109, 32);
            this.ClientsButton.TabIndex = 19;
            this.ClientsButton.Text = "Clients";
            this.ClientsButton.UseVisualStyleBackColor = false;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // SchuedulingPictureBox
            // 
            this.SchuedulingPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SchuedulingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SchuedulingPictureBox.Image")));
            this.SchuedulingPictureBox.Location = new System.Drawing.Point(6, 188);
            this.SchuedulingPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SchuedulingPictureBox.Name = "SchuedulingPictureBox";
            this.SchuedulingPictureBox.Size = new System.Drawing.Size(30, 32);
            this.SchuedulingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SchuedulingPictureBox.TabIndex = 17;
            this.SchuedulingPictureBox.TabStop = false;
            this.SchuedulingPictureBox.Click += new System.EventHandler(this.SchuedulingPictureBox_Click);
            // 
            // ScuedulingButton
            // 
            this.ScuedulingButton.BackColor = System.Drawing.Color.White;
            this.ScuedulingButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ScuedulingButton.Location = new System.Drawing.Point(47, 188);
            this.ScuedulingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScuedulingButton.Name = "ScuedulingButton";
            this.ScuedulingButton.Size = new System.Drawing.Size(109, 32);
            this.ScuedulingButton.TabIndex = 15;
            this.ScuedulingButton.Text = "Squeduling";
            this.ScuedulingButton.UseVisualStyleBackColor = false;
            this.ScuedulingButton.Click += new System.EventHandler(this.ScuedulingButton_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(14, 4);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(148, 83);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // SettingsPictureBox
            // 
            this.SettingsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SettingsPictureBox.Image")));
            this.SettingsPictureBox.Location = new System.Drawing.Point(6, 226);
            this.SettingsPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingsPictureBox.Name = "SettingsPictureBox";
            this.SettingsPictureBox.Size = new System.Drawing.Size(30, 32);
            this.SettingsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsPictureBox.TabIndex = 10;
            this.SettingsPictureBox.TabStop = false;
            this.SettingsPictureBox.Click += new System.EventHandler(this.SettingsPictureBox_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.White;
            this.SettingsButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.SettingsButton.Location = new System.Drawing.Point(47, 226);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(109, 32);
            this.SettingsButton.TabIndex = 9;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // LogOutPictureBox
            // 
            this.LogOutPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogOutPictureBox.Image")));
            this.LogOutPictureBox.Location = new System.Drawing.Point(6, 657);
            this.LogOutPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogOutPictureBox.Name = "LogOutPictureBox";
            this.LogOutPictureBox.Size = new System.Drawing.Size(30, 32);
            this.LogOutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogOutPictureBox.TabIndex = 7;
            this.LogOutPictureBox.TabStop = false;
            this.LogOutPictureBox.Click += new System.EventHandler(this.LogOutPictureBox_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.logOutButton.Location = new System.Drawing.Point(47, 657);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(109, 32);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // HomePictureBox
            // 
            this.HomePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HomePictureBox.Image")));
            this.HomePictureBox.Location = new System.Drawing.Point(6, 113);
            this.HomePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomePictureBox.Name = "HomePictureBox";
            this.HomePictureBox.Size = new System.Drawing.Size(30, 32);
            this.HomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomePictureBox.TabIndex = 3;
            this.HomePictureBox.TabStop = false;
            this.HomePictureBox.Click += new System.EventHandler(this.HomePictureBox_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.White;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.homeButton.Location = new System.Drawing.Point(47, 113);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(109, 32);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // WorkspaceMainPanel
            // 
            this.WorkspaceMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.WorkspaceMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkspaceMainPanel.Location = new System.Drawing.Point(166, 37);
            this.WorkspaceMainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkspaceMainPanel.Name = "WorkspaceMainPanel";
            this.WorkspaceMainPanel.Size = new System.Drawing.Size(1277, 724);
            this.WorkspaceMainPanel.TabIndex = 4;
            // 
            // secretaryDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 761);
            this.Controls.Add(this.WorkspaceMainPanel);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1442, 799);
            this.Name = "secretaryDisplayForm";
            this.Text = "Beauty Salon";
            this.Load += new System.EventHandler(this.secretaryDisplayForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BurgerMenuPictureBox)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceManagerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchuedulingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox BurgerMenuPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox ClientsPictureBox;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.PictureBox SchuedulingPictureBox;
        private System.Windows.Forms.Button ScuedulingButton;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox SettingsPictureBox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.PictureBox LogOutPictureBox;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.PictureBox HomePictureBox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button ServiceManagerButton;
        private System.Windows.Forms.PictureBox ServiceManagerPictureBox;
        private System.Windows.Forms.Panel WorkspaceMainPanel;
    }
}