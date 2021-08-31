using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Final_project___Salon
{
 
    public partial class TimetableInputForm : Form
    {
        private DBSql mySQL;    //var to use Silgelton connection 
        private List<Timetable> timeTable; // list of time tables for update
        private List<Service> serviceList = new List<Service>();//services wich wa are chose
        private List<Service> serviceListFromDB;//services from data base
        private List<TimeSpan> timesList = new List<TimeSpan>();//list of time which we will can to order queue
        private Customer[] customers;
        private Employee[] employees;
        private TimeSpan step = new TimeSpan(0, 30, 0);
        
        private Employee employee = new Employee();//employee from combo box for queue order        
        private Customer customer = new Customer();// customer from combobox for queue order
        private string date = null;//date for queue

        TimeSpan maxTime = new TimeSpan();
        TimeSpan minTime = new TimeSpan();
        public TimetableInputForm()
        {
            InitializeComponent();
            mySQL = DBSql.Instance;
            this.StartPosition = FormStartPosition.CenterScreen;
            serviceListFromDB = mySQL.GetServicesCollection();            
            DateOperationPicker.MinDate = DateTime.Now;
            TimeList(timesList);// TIMES COLLECTION LIST
            ComboEmployeeAndCustomerFill();
            ServiceListBoxFill();
            
        }

      
        /// <summary>
        ///     Event close TimetableInputForm 
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// BUTTON TEXT and title  CHANGE 
        /// </summary>
        public void InsertProperties()
        {
            this.Text = "Insert form";
            this.AddButton.Text = "Insert";
        }
        /// <summary>
        /// BUTTON And Title TEXT CHANGE 
        /// </summary>
        public void UpdateProperties()
        {
            this.Text = "Update form";
            this.AddButton.Text = "Update";
            FillPapametrsFieldsAsync();
        }


        /// <summary>
        /// Insert Method to insert Timetabe record in database 
        /// </summary>
        private async Task InsertAsync()
        {
            if (serviceList.Count == 0)
            {
                WarningMessages.WarningMessage(ErrorChoiseLabel, "Add at least one Service!");
            }
            else
            {
                
                if (comBoxFreeTime.SelectedItem == null)
                {
                    WarningMessages.ShortMessage(ErrorChoiseLabel, "Time wasn`t selected!");
                    return;
                }
                DateTime startTime = DateTime.Parse(comBoxFreeTime?.SelectedItem?.ToString());//Check If comboBox Free time is not null(if null exite from method)
                for (int i = 0; i < serviceList.Count; i++)
                {
                    Timetable oneTimetableRecord = new Timetable();
                    oneTimetableRecord = CreateTimetableViaForm(i, ref startTime);
                    mySQL.InsertTimetable(oneTimetableRecord);
                }
                WarningMessages.ShortMessage(ErrorChoiseLabel, "Inserted succsesfully!");
                await Task.Delay(1500);
                this.Close();
            }
        }

        /// <summary>
        /// Method to update timetable record 
        /// </summary>
        private async Task UpdateAsync()
        {
            Timetable old_record = new Timetable();
            old_record.FromStaticStringToTimetableOblect();

            if (serviceList.Count == 0)
            {
                WarningMessages.WarningMessage(ErrorChoiseLabel, "Set All Options!");
            }
            else
            {
                DateTime startTime = DateTime.Parse(comBoxFreeTime.SelectedItem.ToString());
                for (int i = 0; i < serviceList.Count; i++)
                {
                    Timetable new_record = new Timetable();
                    new_record = CreateTimetableViaForm(i, ref startTime);
                    if (i + 1 > timeTable.Count)
                    {
                        mySQL.InsertTimetable(new_record);
                    }
                    else if((i+1 ==serviceList.Count)&& serviceList.Count< timeTable.Count)
                    {
                        for(; i<timeTable.Count; i++)
                        {
                            mySQL.DeleteTimetable(timeTable[i]);
                        }
                    }else    mySQL.UpdateTimetable(timeTable[i], new_record);
                }
                WarningMessages.ShortMessage(ErrorChoiseLabel, "Update succsesfully!");
                await Task.Delay(1500);
                this.Close();
            }
        }
        /// <summary>
        ///   Function Create and fill one Timetable record use in  insert and  update  functions 
        /// </summary>
        /// <returns>Timetable record </returns>
        private Timetable CreateTimetableViaForm(int i, ref DateTime startTime)
        {
            TimeSpan exe_Time =TimeSpanMultiply(step, (int)Math.Ceiling(serviceList[i].ExecutingTime/ step.TotalMinutes));
            Timetable oneTimetableRecord = new Timetable();
            oneTimetableRecord.Date = DateOperationPicker.Value;
            oneTimetableRecord.Start_time = startTime;
            oneTimetableRecord.Employee_id = employee.Employee_id;
            oneTimetableRecord.Customer_id = customer.Customer_id;
            oneTimetableRecord.Service_id = serviceList[i].Id;
            oneTimetableRecord.End_time = startTime.AddMinutes(exe_Time.TotalMinutes);

            startTime = startTime.AddMinutes(exe_Time.TotalMinutes);

            return oneTimetableRecord;
        }

       
        /// <summary>
        /// Function Fill data to static string in Scueduling class
        /// </summary>
        private async Task FillPapametrsFieldsAsync()
        {
            List<Timetable> tmp = new List<Timetable>();
            DateTime date = Convert.ToDateTime(Scueduling.dataString[0]);
            DateTime start_time = Convert.ToDateTime(Scueduling.dataString[1]);
            timeTable = new List<Timetable>();
            int emp_id = Convert.ToInt32(Scueduling.dataString[8]);
            int cust_id = Convert.ToInt32(Scueduling.dataString[7]);
            tmp = mySQL.GetQueue(date,start_time,emp_id,cust_id);

            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].Start_time == start_time)
                {                    
                    for (;i>0 && tmp[i].Start_time == tmp[i - 1].End_time; i--);
                    for (; i+1 < tmp.Count && tmp[i].End_time == tmp[i + 1].Start_time; i++) timeTable.Add(tmp[i]) ;
                    timeTable.Add(tmp[i]);
                }
            }
            if (timeTable != null && timeTable[0].Date>DateOperationPicker.MinDate)
            {
                                
                DateOperationPicker.Value = timeTable[0].Date;
                comboCustomers.SelectedItem = comboCustomers.Items[comboCustomers.Items.IndexOf(GetCustomerById(cust_id))]; 
                comboEmployees.SelectedItem = comboCustomers.Items[comboEmployees.Items.IndexOf(GetEmployeeById(emp_id))];
                if (serviceListFromDB.Count != 0)
                {
                    for (int i = 0; i < timeTable.Count; i++)
                    {
                        serviceList.Add(GetServiceById(timeTable[i].Service_id));
                        serviceListFromDB.Remove(GetServiceById(timeTable[i].Service_id));
                    }

                }
                ListBoxClean();
                ServiceListBoxFill_CleanTimeComboBox_FillTimesComboBox();
            }
            else
            {
                MessageBox.Show(this, "Coudn`t Update! Old Record!");
                this.Close();
            }
        }
        private Employee GetEmployeeById(int id)
        {
            Employee employee = null;
            var empTmp = from e in employees where e.Employee_id == id select e;
            foreach (var item in empTmp)
            {
                employee = item;
            }
            return employee;
        }

        private Customer GetCustomerById(int id)
        {
            Customer customer = null;
            var cust= from e in customers where e.Customer_id == id select e;
            foreach(var item in cust)
            {
                customer = item;
            }
            return customer;
        }
        private Service GetServiceById(int id)
        {
            Service service = null;
            var serv = from s in serviceListFromDB where s.Id == id select s;
            foreach (var item in serv)
            {
                service = item;
            }
            return service;
        }
        /// <summary>
        ///   Event AddButtonClick to Insert  or Update Timetable record 
        /// </summary>

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (this.Text.ToString())
            {
                case "Insert form":
                    InsertAsync();
                    break;
                case "Update form":
                    UpdateAsync();
                    break;
            }                       
        }

        /// <summary>
        /// Fill right list by services for chose
        /// </summary>
        private void ServiceListBoxFill()
        {
            listBoxServicesFromDB.DataSource = serviceListFromDB;
            listBoxServicesFromDB.DisplayMember = "Name";
            listBoxServicesFromDB.ValueMember = "Id";
            ServiceLeftBoxFill();
        }

        /// <summary>
        /// Chosen services, was dropped to left list box
        /// </summary>
        private void ServiceLeftBoxFill()
        {           
            listBoxServices.DataSource = serviceList;
            listBoxServices.DisplayMember = "Name";
            listBoxServices.ValueMember = "Id";
            FillTotal();
        }

        /// <summary>
        /// clean all list boxes for new filling
        /// </summary>
        private void ListBoxClean()
        {
            listBoxServices.DataSource = null;
            listBoxServices.Items.Clear();
            listBoxServicesFromDB.DataSource = null;
            listBoxServicesFromDB.Items.Clear();
        }
        /// <summary>
        /// drop service from right listbox to left
        /// </summary>
        private void MoveFromRightToLeft()
        {
            if (listBoxServicesFromDB.SelectedItem != null)
            {
                serviceList.Add((Service)listBoxServicesFromDB.SelectedItem);
                serviceListFromDB.Remove((Service)listBoxServicesFromDB.SelectedItem);                
            }
            ListBoxClean();

        }

        /// <summary>
        /// drop service from left listbox to right
        /// </summary>
        private void MoveFromLeftToRight()
        {
            if (serviceList.Count != 0 && listBoxServices.SelectedItem!=null)
            {
                Service serv = (Service)listBoxServices.SelectedItem;
                serviceListFromDB.Add(serv);
                serviceList.Remove(serv);               
            }
            ListBoxClean();

        }

        /// <summary>
        /// return all services to right list box
        /// </summary>
        private void ClearLeftListBox()
        {
            if (serviceList.Count != 0)
            {                
                serviceListFromDB.AddRange(serviceList);
                serviceList.Clear();
            }
            ListBoxClean();
        }


        //--------------BUTTONS EVENTS
        /// <summary>
        /// add service to left list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddService_Click(object sender, EventArgs e)
        {
            MoveFromRightToLeft();
            ServiceListBoxFill_CleanTimeComboBox_FillTimesComboBox();
        }
        /// <summary>
        /// remove service from right list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveService_Click(object sender, EventArgs e)
        {
            MoveFromLeftToRight();
            ServiceListBoxFill_CleanTimeComboBox_FillTimesComboBox();
            listBoxServices.Focus();
            listBoxServices.SelectedIndex = serviceList.Count-1;
        }
        /// <summary>
        /// remove all services from right list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCleanServices_Click(object sender, EventArgs e)
        {
            ClearLeftListBox();
            ServiceListBoxFill_CleanTimeComboBox_FillTimesComboBox();
        }
        /// <summary>
        /// 3 Methods in 1, for list box buttons events
        /// </summary>
        private void ServiceListBoxFill_CleanTimeComboBox_FillTimesComboBox()
        {
            ServiceListBoxFill();
            CleanTimeComboBox();
            FillTimesComboBox();
        }
        //-------------------------------

        /// <summary>
        /// display total executing time and price for services in left list box
        /// </summary>
        private void FillTotal()
        {
            lblTotal.Text = $"Total Sum: {GetTotalSum()}\nTotal Time: {GetExecutingTime()} min";
        }
        /// <summary>
        /// calculate executing time
        /// </summary>
        /// <returns>total executing time</returns>
        private double GetExecutingTime()
        {
            double time = 0;
            foreach (var serv in serviceList)
            {
                time += serv.ExecutingTime;
            }
            return time;
        }
        /// <summary>
        /// Calculate price of all services
        /// </summary>
        /// <returns>total price</returns>
        private double GetTotalSum()
        {
            double sum = 0;
            foreach(var serv in serviceList)
            {
                sum += serv.Price;
            }
            return sum;
        }

        /// <summary>
        /// fill default list of time for queue with 30 min steps
        /// </summary>
        /// <param name="times"></param>
        private void TimeList(List<TimeSpan> times)
        {                   
            
            times.Add(minTime);
            for (; times[times.Count - 1] < maxTime;)
            {
                times.Add(times[times.Count - 1] + step);
            }
        }
        private void TimeListForRemove(List<TimeSpan> times)
        {                        
            List<TimeSpan> tmp = new List<TimeSpan>();
            double executeTime = GetExecutingTime();
            int stepCount = (int)Math.Ceiling(executeTime/step.TotalMinutes);
            foreach(var time in times)
            {
                for (int i = 1; i < stepCount; i++)
                {
                    tmp.Add(time - TimeSpanMultiply(step,i));
                }
            }
            times.AddRange(tmp);
        }


        /// <summary>
        /// Multiply step by quantity of steps from executing time, for removing from free times
        /// </summary>
        /// <param name="time">we getting count of steps from this time</param>
        /// <param name="multi">count of step</param>
        /// <returns>time for remove</returns>
        private TimeSpan TimeSpanMultiply(TimeSpan time, int multi)
        {
            TimeSpan mulTime = new TimeSpan(0, 0, 0);
            if (multi == 0)
            {
                return mulTime;
            }
            
            for(int i = 0; i < multi; i++)
            {
                mulTime += time;
            }
            return mulTime;
        }
        /// <summary>
        /// fill times combo box and remove ordered time by employee and customer
        /// </summary>
        private void FillTimesComboBox()
        {
            List<TimeSpan> remTimes = mySQL.GetTimeForRemoveFromeTimeTable(date, employee, customer);
            if (remTimes == null)
            {
                remTimes = new List<TimeSpan>();
            }
            remTimes.Add(maxTime);// remove time from work day end
            TimeListForRemove(remTimes);
            foreach (var rem in remTimes)
            {
                timesList.Remove(rem);
            }
            

            comBoxFreeTime.DataSource = timesList;

        }
        /// <summary>
        /// Clean times combo box for refilling
        /// </summary>
        private void CleanTimeComboBox()
        {
            comBoxFreeTime.DataSource = null;
            timesList.Clear();
            TimeList(timesList);
        }

        /// <summary>
        /// Fiil combo box of customers and employees from data base
        /// </summary>
        private void ComboEmployeeAndCustomerFill()
        {
            customers = mySQL.GetCustomerData();
            employees = mySQL.GetEmployeeData();
            comboEmployees.DataSource = employees;
            comboEmployees.DisplayMember = "FullName";
            comboCustomers.DataSource = customers;
            comboCustomers.DisplayMember = "FullName";
        }

        private void comboCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            CleanTimeComboBox();
            customer = (Customer)comboCustomers.SelectedItem;
            FillTimesComboBox();
        }

        private void comboEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            CleanTimeComboBox();
            employee = (Employee)comboEmployees.SelectedItem;
            FillTimesComboBox();
        }

        private void DateOperationPicker_ValueChanged(object sender, EventArgs e)
        {
            SetMinAndMaxTimeFromReg();
            CleanTimeComboBox();
            date = DateOperationPicker.Value.ToShortDateString();            
            FillTimesComboBox();

        }

        //Set min and max time for queue from regist(Job Time)
        private void SetMinAndMaxTimeFromReg()
        {
            TimeSpan nowTime = Convert.ToDateTime(DateTime.Now.ToString("HH:mm")).TimeOfDay; // this is now time, for removing past houers from today
            foreach (var key in SettingsForm.jobTime.Keys)
            {

                if (DateOperationPicker.Value.DayOfWeek + " max" == key)
                {
                    maxTime = SettingsForm.jobTime[key].TimeOfDay;
                    break;
                }      
            }
           
            if(DateOperationPicker.Value.DayOfWeek != DateTime.Now.DayOfWeek)
            {
                foreach (var key in SettingsForm.jobTime.Keys)
                {

                    if (DateOperationPicker.Value.DayOfWeek + " min" == key)
                    {
                        minTime = SettingsForm.jobTime[key].TimeOfDay;
                        break;
                    }
                }
                return;
            }

            if (maxTime == nowTime || maxTime < nowTime)
            {
                minTime = maxTime;// if now time not below maxtime, set same min and max time, that couldn't  to get queue
            }
            else
            {
                //set min time
                foreach (var key in SettingsForm.jobTime.Keys)
                {

                    if (DateOperationPicker.Value.DayOfWeek + " min" == key)
                    {
                        minTime = SettingsForm.jobTime[key].TimeOfDay;
                        break;
                    }
                }
                if (minTime < nowTime)
                {
                    if (nowTime.Minutes > 30)
                    {
                        minTime = nowTime.Add(TimeSpan.FromHours(1)).Subtract(TimeSpan.FromMinutes(nowTime.Minutes));// set minimim Time, round forward to xx:00 (if now time 7:35 as forward to 8:00)
                    }
                    else
                    {
                        minTime = nowTime.Subtract(TimeSpan.FromMinutes(nowTime.Minutes)).Add(TimeSpan.FromMinutes(30));// set minimim Time, round forward to xx:30(if now time 7:35 as forward to 8:00)
                    }
                }
                else
                {
                    return;
                }

            }
        }
        /// <summary>
        /// Customer Combobox Filtering
        /// </summary>
        private void textBoxCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            string filterString = textBoxCustomerSearch.Text;
            List<Customer> filteredCustomers = customers.ToList().FindAll(x => x.FullName.ToLower().Contains(filterString.ToLower()));
            comboCustomers.DataSource = filteredCustomers;            
            if (String.IsNullOrWhiteSpace(textBoxCustomerSearch.Text))
            {
                comboCustomers.DataSource = customers;
            }
        }
    }
}
