
namespace Final_project___Salon
{
    partial class PayWeb
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
            this.BrowserPanel = new CefSharp.WinForms.ChromiumWebBrowser();
            this.SuspendLayout();
            // 
            // BrowserPanel
            // 
            this.BrowserPanel.ActivateBrowserOnCreation = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.BrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserPanel.Location = new System.Drawing.Point(0, 0);
            this.BrowserPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrowserPanel.Name = "BrowserPanel";
            this.BrowserPanel.Size = new System.Drawing.Size(480, 857);
            this.BrowserPanel.TabIndex = 0;
            // 
            // PayWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 857);
            this.Controls.Add(this.BrowserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PayWeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay form ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PayWeb_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser BrowserPanel;
    }
}