using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Final_project___Salon
{
   
    public partial class ReportForm : Form
    {
        private Color btnColorPeach = Color.FromArgb(255, 192, 176);
        private Color btnColorGreen = Color.FromArgb(129, 187, 152);
        private DBSql mySQL;
        private Check[] myChecks;
        private Service[] services;
        CompanyInfo compInfo;// information about company, for all reports pages
        public static readonly string absolutePathToProjDir = Path.GetFullPath("../../../Reports/");//get absolute path to "Reports" directory

        public ReportForm(CompanyInfo company)
        {
            InitializeComponent();
            compInfo = company;
            mySQL = DBSql.Instance;
            FillChecks();
        }                                  

        #region/CHECKS
        /*
         * Creation Check in PDF format - Handler
         */
        private void btnSaveCheck_Click(object sender, EventArgs e)        
        {
            CreatePdfCheck();            
        }

        //Print check by dataGrid row
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string id = dataGridChecks.CurrentRow.Cells[1].Value.ToString();
            string path = Path.Combine(absolutePathToProjDir ,"checks" , id + "-check.pdf");//create path to check we are need
            if (!File.Exists(path)) 
                CreatePdfCheck();
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = (path)
            };
            p.Start();
        }

        private void dataGridChecks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridChecks.CurrentRow.Cells[1].Value);// take id from data grid from selected row
            services = mySQL.CheckServices(id);
            lblService.Text = "";
            lblPrice.Text = "";

            foreach (Service  service in services)
            {
                lblService.Text += service.Name+"\n";
                lblPrice.Text += service.Price.ToString()+"\n";
            }
        }



        //Function for check pdf format creation
        private void CreatePdfCheck()
        {
            int id = Convert.ToInt32(dataGridChecks.CurrentRow.Cells[1].Value);// take id from data grid from selected row
            string[] checkData = mySQL.CheckData(id);// take check data
                              
            Report report = new Report(absolutePathToProjDir + "checks", id + "-check");//create PDF File           

            report.pdfSample(absolutePathToProjDir + "1.png", DateTime.Now, compInfo);

            report.SetTitle($"Check Number: {id}");
            report.PaddingDown(1);
            report.SetCheckData(checkData);
            report.PaddingDown(1);
            report.SetCheckServices(services,checkData[2]);
            report.CloseReport();
            WarningMessages.LongWarningMessage(lblChecksMessage, "Saved on " + absolutePathToProjDir + "checks");
            if (checkBoxSendMail.Checked)
            {
                SendMail(absolutePathToProjDir + "checks\\" + id + "-check.pdf", checkData[3], checkData[1]);
            }
        }
        /*
         * TO DO
         * Function fill data grid by checks information
         */
        private void FillChecks(Check[] myChecks)
        {
            if (myChecks is null) return;
            int rowsCount = myChecks.Length;//myChecks.Length;
            int columnsCount = 5;   //properties of service on the screen   

            dataGridChecks.RowCount = rowsCount;
            dataGridChecks.ColumnCount = columnsCount;

            dataGridChecks.Columns[0].HeaderText = "Date and Time";
            dataGridChecks.Columns[1].HeaderText = "Check Id";
            dataGridChecks.Columns[2].HeaderText = "Customer Name";
            dataGridChecks.Columns[3].HeaderText = "Customer Phone";
            dataGridChecks.Columns[4].HeaderText = "Total Sum";

            for (int j = 0; j < rowsCount; j++)
            {

                dataGridChecks[0, j].Value = myChecks[j].Date_time.ToString();
                dataGridChecks[1, j].Value = myChecks[j].Check_id.ToString();
                dataGridChecks[2, j].Value = mySQL.GetOneElement($"SELECT concat_ws(' ',`first_name`,`last_name`) FROM `customers` WHERE `customer_id`= {myChecks[j].Customer_id}");
                dataGridChecks[3, j].Value = mySQL.GetOneElement($"SELECT `phone` FROM `customers` WHERE `customer_id`= {myChecks[j].Customer_id}");
                dataGridChecks[4, j].Value = mySQL.GetOneElement($"SELECT sum FROM `checks` WHERE check_id = {myChecks[j].Check_id}");
            }
        }

        //Get all checks from DB and sending to FiilChecks func
        private void FillChecks()
        {
            myChecks = mySQL.GetChecks();
            FillChecks(myChecks);
        }

        //Filter for checks searching
        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            Check[] checks = null;
            if (!textBoxFilter.Text.Equals(""))
            {
                checks = mySQL.SearchChecks(textBoxFilter.Text);         // sql query function(return array of checks)
                if (checks == null)                 //check if checks array is not empty 
                {
                    FillChecks();
                }
                else
                {
                    FillChecks(checks);
                }

            }
            else
            {
                FillChecks();
            }
        }
        #endregion
        //--------------------------------------------------------------------------------------------------------------------|
        #region/LISTS

        /*
         * Save Pdf buttons! Save report pdf in directiry .../reports/lists
         */
        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            CreatePdfEmployees();
        }
        private void btnCustomersSave_Click(object sender, EventArgs e)
        {
            CreatePdfCustomers();
        }

        private void btnServicesSave_Click(object sender, EventArgs e)
        {
            CreatePdfServices();
        }

        private void btnTimeTableSave_Click(object sender, EventArgs e)
        {
            CreatePdfTimeTable();
        }
        /*-------------------------------------------------------------*/

        //Buttons for Reports printing, if pdf files not exists - create them
        private void btnEmployeePrint_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(absolutePathToProjDir + "lists", "Eployees-" + DateTime.Now.ToShortDateString()+".pdf");
            if (!File.Exists(path))
                CreatePdfEmployees();
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = (path)
            };
            p.Start();
        }

        private void btnCustomersPrint_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(absolutePathToProjDir + "lists", "Customers-" + DateTime.Now.ToShortDateString() + ".pdf");
            if (!File.Exists(path))
                CreatePdfCustomers();
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = (path)
            };
            p.Start();
        }

        private void btnServicesPrint_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(absolutePathToProjDir + "lists", "Services-" + DateTime.Now.ToShortDateString() + ".pdf");
            if (!File.Exists(path))
                CreatePdfServices();
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = (path)
            };
            p.Start();
        }

        private void btnTimeTablePrint_Click(object sender, EventArgs e)
        {
            string theDate = dtPickerTTList.Value.ToShortDateString();
            string path = Path.Combine(absolutePathToProjDir + "lists", "TimeTable-" + theDate + ".pdf");
            if (!File.Exists(path))
                CreatePdfTimeTable();
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = (path)
            };
            p.Start();
        }
        /******************************************************************/

        /// <summary>
        /// Methods was activating from save buttons.
        /// Send query to data base, and recieve dataTable file with result table
        /// and insert to pdf file in specified format.
        /// At the end of creating, show mesage with file path
        /// </summary>
        private void CreatePdfEmployees()
        {
            string query = "SELECT `employee_id` as 'EMP Id',`first_name`,`last_name`,`salary`,`birth_date`,`city`,`street`,concat_ws('/',house,appartment) AS 'H/Apt',`phone`,`start_work_date`,`mail` FROM `employees`";
            DataTable dt = mySQL.GetReportList(query);
            Report report = new Report(absolutePathToProjDir + "lists", "Eployees-"+ DateTime.Now.ToShortDateString());//create PDF File     
            report.pdfSample(absolutePathToProjDir + "1.png", DateTime.Now, compInfo);           
            
            report.SetTitle($"Employees List");
            report.PaddingDown(1);
            report.ListsInformation(dt);

            report.CloseReport();
            WarningMessages.LongWarningMessage(lblEmpMessage, "Saved on " + absolutePathToProjDir + "lists");
        }
        private void CreatePdfCustomers()
        {
            string query = "SELECT `customer_id` as 'Client Id',`first_name`,`last_name`,`birth_date`,`city`,`street`,concat_ws('/',house,appartment) AS 'No',`phone`,`mail` FROM `customers`";
            DataTable dt = mySQL.GetReportList(query);
            Report report = new Report(absolutePathToProjDir + "lists", "Customers-" + DateTime.Now.ToShortDateString());//create PDF File     
            report.pdfSample(absolutePathToProjDir + "1.png", DateTime.Now, compInfo);

            report.SetTitle($"Customers List");
            report.PaddingDown(1);
            report.ListsInformation(dt);

            report.CloseReport();
            WarningMessages.LongWarningMessage(lblCustomersMessage, "Saved on " + absolutePathToProjDir + "lists");
        }
        private void CreatePdfServices()
        {
            string query = "SELECT `service_id`,`name_service`,concat_ws(' ',`executing_time`,'min') AS 'Executing Time',`price` FROM `services` WHERE `deleted`= 0";
            DataTable dt = mySQL.GetReportList(query);

            Report report = new Report(absolutePathToProjDir + "lists", "Services-" + DateTime.Now.ToShortDateString());//create PDF File     
            report.pdfSample(absolutePathToProjDir + "1.png", DateTime.Now, compInfo);

            report.SetTitle($"Services List");
            report.PaddingDown(1);
            report.ListsInformation(dt);

            report.CloseReport();
            WarningMessages.LongWarningMessage(lblServiceMessage, "Saved on " + absolutePathToProjDir + "lists");
        }
        private void CreatePdfTimeTable()
        {
            string theDate = dtPickerTTList.Value.ToShortDateString();
            string query = $"SELECT DATE_FORMAT(t.date, '%d.%m.%y') AS 'date' ,DATE_FORMAT(`start_time`,'%H:%i') AS 'start time',DATE_FORMAT(`end_time`,'%H:%i') AS 'End Time'," +
                $"e.employee_id AS 'Emp Id',concat_ws(' ',e.first_name,e.last_name) AS 'Employee Full Name'," +
                $"c.customer_id AS 'Client id', Concat_ws(' ',c.last_name , c.first_name) AS 'Customer Full Name',c.phone, s.name_service AS Service, s.price, concat_ws(' ',`executing_time`,'min') AS 'Time' " +
                $"FROM `timetable` t INNER JOIN `employees` e ON t.employee_id=e.employee_id INNER JOIN customers c ON t.customer_id=c.customer_id INNER JOIN services s ON t.service_id=s.service_id " +
                $"WHERE DATE_FORMAT(t.date,'%d.%m.%Y')='{theDate}' ORDER BY `date`,`start_time`";
           DataTable dt = mySQL.GetReportList(query);                               

            Report report = new Report(absolutePathToProjDir + "lists", "TimeTable-" + theDate);//create PDF File     
            report.pdfSample(absolutePathToProjDir + "1.png", DateTime.Now, compInfo);

            report.SetTitle($"TimeTable List on {theDate}");
            report.PaddingDown(1);
            report.ListsInformation(dt);

            report.CloseReport();
            WarningMessages.LongWarningMessage(lblTimeTableMessage, "Saved on " + absolutePathToProjDir + "lists");
        }



        /*--------------------------------------------------------------------------------------------------------*/
        #endregion
        //--------------------------------------------------------------------------------------------------------------------|

        #region/STATISTIC

        /*
         * Method create pdf file with statisic report(fills it)
         */
        private void CreatePdfStatisic()
        {
            DateTime fromDT = dtPickerFrom.Value;
            DateTime toDT = dtPickerTo.Value;
            DataTable dt;
            Report report= null;

            if (comboBoxStat.SelectedIndex == 0)// selected "Sirvices Income" combobox
            {

                report = new Report(absolutePathToProjDir + "Statistic", "Service Income " + dtPickerFrom.Text + "-" + dtPickerTo.Text);//create PDF File     
                report.pdfSample(absolutePathToProjDir + "1.png", DateTime.Now, compInfo);
                report.SetTitle($"Services Income\n{fromDT.ToString().Replace(" 0:00:00", "")} - {toDT.ToString().Replace(" 0:00:00", "")  }");
                report.PaddingDown(1);

                report.GetServiceStatHeader();
                dt = mySQL.ServicesReport(fromDT, toDT);
                report.GetServicesStatistic(dt);
                report.PaddingDown(1);
            }
            else if (comboBoxStat.SelectedIndex == 1)// selected "Customers Report" combobox
            {
                report = new Report(absolutePathToProjDir + "Statistic", "Customers Statistic " + dtPickerFrom.Text + "-" + dtPickerTo.Text);//create PDF File     
                report.pdfSample(absolutePathToProjDir + "1.png", DateTime.Now, compInfo);
                report.SetTitle($"Customers Statistic\n{fromDT.ToString().Replace(" 0:00:00", "")} - {toDT.ToString().Replace(" 0:00:00", "")  }");
                report.PaddingDown(1);

                dt = mySQL.CustomersReport(fromDT, toDT);
                report.GetClientsStatHeader(dt);
                report.PaddingDown(1);
            }
            else if (comboBoxStat.SelectedIndex == 2)//selected "Employees Report" combobox
            {
                report = new Report(absolutePathToProjDir + "Statistic", "Employees Statistic " + dtPickerFrom.Text + "-" + dtPickerTo.Text);//create PDF File     
                report.pdfSample(absolutePathToProjDir + "1.png", DateTime.Now, compInfo);
                report.SetTitle($"Employees Statistic\n{fromDT.ToString().Replace(" 0:00:00", "")} - {toDT.ToString().Replace(" 0:00:00", "")  }");
                report.PaddingDown(1);


                dt = mySQL.EmployeesReport(fromDT, toDT);
                report.GetEmployeeStatistic(dt);
            }

                report?.CloseReport();
            WarningMessages.LongWarningMessage(lblStatMessage, "Saved on " + absolutePathToProjDir + "Statistic");
        }


        
        /// <summary>
        /// Fill DataGrid By Services Income Values
        /// </summary>
        /// <param name="dt">Services by quantity and Sum</param>
        private void ServicesStatDataGrid(DataTable dt)
        {
            int rowsCount = dt.Rows.Count;
            int columnsCount = 4;
            double total = 0;
            if (rowsCount < 1) 
            {
                WarningMessages.WarningMessage(lblStatMessage, "No Data!");
                return; 
            }
            dataGridStat.RowCount = rowsCount;
            dataGridStat.ColumnCount = columnsCount;

            dataGridStat.Columns[0].HeaderText = "Service Name";
            dataGridStat.Columns[1].HeaderText = "Quantity";
            dataGridStat.Columns[2].HeaderText = "Amount";
            dataGridStat.Columns[3].HeaderText = "Procent";

            //get sums of all services
            var result = dt.AsEnumerable().Select(row => row.Field<Decimal>("sum"));
            foreach (var res in result)
            {
                total += Convert.ToInt64(res);//sum of all services
            }

            for (int i = 0; i < rowsCount; i++)           
            {

                dataGridStat[0, i].Value = dt.Rows[i][0];// name of service
                dataGridStat[1, i].Value = dt.Rows[i][1];// quantity of each service
                dataGridStat[2, i].Value = dt.Rows[i][2] + " ₪";// summ of each service
                dataGridStat[3, i].Value = Format.FormatDuobleTwoDecPlaces((Convert.ToInt64(dt.Rows[i][2]) * 100) / total) + " %";// procent of service sum from total sum
            }

        }

        /// <summary>
        /// Fill DataGrid By Customers Statistic
        /// </summary>
        /// <param name="dt">Customer name, phone,number of visits and amound of payed money </param>
        private void CustomersStatDataGrid(DataTable dt)
        {
            int rowsCount = dt.Rows.Count;
            int columnsCount = 5;
            double total = 0;
            if (rowsCount < 1)
            {
                WarningMessages.WarningMessage(lblStatMessage, "No Data!");
                return;
            }
            dataGridStat.RowCount = rowsCount;
            dataGridStat.ColumnCount = columnsCount;

            dataGridStat.Columns[0].HeaderText = "Customer Name";
            dataGridStat.Columns[1].HeaderText = "Telephone";
            dataGridStat.Columns[2].HeaderText = "Services Amount";
            dataGridStat.Columns[3].HeaderText = "Services Total Sum";
            dataGridStat.Columns[4].HeaderText = "Procent";

            //get sums of all services
            var result = dt.AsEnumerable().Select(row => row.Field<Decimal>("All Service Sum"));
            foreach (var res in result)
            {
                total += Convert.ToInt64(res);//sum of all services
            }

            for (int i = 0; i < rowsCount; i++)
            {
                dataGridStat[0, i].Value = dt.Rows[i][0];// name of customer
                dataGridStat[1, i].Value = dt.Rows[i][1];// customer phone
                dataGridStat[2, i].Value = dt.Rows[i][2];// quantity of services by customer
                dataGridStat[3, i].Value = dt.Rows[i][3] + " ₪";// cost of all customer`s services
                dataGridStat[4, i].Value = Format.FormatDuobleTwoDecPlaces((Convert.ToInt64(dt.Rows[i][3]) * 100) / total) + " %";// procent of srvice sum from total sum
            }
        }
        /// <summary>
        /// Fill DataGrid By Employees Statistic
        /// </summary>
        /// <param name="dt">Data Table with - Employee Name,Number Of Clients,Number Of Services per employee,Total Sevices Sum per employee,Salary</param>
        private void EmployeeStatDataGrid(DataTable dt)
        {
            int rowsCount = dt.Rows.Count;
            int columnsCount = 6;
            double total = 0;
            if (rowsCount < 1)
            {
                WarningMessages.WarningMessage(lblStatMessage, "No Data!");
                return;
            }
            dataGridStat.RowCount = rowsCount;
            dataGridStat.ColumnCount = columnsCount;

            dataGridStat.Columns[0].HeaderText = "Employee Name";
            dataGridStat.Columns[1].HeaderText = "Number Of Clients";
            dataGridStat.Columns[2].HeaderText = "Number Of Services";
            dataGridStat.Columns[3].HeaderText = "Total Sevices Sum";
            dataGridStat.Columns[4].HeaderText = "Procent From All Services Sum";
            dataGridStat.Columns[5].HeaderText = "Salary";

            //get sums of all services
            var result = dt.AsEnumerable().Select(row => row.Field<Decimal>("Sum of Services"));
            foreach (var res in result)
            {
                total += Convert.ToInt64(res);//sum of all services
            }

            for (int i = 0; i < rowsCount; i++)
            {
                dataGridStat[0, i].Value = dt.Rows[i][0];//Employee name
                dataGridStat[1, i].Value = dt.Rows[i][1];//Number of clients
                dataGridStat[2, i].Value = dt.Rows[i][2];//Number of services
                dataGridStat[3, i].Value = dt.Rows[i][3];//summ of services
                dataGridStat[4, i].Value = Format.FormatDuobleTwoDecPlaces((Convert.ToInt64(dt.Rows[i][3]) * 100) / total) + " %";//Procent from all service sum
                dataGridStat[5, i].Value = dt.Rows[i][4] + " ₪";//salary

            }
        }
        private void GetStatistic()
        {
            DateTime fromDT = dtPickerFrom.Value;
            DateTime toDT = dtPickerTo.Value;
            DataTable dt = null;

            if (comboBoxStat.SelectedIndex == 0)// select "Sirvices Income" combobox
            {
                dt = mySQL.ServicesReport(fromDT, toDT);
                ServicesStatDataGrid(dt);
            }
            else if (comboBoxStat.SelectedIndex == 1)// select "Sirvices Income" combobox
            {
                dt = mySQL.CustomersReport(fromDT, toDT);
                CustomersStatDataGrid(dt);
            }
            else if (comboBoxStat.SelectedIndex == 2) //select "Employees Report" combobox
            {
                dt = mySQL.EmployeesReport(fromDT, toDT);
                EmployeeStatDataGrid(dt);
            }
        }
        private void comboBoxStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStatistic();
        }




        //Button one Week back from current date
        private void btnWeek_Click(object sender, EventArgs e)
        {
            dtPickerFrom.Value = DateTime.Today.AddDays(-7);
            dtPickerTo.Value = DateTime.Today;
            setButtonDefaultColor(ref btnWeek);
            comboBoxStat_SelectedIndexChanged(sender, e);
        }

        //Button one Month back from current date
        private void btnMonth_Click(object sender, EventArgs e)
        {
            dtPickerFrom.Value = DateTime.Today.AddMonths(-1);
            dtPickerTo.Value = DateTime.Today;
            setButtonDefaultColor(ref btnMonth);
            comboBoxStat_SelectedIndexChanged(sender,e);
        }

        //Button one Year back from current date
        private void btnYear_Click(object sender, EventArgs e)
        {            
            dtPickerFrom.Value = DateTime.Today.AddYears(-1);
            dtPickerTo.Value = DateTime.Today;
            setButtonDefaultColor(ref btnYear);
            comboBoxStat_SelectedIndexChanged(sender, e);
        }

        /*
         * Method set on all buttons green color and set other color on clicked button(Argument - "btn"),
         * If flag false all buttons stay green
         */
        private void setButtonDefaultColor(ref Button btn, bool flag = true)
        {
            btnWeek.BackColor = btnColorGreen;
            btnMonth.BackColor = btnColorGreen;
            btnYear.BackColor = btnColorGreen;
            if (flag)
            {
                btn.BackColor = btnColorPeach;
            }
        }

        //Set all buttons  green by click, and reset dates
        private void tabPage4_Click(object sender, EventArgs e)
        {
            dtPickerFrom.Value = dtPickerTo.Value = DateTime.Today;
            setButtonDefaultColor(ref btnYear,false);
        }

        //If date was changed, unset button(set green color)
        private void dtPickerFrom_ValueChanged(object sender, EventArgs e)
        {
            setButtonDefaultColor(ref btnYear,false);
            comboBoxStat_SelectedIndexChanged(sender, e);
        }

        //If date was changed, unset button(set green color)
        private void dtPickerTo_ValueChanged(object sender, EventArgs e)
        {
           setButtonDefaultColor(ref btnYear, false);
           comboBoxStat_SelectedIndexChanged(sender, e);
        }

        //Create and save PDF with report by click and date
        private void btnSaveStatistic_Click(object sender, EventArgs e)
        {
            CreatePdfStatisic();
        }

        // Print Report statistic
        private void btnPrintStatistic_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(absolutePathToProjDir + "Statistic", dtPickerFrom.Text + "-" + dtPickerTo.Text + ".pdf");
            if (!File.Exists(path))
                CreatePdfServices();
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = (path)
            };
            p.Start();
        }



        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillChecks();
        }


        /// <summary>
        /// Send pdf of check to customer
        /// </summary>
        /// <param name="path">path to pdf file</param>
        /// <param name="mail">email of customer</param>
        /// <param name="name">name of customer</param>
        private void SendMail(string path,string mail,string name)
        {

            // mail of sender and name to display
            MailAddress from = new MailAddress(compInfo.CompEmail, compInfo.CompName);
            // mail destination
            MailAddress to = new MailAddress(mail);
            // Message object
            MailMessage message = new MailMessage(from, to);
            //file
            message.Attachments.Add(new Attachment(path));
            // mail subject
            message.Subject = "Your's check";
            // text of mail in html format
            message.Body = $"<h2>Hi {name}! It's Yours Check </h2>";
            // письмо представляет код html
            message.IsBodyHtml = true;
            // stmp server addres and port
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // login and pass of sender
            smtp.Credentials = new NetworkCredential("vandrass@gmail.com", "orkiydzfmcggitwc");
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
    }
}
