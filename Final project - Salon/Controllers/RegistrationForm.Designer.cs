namespace Final_project___Salon
{
    partial class RegistrationForm
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
            this.authorizationButton = new System.Windows.Forms.Button();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.ErrMessage = new System.Windows.Forms.Label();
            this.exitButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorizationButton
            // 
            this.authorizationButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.authorizationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(187)))), ((int)(((byte)(152)))));
            this.authorizationButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(15)))), ((int)(((byte)(134)))));
            this.authorizationButton.Location = new System.Drawing.Point(180, 231);
            this.authorizationButton.Margin = new System.Windows.Forms.Padding(2);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(84, 33);
            this.authorizationButton.TabIndex = 3;
            this.authorizationButton.Text = "Enter";
            this.authorizationButton.UseVisualStyleBackColor = false;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // userNameField
            // 
            this.userNameField.BackColor = System.Drawing.SystemColors.Info;
            this.userNameField.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.Location = new System.Drawing.Point(151, 150);
            this.userNameField.Margin = new System.Windows.Forms.Padding(2);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(145, 26);
            this.userNameField.TabIndex = 1;
            this.userNameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameField.TextChanged += new System.EventHandler(this.userNameField_TextChanged);
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.SystemColors.Info;
            this.passField.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.passField.ForeColor = System.Drawing.SystemColors.MenuText;
            this.passField.Location = new System.Drawing.Point(151, 196);
            this.passField.Margin = new System.Windows.Forms.Padding(2);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(144, 24);
            this.passField.TabIndex = 2;
            this.passField.Text = "admin";
            this.passField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passField.UseSystemPasswordChar = true;
            this.passField.TextChanged += new System.EventHandler(this.passField_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(153)))));
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblTitle.Location = new System.Drawing.Point(114, 73);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 41);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Authorization";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Narkisim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.UsernameLabel.Location = new System.Drawing.Point(164, 133);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(119, 15);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Enter user name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Narkisim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.passwordLabel.Location = new System.Drawing.Point(164, 179);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(115, 15);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Enter password:";
            // 
            // ErrMessage
            // 
            this.ErrMessage.AutoSize = true;
            this.ErrMessage.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ErrMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(28)))), ((int)(((byte)(8)))));
            this.ErrMessage.Location = new System.Drawing.Point(12, 366);
            this.ErrMessage.Name = "ErrMessage";
            this.ErrMessage.Size = new System.Drawing.Size(15, 19);
            this.ErrMessage.TabIndex = 6;
            this.ErrMessage.Text = "*";
            // 
            // exitButon
            // 
            this.exitButon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.exitButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.exitButon.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.exitButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(15)))), ((int)(((byte)(134)))));
            this.exitButon.Location = new System.Drawing.Point(370, 344);
            this.exitButon.Margin = new System.Windows.Forms.Padding(2);
            this.exitButon.Name = "exitButon";
            this.exitButon.Size = new System.Drawing.Size(71, 35);
            this.exitButon.TabIndex = 4;
            this.exitButon.Text = "Exit";
            this.exitButon.UseVisualStyleBackColor = false;
            this.exitButon.Click += new System.EventHandler(this.exitButon_Click);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.authorizationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(452, 390);
            this.Controls.Add(this.exitButon);
            this.Controls.Add(this.ErrMessage);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.authorizationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrationForm";
            this.Text = "Beauty salon";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label ErrMessage;
        private System.Windows.Forms.Button exitButon;
    }
}

