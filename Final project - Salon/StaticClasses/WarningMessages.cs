using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project___Salon
{
    public static class WarningMessages
    {

        // ----------STATIC FUNCTIONS - FOR MESSAGE OUTPUT -----------------//

        /*
         * Function display warning message with delay
         * Arguments:
         * string message - warning message
         * Label lbl - place for message
         */

        ///message with 5 sec Delay
        public async static void LongWarningMessage(Label lbl, string message)
        {
            lbl.Text = message;
            await Task.Delay(5000);
            lbl.Text = "";
        }
        ///message with 3sec Delay
        public async static void WarningMessage(Label lbl, string message)
        {     
            lbl.Text = message;
            await Task.Delay(3000);
            lbl.Text = "";
        }
        ///message with 1.5 sec Delay
        public async static void ShortMessage(Label lbl, string message)
        {
            lbl.Text = message;
            await Task.Delay(1500);
            lbl.Text = "";
        }



    }
}
