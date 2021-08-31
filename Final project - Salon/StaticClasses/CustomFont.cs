using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Final_project___Salon
{
    /// <summary>
    /// Class will make set users fonts possible
    /// </summary>
    public static class CustomFont
    {
        private static PrivateFontCollection myfont = new PrivateFontCollection();

        /// <summary>
        /// Set customer font for lable
        /// </summary>
        /// <param name="myLabel">label for font changing</param>
        /// <param name="fontSize">font size,in default = 20</param>
        public static void SetLabelFont(Label myLabel,int fontSize = 20)
        {
            
            using (MemoryStream fontStream = new MemoryStream(Properties.Resources.arkhip))
            {
                var data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                byte[] fontdata = new byte[fontStream.Length];
                fontStream.Read(fontdata, 0, (int)fontStream.Length);
                Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
                myfont.AddMemoryFont(data, (int)fontStream.Length);
                Marshal.FreeCoTaskMem(data);
            }
                        
            myLabel.Font = new Font(myfont.Families[0], fontSize);
            myLabel.UseCompatibleTextRendering = true;
        }

        /// <summary>
        /// Set customer font for buttons
        /// </summary>
        /// <param name="myButton">Button for changing</param>
        /// <param name="fontSize">font size, in default = 10</param>
        public static void SetButtonFont(Button myButton,int fontSize = 10)
        {
            
            using (MemoryStream fontStream = new MemoryStream(Properties.Resources.century_gothic))
            {
                var data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                byte[] fontdata = new byte[fontStream.Length];
                fontStream.Read(fontdata, 0, (int)fontStream.Length);
                Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
                myfont.AddMemoryFont(data, (int)fontStream.Length);
                Marshal.FreeCoTaskMem(data);
            }

            myButton.Font = new Font(myfont.Families[1], fontSize);
            myButton.UseCompatibleTextRendering = true;

        }
    }
}
