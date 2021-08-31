using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Final_project___Salon
{
    /// <summary>
    /// Class Cointains All Queries to Data Base
    /// </summary>
    public class DBSql : DBConnection
    {
        private static DBSql instance;

        //Constructor
        private DBSql()
        {
            DatabaseName = "nails";
            UserName = "root";
            Password = string.Empty;
        }

        //INSTANCE =>   Singleton connection 
        public static DBSql Instance
        {
            get
            {
                if (instance == null)
                {
                    DBConnection connection = DBConnection.Instance(); //opens connection
                    instance = new DBSql();

                }
                return instance;
            }
        }

        public static string DataBaseName //allows to change protected parameters in DBConnection
        {
            set
            {
                if (value != string.Empty)
                {
                    DatabaseName = value;
                }
            }
            get
            {
                return DatabaseName;
            }
        }

        public static string Username
        {
            set
            {
                if (value != string.Empty)
                {
                    UserName = value;
                }
            }
            get
            {
                return UserName;
            }
        }

        public static string Pass
        {
            set
            {
                if (value != string.Empty)
                {
                    Password = value;
                }
            }
            get
            {
                return Password;
            }
        }


        ///START--------------------------- CUSTOMERS FUNCTIONS ------------------------------------------------------------///  
        #region/CUSTOMERS
        /// <summary>
        /// Function return array of Customers from DB
        /// </summary>
        public Customer[] GetCustomerData(string cmdStr = "SELECT * FROM customers WHERE `deleted`= 0")     //Default query get all customers
        {                                                        //Or we send another query to get some customers if we need  
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Customer[] customers = null;

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                customers = new Customer[dt.Rows.Count];
                for (int i = 0; i < customers.Length; ++i)
                {
                    customers[i] = new Customer();
                    customers[i].Customer_id = Convert.ToInt32(dt.Rows[i][0]);
                    customers[i].First_name = dt.Rows[i][1].ToString();
                    customers[i].Last_name = dt.Rows[i][2].ToString();
                    customers[i].Birth_date = Convert.ToDateTime(dt.Rows[i][3]);
                    customers[i].City = dt.Rows[i][4].ToString();
                    customers[i].Street = dt.Rows[i][5].ToString();
                    customers[i].House = Convert.ToInt32(dt.Rows[i][6]);
                    customers[i].Appartment = Convert.ToInt32(dt.Rows[i][7]);
                    customers[i].Phone = dt.Rows[i][8].ToString();
                    customers[i].Mail = dt.Rows[i][9].ToString();
                }
            }
            return customers;
        }

        /// <summary>
        ///   Function SearchCustomer send query to function GetCustomerData() for find data that we need in database
        ///   and  return result array of customers,
        ///   than we display result on the screen(datagridview)
        /// </summary>
        /// <param name="searchValue">value for search customer by in DB</param>
        /// <returns>Array of customers</returns>
        public Customer[] SearchCustomer(string searchValue)
        {
            string cmdStr = "SELECT * FROM customers WHERE `deleted`= 0 AND (first_name LIKE '%" + searchValue + "%' OR last_name LIKE '%" + searchValue + "%' OR `birth_date` LIKE '%" + searchValue + "%' OR `city` LIKE '%" + searchValue + "%' OR `street` LIKE '%" + searchValue + "%' OR house LIKE '%" + searchValue + "%' OR `phone` LIKE '%" + searchValue + "%' OR mail LIKE '%" + searchValue + "%')";
            Customer[] customers = null;
            return customers = GetCustomerData(cmdStr);

        }

        /// <summary>
        ///   Insert customer function => paramert Item(customer)
        /// </summary>
        public void InsertCustomer(Customer Item)
        {
            string cmdStr = "INSERT INTO customers (customer_id, first_name, last_name, birth_date, city, street, house, appartment, phone, mail) VALUES (@id, @firstName, @lastName, @birthDay, @city, @street, @house, @appartment, @phone, @mail)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", null);
                command.Parameters.AddWithValue("@firstName", Item.First_name);
                command.Parameters.AddWithValue("@lastName", Item.Last_name);
                command.Parameters.AddWithValue("@birthDay", Item.Birth_date);
                command.Parameters.AddWithValue("@city", Item.City);
                command.Parameters.AddWithValue("@street", Item.Street);
                command.Parameters.AddWithValue("@house", Item.House);
                command.Parameters.AddWithValue("@appartment", Item.Appartment);
                command.Parameters.AddWithValue("@phone", Item.Phone);
                command.Parameters.AddWithValue("@mail", Item.Mail);

                base.ExecuteSimpleQuery(command); //to access base class (DBConnection), not required
            }
        }

        /// <summary>
        ///    Function for update Customer in DB (Item => customer)
        /// </summary>
        public void UpdateCustomer(Customer Item)
        {
            string cmdStr = "UPDATE `customers` SET `first_name` = @firstName, `last_name` = @lastName, `birth_date` = @birthDay,`city` = @city, `street` = @street, `house` = @house, `appartment` = @appartment, `phone` = @phone, `mail` = @mail WHERE `customer_id` like @id";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", Item.Customer_id);
                command.Parameters.AddWithValue("@firstName", Item.First_name);
                command.Parameters.AddWithValue("@lastName", Item.Last_name);
                command.Parameters.AddWithValue("@birthDay", Item.Birth_date);
                command.Parameters.AddWithValue("@city", Item.City);
                command.Parameters.AddWithValue("@street", Item.Street);
                command.Parameters.AddWithValue("@house", Item.House);
                command.Parameters.AddWithValue("@appartment", Item.Appartment);
                command.Parameters.AddWithValue("@phone", Item.Phone);
                command.Parameters.AddWithValue("@mail", Item.Mail);

                base.ExecuteSimpleQuery(command); //to access base class (DBConnection), not required
            }

        }

        /// <summary>
        ///     Function for Delete Customer from DB=> param customer
        /// </summary>
        public void DeleteCustomer(Customer customer)
        {
            string cmdStr = "DELETE FROM `timetable` WHERE customer_id = @id;UPDATE `customers` SET `customers`.`deleted`=1 WHERE `customers`.`customer_id` = @id;";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", customer.Customer_id);


                base.ExecuteSimpleQuery(command); //to access base class (DBConnection), not required
            }
        }
        #endregion
        ///END--------------------------- CUSTOMERS FUNCTIONS ------------------------------------------------------------///  



        ///START--------------------------- EMPLOYEE FUNCTIONS ------------------------------------------------------------/// 
        #region/EMPLOYEE
        /// <summary>
        /// Function return array of Employees from DB
        /// </summary>                                                    
        public Employee[] GetEmployeeData(string cmdStr = "SELECT * FROM employees where deleted=0")   //Default query get all employees
        {                                                               //Or we send another query to get some employees if we need 
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Employee[] employees = null;

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                employees = new Employee[dt.Rows.Count];
                for (int i = 0; i < employees.Length; ++i)
                {
                    employees[i] = new Employee();
                    employees[i].Employee_id = Convert.ToInt32(dt.Rows[i][0]);
                    employees[i].First_name = dt.Rows[i][1].ToString();
                    employees[i].Last_name = dt.Rows[i][2].ToString();
                    employees[i].Salary = Convert.ToInt32(dt.Rows[i][3]);
                    employees[i].Birth_date = Convert.ToDateTime(dt.Rows[i][4]);
                    employees[i].City = dt.Rows[i][5].ToString();
                    employees[i].House = Convert.ToInt32(dt.Rows[i][6]);
                    employees[i].Street = dt.Rows[i][7].ToString();
                    employees[i].Appartment = Convert.ToInt32(dt.Rows[i][8]);
                    employees[i].Phone = dt.Rows[i][9].ToString();
                    employees[i].Start_work_date = Convert.ToDateTime(dt.Rows[i][10]);
                    employees[i].Mail = dt.Rows[i][11].ToString();
                }
            }
            return employees;
        }

        /// <summary>
        ///   Function SearchEmployee send query to function GetEmployeeData() for find data that we need in database
        ///   and  return result array of employees,
        ///   than we display result on the screen(datagridview)
        /// </summary>
        /// <param name="searchValue">value for search employee by in DB</param>
        /// <returns>Array of employees</returns>
        public Employee[] SearchEmployee(string searchValue)
        {
            string cmdStr = "SELECT * FROM employees WHERE first_name LIKE '%" + searchValue + "%' OR last_name LIKE '%" + searchValue + "%' OR salary LIKE '%" + searchValue + "%' OR `birth_date` LIKE '%" + searchValue + "%' OR `city` LIKE '%" + searchValue + "%' OR `street` LIKE '%" + searchValue + "%' OR house LIKE '%" + searchValue + "%' OR `phone` LIKE '%" + searchValue + "%' OR mail LIKE '%" + searchValue + "%'";
            Employee[] employees = null;
            return employees = GetEmployeeData(cmdStr);
        }

        /// <summary>
        ///    Insert Employee => function to insert Employee to DB 
        /// </summary>
        public void InsertEmployee(Employee Item)
        {
            string cmdStr = "INSERT INTO employees (first_name, last_name, salary, birth_date, city, street, house, appartment, phone, start_work_date, mail) VALUES (@firstName, @lastName, @salary, @birthDay, @city, @street, @house, @appartment, @phone, @startWork, @mail)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@firstName", Item.First_name);
                command.Parameters.AddWithValue("@lastName", Item.Last_name);
                command.Parameters.AddWithValue("@salary", Item.Salary);
                command.Parameters.AddWithValue("@birthDay", Item.Birth_date);
                command.Parameters.AddWithValue("@city", Item.City);
                command.Parameters.AddWithValue("@street", Item.Street);
                command.Parameters.AddWithValue("@house", Item.House);
                command.Parameters.AddWithValue("@appartment", Item.Appartment);
                command.Parameters.AddWithValue("@phone", Item.Phone);
                command.Parameters.AddWithValue("@startWork", Item.Start_work_date);
                command.Parameters.AddWithValue("@mail", Item.Mail);

                base.ExecuteSimpleQuery(command); //to access base class (DBConnection), not required
            }
        }

        /// <summary>
        ///    Function for update Update Employee in DB (Item => Emplyee)
        /// </summary>
        public void UpdateEmployee(Employee Item)
        {
            string cmdStr = "UPDATE `employees` SET `first_name` = @firstName, `last_name` = @lastName, `salary` = @salary, `birth_date` = @birthDay,`city` = @city, `street` = @street, `house` = @house, `appartment` = @appartment, `phone` = @phone, `start_work_date` = @startWork, `mail` = @mail WHERE `employee_id` like @id";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", Item.Employee_id);
                command.Parameters.AddWithValue("@firstName", Item.First_name);
                command.Parameters.AddWithValue("@lastName", Item.Last_name);
                command.Parameters.AddWithValue("@salary", Item.Salary);
                command.Parameters.AddWithValue("@birthDay", Item.Birth_date);
                command.Parameters.AddWithValue("@city", Item.City);
                command.Parameters.AddWithValue("@street", Item.Street);
                command.Parameters.AddWithValue("@house", Item.House);
                command.Parameters.AddWithValue("@appartment", Item.Appartment);
                command.Parameters.AddWithValue("@phone", Item.Phone);
                command.Parameters.AddWithValue("@startWork", Item.Start_work_date);
                command.Parameters.AddWithValue("@mail", Item.Mail);

                base.ExecuteSimpleQuery(command); //to access base class (DBConnection), not required
            }

        }

        /// <summary>
        ///     Function for Delete Employee from DB=> param Item = employee
        /// </summary>
        public void DeleteEmployee(Employee Item)
        {
            string cmdStr = "DELETE FROM `timetable` WHERE employee_id = @id;UPDATE `employees` SET `employees`.`deleted` = 1 WHERE `employees`.`employee_id` = @id;";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", Item.Employee_id);
                command.Parameters.AddWithValue("@firstName", Item.First_name);
                command.Parameters.AddWithValue("@lastName", Item.Last_name);
                command.Parameters.AddWithValue("@salary", Item.Salary);
                command.Parameters.AddWithValue("@birthDay", Item.Birth_date);
                command.Parameters.AddWithValue("@city", Item.City);
                command.Parameters.AddWithValue("@street", Item.Street);
                command.Parameters.AddWithValue("@house", Item.House);
                command.Parameters.AddWithValue("@appartment", Item.Appartment);
                command.Parameters.AddWithValue("@phone", Item.Phone);
                command.Parameters.AddWithValue("@startWork", Item.Start_work_date);
                command.Parameters.AddWithValue("@mail", Item.Mail);

                base.ExecuteSimpleQuery(command); //to access base class (DBConnection), not required
            }
        }
        #endregion
        ///END--------------------------- EMPLOYEE FUNCTIONS ------------------------------------------------------------/// 

        #region/SERVICES
        ///START--------------------------- SERVICES FUNCTIONS ------------------------------------------------------------/// 

       

        /// <summary>
        /// Function Take from db all services and Return array of services
        /// </summary>
        /// <arguments>
        /// int delete: 1 - to get all srvicese, deleted too
        ///             0 - without deleted service(actually only)
        /// </arguments>

        public Service[] GetServices()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Service[] services = null;
            string query = "SELECT * FROM `services` WHERE `deleted` = 0";

            using (MySqlCommand command = new MySqlCommand(query))
            {
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                services = new Service[dt.Rows.Count];
                for (int i = 0; i < services.Length; ++i)
                {
                    services[i] = new Service();
                    services[i].Id = Convert.ToInt32(dt.Rows[i][0]);
                    services[i].Name = dt.Rows[i][1].ToString();
                    services[i].ExecutingTime = Convert.ToInt64(dt.Rows[i][2]);
                    services[i].Price = Convert.ToInt64(dt.Rows[i][3]);
                }
            }
            return services;
        }
        /// <summary>
        /// Function Take from db all services and Return array of services(with deleted services)
        /// </summary>       

        public Service[] GetServicesWithDeleted()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Service[] services = null;
            string query = "SELECT * FROM `services`";

            using (MySqlCommand command = new MySqlCommand(query))
            {
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                services = new Service[dt.Rows.Count];
                for (int i = 0; i < services.Length; ++i)
                {
                    services[i] = new Service();
                    services[i].Id = Convert.ToInt32(dt.Rows[i][0]);
                    services[i].Name = dt.Rows[i][1].ToString();
                    services[i].ExecutingTime = Convert.ToInt64(dt.Rows[i][2]);
                    services[i].Price = Convert.ToInt64(dt.Rows[i][3]);
                }
            }
            return services;
        }

        // Function Take from db all services and Return Collection

        public List<Service> GetServicesCollection(string query = "SELECT * FROM `services` WHERE `deleted` = '0'")
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Service service;
            List<Service> services = new List<Service>();

            using (MySqlCommand command = new MySqlCommand(query))
            {
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    service = new Service();
                    service.Id = Convert.ToInt32(dt.Rows[i][0]);
                    service.Name = dt.Rows[i][1].ToString();
                    service.ExecutingTime = Convert.ToInt64(dt.Rows[i][2]);
                    service.Price = Convert.ToInt64(dt.Rows[i][3]);
                    services.Add(service);
                }
            }
            return services;
        }

        /**Insert Service function - function add new service to DB 
         * arguments: Service service
         * return 1 or 0
         */
        public int InsertService(Service service)
        {
            int numb = -1;
            string query = "INSERT INTO `services`(`name_service`, `executing_time`, `price`) VALUES (@name, @exTime, @price)";
            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@name",service.Name);
                command.Parameters.AddWithValue("@exTime", service.ExecutingTime);
                command.Parameters.AddWithValue("@price",service.Price);

                base.ExecuteSimpleQuery(command, ref numb);
            }
            return numb;
        }

        /*
         * Update service in DB 
         * arguments: Service service
         * return 1 or 0 
         */
        public int UpdateService(Service service)
        {
            int numb = -1;
            string query = "UPDATE `services` SET `name_service`= @name,`executing_time`= @exTime,`price`= @price WHERE `service_id` = @id AND `deleted` = '0'";
            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@name", service.Name);
                command.Parameters.AddWithValue("@exTime", service.ExecutingTime);
                command.Parameters.AddWithValue("@price", service.Price);
                command.Parameters.AddWithValue("@id", service.Id);

                base.ExecuteSimpleQuery(command, ref numb);
            }
            return numb;
        }

        /*
         * Service soft Delete 
         * arguments: Service service
         * return 1 or 0 
         */
        public int DeleteService(Service service)
        {
            int numb = -1;
            string query = "UPDATE `services` SET `deleted`='1' WHERE `service_id` = @id";
            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@id", service.Id);
                base.ExecuteSimpleQuery(command, ref numb);
            }
            return numb;
        }


        /*Function SearchService send query to function GetServices() for find data that we need in database
         * and  return result array of services,
         * than we display result on the screen(datagridview)        
         * arguments : searchValue  for search service by in DB</param>
         * return    : Array of employees
         */
        public Service[] SearchService(string searchValue)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Service[] services = null;

            string query = "SELECT * FROM services WHERE (`service_id` LIKE @value OR `name_service` LIKE @value OR `executing_time` LIKE @value OR `price` LIKE @value) AND `deleted` = '0'";

            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@value", searchValue);
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                services = new Service[dt.Rows.Count];
                for (int i = 0; i < services.Length; ++i)
                {
                    services[i] = new Service();
                    services[i].Id = Convert.ToInt32(dt.Rows[i][0]);
                    services[i].Name = dt.Rows[i][1].ToString();
                    services[i].ExecutingTime = Convert.ToInt64(dt.Rows[i][2]);
                    services[i].Price = Convert.ToInt64(dt.Rows[i][3]);
                }
            }
            return services;

        }

        // Amount of actually services
        public int GetServicesCount()
        {
            int result = 0;
            string query = "SELECT COUNT(deleted) FROM services WHERE deleted = 0";
            using (MySqlCommand command = new MySqlCommand(query))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        ///END--------------------------- SERVICES FUNCTIONS ------------------
        #endregion

        ///START--------------------------- LOGIN, and SETINGS FUNCTIONS -----------------------------------///       
        #region/SETTINGS_LOGIN
        public CompanyInfo LogIn(string login, string pass)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            CompanyInfo company = null;
            string query = "SELECT u.login,u.pass,u.if_boss, ci.* FROM `users` u INNER JOIN comp_info ci ON u.comp_id=ci.comp_id WHERE login = @login AND pass = @pass";

            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@pass", pass);

                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { 
                // for indication that no DB connection
                company = new CompanyInfo();
                company.CompId = -1;
                }
            if (dt.Rows.Count > 0)
            {
                company = new CompanyInfo();
                company.UserName = dt.Rows[0][0].ToString();
                company.Password = dt.Rows[0][1].ToString();
                company.IfBoss = Convert.ToBoolean(dt.Rows[0][2]);
                company.CompId = Convert.ToInt32(dt.Rows[0][3]);
                company.CompName = dt.Rows[0][4].ToString();
                company.CompEmail = dt.Rows[0][5].ToString();
                company.CompPhone = dt.Rows[0][6].ToString();
                company.CompAddress = dt.Rows[0][7].ToString();
                company.CompLicense = Convert.ToInt32(dt.Rows[0][8]);

            }
            return company;
        }

       

        /*
         * Function change password
         * If pass was change number >1 else numb = 0 or -1
         */
        public int ChangePassword(string login, string oldPass, string newPass)
        {
            int number = -1;
            string cmdStr = "UPDATE `users` SET `pass`=@newPass WHERE `login`= @login AND `pass` = @oldPass";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@newPass", newPass);
                command.Parameters.AddWithValue("@oldPass", oldPass);
                command.Parameters.AddWithValue("@login", login);

                base.ExecuteSimpleQuery(command, ref number);
            }
            return number;

        }



        /*
        * Get information about Company we are working them
        * Arguments:
        * - string userName - user name
        * Return:
        * -CompanyInfo compInfo - Basic Company information (Name? adress? phone, email etc)
        */
        public CompanyInfo GetCompInfo(string userName = "admin")
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            CompanyInfo compInfo = null;

            string query = "SELECT ci.* FROM `users` u INNER JOIN comp_info ci ON u.comp_id=ci.comp_id WHERE u.login = @userName";
            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@userName", userName);

                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                compInfo = new CompanyInfo();

                compInfo.CompId = Convert.ToInt32(dt.Rows[0][0]);
                compInfo.CompName = dt.Rows[0][1].ToString();
                compInfo.CompEmail = dt.Rows[0][2].ToString();
                compInfo.CompPhone = dt.Rows[0][3].ToString();
                compInfo.CompAddress = dt.Rows[0][4].ToString();
                compInfo.CompLicense = Convert.ToInt32(dt.Rows[0][5]);


            }

            return compInfo;
        }

        public bool UpdateCompanyInfo(CompanyInfo company)
        {
            int number = -1;
            string cmdStr = $"UPDATE `comp_info` SET `comp_name`= @name, " +
                $"`comp_email`=@mail, `comp_phone`=@phone, " +
                $"`comp_address`= @adsress,`comp_license`=@license WHERE `comp_id`=@id";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name",company.CompName);
                command.Parameters.AddWithValue("@mail", company.CompEmail);
                command.Parameters.AddWithValue("@phone",company.CompPhone);
                command.Parameters.AddWithValue("@adsress", company.CompAddress);
                command.Parameters.AddWithValue("@license", company.CompAddress);
                command.Parameters.AddWithValue("@id", company.CompAddress);

                base.ExecuteSimpleQuery(command, ref number);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Set VAT value
        /// </summary>
        /// <param name="vat">vat value in procent</param>
        public void SetVat(double vat)
        {
            string query = "UPDATE `taxes_sales` SET `vat`=@vat WHERE 1";

            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@vat", vat);
                ExecuteSimpleQuery(command);
            }
        }
        /// <summary>
        /// Set sale value
        /// </summary>
        /// /// <param name="sale">sale value in procent</param>
        public void SetSale(double sale)
        {
            string query = "UPDATE `taxes_sales` SET `sale`=@sale WHERE 1";

            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@sale", sale);
                ExecuteSimpleQuery(command);
            }
        }

        // get vat from db
        public double GetVat()
        {
            double vat = 0;
            string query = "SELECT `vat` FROM `taxes_sales`";
            using (MySqlCommand command = new MySqlCommand(query))
            {
                vat = ExecuteScalarIntQuery(command);
            }

            return vat;
        }

        public double GetSale()
        {
            double sale = 0;
            string query = "SELECT `sale` FROM `taxes_sales`";
            using (MySqlCommand command = new MySqlCommand(query))
            {
                sale = ExecuteScalarIntQuery(command);
            }
            return sale;
        }
        #endregion
        ///END--------------------------- LOGIN, and SETINGS FUNCTIONS -----------------------------------///     



        ///START--------------------------- TIME TABLE FUNCTIONS ------------------------------------------------------------/// 
        #region/TIME_TABLE
        /// <summary>
        /// Function search in Timetable 
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns>timetables array </returns>
        public Timetable[] SearchTimetable(string searchValue)
        {
            string cmdStr = "SELECT date, t.start_time, CONCAT(e.first_name, '  ', e.last_name) , CONCAT(c.first_name, '  ', c.last_name), s.name_service, t.end_time, t.status, t.customer_id, t.employee_id, t.service_id, t.payed  FROM timetable t INNER JOIN customers c ON t.customer_id = c.customer_id INNER JOIN employees e ON t.employee_id = e.employee_id INNER JOIN services s ON t.service_id = s.service_id WHERE `date` LIKE '%" + searchValue + "%' OR `start_time` LIKE '%" + searchValue + "%' OR CONCAT(e.first_name, '  ', e.last_name) LIKE '%" + searchValue + "%' OR  CONCAT(c.first_name, '  ', c.last_name) LIKE '%" + searchValue + "%' OR s.name_service LIKE '%" + searchValue + "%' OR t.end_time LIKE '%" + searchValue + "%' OR t.status LIKE '%" + searchValue + "%' ORDER BY `date`,`employee_id`,`start_time`";
            Timetable[] timetables = null;
            return timetables = GetTimetableData(cmdStr);

        }
         /// <summary>
         /// Function Search in timetable By Date from calendar 
         /// </summary>
         /// <param name="searchValue"></param>
         /// <returns></returns>
        public Timetable[] SearchTimetableByDate(string searchValue)
        {
            string cmdStr = "SELECT date, t.start_time, CONCAT(e.first_name, '  ', e.last_name) , CONCAT(c.first_name, '  ', c.last_name), s.name_service, t.end_time, t.status, t.customer_id, t.employee_id, t.service_id, t.payed FROM timetable t INNER JOIN customers c ON t.customer_id = c.customer_id INNER JOIN employees e ON t.employee_id = e.employee_id INNER JOIN services s ON t.service_id = s.service_id WHERE `date` LIKE '%" + searchValue + "%' ORDER BY `date`,`employee_id`,`start_time`";
            Timetable[] timetables = null;
            return timetables = GetTimetableData(cmdStr);

        }

         /// <summary>
         ///    Function Get data of timetables from databaase
         /// </summary>
        public Timetable[] GetTimetableData(string cmdStr = "SELECT t.date, t.start_time, CONCAT(e.first_name, ' ', e.last_name) , CONCAT(c.first_name, ' ', c.last_name), s.name_service, t.end_time, t.status, t.customer_id, t.employee_id, t.service_id, t.payed FROM timetable t INNER JOIN customers c ON t.customer_id = c.customer_id INNER JOIN employees e ON t.employee_id = e.employee_id INNER JOIN services s ON t.service_id = s.service_id WHERE date >= CURRENT_DATE() ORDER BY `date`,`employee_id`,`start_time` ")
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Timetable[] TimetableArray = null;

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                TimetableArray = new Timetable[dt.Rows.Count];
                for (int i = 0; i < TimetableArray.Length; ++i)
                {
                    TimetableArray[i] = new Timetable();
                    TimetableArray[i].Date = Convert.ToDateTime(dt.Rows[i][0]);
                    TimetableArray[i].Start_time = Convert.ToDateTime(dt.Rows[i][1].ToString());
                    TimetableArray[i].Employee_name = dt.Rows[i][2].ToString();
                    TimetableArray[i].Customer_name = dt.Rows[i][3].ToString();
                    TimetableArray[i].Service_name = dt.Rows[i][4].ToString();
                    TimetableArray[i].End_time = Convert.ToDateTime(dt.Rows[i][5].ToString());
                    TimetableArray[i].Status = dt.Rows[i][6].ToString();                    

                    TimetableArray[i].Customer_id = Convert.ToInt32(dt.Rows[i][7]);
                    TimetableArray[i].Employee_id = Convert.ToInt32(dt.Rows[i][8]);
                    TimetableArray[i].Service_id = Convert.ToInt32(dt.Rows[i][9]);
                    TimetableArray[i].Payed = Convert.ToInt32(dt.Rows[i][10]);


                }

            }
            return TimetableArray;
        }
        public void GetTimeTableCollection(List<Timetable> timetables)
        {
            string query = "SELECT * FROM `timetable` ORDER BY `date`, start_time ASC";
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Timetable timetable;

            using (MySqlCommand command = new MySqlCommand(query))
            {
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    timetable = new Timetable();
                    timetable.Start_time = Convert.ToDateTime(dt.Rows[i][0].ToString());
                    timetable.Date = Convert.ToDateTime(dt.Rows[i][1]);
                    timetable.Employee_id = Convert.ToInt32(dt.Rows[i][2]);
                    timetable.Customer_id = Convert.ToInt32(dt.Rows[i][3]);
                    timetable.Service_id = Convert.ToInt32(dt.Rows[i][4]);
                    timetable.End_time = Convert.ToDateTime(dt.Rows[i][5].ToString());
                    timetable.Status = dt.Rows[i][6].ToString();
                    timetable.Payed = Convert.ToInt32(dt.Rows[i][7]);
                    timetables.Add(timetable);
                }
            }
        }

        /// <summary>
        ///   Insert timetable Method to insert timetable record to database  
        ///   param: Item => Timetable object to insert 
        /// </summary>
        public void InsertTimetable(Timetable Item)
        {
            string cmdStr = "INSERT INTO `timetable` (`start_time`, `date`, `employee_id`, `customer_id`, `service_id`, `end_time`, `status`) VALUES(@start_time, @date, @employee_id, @customer_id, @service_id, @end_time, @status)";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                
                command.Parameters.AddWithValue("@start_time", Item.Start_time);
                command.Parameters.AddWithValue("@date", Item.Date);
                command.Parameters.AddWithValue("@employee_id", Item.Employee_id);
                command.Parameters.AddWithValue("@customer_id", Item.Customer_id);
                command.Parameters.AddWithValue("@service_id", Item.Service_id);
                command.Parameters.AddWithValue("@end_time", Item.End_time);
                command.Parameters.AddWithValue("@status", Item.Status);

                base.ExecuteSimpleQuery(command); //to access base class (DBConnection), not required
            }
        }

        /// <summary>
        ///  Method to update Timetable record in database 
        ///  param: old_record => Timetable object 
        ///  param: new_record => Timetable object 
        ///  Make changes from old record to new record 
        /// </summary>
        public void UpdateTimetable(Timetable old_record, Timetable new_record)
        {
            string query = "UPDATE `timetable` SET `start_time` = @start_time , `date` = @date, `timetable`.`employee_id` = @employee_id, `timetable`.`customer_id` = @customer_id ," +
                " `timetable`.`service_id` = @service_id, `timetable`.`end_time` = @end_time, `timetable`.`status` = @status " +
                "WHERE `timetable`.`start_time`= @start_time_old AND `timetable`.`date`= @date_old AND `timetable`.`employee_id`= @employee_id_old " +
                "AND `timetable`.`customer_id`= @customer_id_old AND `timetable`.`service_id`= @service_id_old AND `timetable`.`end_time`= @end_time_old AND `timetable`.`status` = @status_old";

            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@start_time", new_record.Start_time.ToString("HH:mm:ss"));
                command.Parameters.AddWithValue("@date", new_record.Date.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@employee_id", new_record.Employee_id);
                command.Parameters.AddWithValue("@customer_id", new_record.Customer_id);
                command.Parameters.AddWithValue("@service_id", new_record.Service_id);
                command.Parameters.AddWithValue("@end_time", new_record.End_time.ToString("HH:mm:ss"));
                command.Parameters.AddWithValue("@status", new_record.Status);

                command.Parameters.AddWithValue("@start_time_old", old_record.Start_time.ToString("HH:mm:ss"));
                command.Parameters.AddWithValue("@date_old", old_record.Date.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@employee_id_old", old_record.Employee_id);
                command.Parameters.AddWithValue("@customer_id_old", old_record.Customer_id);
                command.Parameters.AddWithValue("@service_id_old", old_record.Service_id);
                command.Parameters.AddWithValue("@end_time_old", old_record.End_time.ToString("HH:mm:ss"));
                command.Parameters.AddWithValue("@status_old", old_record.Status);



                base.ExecuteSimpleQuery(command); //to access base class (DBConnection), not required
            }

        }
        /// <summary>
        ///  Delete Method => Delete Timetable record from db
        ///  param: Item -> Timetable object 
        /// </summary>
        public void DeleteTimetable(Timetable Item)
        {
            string cmdStr = "DELETE FROM `timetable` WHERE `timetable`.`start_time` = @start_time AND `timetable`.`date` = @date AND `timetable`.`employee_id` = @employee_id AND `timetable`.`customer_id` = @customer_id AND `timetable`.`service_id` = @service_id";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {

                command.Parameters.AddWithValue("@start_time", Item.Start_time.ToString("HH:mm:ss"));
                command.Parameters.AddWithValue("@date", Item.Date.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@employee_id", Item.Employee_id);
                command.Parameters.AddWithValue("@customer_id", Item.Customer_id);
                command.Parameters.AddWithValue("@service_id", Item.Service_id);
 

                base.ExecuteSimpleQuery(command); //to access base class (DBConnection), not required
            }
        }

        /// <summary>
        /// Method removes unavailable time for ordering a queue
        /// </summary>
        public List<TimeSpan> GetTimeForRemoveFromeTimeTable(string date, Employee employee, Customer customer)
        {
            
            string cmdStr = "SELECT start_time, end_time FROM `timetable` WHERE date=@date AND (customer_id = @custom_id OR employee_id = @emp_id)";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            List<TimeSpan> timesList = null;
            TimeSpan step = new TimeSpan(0, 30, 0);

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@date", Convert.ToDateTime(date));
                command.Parameters.AddWithValue("@emp_id", Convert.ToInt32(employee.Employee_id));
                command.Parameters.AddWithValue("@custom_id", Convert.ToInt32(customer.Customer_id));

                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }

            if (dt.Rows.Count > 0)
            {
                timesList = new List<TimeSpan>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    
                    timesList.Add(TimeSpan.Parse(dt.Rows[i][0].ToString()));
                    while(timesList[timesList.Count-1]< TimeSpan.Parse(dt.Rows[i][1].ToString())-step)
                    {
                        timesList.Add(timesList[timesList.Count - 1]+step);
                    }
                }
            }
            return timesList;
        }

        public List<Timetable> GetQueue(DateTime date, DateTime start_time, int emp_id, int cust_id)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            List<Timetable> timeTable = null;
            string cmdStr = "SELECT * FROM `timetable` WHERE date=@date AND (employee_id=@empId AND customer_id = @custId) ORDER BY @startTime";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@empId", emp_id);
                command.Parameters.AddWithValue("@custId", cust_id);
                command.Parameters.AddWithValue("@startTime", start_time);

                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }

            if (dt.Rows.Count > 0)
            {
                timeTable = new List<Timetable>();                

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    Timetable tmp = new Timetable();
                    tmp.Start_time = Convert.ToDateTime(dt.Rows[i][0].ToString());
                    tmp.Date = Convert.ToDateTime(dt.Rows[i][1]);
                    tmp.Employee_id = Convert.ToInt32(dt.Rows[i][2]);
                    tmp.Customer_id = Convert.ToInt32(dt.Rows[i][3]);
                    tmp.Service_id = Convert.ToInt32(dt.Rows[i][4]);
                    tmp.End_time = Convert.ToDateTime(dt.Rows[i][5].ToString());
                    tmp.Status = dt.Rows[i][6].ToString();
                    tmp.Payed = Convert.ToInt32(dt.Rows[i][7]);

                    timeTable.Add(tmp);
                } 
                    
            }

            return timeTable;
        }

        /// <summary>
        /// Get One cudtomer from DB by ID
        /// </summary>
        /// <param name="customer">Object for getting</param>
        /// <param name="id">customer id for getting</param>
        public void GetCustomerById(Customer customer, int id)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM `customers` WHERE customer_id =@id";

            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@id", id);

                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }

            if (dt.Rows.Count > 0)
            {

                customer.Customer_id = Convert.ToInt32(dt.Rows[0][0]);
                customer.First_name = dt.Rows[0][1].ToString();
                customer.Last_name = dt.Rows[0][2].ToString();
                customer.Birth_date = Convert.ToDateTime(dt.Rows[0][3]);
                customer.City = dt.Rows[0][4].ToString();
                customer.Street = dt.Rows[0][5].ToString();
                customer.House = Convert.ToInt32(dt.Rows[0][6]);
                customer.Appartment = Convert.ToInt32(dt.Rows[0][7]);
                customer.Phone = dt.Rows[0][8].ToString();
                customer.Mail = dt.Rows[0][9].ToString();
            }

        }

        #endregion
        ///END--------------------------- TIME TABLE FUNCTIONS ------------------------------------------------------------/// 




        ///START------------------------REPORT FUNCTIONS ---------------------------------------------------------------START|
        #region/REPORTS

        //-START ------------- CHECKS ----------------------------------||
        #region/CHECKS

        /*
         * Function to getting one element from DB by query
         * Arguments:
         * - string query - sql query
         * Return:
         * -string  element - result of query
         */
        public string GetOneElement(string query)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string element=null;
            using (MySqlCommand command = new MySqlCommand(query))
            {
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                element = dt.Rows[0][0].ToString();
            }
            return element;
        }

        /*
         * Get All cheks Information
         * Arguments:
         * - string query - sql query
         * Return:
         * -Check[] checks - array of checks
         */
        public Check[] GetChecks(string query = "SELECT * FROM checks")
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Check[] checks = null;

            using (MySqlCommand command = new MySqlCommand(query))
            {
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                checks = new Check[dt.Rows.Count];
                for (int i = 0; i < checks.Length; i++)
                {
                    checks[i] = new Check();
                    checks[i].Check_id =Convert.ToInt32(dt.Rows[i][0]);
                    checks[i].Customer_id = Convert.ToInt32(dt.Rows[i][1]);
                    checks[i].Date_time = dt.Rows[i][2].ToString();
                    checks[i].Sum= Convert.ToInt64(dt.Rows[i][3]);
                }
                
            }
            return checks;
        }


        /*
        * Get All services of specific check by Id
        * Arguments:
        * - string checkId - id of check what we want
        * Return:
        * -String[,] servicePrices - 2D array of id:service:price
        */
        public Service[] CheckServices(int id)
        {
            Service[] servicesTmp = null;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string query = $"SELECT s.service_id,s.name_service,s.price FROM `check_service` cs INNER JOIN `services` s ON cs.service_id = s.service_id WHERE check_id = @id";
            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@id", id);

                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                servicesTmp = new Service[dt.Rows.Count];
                for (int i = 0; i < servicesTmp.Length; i++)
                {
                    servicesTmp[i] = new Service();
                    servicesTmp[i].Id =Convert.ToInt32(dt.Rows[i][0]);
                    servicesTmp[i].Name = dt.Rows[i][1].ToString();
                    servicesTmp[i].Price = Convert.ToInt32(dt.Rows[i][2]);
                }
                return servicesTmp;
            }
            return servicesTmp;
        }


        /*
        * Get emp name, customer name and dateTime of specific check
        * Arguments:
        * - string checkId - id of check what we want
        * Return:
        * -String[] checkData - array with emp name, customer name and dateTime
        */
        public string[] CheckData(int checkId)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            String[] checkData = null;
            string query = $"SELECT ch.date_time, concat_ws(' ',c.first_name, c.last_name), sum, c.mail " +
                $"FROM `check_service` cs INNER JOIN `checks` ch ON cs.check_id=ch.check_id" +
                $" INNER JOIN `customers` c ON ch.customer_id=c.customer_id INNER JOIN `services` s ON cs.service_id = s.service_id WHERE cs.check_id=@id GROUP BY cs.check_id";
            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@id",checkId);

                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0)
            {
                checkData = new String[dt.Columns.Count];
                for (int i = 0; i < checkData.Length; ++i)
                {
                    checkData[i] = dt.Rows[0][i].ToString();
                }
            }
            return checkData;
        }


        // Function for search and filteting Checks dataGrid
        public Check[] SearchChecks(string searchValue)
        {
            string cmdStr = $"SELECT ch.* FROM `checks` ch " +
                $"INNER JOIN `customers` c ON ch.customer_id=c.customer_id " +
                $"WHERE ch.date_time LIKE '%{searchValue}%' OR c.first_name LIKE '%{searchValue}%' " +
                $"OR c.last_name LIKE '%{searchValue}%' OR c.phone LIKE '%{searchValue}%'";
            Check[] checks = null;
            return checks = GetChecks(cmdStr);
        }
        #endregion
        //-END ------------- CHECKS ------------------------------------||

        //-START ------------- LISTS ----------------------------------||
        #region/LISTS
         public DataTable GetReportList(string query)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (MySqlCommand command = new MySqlCommand(query))
            {
                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            return dt;
        }

        #endregion
        //-END ------------- LISTS ------------------------------------||
        //Function return  dataSet for report
        public DataTable ServicesReport(DateTime fromDT,DateTime toDT)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string query = "SELECT s.name_service, COUNT(cs.service_id), SUM(s.price)*@VAT as 'sum' FROM services s " +
                "INNER JOIN check_service cs ON s.service_id=cs.service_id INNER JOIN checks ch ON cs.check_id = ch.check_id " +
                "WHERE ch.date_time>=STR_TO_DATE(@from,'%d.%m.%Y') AND ch.date_time<=STR_TO_DATE(@to,'%d.%m.%Y') GROUP BY s.service_id ORDER BY SUM(s.price) DESC";


            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@from",fromDT.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@to", toDT.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@VAT", TaxesAndSales.Vat+1);

                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }           
            return dt;
        }
        
        //Function return  dataSet for report
        public DataTable CustomersReport(DateTime fromDT, DateTime toDT)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string query = "SELECT concat_ws(' ',c.first_name,c.last_name) as 'Name', c.phone as 'Telephone', Count(tb.customer_id) as 'Total Quantity', Sum(s.price)*@VAT as 'All Service Sum'" +
                " FROM `timetable` tb INNER JOIN customers c On tb.customer_id = c.customer_id INNER JOIN services s On tb.service_id = s.service_id" +
                " WHERE tb.payed =1 AND tb.date>=STR_TO_DATE(@from,'%d.%m.%Y') AND tb.date<=STR_TO_DATE(@to,'%d.%m.%Y') GROUP by tb.customer_id";


            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@from", fromDT.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@to", toDT.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@VAT", TaxesAndSales.Vat + 1);

                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            return dt;
        }
        public DataTable EmployeesReport(DateTime fromDT, DateTime toDT)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string query = "SELECT concat_ws(' ',e.first_name,e.last_name) as 'Employee Name',COUNT(DISTINCT e.employee_id, date, t.customer_id) as 'Number of Clients', " +
                "COUNT(t.service_id) as 'Number of Services', SUM(s.price) as 'Sum of Services', e.salary as 'Salary'" +
                   "FROM `timetable` t INNER JOIN `services` s ON t.service_id = s.service_id INNER JOIN `employees` e ON t.employee_id = e.employee_id " +
                   "WHERE date>=STR_TO_DATE(@from,'%d.%m.%Y') AND date<=STR_TO_DATE(@to,'%d.%m.%Y') GROUP BY e.employee_id";


            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@from", fromDT.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@to", toDT.ToString("dd.MM.yyyy"));

                ds = GetMultipleQuery(command);
            }
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            return dt;
        }

        
        //-END ------------- LISTS ------------------------------------||

        #endregion
        ///END--------------------------REPORT FUNCTIONS -----------------------------------------------------------------END|

        ///START------------------------PAYING FUNCTIONS ---------------------------------------------------------------START|
        #region
        public bool Pay(Basket basket)
        {
            if (basket == null) return false;
            int flag = -1;
            string query = "INSERT INTO `checks`(`customer_id`, `date_time`, `sum`) VALUES(@customer_id, @date, @sum)";
            using(MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@customer_id",basket.Customer.Customer_id);
                command.Parameters.AddWithValue("@date", Convert.ToDateTime(basket.PayDate.ToString("yyyy-MM-dd HH:MM")));
                command.Parameters.AddWithValue("@sum", basket.CalculateTotalSum());
                ExecuteSimpleQuery(command,ref flag); 
                if(flag<0) return false;
            }
            AddServicesToCheck(basket);
            return true;
        }

        private void AddServicesToCheck(Basket basket)
        {            
            int checkId = GetCheckId(basket);
            string query = "INSERT INTO `check_service`(`check_id`, `service_id`) VALUES (@check_id, @service_id)";
            for (int i = 0; i < basket.Services.Length; i++)
            {
                    using (MySqlCommand command = new MySqlCommand(query))
                {
                
                        command.Parameters.AddWithValue("@check_id", checkId);
                        command.Parameters.AddWithValue("@service_id", basket.Services[i].Id);
                        ExecuteSimpleQuery(command);                                                      
                }
            }
            SetPaid(basket);
        }

        private int GetCheckId(Basket basket)
        {
            int result = 0;
            string query = "SELECT `check_id` FROM `checks` WHERE `customer_id`= @customer_id AND date_time = @date ";
            using(MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@customer_id", basket.Customer.Customer_id);
                command.Parameters.AddWithValue("@date", Convert.ToDateTime(basket.PayDate.ToString("yyyy-MM-dd HH:MM")));

                result = ExecuteScalarIntQuery(command);
            }
              return result;
        }

        private void SetPaid(Basket basket)
        {
            string query = "UPDATE `timetable` SET `payed`='1' WHERE `date`= @date AND `customer_id`= @customer_id AND `service_id`= @serv_id";
            for (int i = 0; i < basket.Services.Length; i++)
            {
                using (MySqlCommand command = new MySqlCommand(query))
                {                
                    command.Parameters.AddWithValue("@date", basket.dateOfServices[i]);
                    command.Parameters.AddWithValue("@customer_id", basket.Customer.Customer_id);
                    command.Parameters.AddWithValue("@serv_id", basket.Services[i].Id);
                    ExecuteSimpleQuery(command);
                }
            }
        }
        #endregion
        ///END--------------------------PAYING FUNCTIONS -----------------------------------------------------------------END|
    }
}
