

namespace Final_project___Salon
{

    /// <summary>
    /// Class With Discount and VAT value 
    /// Value Saved In DB
    /// 
    /// </summary>
    public static class TaxesAndSales
    {
        private static DBSql mySQL = DBSql.Instance;

        private static double vat = mySQL.GetVat()/100 ;
        private static double sale = mySQL.GetSale()/100;

        public static double Vat 
        {
            get { return vat; }
            set {
                    mySQL.SetVat(value);
                    vat = mySQL.GetVat() / 100;
                }
        }

        public static double GetVatInProcent()
        {
            return vat * 100;
        }
        public static double GetSaleInProcent()
        {
            return sale * 100;
        }
        public static double Sale 
        {
            get { return sale; }
            set{
                mySQL.SetSale(value);
                sale = mySQL.GetSale() / 100;
                }
        }

    }
}
