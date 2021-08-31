using System;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Final_project___Salon
{
    /// <summary>
    /// User Control - Clock    
    /// Digital Clock with time, day and Month
    /// Used IN Home Page         
    /// </summary>
    public partial class clock : UserControl
    {
        PrivateFontCollection myfont = new PrivateFontCollection();
        public clock()
        {
            InitializeComponent();
            SetFont();
        }
        private void SetFont()
        {

            using (MemoryStream fontStream = new MemoryStream(Properties.Resources.digital))
            {
                var data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                byte[] fontdata = new byte[fontStream.Length];
                fontStream.Read(fontdata, 0, (int)fontStream.Length);
                Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
                myfont.AddMemoryFont(data, (int)fontStream.Length);
                Marshal.FreeCoTaskMem(data);
            }

            lblTime.Font = lblDate.Font = lblDay.Font = new Font(myfont.Families[0], 25);
            lblSec.Font = new Font(myfont.Families[0], 11);
            lblDate.UseCompatibleTextRendering = lblDay.UseCompatibleTextRendering = lblTime.UseCompatibleTextRendering = true;
            lblSec.UseCompatibleTextRendering = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTimeFormatInfo usDtfi = new CultureInfo("en-US", false).DateTimeFormat;


            lblTime.Text = DateTime.Now.ToString("HH:mm", usDtfi);
            lblSec.Text = DateTime.Now.ToString("ss", usDtfi);
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy", usDtfi);
            lblDay.Text = DateTime.Now.ToString("dddd", usDtfi);
            lblSec.Location = new Point(lblTime.Location.X + lblTime.Width, lblSec.Location.Y);

        }

        private void clock_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }

}

