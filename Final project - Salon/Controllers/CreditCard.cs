using System;
using System.Windows.Forms;

namespace Final_project___Salon
{
    public partial class CreditCard : Form
    {
        private DBSql mySQL;
        Basket basket;
        public CreditCard(Basket basket)
        {
            InitializeComponent();
            mySQL = DBSql.Instance;
            this.basket = basket;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCashPay_Click(object sender, EventArgs e)
        {
            
            if (mySQL.Pay(this.basket))
            {
                MessageBox.Show($"Payed Successfully");
                this.Close();
            }
            else MessageBox.Show("Error, Don`t Payed!");
            
        }
    }
}
