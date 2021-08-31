using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Final_project___Salon
{
    public partial class EmployeeWorkerForm : Form
    {
        private Employee[] arrayEmployee;
        private int tmpEmployee_id = 0;  //temp var(use in update action)      ///////////////////
        private DBSql mySQL;              //var class DBSql to use Silgelton connection 


        public EmployeeWorkerForm()
        {
            InitializeComponent();
            mySQL = DBSql.Instance;
            FillEmployee();
        }

        /// <summary>
        /// Function FillEmployee add Employees in DataGrid Wiew
        /// </summary>
        private void FillEmployee()
        {
            arrayEmployee = mySQL.GetEmployeeData();         ///////////////////////////
            FillEmployee(arrayEmployee);
        }

        /// <summary>
        /// Function FillEmployee Fill Empl in DataGrid Wiew
        /// </summary>
        private void FillEmployee(Employee[] arrayEmployee)
        {

            int rowsCount = arrayEmployee.Length;
            int columnsCount = 12;   //11 from 12 properties of employee on the screen   

            EmployeeDataGridView.RowCount = rowsCount;
            EmployeeDataGridView.ColumnCount = columnsCount;

            EmployeeDataGridView.Columns[0].HeaderText = "Id";
            EmployeeDataGridView.Columns[0].Visible = false;

            EmployeeDataGridView.Columns[1].HeaderText = "First Name";
            EmployeeDataGridView.Columns[2].HeaderText = "Last Name";
            EmployeeDataGridView.Columns[3].HeaderText = "Salary";
            EmployeeDataGridView.Columns[4].HeaderText = "Birth Date";
            EmployeeDataGridView.Columns[5].HeaderText = "City";
            EmployeeDataGridView.Columns[6].HeaderText = "Street";
            EmployeeDataGridView.Columns[7].HeaderText = "House";
            EmployeeDataGridView.Columns[8].HeaderText = "Appartment";
            EmployeeDataGridView.Columns[9].HeaderText = "Phone";
            EmployeeDataGridView.Columns[10].HeaderText = "Start Work";
            EmployeeDataGridView.Columns[11].HeaderText = "Mail";

            for (int j = 0; j < arrayEmployee.Length; j++)
            {


                EmployeeDataGridView[0, j].Value = arrayEmployee[j].Employee_id.ToString();
                EmployeeDataGridView[1, j].Value = arrayEmployee[j].First_name.ToString();
                EmployeeDataGridView[2, j].Value = arrayEmployee[j].Last_name.ToString();
                EmployeeDataGridView[3, j].Value = arrayEmployee[j].Salary.ToString();
                EmployeeDataGridView[4, j].Value = arrayEmployee[j].Birth_date.ToString("d", CultureInfo.GetCultureInfo("ru-ru"));
                EmployeeDataGridView[5, j].Value = arrayEmployee[j].City.ToString();
                EmployeeDataGridView[6, j].Value = arrayEmployee[j].Street.ToString();
                EmployeeDataGridView[7, j].Value = arrayEmployee[j].House.ToString();
                EmployeeDataGridView[8, j].Value = arrayEmployee[j].Appartment.ToString();
                EmployeeDataGridView[9, j].Value = arrayEmployee[j].Phone.ToString();
                EmployeeDataGridView[10, j].Value = arrayEmployee[j].Start_work_date.ToString("d", CultureInfo.GetCultureInfo("ru-ru"));
                EmployeeDataGridView[11, j].Value = arrayEmployee[j].Mail.ToString();

            }
        }

        /// <summary>
        ///   InsertEmployeeButton_Click Event to Insert Employee button 
        /// </summary>
        private void InsertEmployeeButton_Click(object sender, EventArgs e)
        {
            if (CheckIfInputTextIsEmpty()) //check if  textboxes not empty
            {
                Employee[] arrayEmployee = mySQL.GetEmployeeData();

                for (int i = 0; i < arrayEmployee.Length; ++i)
                {
                    if (arrayEmployee[i].Mail.Equals(MailTextBox.Text))   //if same mail exist in database - dont insert user 
                    {
                        MessageBox.Show("Insert don't succsesfully!\n E-mail exist in database!");
                        return;
                    }
                }

                mySQL.InsertEmployee(FillEmployeeFromTxtBox());
                FillEmployee();
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
            return (FirstNameTextBox.Text != "" && LastNameTextBox.Text != "" && SalaryTextBox.Text !="" && CityTextBox.Text != "" && StreetTextBox.Text != "" && HouseTextBox.Text != "" &&
                       AppartmentTextBox.Text != "" && PhoneTextBox.Text != "" && MailTextBox.Text != "");
        }


        //function cleared input form after all action
        private void ClearInputText()
        {
            FirstNameTextBox.Text = LastNameTextBox.Text = CityTextBox.Text = StreetTextBox.Text = HouseTextBox.Text =
               AppartmentTextBox.Text = PhoneTextBox.Text = SalaryTextBox.Text = MailTextBox.Text = "";

            tmpEmployee_id = 0;
        }

        private Employee FillEmployeeFromTxtBox()
        {
            Employee employee = new Employee();

            employee.Employee_id = 0;
            employee.First_name = FirstNameTextBox.Text;
            employee.Last_name = LastNameTextBox.Text;
            employee.Salary = Convert.ToInt32(SalaryTextBox.Text);
            employee.Birth_date = BirthDateTimePicker.Value;
            employee.City = CityTextBox.Text;
            employee.Street = StreetTextBox.Text;
            employee.House = Convert.ToInt32(HouseTextBox.Text);
            employee.Appartment = Convert.ToInt32(AppartmentTextBox.Text);
            employee.Phone = PhoneTextBox.Text;
            employee.Start_work_date = StartWorkDateTimePicker.Value;
            employee.Mail = MailTextBox.Text;


            return employee;
        }

        /// <summary>
        ///   If we Clicked on DatagridWiew => get data from dtgw to text boxes  
        /// </summary>
        private void EmployeeDataGridView_DoubleClick(object sender, EventArgs e)
        {
            
        }
       
       /// <summary>
       /// Search function Employeees 
        private void SearchEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee[] employees = null;
            if (!SearchEmployeeTextBox.Text.Equals(""))
            {
                employees = mySQL.SearchEmployee(SearchEmployeeTextBox.Text);         // sql query function(return array of customers)
                if (employees == null)                 //check if customer array is not empty 
                {
                    FillEmployee();
                }
                else
                {
                    FillEmployee(employees);
                }

            }
            else
            {
                FillEmployee();
            }
        }



        /// <summary>
        ///     Function Update Employee data in database 
        /// </summary>
        private void EmployeeUpdateButton_Click_1(object sender, EventArgs e)
        {
            if (CheckIfInputTextIsEmpty()) //check if  textboxes not empty
            {
                Employee employee = new Employee();
                employee = FillEmployeeFromTxtBox();
                employee.Employee_id = tmpEmployee_id;
                mySQL.UpdateEmployee(employee);
                FillEmployee();
                MessageBox.Show("Update succsesfully!");
                ClearInputText();             //clear input text form
            }
            else
            {
                MessageBox.Show("Update don't succsesfully!\n One of data fields is empty!");
            }
        }

        private void EmployeeDataGridView_DoubleClick_1(object sender, EventArgs e)
        {
            if (EmployeeDataGridView.CurrentRow.Index != -1)     //check if we clicked on table => insert input fields in form 
            {
                FirstNameTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[1].Value.ToString();
                LastNameTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[2].Value.ToString();
                SalaryTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[3].Value.ToString();
                BirthDateTimePicker.Value = Convert.ToDateTime(EmployeeDataGridView.CurrentRow.Cells[4].Value.ToString());
                CityTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[5].Value.ToString();
                StreetTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[6].Value.ToString();
                HouseTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[7].Value.ToString();
                AppartmentTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[8].Value.ToString();
                PhoneTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[9].Value.ToString();
                StartWorkDateTimePicker.Value = Convert.ToDateTime(EmployeeDataGridView.CurrentRow.Cells[10].Value.ToString());
                MailTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[11].Value.ToString();

                tmpEmployee_id = Convert.ToInt32(EmployeeDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
        }

        /// <summary>
        ///  Function Delete Employee from Database 
        /// </summary>
        private void EmployeeDeleteButton_Click_1(object sender, EventArgs e)
        {
            Employee employee = new Employee();


            if (CheckIfInputTextIsEmpty()) //check if  textboxes not empty
            {
                DialogResult result = MessageBox.Show("After operation 'Delete'\n all employee records are deleted from database\n Are you sure?",
                 "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    employee = FillEmployeeFromTxtBox();
                    employee.Employee_id = tmpEmployee_id;
                    mySQL.DeleteEmployee(employee);                       //func delete emp from BD 
                }

                FillEmployee();
                ClearInputText();             //clear input text form
            }
            else
            {
                MessageBox.Show("Delete operation don't succsesfully!\n One of data fields is empty!");
            }
        }


        /// <summary>
        ///     Employee text box is empty event Fill DatagrigWiew from database
        /// </summary>
        private void SearchEmployeeTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchEmployeeTextBox.Text))
            {
                FillEmployee();
            }
        }

        private void EmployeeWorkerForm_Load(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.TextInputValidation(sender);

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.TextInputValidation(sender);
        }

        private void SalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.NumericInputValidation(sender);
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
    }
}
