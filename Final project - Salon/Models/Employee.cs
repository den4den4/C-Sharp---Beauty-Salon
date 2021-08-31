using System;

namespace Final_project___Salon
{
    /// <summary>
    /// Class For Employee objects creating
    /// 
    /// Used in: Time Table, Reports, Home Page for stat
    /// 
    /// Inherited From  - Person
    /// </summary>
    public class Employee : Person
    {
        private int employee_id;
        private int salary;
        private DateTime start_work_date;

        //CONSTRUCTOR
        public Employee()
        {
            Employee_id = -1;
            Salary = 0;
            Start_work_date = DateTime.Now;
            base.First_name = string.Empty;
            base.Last_name = string.Empty;
            base.Birth_date = DateTime.Now;
            base.Phone = null;
            base.Mail = string.Empty;
            base.Street = string.Empty;
            base.City = string.Empty;
            base.House = 0;
            base.Appartment = 0;
        }



        //GETTERS AND SETTERS 
        public int Employee_id { get => employee_id; set => employee_id = value; }
        public int Salary { get => salary; set => salary = value; }
        public DateTime Start_work_date { get => start_work_date; set => start_work_date = value; }




    }
    

}
