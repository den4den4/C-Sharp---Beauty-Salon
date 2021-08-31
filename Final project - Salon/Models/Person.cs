using System;

namespace Final_project___Salon
{
    /// <summary>
    /// Parent class
    /// Include all Standart Human Information 
    /// </summary>
    public class Person
    {
        private string first_name;
        private string last_name;
        private DateTime birth_date;
        private string phone;
        private string mail;
        private string city;
        private string street;
        private int house;
        private int appartment;

        //GETTERS AND SETTERS

        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public DateTime Birth_date { get => birth_date; set => birth_date = value; }

        public string Phone { get => phone; set => phone = value; }
        public string Mail { get => mail; set => mail = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public int House { get => house; set => house = value; }
        public int Appartment { get => appartment; set => appartment = value; }

        public string FullName { get { return First_name + " " + Last_name; } }




        


    }
}
