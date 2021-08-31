using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace Final_project___Salon
{
    public partial class RegistrationForm : Form
    {
        private DBSql mySQL;    //var to use Silgelton connection 
        public static CompanyInfo company;
        public RegistrationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;            
            ErrMessage.Text = ""; // label for warning messages
            DBSql.DataBaseName = "nails";
            DBSql.Username = "root";
            DBSql.Password = string.Empty;
            mySQL = DBSql.Instance;

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            authorizationButton.FlatStyle = FlatStyle.Flat;
            authorizationButton.FlatAppearance.BorderSize = 0;
            authorizationButton.Enabled = false;
        }


        private string getHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }       


        private void authorizationButton_Click(object sender, EventArgs e)
        {


            string loginUser = userNameField.Text;
            string passUser = getHash(passField.Text);
                      

            company = mySQL.LogIn(loginUser, passUser);

            if(company == null)
            {
                WarningMessages.WarningMessage(ErrMessage, "Wrong login or Password");
            }
            else if (company.CompId == -1)// if DB not return nothin companyId =-1
            {
                WarningMessages.WarningMessage(ErrMessage, "No Connection to Data Base!");
            }
            else if(company!=null && company.IfBoss == true)   //if user exist  && it is admin
            {
                this.Hide();
                BossDisplayForm bossForm = new BossDisplayForm(company);
                bossForm.Show();
            }
            else if (company != null && company.IfBoss == false)
            {
                this.Hide();
                secretaryDisplayForm secretaryForm = new secretaryDisplayForm(company);
                secretaryForm.Show();

            }
            else
            {
                WarningMessages.WarningMessage(ErrMessage,"Incorrect Username or Password!");//check what a problem
            }
        }      
                               
                

        private void exitButon_Click(object sender, EventArgs e)
        {            
            Environment.Exit(0);
        }
        
         //Events blocks "authorizationButton" if text field of login or pass are empty
         
        private void userNameField_TextChanged(object sender, EventArgs e)
        {
            if (userNameField.Text.Length == 0 || passField.Text.Length == 0)
                authorizationButton.Enabled = false;
            else authorizationButton.Enabled = true;
        }
        private void passField_TextChanged(object sender, EventArgs e)
        {
            if (userNameField.Text.Length == 0 || passField.Text.Length == 0)
                authorizationButton.Enabled = false;
            else authorizationButton.Enabled = true;
        }
        //------------------------------------------------------------------------------


        /// <summary>
        /// set Customer font for all elements on form
        /// </summary>
        private void SetFonts()
        {
            CustomFont.SetLabelFont(lblTitle, 20);// Set customer font for titles
            CustomFont.SetButtonFont(authorizationButton, 14);
            CustomFont.SetButtonFont(exitButon,12);
            

        }

        
    }

}
