using CefSharp;
using CefSharp.WinForms;
using System.IO;
using System.Windows.Forms;

namespace Final_project___Salon
{
    public partial class PayWeb : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public PayWeb(Basket basket)
        {
            InitializeComponent();
            InitializeChromium();
        } 

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser(Path.GetFullPath("..//..//Paypal//AllBasket.html"));
            // Add it to the form and fill it to the form window.
            BrowserPanel.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void PayWeb_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }

}
