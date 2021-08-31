using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Final_project___Salon
{
    public partial class SettingsForm : Form
    {
        private DBSql mySql;
        CompanyInfo compInfo;
        public static Dictionary<string, DateTime> jobTime = new Dictionary<string, DateTime>();
        public SettingsForm(CompanyInfo company)
        {
            InitializeComponent();
            GetWorkTimeFromReg();
            SetTimeFromDictionaryToTimePicker();
            this.compInfo = company;
            mySql = DBSql.Instance;

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            lblPassMessage.Text = lblCompMessage.Text = "";
            txtUserName.Text = compInfo.UserName;
            BlockFields();
            FillCompTextBoxes();
            GetVatAndSale();

            btnSaveVatAndSale.Enabled = btnSave.Enabled = btnChange.Enabled = false;
        }

        /// <summary>
        /// Get Job Time from Regist For Queue setting
        /// </summary>
        private void GetWorkTimeFromReg()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SoftWare\Beauty Salon\date", true))
            {
                if (key == null || key.ValueCount < 14)
                {
                    CreateWorkTimeInReg();
                    return;
                }
                foreach (string name in key.GetValueNames())
                {
                    try
                    {
                        jobTime.Add(name, Convert.ToDateTime(key.GetValue(name)));
                    }
                    catch { }
                }
            }
        }

        /// <summary>
        /// Job Times From reg by days
        /// </summary>
        private void SetTimeFromDictionaryToTimePicker()
        {
            dtSunMin.Value = jobTime["Sunday min"];
            dtSunMax.Value = jobTime["Sunday max"];

            dtMonMin.Value = jobTime["Monday min"];
            dtMonMax.Value = jobTime["Monday max"];

            dtTueMin.Value = jobTime["Tuesday min"];
            dtTueMax.Value = jobTime["Tuesday max"];

            dtWedMin.Value = jobTime["Wednesday min"];
            dtWedMax.Value = jobTime["Wednesday max"];

            dtThuMin.Value = jobTime["Thursday min"];
            dtThuMax.Value = jobTime["Thursday max"];

            dtFriMin.Value = jobTime["Friday min"];
            dtFriMax.Value = jobTime["Friday max"];

            dtSatMin.Value = jobTime["Saturday min"];
            dtSatMax.Value = jobTime["Saturday max"];

        }

        /// <summary>
        /// Method Creat default job times -  If Job Work Time not exixst 
        /// </summary>
        private void CreateWorkTimeInReg()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SoftWare\Beauty Salon\date", true))
            {
                key.SetValue("Sunday min", "8:00");
                key.SetValue("Sunday max", "20:00");
                key.SetValue("Monday min", "8:00");
                key.SetValue("Monday max", "20:00");
                key.SetValue("Tuesday min", "8:00");
                key.SetValue("Tuesday max", "20:00");
                key.SetValue("Wednesday min", "8:00");
                key.SetValue("Wednesday max", "20:00");
                key.SetValue("Thursday min", "8:00");
                key.SetValue("Thursday max", "20:00");
                key.SetValue("Friday min", "9:00");
                key.SetValue("Friday max", "15:00");
                key.SetValue("Saturday min", "00:00");
                key.SetValue("Saturday max", "00:00");

                GetWorkTimeFromReg();
            }
        }

        /// <summary>
        /// Set To time Pickers In Setting FOrm from times dictionary
        /// </summary>
        private void SetValueFromTamePickerToDictionary()
        {
            jobTime["Sunday min"] = dtSunMin.Value;
            jobTime["Sunday max"] = dtSunMax.Value;

            jobTime["Monday min"] = dtMonMin.Value;
            jobTime["Monday max"] = dtMonMax.Value;

            jobTime["Tuesday min"] = dtTueMin.Value;
            jobTime["Tuesday max"] = dtTueMax.Value;

            jobTime["Wednesday min"] = dtWedMin.Value;
            jobTime["Wednesday max"] = dtWedMax.Value;

            jobTime["Thursday min"] = dtThuMin.Value;
            jobTime["Thursday max"] = dtThuMax.Value;

            jobTime["Friday min"] = dtFriMin.Value;
            jobTime["Friday max"] = dtFriMax.Value;

            jobTime["Saturday min"] = dtSatMin.Value;
            jobTime["Saturday max"] = dtSatMax.Value;
        }

        /// <summary>
        /// Set new job time value to reg
        /// </summary>
        private void SetValueToReg()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SoftWare\Beauty Salon\date", true))
            {
                foreach(var time in jobTime)
                {
                    key.SetValue(time.Key, time.Value);
                }
            }
        }


        #region//DATETIMEPICKER_VALUECHANGED
        private void dtSunMin_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtSunMin);
        }
        private void dtSunMax_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtSunMax);
        }
        private void dtMonMin_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtMonMin);
        }
        private void dtMonMax_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtMonMax);
        }
        private void dtTueMin_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtTueMin);
        }

        private void dtTueMax_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtTueMax);
        }

        private void dtWedMin_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtWedMin);
        }

        private void dtWedMax_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtWedMax);
        }

        private void dtThuMin_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtThuMin);
        }

        private void dtThuMax_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtThuMax);
        }

        private void dtFriMin_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtFriMin);
        }

        private void dtFriMax_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtFriMax);
        }

        private void dtSatMin_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtSatMin);
        }

        private void dtSatMax_ValueChanged(object sender, EventArgs e)
        {
            TimeQuaterSteps(dtSatMax);
        }

        /// <summary>
        /// let to set minutes by 15 min steps
        /// </summary>
        /// <param name="time">dateTimePicker to change</param>
        private void TimeQuaterSteps(DateTimePicker time)
        {
            DateTime dt = time.Value;
            int mins = dt.Minute;
            if (mins == 1 || mins == 16 || mins == 31 || mins == 46)
            {
                dt = dt.AddMinutes(14);
                time.Value = dt;
            }
            if (mins == 59 || mins == 44 || mins == 29 || mins == 14)
            {
                dt = dt.AddMinutes(-14);
                time.Value = dt;
            }
        }
        #endregion


        private void btnJobTimeSave_Click(object sender, EventArgs e)
        {
            SetValueFromTamePickerToDictionary();
            SetValueToReg();
        }

        #region/PASS_CHENGING
        /*
         *function creat hash string for password coding 
         */
        private string getHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }
        //-----------------------------------------/


        //click button for apply pass changes
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!passValidFunc())
                return;
            string oldPass = getHash(txtOldPass.Text);
            string newPass = getHash(txtNewPass.Text);
            if (mySql.ChangePassword(txtUserName.Text, oldPass, newPass) > 0)//return number of affected rows
            {
                WarningMessages.WarningMessage(lblPassMessage, "Password Was Changed");
                ClearInput();
            }
            else
                WarningMessages.WarningMessage(lblPassMessage, "Wrong Password Or User Name");

        }
        /// <summary>
        ///    Clear input fields 
        /// </summary>
        private void ClearInput()
        {
            txtOldPass.Text = txtNewPass.Text = txtConfirmPass.Text = "";
        }


        /*
         * Function check text field on correction
         */
        private bool passValidFunc()
        {

            if (txtNewPass.Text.Length <= 4)
            {
                WarningMessages.WarningMessage(lblPassMessage, "Password must contain more than 4 characters ");
                return false;
            }
            else if (txtNewPass.Text.Equals(txtOldPass.Text))
            {
                WarningMessages.WarningMessage(lblPassMessage, "New Password and Old Passwords are Equals !");
                return false;
            }
            else if (!txtNewPass.Text.Equals(txtConfirmPass.Text))
            {
                WarningMessages.WarningMessage(lblPassMessage, "New Password and Confirm Password not Equals!");
                return false;
            }
            else return true;
        }


        // ---- Event - if at least one text field empty "btnApply" is block---------------------------------------------------------------------|
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            CheckPassFields();
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            CheckPassFields();
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            CheckPassFields();
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            CheckPassFields();
        }

        private void CheckPassFields()
        {
            if (txtUserName.Text.Length == 0 || txtOldPass.Text.Length == 0 || txtNewPass.Text.Length == 0 || txtConfirmPass.Text.Length == 0)
                btnChange.Enabled = false;
            else if (GeneralInputValidation.PassInput(txtNewPass.Text) == false)// validate if new pass not begin on numbers and include numbers and letters only
            {
                WarningMessages.LongWarningMessage(lblPassMessage, "Password must begin from A-z\nAnd must include A-z and 0-9 only!");
                btnChange.Enabled = false;
            }
            else btnChange.Enabled = true;
        }





        #endregion
        //-------------------------------------------------------------------------------------------------------------------------------------|
        #region/VAT and SALE CHANGING
        //Display Vat and sale
        private void GetVatAndSale()
        {
            lblVat.Text = (TaxesAndSales.Vat * 100).ToString() + "%";
            lblSale.Text = (TaxesAndSales.Sale * 100).ToString() + "%";
        }

        //Save in db new Vat and Sale Value
        private void btnSaveVatAndSale_Click(object sender, EventArgs e)
        {
            if (textBoxSale.Text == "")
            {
                TaxesAndSales.Vat = Convert.ToInt64(textBoxVat.Text);
            }
            else if (textBoxVat.Text == "")
            {
                TaxesAndSales.Sale = Convert.ToInt64(textBoxSale.Text);
            }
            else
            {
                TaxesAndSales.Sale = Convert.ToInt64(textBoxSale.Text);
                TaxesAndSales.Vat = Convert.ToInt64(textBoxVat.Text);
            }
            GetVatAndSale();
            CleanVatAndSale();
        }


        private void textBoxVat_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.NumericInputValidation(sender);
            CheckSaleAndVat(textBoxVat);
        }
        private void textBoxSale_TextChanged(object sender, EventArgs e)
        {
            CheckSaleAndVat(textBoxSale);
        }

        // Checking if Input Correct
        private void CheckSaleAndVat(TextBox textBox)
        {
            if (GeneralInputValidation.NumericInput(textBox.Text) == false || Convert.ToInt64(textBox.Text) > 100 || textBox.Text == "")
            {
                btnSaveVatAndSale.Enabled = false;
            }
            else btnSaveVatAndSale.Enabled = true;
        }

        //TextBoxes Sale and Vat
        private void CleanVatAndSale()
        {
            textBoxSale.Text = "";
            textBoxVat.Text = "";
        }
        #endregion
        //-------------------------------------------------------------------------------------------------------------------------------------|
        

        #region/COMPANY_INFO_CHANGING

        //Fill Company text boxes 
        private void FillCompTextBoxes()
        {

            textCompName.Text = compInfo.CompName;
            textCompEmail.Text = compInfo.CompEmail;
            textCompanyPhone.Text = compInfo.CompPhone;
            textCompanyAddress.Text = compInfo.CompAddress;
            textLicenseId.Text = compInfo.CompLicense.ToString();
        }

        //Block fields for User without permissions
        private void BlockFields()
        {
            if (!compInfo.IfBoss)
                textCompanyAddress.Enabled = textCompanyPhone.Enabled = textCompEmail.Enabled = textCompName.Enabled = textLicenseId.Enabled = txtUserName.Enabled = false;
        }

        //-------------- TEXT CHANGE FIELDS - validate txt field befor changing recieve ------------------------------||
        private void textCompName_TextChanged(object sender, EventArgs e)
        {
            CheckCompanyFields();
        }

        private void textCompEmail_TextChanged(object sender, EventArgs e)
        {
            if (GeneralInputValidation.EmailInputValidation(textCompEmail.Text) == false)// validate on righting email format
            {
                WarningMessages.LongWarningMessage(lblCompMessage, "Incorret email format!");
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
                CheckCompanyFields();//check all fields
            }

        }

        private void textCompanyPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            CheckCompanyFields();//check all fields
        }

        private void textCompanyAddress_TextChanged(object sender, EventArgs e)
        {
            CheckCompanyFields();//check all fields
        }

        private void textLicenseId_TextChanged(object sender, EventArgs e)
        {

            if (GeneralInputValidation.NumericInput(textLicenseId.Text) == false)// validate if all symbols are numbers
            {
                WarningMessages.LongWarningMessage(lblCompMessage, "Numbers Only!");
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
                CheckCompanyFields();//check all fields
            }

        }
        //----------------------------------------------------------------||

        /// <summary>
        /// Save changed company info
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            CompanyInfo tmpCompany = new CompanyInfo();
            tmpCompany.CompId = compInfo.CompId;
            tmpCompany.CompAddress = textCompanyAddress.Text;
            tmpCompany.CompEmail = textCompEmail.Text;
            tmpCompany.CompPhone = String.Join("", textCompanyPhone.Text.Split(' ', '(', ')', '-'));
            tmpCompany.CompName = textCompName.Text;
            tmpCompany.CompLicense = Convert.ToInt32(textLicenseId.Text);
            if (mySql.UpdateCompanyInfo(tmpCompany) == true)
            {
                WarningMessages.LongWarningMessage(lblCompMessage, "Information Changed");
                compInfo = tmpCompany;
            }
            else
            {
                WarningMessages.LongWarningMessage(lblCompMessage, "No changed!");
                tmpCompany = null;
            }
        }

        private void CheckCompanyFields()
        {
            if ((textCompName.Text.Length == 0 || textCompanyAddress.Text.Length == 0 || textCompanyPhone.Text.Length == 0 || textCompEmail.Text.Length == 0 || textLicenseId.Text.Length == 0)
                || (compInfo.CompAddress == textCompanyAddress.Text && compInfo.CompEmail == textCompEmail.Text
                && compInfo.CompPhone == String.Join("", textCompanyPhone.Text.Split(' ', '(', ')', '-')) && compInfo.CompName == textCompName.Text
                && compInfo.CompLicense.ToString() == textLicenseId.Text))
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }
                

        #endregion
        //-------------------------------------------------------------------------------------------------------------------------------------|

    }

}
