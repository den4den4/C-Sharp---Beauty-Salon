using System;

namespace Final_project___Salon
{
    /// <summary>
    /// Class For Clients objects creating
    /// 
    /// Used in: Time Table, Reports, Home Page for stat and paying
    /// 
    /// Inherited From  - Person
    /// </summary>
    public class Customer : Person
    {
        private int customer_id;



        //CONSTRUCTOR
        public Customer()
        {
            Customer_id = -1;
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
        public int Customer_id { get => customer_id; set => customer_id = value; }
    }
       






     


}

