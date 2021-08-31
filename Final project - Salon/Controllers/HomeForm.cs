using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;
using System.Drawing;

namespace Final_project___Salon
{

    
    public partial class HomeForm : Form
    {
        DBSql mySQL;
        List<Timetable> timetables = new List<Timetable>();
        Customer[] customers = null;
        Employee[] employees = null;
        Service[] services = null;

        static string Myquery = "SELECT t.date, t.start_time, CONCAT(e.first_name, ' ', e.last_name) , CONCAT(c.first_name, ' ', c.last_name), s.name_service, t.end_time, t.status, t.customer_id, t.employee_id, t.service_id, t.payed FROM timetable t INNER JOIN customers c ON t.customer_id = c.customer_id INNER JOIN employees e ON t.employee_id = e.employee_id INNER JOIN services s ON t.service_id = s.service_id  ORDER BY `date`,`employee_id`,`start_time`";


        public HomeForm()
        {
            InitializeComponent();
            DBSql.Password = string.Empty;
            mySQL = DBSql.Instance;
            SetTitle();
            EmpGraphFillData();
            ServiceGraphFillData();
            CustomerGraphFillData();
            EmployeeStatisticGraphFillData();
            FillTimeTable();
        }
        private void HomeForm_Load(object sender, System.EventArgs e)
        {
            FillData();
            DisplayClientsNumber();
            DisplayEmployeesNumber();
            DisplayServicesNumber();
            IncomevaluesFill();
            SetPerformedServices();
            SetTotalWorkTime();
        }

        public void FillTimeTable()
        {
            Timetable[] TimetableArray = mySQL.GetTimetableData();
            if (TimetableArray != null)
            {
                FillTimeTable(TimetableArray);
                HomeStatisticDataGridView.Enabled = true;
            }
            else HomeStatisticDataGridView.Enabled = false;
        }

        /// <summary>
        /// Function FillTimeTable Fill Data in DataGrid Wiew
        /// </summary>
        public void FillTimeTable(Timetable[] timetables)
        {

            int rowsCount = timetables.Length;
            int columnsCount = 11;   //

            HomeStatisticDataGridView.RowCount = rowsCount;
            HomeStatisticDataGridView.ColumnCount = columnsCount;

            HomeStatisticDataGridView.Columns[0].HeaderText = "Date";
            HomeStatisticDataGridView.Columns[1].HeaderText = "Start Time";
            HomeStatisticDataGridView.Columns[2].HeaderText = "Customer Name";
            HomeStatisticDataGridView.Columns[3].HeaderText = "Employee Name";
            HomeStatisticDataGridView.Columns[4].HeaderText = "Service Name";
            HomeStatisticDataGridView.Columns[5].HeaderText = "End Time";
            HomeStatisticDataGridView.Columns[6].HeaderText = "Status";
            HomeStatisticDataGridView.Columns[6].Visible = false;
            HomeStatisticDataGridView.Columns[7].HeaderText = "Customer id";
            HomeStatisticDataGridView.Columns[7].Visible = false;
            HomeStatisticDataGridView.Columns[8].HeaderText = "Employee id";
            HomeStatisticDataGridView.Columns[8].Visible = false;
            HomeStatisticDataGridView.Columns[9].HeaderText = "Service id";
            HomeStatisticDataGridView.Columns[9].Visible = false;
            HomeStatisticDataGridView.Columns[10].HeaderText = "Payed";
            HomeStatisticDataGridView.Columns[10].Visible = false;


            for (int j = 0; j < timetables.Length; j++)
            {
                if (timetables[j].Date.Day == DateTime.Today.Day)
                {
                    HomeStatisticDataGridView[0, j].Value = timetables[j].Date.ToString("d", CultureInfo.GetCultureInfo("ru-ru"));
                    HomeStatisticDataGridView[1, j].Value = timetables[j].Start_time.ToString("t", CultureInfo.GetCultureInfo("ru-ru"));
                    HomeStatisticDataGridView[2, j].Value = timetables[j].Customer_name.ToString();
                    HomeStatisticDataGridView[3, j].Value = timetables[j].Employee_name.ToString();
                    HomeStatisticDataGridView[4, j].Value = timetables[j].Service_name.ToString();
                    HomeStatisticDataGridView[5, j].Value = timetables[j].End_time.ToString("t", CultureInfo.GetCultureInfo("ru-ru"));
                    HomeStatisticDataGridView[6, j].Value = timetables[j].Status.ToString();

                    HomeStatisticDataGridView[7, j].Value = timetables[j].Customer_id;
                    HomeStatisticDataGridView[8, j].Value = timetables[j].Employee_id;
                    HomeStatisticDataGridView[9, j].Value = timetables[j].Service_id;
                    HomeStatisticDataGridView[10, j].Value = timetables[j].Payed;

                    if (Convert.ToInt32(HomeStatisticDataGridView[10, j].Value) == 0)
                    {
                        HomeStatisticDataGridView.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 176);
                    }
                    else { HomeStatisticDataGridView.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(129, 187, 152); }
                }
            }
        }
        /// <summary>
        /// Title Message foe Admin or Secretary
        /// </summary>
        private void SetTitle()
        {
            if (RegistrationForm.company.IfBoss)
            {
                lblTitle.Text = "Hello Admin";
            }
            else
            {
                lblTitle.Text = "Hello Secretary";
            }
        }
        /// <summary>
        /// Display current number of customers in system
        /// </summary>
        private void DisplayClientsNumber()
        {
            lblClientsNumber.Text = customers.Length.ToString();
        }
        /// <summary>
        /// Display current number of employees in system
        /// </summary>
        private void DisplayEmployeesNumber()
        {
            lblEmployees.Text = employees.Length.ToString();
        }
        /// <summary>
        /// Display current number of services in system
        /// </summary>
        private void DisplayServicesNumber()
        {
            lblServiceNumber.Text = mySQL.GetServicesCount().ToString();
        }

        /// <summary>
        /// Fill All objects from DB : Employees, Customers, Services, Timetable
        /// </summary>
        private void FillData()
        {
            customers = mySQL.GetCustomerData();
            employees = mySQL.GetEmployeeData();
            services = mySQL.GetServicesWithDeleted();
            mySQL.GetTimeTableCollection(timetables);
        }


        /// <summary>
        /// Display All services that were made
        /// </summary>
        private void SetPerformedServices()
        {
            var performedServices = timetables.Where(table => table.Payed == 1).Count();
            lblPerformedServices.Text = performedServices.ToString();
        }

        /// <summary>
        /// Time of all ended services
        /// </summary>
        private void SetTotalWorkTime()
        {
            double totalTime = 0;

            var totalServ = timetables.Where(table => table.Payed == 1).Select(table=>table.Service_id);
            foreach(var serv in totalServ)
            {
                foreach(Service service in services)
                {
                    if(service.Id == Convert.ToInt32(serv))
                    {
                        totalTime += service.ExecutingTime;
                    }
                }
            }

            lblTotalWorkTime.Text = (totalTime / 60) + " H";
        }

        private void IncomevaluesFill()
        {
            DateTime month = DateTime.Today.AddMonths(-1);
            DateTime year = DateTime.Today.AddYears(-1);
            CalculateAndSetIncomeLastMonth(month);
            CalculateAndSetIncomeLastYear(year);
            CalculateAndSetIncomeAllTine();

        }
        private void CalculateAndSetIncomeAllTine()
        {
            long sum = 0;
            var allTimeServices = timetables.Where(table => table.Payed == 1).Select(table => table.Service_id).ToArray();
            for (int i = 0; i < allTimeServices.Length; i++)
            {
                sum += (long)services.Where(service => service.Id == allTimeServices[i]).Select(service => service.Price).Single();
            }
            lblIncomeAllTime.Text = sum.ToString() + " ₪";
        }
        private void CalculateAndSetIncomeLastYear(DateTime year)
        {
            long sum = 0;
            var lastYearServices = timetables.Where(table => table.Date > year).Where(table => table.Payed == 1).Select(table => table.Service_id).ToArray();
            for (int i = 0; i < lastYearServices.Length; i++)
            {
                sum += (long)services.Where(service => service.Id == lastYearServices[i]).Select(service => service.Price).Single();
            }
            lblIncomeYear.Text = sum.ToString() + " ₪";
        }
        private void CalculateAndSetIncomeLastMonth(DateTime month)
        {
            long sum = 0;
            var lastMonthServices = timetables.Where(table => table.Date > month).Where(table => table.Payed == 1).Select(table => table.Service_id).ToArray();
            for (int i = 0; i < lastMonthServices.Length; i++)
            {
                sum += (long)services.Where(service => service.Id == lastMonthServices[i]).Select(service => service.Price).Single();
            }
            lblIncomeMonth.Text = sum.ToString() + " ₪";
        }


        /// <summary>
        /// Fill Employee data to graph
        /// </summary>
        private void EmpGraphFillData()
        {
            Employee[] employees = mySQL.GetEmployeeData();

            for (int i = 0; i < employees.Length; ++i)
            {
                EmployeeChart.Series["Salary"].Points.AddXY(employees[i].First_name.ToString(), employees[i].Salary.ToString());
            }
        }

        /// <summary>
        /// Fill Service price data to graph
        /// </summary>
        private void ServiceGraphFillData()
        {
            Service[] services = mySQL.GetServices();

            for (int i = 0; i < services.Length; ++i)
            {
                ServiceChart.Series["Price"].Points.AddXY(services[i].Name.ToString(), services[i].Price.ToString());
            }
        }

        /// <summary>
        /// Fill Employee data to graph
        /// </summary>
        private void CustomerGraphFillData()
        {
            Timetable[] timetables = mySQL.GetTimetableData(Myquery);
            int[] counter_array = new int[1000]; // 1000 - array of counters for id's

            if (timetables == null) return;
            for (int i = 0; i < timetables.Length; ++i)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (timetables[i].Customer_id == j)
                    {
                        counter_array[j]++;
                        break;
                    }
                }                  
            }
            timetables = CustomerGraphNonReturnedNames(timetables);
            for (int i = 0; i < timetables.Length; ++i)
            {              
                for (int j = 0; j < 1000; j++)
                {
                    if (j == timetables[i].Customer_id )
                    {                      
                        CustomerChart.Series["Count of services"].Points.AddXY(timetables[i].Customer_name.ToString(), counter_array[j].ToString());
                    }
                }                      
            }        
        }
        /// <summary>
        ///    Functions to get and  sort and than  return unique values in timtable array
        /// </summary>

        private Timetable[] CustomerGraphNonReturnedNames(Timetable[] timetables)
        {
            List<Timetable> list = timetables.ToList();       //array converted to list
            var res = list.GroupBy(x => x.Customer_id).Select(x => x.First());             //getUniqe  values in list 
            timetables = res.ToArray();
            return timetables;

        }


        private void EmployeeStatisticGraphFillData()
        {
            
            Timetable[] timetables = mySQL.GetTimetableData(Myquery);
            int[] counter_array = new int[1000]; // 1000 - array of counters for id's
            if (timetables == null) { return; }
            for (int i = 0; i < timetables.Length; ++i)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (timetables[i].Customer_id == j)
                    {
                        counter_array[j]++;
                        break;
                    }
                }
            }
            timetables = EmployeeGraphNonReturnedNames(timetables);
            for (int i = 0; i < timetables.Length; ++i)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (j == timetables[i].Customer_id)
                    {
                        EmployeeStatChart.Series["Count of clients"].Points.AddXY(timetables[i].Employee_name.ToString(), counter_array[j].ToString());
                    }
                }
            }
        }
        /// <summary>
        ///    Functions to get and  sort and than  return unique values in timtable array
        /// </summary>

        private Timetable[] EmployeeGraphNonReturnedNames(Timetable[] timetables)
        {
            List<Timetable> list = timetables.ToList();       //array converted to list
            var res = list.GroupBy(x => x.Employee_id).Select(x => x.First());             //getUniqe  values in list 
            timetables = res.ToArray();
            return timetables;

        }

  

    }
}


