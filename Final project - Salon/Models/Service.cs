

namespace Final_project___Salon
{
    /// <summary>
    /// Service class - service saved in DB
    /// Include- name, id , price and executing time
    /// Methods - GetVat, GetSale, GetPriceWithSale, GetPriceWithVat and Equal
    /// </summary>
    public class Service
    {
        private int serviceId;
        private string serviceName;
        private double price;
        private double executingTime;



        public Service(): this(0,"noName",0,0)
        {              
        }
        public Service(int id, string name, double price, double time)
        {
            Id = id;
            Name = name;
            Price = price;
            ExecutingTime = time;
        }

        //Properties
        public int Id 
        { 
            get { return serviceId; }
            set {serviceId = value; }
        }
        public string Name 
        {
            get { return serviceName; }
            set { serviceName = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public double ExecutingTime
        {
            get { return executingTime; }
            set { executingTime = value; }
        }


        /// <summary>
        /// Equal two services
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true or false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Service && obj != null)
            {
                Service tmp;
                tmp = (Service)obj;
                if (tmp.Id == this.Id
                    && tmp.Name == this.Name
                    && tmp.ExecutingTime == this.ExecutingTime
                    && tmp.Price == this.Price)
                    return true;
                else
                    return false;
            }
            return false;
        }

        /// <summary>
        /// Get VAT From price of service
        /// </summary>
        /// <returns>vat from price</returns>
        public double GetVat()
        {
            return price * TaxesAndSales.Vat;
        }

        /// <summary>
        /// Get Discount Sum from price of service
        /// </summary>
        /// <returns>discount sum from price</returns>
        public double GetSale()
        {
            return price * TaxesAndSales.Sale;
        }

        /// <summary>
        /// Get Price with VAt
        /// </summary>
        /// <returns>Price with Vat</returns>
        public double GetPriceWithVat()
        {
            return price + this.GetVat();
        }

        /// <summary>
        /// Price With discount
        /// </summary>
        /// <returns>price + discount</returns>
        public double GetPriceWithSale()
        {
            return GetPriceWithVat() - this.GetSale();
        }

        public string NameAndPriceToString()
        {
            return Name + " " + Price;
        }
    }
}
