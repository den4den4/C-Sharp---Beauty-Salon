
namespace Final_project___Salon
{

    /// <summary>
    /// Class Using for saving check in Data Base
    /// and reading from DB, And for creating PDF version
    /// </summary>
    public class Check
    {
        private int check_id;
        private string date_time;
        private int customer_id;
        private double sum;


        //GETTERS SETTERS 
        public int Check_id { get => check_id; set => check_id = value; }
        public string Date_time { get => date_time; set => date_time = value; }
        public int Customer_id { get => customer_id; set => customer_id = value; }
        public double Sum { get => sum; set => sum = value; }
    }
}
