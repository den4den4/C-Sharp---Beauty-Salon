using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Final_project___Salon
{
    public partial class CustomerForm : Form
    {
        private int tmpCustomer_id = 0;  //temp var(use in update action)      ///////////////////
        private DBSql mySQL;    //var to use Silgelton connection 

        //CONSTRUCTOR 
        public CustomerForm()
        {

            InitializeComponent();
            mySQL = DBSql.Instance;
            FillCustomer();
        }
        /// <summary>
        /// Function FillCustomer Fill Customers in DataGrid Wiew
        /// </summary>
        private void FillCustomer()
        {
            Customer[] arrayCustomers = mySQL.GetCustomerData();
            FillCustomer(arrayCustomers);
        }

        /// <summary>
        /// Function FillCustomer Fill Customers in DataGrid Wiew
        /// </summary>
        private void FillCustomer(Customer[] arrayCustomers)
        {

            int rowsCount = arrayCustomers.Length;
            int columnsCount = 10;   //9 from 10 properties of customer on the screen   

            CustomerDataGridView.RowCount = rowsCount;
            CustomerDataGridView.ColumnCount = columnsCount;

            CustomerDataGridView.Columns[0].HeaderText = "Id";
            CustomerDataGridView.Columns[0].Visible = false;

            CustomerDataGridView.Columns[1].HeaderText = "First Name";
            CustomerDataGridView.Columns[2].HeaderText = "Last Name";
            CustomerDataGridView.Columns[3].HeaderText = "Birth Date";
            CustomerDataGridView.Columns[4].HeaderText = "City";
            CustomerDataGridView.Columns[5].HeaderText = "Street";
            CustomerDataGridView.Columns[6].HeaderText = "House";
            CustomerDataGridView.Columns[7].HeaderText = "Appartment";
            CustomerDataGridView.Columns[8].HeaderText = "Phone";
            CustomerDataGridView.Columns[9].HeaderText = "Mail";

            for (int j = 0; j < arrayCustomers.Length; j++)
            {


                CustomerDataGridView[0, j].Value = arrayCustomers[j].Customer_id.ToString();
                CustomerDataGridView[1, j].Value = arrayCustomers[j].First_name.ToString();
                CustomerDataGridView[2, j].Value = arrayCustomers[j].Last_name.ToString();
                CustomerDataGridView[3, j].Value = arrayCustomers[j].Birth_date.ToString("d", CultureInfo.GetCultureInfo("ru-ru"));
                CustomerDataGridView[4, j].Value = arrayCustomers[j].City.ToString();
                CustomerDataGridView[5, j].Value = arrayCustomers[j].Street.ToString();
                CustomerDataGridView[6, j].Value = arrayCustomers[j].House.ToString();
                CustomerDataGridView[7, j].Value = arrayCustomers[j].Appartment.ToString();
                CustomerDataGridView[8, j].Value = arrayCustomers[j].Phone.ToString();
                CustomerDataGridView[9, j].Value = arrayCustomers[j].Mail.ToString();

            }
        }
        /// <summary>
        ///   InsertCustomerButton_Click Event to Insert customer button 
        /// </summary>
        private void InsertCustomerButton_Click(object sender, EventArgs e)
        {

            if (CheckIfInputTextIsEmpty()) //check if  textboxes not empty
            {
                Customer[] arrayCustomers = mySQL.GetCustomerData();

                for (int i = 0; i < arrayCustomers.Length; ++i)
                {
                    if (arrayCustomers[i].Mail.Equals(MailTextBox.Text))   //if same mail exist in database - dont insert user 
                    {
                        MessageBox.Show("Insert don't succsesfully!\n E-mail exist in database!");
                        return;
                    }
                }

                mySQL.InsertCustomer(FillCustomerFromTxtBox());
                FillCustomer();
                MessageBox.Show("Insert succsesfully!");
                ClearInputText();  //clear input text form
            }
            else
            {
                MessageBox.Show("Insert don't succsesfully!\n One of data fields is empty!");
            }

        }

        // function check if  textboxes not empty
        private bool CheckIfInputTextIsEmpty()
        {
            return (FirstNameTextBox.Text != "" && LastNameTextBox.Text != "" && CityTextBox.Text != "" && StreetTextBox.Text != "" && HouseTextBox.Text != "" &&
                       AppartmentTextBox.Text != "" && PhoneTextBox.Text != "" && MailTextBox.Text != "");
        }


        //function cleared input form after all action
        private void ClearInputText()
        {
            FirstNameTextBox.Text = LastNameTextBox.Text = CityTextBox.Text = StreetTextBox.Text = HouseTextBox.Text =
               AppartmentTextBox.Text = PhoneTextBox.Text = MailTextBox.Text = "";

            tmpCustomer_id = 0;


        }
        /// <summary>
        ///   If we Clicked on DatagridWiew on parametr of customer 
        /// </summary>
        private void CustomerDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (CustomerDataGridView.CurrentRow.Index != -1)     //check if we clicked on table => insert input fields in form 
            {
                FirstNameTextBox.Text = CustomerDataGridView.CurrentRow.Cells[1].Value.ToString();
                LastNameTextBox.Text = CustomerDataGridView.CurrentRow.Cells[2].Value.ToString();
                BirthDateTimePicker.Value = Convert.ToDateTime(CustomerDataGridView.CurrentRow.Cells[3].Value.ToString());
                CityTextBox.Text = CustomerDataGridView.CurrentRow.Cells[4].Value.ToString();
                StreetTextBox.Text = CustomerDataGridView.CurrentRow.Cells[5].Value.ToString();
                HouseTextBox.Text = CustomerDataGridView.CurrentRow.Cells[6].Value.ToString();
                AppartmentTextBox.Text = CustomerDataGridView.CurrentRow.Cells[7].Value.ToString();
                PhoneTextBox.Text = CustomerDataGridView.CurrentRow.Cells[8].Value.ToString();
                MailTextBox.Text = CustomerDataGridView.CurrentRow.Cells[9].Value.ToString();

                tmpCustomer_id = Convert.ToInt32(CustomerDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
        }
        /// <summary>
        ///        Function create and fill data of 1 Customer  from text areas in form customer 
        ///        And return cusustomer 
        /// </summary>
        private Customer FillCustomerFromTxtBox()
        {
            Customer customer = new Customer();

            customer.Customer_id = 0;
            customer.First_name = FirstNameTextBox.Text;
            customer.Last_name = LastNameTextBox.Text;
            customer.Birth_date = BirthDateTimePicker.Value;
            customer.City = CityTextBox.Text;
            customer.Street = StreetTextBox.Text;
            customer.House = Convert.ToInt32(HouseTextBox.Text);
            customer.Appartment = Convert.ToInt32(AppartmentTextBox.Text);
            customer.Phone = PhoneTextBox.Text;
            customer.Mail = MailTextBox.Text;


            return customer;
        }


        /// <summary>
        ///     Function Update customer data in database 
        /// </summary>
        private void CustomerUpdateButton_Click(object sender, EventArgs e)
        {

            if (CheckIfInputTextIsEmpty()) //check if  textboxes not empty
            {
                Customer customer = new Customer();
                customer = FillCustomerFromTxtBox();
                customer.Customer_id = tmpCustomer_id;
                mySQL.UpdateCustomer(customer);
                FillCustomer();
                MessageBox.Show("Update succsesfully!");
                ClearInputText();             //clear input text form
            }
            else
            {
                MessageBox.Show("Update don't succsesfully!\n One of data fields is empty!");
            }

        }
        /// <summary>
        ///  Function Delete Customer from Database 
        /// </summary>

        private void CustomerDeleteButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();


            if (CheckIfInputTextIsEmpty()) //check if  textboxes not empty
            {
                DialogResult result = MessageBox.Show("After operation 'Delete'\n all customer records are deleted from database\n Are you sure?",
                 "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    customer = FillCustomerFromTxtBox();
                    customer.Customer_id = tmpCustomer_id;
                    mySQL.DeleteCustomer(customer);                       //func delete customer from BD 
                }

                FillCustomer();
                ClearInputText();             //clear input text form
            }
            else
            {
                MessageBox.Show("Delete operation don't succsesfully!\n One of data fields is empty!");
            }


        }
        /// <summary>
        ///  SearchCustomerButton_Click Event that search customer in database 
        /// </summary>
        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            Customer[] customers = null;
            if (!SearchCustomerTextBox.Text.Equals(""))
            {
                customers = mySQL.SearchCustomer(SearchCustomerTextBox.Text);         // sql query function(return array of customers)
                if (customers == null)                 //check if customer array is not empty 
                {
                    FillCustomer();
                }
                else
                {
                    FillCustomer(customers);
                }

            }
            else
            {
                FillCustomer();
            }

        }
        /// <summary>
        ///     Customer text box is empty event Fill DatagrigWiew from database
        /// </summary>
        private void SearchCustomerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchCustomerTextBox.Text))
            {
                FillCustomer();
            }
        }
        /// <summary>
        ///   Event Text Validate Only charachters if fields
        /// </summary>
        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.TextInputValidation(sender);
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.TextInputValidation(sender);
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.TextInputValidation(sender);
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.TextInputValidation(sender);
        }

        private void MailTextBox_Validating(object sender, CancelEventArgs e)
        {
            GeneralInputValidation.MailValidation(sender);
        }

        private void HouseTextBox_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.NumericInputValidation(sender);
        }

        private void AppartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.NumericInputValidation(sender);
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.NumericInputValidation(sender);
        }
    }
}
