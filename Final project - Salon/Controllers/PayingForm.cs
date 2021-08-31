using System;
using System.Windows.Forms;


namespace Final_project___Salon
{
    public partial class PayingForm : Form
    {

        private DBSql mySQL;    //var to use Silgelton connection 
        private Basket basket;
        private string shekel = " ₪";

        public PayingForm()
        {
            InitializeComponent();
            mySQL = DBSql.Instance;

        }
        //-------------------------------------------------------------
        #region/CASH PAY
        public void SetAllPayingData()
        {
            lblClientName.Text = basket.Customer.FullName;
            lblVat.Text = (basket.CalculateSumWithoutVat()*TaxesAndSales.Vat).ToString()+ shekel + "|" + TaxesAndSales.GetVatInProcent()+"%";
            lblWithoutVat.Text = basket.CalculateSumWithoutVat().ToString()+ shekel;
            lblTotal.Text = basket.CalculateTotalSum().ToString()+ shekel;
            lblSale.Text = (basket.CalculateSumWithoutVat() * TaxesAndSales.Sale).ToString() + shekel+"|" + TaxesAndSales.GetSaleInProcent()+"%";

            DisplayServicesInfo();
        }


        public void CleanCashData()
        {
            basket = null;
            DisplayServicesInfo();
            btnCashPay.Enabled = false;
            lblClientName.Text = "none";
            lblVat.Text = "0" + shekel;
            lblWithoutVat.Text = "0" + shekel;
            lblTotal.Text = "0" + shekel;
            lblChange.Text = "0.00" + shekel;
            textBoxCash.Text = "0";
        }

        

        /// <summary>
        /// Display Information about services from the basket
        /// </summary>
        private void DisplayServicesInfo()
        {
            int i = 1;
            if (basket != null)
            {
                lblService.Text = lblPrice.Text = "";
                foreach (Service service in basket.Services)
                {
                    lblService.Text += i + ". " + service.Name+"\n";
                    lblPrice.Text += service.Price.ToString()+ shekel + "\n";
                    i++;
                }
            }
            else lblService.Text = lblPrice.Text = "";
        }

        /// <summary>
        /// Calculate and check if sum in check box more than sum for pay
        /// </summary>
        private void textBoxCash_TextChanged(object sender, EventArgs e)
        {
            textBoxCashValidation();
        }

        /// <summary>
        /// Calculate and check if sum in check box more than sum for pay
        /// </summary>
        private void textBoxCashValidation()
        {
            if (textBoxCash.Text != "" && basket != null && GeneralInputValidation.FloatingPointNumericInput(textBoxCash.Text))
            {
                lblChange.Text = (Format.FormatDuobleTwoDecPlaces(Convert.ToDouble(textBoxCash.Text) - basket.CalculateSumWithVat()).ToString()) + shekel;
                if ((Convert.ToDouble(textBoxCash.Text) - basket.CalculateSumWithVat()) < 0)
                    btnCashPay.Enabled = false;
                else
                    btnCashPay.Enabled = true;
            }
            else { btnCashPay.Enabled = false; }
        }

        /// <summary>
        /// If paying by cash - insert check data to DB and clean basket
        /// if paying by paypal - redirect to paypal paying
        /// if paying by credit card - open credit card form (interface level only)
        /// </summary>
        private void btnCashPay_Click(object sender, EventArgs e)
        {                

            if (radioCash.Checked == true)
            {
                if (mySQL.Pay(basket))
                {
                    MessageBox.Show($"Payed Successfully\n You Change is: {lblChange.Text}");
                    CleanCashData();
                }
                else MessageBox.Show("Error, Don`t Payed!");
            }
            else if (radioPayPal.Checked == true)
            {
                PayWeb form = new PayWeb(basket);
                form.Show();
            }
            else if(radioCreditCard.Checked == true)
            {
                CreditCard form = new CreditCard(basket);
                form.Show();
            }                  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CleanCashData();
            btnCashPay.Enabled = false;
        }
        #endregion

        //-------------------------------------                      

        public Basket Basket
        {
            get { return basket; }
            set { basket = value; }
        }

        private void radioPayPal_CheckedChanged(object sender, EventArgs e)
        {
            if (basket != null)
            {
                btnCashPay.Enabled = true;
            }
        }

        private void radioCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (basket != null)
            {
                btnCashPay.Enabled = true;
            }
        }

        private void radioCash_CheckedChanged(object sender, EventArgs e)
        {
            if (basket != null)
            {
                textBoxCashValidation();
            }
        }
    }
}
