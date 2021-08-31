using System;

namespace Final_project___Salon
{
    /// <summary>
    /// Time Table Class
    /// Include Information of One prcedure queue
    /// Used For TimeTable,Reports and Home Page 
    /// </summary>
    public class Timetable  
    {
        
        private DateTime date;// date Of queue
        private DateTime start_time;// Time for service start
        int employee_id;// employee, perform work(Service)
        int customer_id;//serving customer
        int service_id;//service for perform     
        private DateTime end_time;// time of service ending
        private string status;

        string employee_name;
        string customer_name;
        string service_name;
        int payed = 0;// if service was paid

        public Timetable()
        {
            Date = DateTime.Now;
            Start_time = DateTime.Now;
            Employee_id = -1;
            Customer_id = -1;
            Service_id = -1;            
            End_time = DateTime.Now;
            Status = string.Empty;
            Employee_name = string.Empty;
            Customer_name = string.Empty;
            Service_name = string.Empty;
            
        }




        public Timetable(DateTime date, DateTime start_time, int emp_id, int cust_id, int service_id, DateTime end_time, string status,
            string  emp_name, string cust_name, string servise_name)
        {
            this.Date = date;
            this.Start_time = start_time;
            this.Employee_id = emp_id;
            this.Customer_id = cust_id;
            this.Service_id = service_id;
            this.End_time = end_time;
            this.Status = status;
            this.Employee_name = emp_name;
            this.Customer_name = cust_name;
            this.Service_name = servise_name;
        }

        public Timetable(string v, object selectedItem1, int employee_id, int customer_id, int id, object selectedItem2)
        {
            V = v;
            SelectedItem1 = selectedItem1;
            this.employee_id = employee_id;
            this.customer_id = customer_id;
            Id = id;
            SelectedItem2 = selectedItem2;
        }


        //GETTERS SETTERS 
        public string Status { get => status; set => status = value; }
        public int Employee_id { get => employee_id; set => employee_id = value; }
        public int Customer_id { get => customer_id; set => customer_id = value; }
        public int Service_id { get => service_id; set => service_id = value; }
        public DateTime Start_time { get => start_time; set => start_time = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime End_time { get => end_time; set => end_time = value; }
        public string Employee_name { get => employee_name; set => employee_name = value; }
        public string Customer_name { get => customer_name; set => customer_name = value; }
        public string Service_name { get => service_name; set => service_name = value; }
        public int Payed { get => payed; set => payed = value; }
        public string V { get; }
        public object SelectedItem1 { get; }
        public int Id { get; }
        public object SelectedItem2 { get; }

        /// <summary>
        ///     Clone curr obj
        /// </summary>
        public Timetable ShallowCopy()
        {
            return (Timetable)this.MemberwiseClone();
        }
        /// <summary>
        ///  Check if object properties is null 
        /// </summary>
        /// <returns>True if at least one properie is null</returns>
        public bool PropertiesNullValidation()
        {
            return (this.Date == null || this.Employee_id == 0 || this.Service_id == 0 || this.Customer_id == 0);
        }

        public void FromStaticStringToTimetableOblect()
        {
            this.Date = Convert.ToDateTime(Scueduling.dataString[0]);
            this.Start_time = Convert.ToDateTime(Scueduling.dataString[1]);
            this.Customer_name = Scueduling.dataString[2].ToString();
            this.Employee_name = Scueduling.dataString[3].ToString();
            this.Service_name = Scueduling.dataString[4].ToString();
            this.End_time = Convert.ToDateTime(Scueduling.dataString[5]);
            this.Status = Scueduling.dataString[6].ToString();
            this.Customer_id = Convert.ToInt32(Scueduling.dataString[7]);
            this.Employee_id = Convert.ToInt32(Scueduling.dataString[8]);
            this.Service_id = Convert.ToInt32(Scueduling.dataString[9]);

        }



    }
}
