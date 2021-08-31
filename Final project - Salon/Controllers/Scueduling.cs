using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Final_project___Salon
{

    public partial class Scueduling : Form
    {
        private DBSql mySQL;    //var to use Silgelton connection 
        public static string[] dataString = null;   //use in update action 
        private  Basket basket;

        public Scueduling()
        {
            InitializeComponent();
            mySQL = DBSql.Instance;
            FillTimeTable();
            EmployeeFullNameComboBoxFill();
            MonthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
        }

        /// <summary>
        /// Function FillTimeTable Fill Data in DataGrid Wiew
        /// </summary>
        public void FillTimeTable()
        {
            Timetable[] TimetableArray = mySQL.GetTimetableData();
            if (TimetableArray != null)
            {
                FillTimeTable(TimetableArray);
                TimetableDataGridView.Enabled = true;
            }
            else TimetableDataGridView.Enabled = false;
        }

        /// <summary>
        /// Function FillTimeTable Fill Data in DataGrid Wiew
        /// </summary>
        public void FillTimeTable(Timetable[] timetables)
        {

            int rowsCount = timetables.Length ;
            int columnsCount = 11;   //

            TimetableDataGridView.RowCount = rowsCount;
            TimetableDataGridView.ColumnCount = columnsCount;

            TimetableDataGridView.Columns[0].HeaderText = "Date";
            TimetableDataGridView.Columns[1].HeaderText = "Start Time";
            TimetableDataGridView.Columns[2].HeaderText = "Customer Name";
            TimetableDataGridView.Columns[3].HeaderText = "Emplyee Name";
            TimetableDataGridView.Columns[4].HeaderText = "Service Name";
            TimetableDataGridView.Columns[5].HeaderText = "End Time";
            TimetableDataGridView.Columns[6].HeaderText = "Status";
            TimetableDataGridView.Columns[6].Visible = false;
            TimetableDataGridView.Columns[7].HeaderText = "Customer id";
            TimetableDataGridView.Columns[7].Visible = false;
            TimetableDataGridView.Columns[8].HeaderText = "Employee id";
            TimetableDataGridView.Columns[8].Visible = false;
            TimetableDataGridView.Columns[9].HeaderText = "Servise id";
            TimetableDataGridView.Columns[9].Visible = false;
            TimetableDataGridView.Columns[10].HeaderText = "Payed";
            TimetableDataGridView.Columns[10].Visible = false;


            for (int j = 0; j < timetables.Length; j++)
            {
                

                TimetableDataGridView[0, j].Value = timetables[j].Date.ToString("d", CultureInfo.GetCultureInfo("ru-ru"));
                TimetableDataGridView[1, j].Value = timetables[j].Start_time.ToString("t", CultureInfo.GetCultureInfo("ru-ru"));
                TimetableDataGridView[2, j].Value = timetables[j].Customer_name.ToString();
                TimetableDataGridView[3, j].Value = timetables[j].Employee_name.ToString();
                TimetableDataGridView[4, j].Value = timetables[j].Service_name.ToString();
                TimetableDataGridView[5, j].Value = timetables[j].End_time.ToString("t", CultureInfo.GetCultureInfo("ru-ru"));
                TimetableDataGridView[6, j].Value = timetables[j].Status.ToString();

                TimetableDataGridView[7, j].Value = timetables[j].Customer_id;
                TimetableDataGridView[8, j].Value = timetables[j].Employee_id;
                TimetableDataGridView[9, j].Value = timetables[j].Service_id;
                TimetableDataGridView[10, j].Value = timetables[j].Payed;

                if (Convert.ToInt32(TimetableDataGridView[10, j].Value) == 0)
                {
                    TimetableDataGridView.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 176);
                }
                else { TimetableDataGridView.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(129, 187, 152); }

            }
        }

        /// <summary>
        /// Fill Customer combobox 
        /// </summary>

        /// <summary>
        /// Fill Employeer names in combobox 
        /// </summary>
        private void EmployeeFullNameComboBoxFill()
        {
            Employee[] employees = mySQL.GetEmployeeData();
            for (int i = 0; i < employees.Length; ++i)
            {
                EmployeeFullNameComboBox.Items.Add(employees[i].First_name.ToString() + " " + employees[i].Last_name.ToString());
            }
        }

        /// <summary>
        ///  event  Buttonclick "Search timetable"
        /// </summary>
        private void SearchTimetableButton_Click(object sender, EventArgs e)
        {
            Timetable[] timetables = null;
            if (!SearchTimetableTextBox.Text.Equals(""))
            {
                timetables = mySQL.SearchTimetable(SearchTimetableTextBox.Text);// sql query function(return array of timetables)
                if (timetables == null)           //check if timetable array is not empty 
                {
                    FillTimeTable();
                    WarningMessages.WarningMessage(SearchStringLblWarning, $"No records with input value");
                }
                else
                {
                    FillTimeTable(timetables);
                }

            }

        }
        /// <summary>
        ///   Search text box function
        /// </summary>
        private void SearchTimetableTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchTimetableTextBox.Text))
            {
                FillTimeTable();
            }
        }

        private void CustomerFullNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///   event button click fill data in datagridview 
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            FillTimeTable();
            ShoByPayingComboBox.Text = "select record";
            EmployeeFullNameComboBox.Text = "select name";
        }


        /// <summary>
        ///    Method call another function from DBCalss 
        ///    which find records in database by calendar date and
        ///    display results in datagrid view 
        /// </summary>
        private void SearchByDateButton_Click(object sender, EventArgs e)
        {
            string data = MonthCalendar.SelectionRange.Start.Date.ToString("yyyy-MM-dd");
            Timetable[] timetables = null;


            timetables = mySQL.SearchTimetableByDate(data);
            if (timetables != null)
            {
                FillTimeTable(timetables);
            }
            else
            {
                WarningMessages.WarningMessage(SearchByCalendarblWarning, $"No records on input date!");
            }


        }


        /// <summary>
        ///    Event to choose Employee name in combobox and display records due to Employee in Datagrid view 
        /// </summary>
        private void EmployeeFullNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Timetable[] timetables = null;
            Timetable[] tmp = mySQL.GetTimetableData();     //get data  from db 
            string name = EmployeeFullNameComboBox.SelectedItem.ToString();       //chose selected item
            int i, j;

            if(tmp ==null) { return; }
            timetables = new Timetable[tmp.Length];
            for (j = 0, i = 0; j < tmp.Length; j++)      //run into records
            {

                if (tmp[j].Employee_name.Equals(name))        //check if find 
                {
                    timetables[i] = new Timetable();
                    timetables[i] = tmp[j].ShallowCopy();    //copy obj 
                    i++;
                }


            }
            Array.Resize(ref timetables, i);       //resize attay of timetables 

            if (timetables != null && i != 0)    //if timetable exist 
            {
                FillTimeTable(timetables);
            }
            else
            {
                WarningMessages.WarningMessage(EmployeeLblWarning, $"Not found records for employee {name}");
                FillTimeTable();

            }
        }

        /// <summary>
        ///  Event Insert => call form with "Insert" button and text  design 
        /// </summary>
        private void InsertTimetableButton_Click(object sender, EventArgs e)
        {
            TimetableInputForm form = new TimetableInputForm();
            
            form.InsertProperties();
            form.FormClosed += TimetableInput_FormClosed;
            form.Show();
    
        }
         /// <summary>
         ///  Event to Refresh DATAgridView after update and delete actions  
         /// </summary>

        private  void TimetableInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillTimeTable();
        }


        /// <summary>
        ///    Event Double click on datagrid view => open new form and ask what te wand to do with choise we did   
        /// </summary>
        private void TimetableDataGridView_DoubleClick(object sender, EventArgs e)
        {

            DataGridClick();                //function to add selected data to dataString static array  

            MessageBoxManagerForm message = new MessageBoxManagerForm();
            message.Show();
            message.FormClosed += TimetableInput_FormClosed;


        }

        private void DataGridClick()
        {
            dataString = new string[10];


            if (TimetableDataGridView.CurrentRow.Index != -1)     //check if we clicked on table => insert input fields in form 
            {

                for (int i = 0; i < 10; ++i)     //10 - count of properties in datagrid view table 
                {
                    dataString[i] = TimetableDataGridView.CurrentRow.Cells[i].Value.ToString();
                }

            }
        }
               

        /// <summary>
        ///      Event oneckick on table: =>  call function BasketDataChange 
        ///      event select data from timetable and push it to basket 
        /// </summary>

        private void TimetableDataGridView_Click(object sender, EventArgs e)
        {
           
            Timetable[] timetables = null;
            Service[] services = null;
            
            DataGridClick();     //function to add selected data to dataString static array 
            timetables = mySQL.GetTimetableData("SELECT t.date, t.start_time, CONCAT(e.first_name, ' ', e.last_name) , CONCAT(c.first_name, ' ', c.last_name), s.name_service, t.end_time, t.status, t.customer_id, t.employee_id, t.service_id, t.payed FROM timetable t INNER JOIN customers c ON t.customer_id = c.customer_id INNER JOIN employees e ON t.employee_id = e.employee_id INNER JOIN services s ON t.service_id = s.service_id ORDER BY `date`,`employee_id`,`start_time` ");
            services = mySQL.GetServices();
            BasketTextBox.Text = "";
            BasketDataChange(timetables, services);


        }
        /// <summary>
        ///    Method take data from timetable and search him service name, price and executing time
        ///    than display data on basket for user 
        ///    And Fill Basket for paying 
        /// </summary>
        /// <param name="timetables"> array of timetables records </param>
        /// <param name="services">array of services</param>
        private void BasketDataChange(Timetable[] timetables, Service[] services)
        {
            basket = new Basket();
            Customer customer = new Customer();
            List<Service> tmpServices = new List<Service>();// list of serices for filling basket service array for pay
            List<DateTime> dateOfProc = new List<DateTime>();
            double totalSum = 0;
            double estimateTime = 0;
            int index = 0;

            mySQL.GetCustomerById(customer ,Convert.ToInt32(TimetableDataGridView.CurrentRow.Cells[7].Value));//get customer by Id

            for (int i = 0, j = 0; i < timetables.Length; i++)      //run into timetable records
            {
                if (timetables[i].Customer_name.Equals(dataString[2]) && timetables[i].Payed == 0)   //customer not paid 
                {
                    BasketTextBox.Text += $"{++j}. " + timetables[i].Service_name.ToString();
                    while (!(services[index].Name.Equals(timetables[i].Service_name)))           //search service 
                    {
                        index++;
                    }
                    tmpServices.Add(services[index]);
                    basket.dateOfServices.Add(Convert.ToDateTime(timetables[i].Date));
                    BasketTextBox.Text += $" - {services[index].ExecutingTime.ToString()} min --- {services[index].Price.ToString()} ₪" + System.Environment.NewLine;
                    estimateTime += services[index].ExecutingTime;
                    totalSum += services[index].Price;
                }
                
                TotalSumLabel.Text = totalSum.ToString() + " ₪";
                EstimateTimeLabel.Text = estimateTime.ToString() + " min";

                index = 0;
            }
            if (tmpServices.Count > 0)
            {
                basket.Services = tmpServices.ToArray();//fill array of services for pay
                basket.PayDate = DateTime.Now;// date of pay
                basket.Customer = customer;
            }
            PayButtonEnabled();

            CustomerNameLabelFromStringArray.Text = dataString[2];  // Customer name index - [2]
        }
      
        private void PayButtonEnabled()
        {
            if (basket == null || basket.Services==null) AddBasketButton.Enabled = false;
            else AddBasketButton.Enabled = true;
        }
        


     /// <summary>
     ///            MEthod is clean basket
     /// </summary>
        private void CleanBasketButton_Click(object sender, EventArgs e)
        {
            CustomerNameLabelFromStringArray.Text = BasketTextBox.Text = EstimateTimeLabel.Text = TotalSumLabel.Text = "";
            basket = null;
            PayButtonEnabled();
        }
        

        private void AddBasketButton_Click(object sender, EventArgs e)
        {
            PayingForm form = new PayingForm();            
            form = (PayingForm)Application.OpenForms["PayingForm"];
            form.Basket = basket;
            CleanBasketButton_Click(sender,e);
            FillTimeTable();
            form.SetAllPayingData();
            form.Show();
        }

        /// <summary>
        ///      ShowByPayingComboBoxPayedOptionSelected - method show in datagridview payed records 
        /// </summary>
        private void ShowByPayingComboBoxPayedOptionSelected()
        {
            Timetable[] timetables_payed = null;
            Timetable[] tmp = mySQL.GetTimetableData();     //get data  from db 
            string name = ShoByPayingComboBox.SelectedItem.ToString();       //chose selected item
            int i, j;

            if (timetables_payed == null) { return; }
            timetables_payed = new Timetable[tmp.Length];

            for (j = 0, i = 0; j < tmp.Length; j++)      //run into records
            {

                if (tmp[j].Payed.Equals(1))        //check if find 
                {
                    timetables_payed[i] = new Timetable();
                    timetables_payed[i] = tmp[j].ShallowCopy();    //copy obj 
                    i++;
                }
            }
            Array.Resize(ref timetables_payed, i);       //resize attay of timetables 

            if (timetables_payed != null && i != 0)    //if timetable exist 
            {
                FillTimeTable(timetables_payed);
            }
            else
            {
                FillTimeTable();
            }

        }

        /// <summary>
        ///      ShowByPayingComboBoxNotPayedOptionSelected - method show in datagridview not payed records 
        /// </summary>
        private void ShowByPayingComboBoxNotPayedOptionSelected()
        {
            Timetable[] timetables_not_payed = null;
            Timetable[] tmp = mySQL.GetTimetableData("SELECT t.date, t.start_time, CONCAT(e.first_name, ' ', e.last_name) , " +
                "CONCAT(c.first_name, ' ', c.last_name), s.name_service, t.end_time, t.status, t.customer_id, t.employee_id, t.service_id, t.payed FROM timetable t INNER JOIN customers c " +
                "ON t.customer_id = c.customer_id INNER JOIN employees e ON t.employee_id = e.employee_id INNER JOIN services s ON t.service_id = s.service_id ORDER BY `date`,`employee_id`,`start_time` ");     //get data  from db 
            string name = ShoByPayingComboBox.SelectedItem.ToString();       //chose selected item
            int k, j;

            timetables_not_payed = new Timetable[tmp.Length];

            for (j = 0, k = 0; j < tmp.Length; j++)      //run into records
            {

                if (tmp[j].Payed.Equals(0))        //check if find 
                {
                    timetables_not_payed[k] = new Timetable();
                    timetables_not_payed[k] = tmp[j].ShallowCopy();    //copy obj 
                    k++;
                }
            }
            Array.Resize(ref timetables_not_payed, k);       //resize array of timetables 

            if (timetables_not_payed != null && k != 0)    //if timetable exist 
            {
                FillTimeTable(timetables_not_payed);
            }
            else
            {
                FillTimeTable();
            }
        }

        /// <summary>
        ///    Event to show  payed or not payed records int datatable 
        /// </summary>

        private void ShoByPayingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {             
            Timetable[] tmp = mySQL.GetTimetableData();     //get data  from db 
            string name = ShoByPayingComboBox.SelectedItem.ToString();       //chose selected 
            
            if (name == "payed")
            {
                ShowByPayingComboBoxPayedOptionSelected();
            }
            else
            {
                ShowByPayingComboBoxNotPayedOptionSelected();
            }
        }

    }
    
}

