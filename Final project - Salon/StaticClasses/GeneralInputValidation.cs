using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Final_project___Salon
{
    /// <summary>
    /// Validation Of Differnt Types of  Inputs
    /// </summary>
    public static class GeneralInputValidation

    {       
        /// <summary>
        /// Method check if input was between A-z 
        /// <returns>true or false</returns>
        public static bool BigLittleAlpfabetInput(string str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z ]+$");
        }

        /// <summary>
        /// Method check if input was between 0-9 
        /// <returns>true or false</returns>
        public static bool NumericInput(string str)
        {
            return Regex.IsMatch(str, @"^[0-9]+$");
        }
        /// <summary>
        /// Method check if input was between 0-9 
        /// <returns>true or false</returns>
        public static bool FloatingPointNumericInput(string str)
        {
            return Regex.IsMatch(str, @"^[0-9,]+$");
        }
        /// <summary>
        /// Method check if input was between 0-9 
        /// <returns>true or false</returns>
        public static bool NumericAndAlphabetInput(string str)
        {
            return Regex.IsMatch(str, @"^([a-zA-Z0-9]{1})[a-zA-Z 0-9]+$");
        }
        /// <summary>
        /// Method check if input was included numbers and letters only 
        /// <returns>true or false</returns>
        public static bool PassInput(string str)
        {
            return Regex.IsMatch(str, @"^([a-zA-Z]{1})[a-zA-Z0-9]+$");
        }
        /// <summary>
        /// Method check input E-mail validation  
        /// <returns>true or false</returns>
        public static bool EmailInputValidation(string email)
        {
            bool result = false;
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
            {
                result = true;
            }

            return result;
        }


        private static TextBox CheckInputObject(object Textbox)
        {
            TextBox TextBoxName = null;
            if (Textbox is TextBox)
            {
                TextBoxName = (TextBox)Textbox;
                return TextBoxName;
            }
            return null;
           
        }

        public static void TextInputValidation(object Textbox)
        {
            TextBox TextBoxName = CheckInputObject(Textbox);
            if (TextBoxName != null)
            {
                if (GeneralInputValidation.BigLittleAlpfabetInput(TextBoxName.Text)) { }
                else
                {
                    if (TextBoxName.Text.Length > 0)
                    {
                        TextBoxName.Text = TextBoxName.Text.Remove(TextBoxName.Text.Length - 1);
                        TextBoxName.Focus();
                        TextBoxName.SelectionStart = TextBoxName.Text.Length;
                    }
                }
            }
            else
            {
                return;
            }
         }
      

        public static void NumericInputValidation(object Textbox)
        {
    
            TextBox TextBoxName = CheckInputObject(Textbox);
            if (TextBoxName != null)
            {
                if (GeneralInputValidation.NumericInput(TextBoxName.Text)) { }
                else
                {
                    if (TextBoxName.Text.Length > 0)
                    {
                        TextBoxName.Text = TextBoxName.Text.Remove(TextBoxName.Text.Length - 1);
                        TextBoxName.Focus();
                        TextBoxName.SelectionStart = TextBoxName.Text.Length;
                    }
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        ///    Mail Validation 
        /// </summary>
        public static void MailValidation(object Mail)
        {
            TextBox TextBoxName = CheckInputObject(Mail);
            if (TextBoxName != null)
            {

                if (GeneralInputValidation.EmailInputValidation(TextBoxName.Text)) { }
                else
                {
                    MessageBox.Show("Wrong E-mail format!");
                }
            }
        }


    }
}
