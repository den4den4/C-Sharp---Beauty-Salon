using System;
using System.Collections.Generic;

namespace Final_project___Salon
{
    /// <summary>
    /// Class Basket - create object for paying using
    /// And Calculate Summ,Vat And Price Without Vat
    /// </summary>
    public class Basket
    {
        private  Service[] services;
        public List<DateTime> dateOfServices = new List<DateTime>();
        private  Customer customer = new Customer();
        private  DateTime payDate = new DateTime();
        private double sumWithVat;
        private double totalSum;
        private double sumWithoutVat;


        //properties
        #region/Properties
        public Service[] Services
        {
            get { return services; }
            set { 
                services = new Service[value.Length];
                services = value;
                }
        }
        public  Customer Customer
        {
            get {return customer ;}
            set {customer = value ;} 
        }
        public  DateTime PayDate 
        {
            get { return payDate; }
            set { payDate = value; }
        }
        public double SumWithVat { get; set; }
        public double SumWithoutVat { get; set; }
        public double TotalSum { get; set; }


        #endregion


        public double CalculateSumWithoutVat()
        {
            sumWithoutVat = 0;
            
            foreach (Service service in Services)
            {
                sumWithoutVat += service.Price;
            }
            return sumWithoutVat;
        }

        public double CalculateSumWithVat()
        {
            sumWithVat = 0;
            foreach (Service service in Services)
            {
                sumWithVat += service.GetPriceWithVat();
            }
            return sumWithVat;
        }


        public double CalculateTotalSum()
        {
            totalSum = 0;
            foreach (Service service in Services)
            {
                totalSum += service.GetPriceWithSale();
            }
            return totalSum;
        }

    }
}
