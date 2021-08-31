using System;
using System.Windows.Forms;

namespace Final_project___Salon
{
    public partial class ServiceManagerForm : Form
    {
        private DBSql mySQL;
        private Service[] myServices;
        private AutoCompleteStringCollection source;// coolection with autofill strings
        private int ID;
        public ServiceManagerForm()
        {            
            InitializeComponent();
            mySQL = DBSql.Instance;

            CheckBoxAutoFillSource();
            FillServices();            
        }
        private void ServiceManagerForm_Load(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            btnServiceInsert.Enabled = false;
            btnServiceDel.Enabled = false;
            btnServiceUpdate.Enabled = false;
        }


        /// <summary>
        /// Function FillServices add Services in DataGrid Wiew
        /// </summary>
        private void FillServices()
        {
            myServices = mySQL.GetServices(); 
            FillServices(myServices);            
        }
        /// <summary>
        /// Function FillServices Fill Services in DataGrid Wiew
        /// </summary>
        private void FillServices(Service[] services)
        {

            int rowsCount = services.Length;
            int columnsCount = 4;   //properties of service on the screen   
            source.Clear();

            servicesDataGrid.RowCount = rowsCount;
            servicesDataGrid.ColumnCount = columnsCount;

            servicesDataGrid.Columns[0].HeaderText = "Id";
            servicesDataGrid.Columns[0].Visible = false;
            servicesDataGrid.Columns[1].HeaderText = "Name";
            servicesDataGrid.Columns[2].HeaderText = "Time";
            servicesDataGrid.Columns[3].HeaderText = "Price";

            for (int j = 0; j < services.Length; j++)
            {
                source.Add(services[j].Name.ToString());
                servicesDataGrid[0, j].Value = services[j].Id.ToString();
                servicesDataGrid[1, j].Value = services[j].Name.ToString();
                servicesDataGrid[2, j].Value = services[j].ExecutingTime.ToString()+" min";
                servicesDataGrid[3, j].Value = services[j].Price.ToString();
            }
        }

        /*
         *CLean all Text Box Fielad, exept search
         */
        private void CleanFields()
        {
            textBoxExecutingTime.Text = textBoxPrice.Text = textBoxServiceName.Text = textBoxSearchService.Text = "";
        }

    

        public bool CheckEqualName(Service service)
        {
            for (int i = 0; i < servicesDataGrid.Rows.Count; ++i)
            {
                if (service.Name.ToString() == servicesDataGrid.Rows[i].Cells[1].Value.ToString())
                {
                    WarningMessages.WarningMessage(lblWarning, "Service not update! Name is exist!");
                    return true;
                }

            }
            return false;
        }

        //----------------------------------ALL BUTTONS EVENTS ----------------------------------|

        /*
         * Function  event for adding new service to data base
         * If Service was added: Clean all textbox fields and Fill Data Grid again        
         * Else: Error massage 
         */
        private void btnServiceInsert_Click(object sender, EventArgs e)
        {
            Service service = new Service( 0 , textBoxServiceName.Text, Convert.ToInt64(textBoxPrice.Text), Convert.ToInt64(textBoxExecutingTime.Text));
            
            if (mySQL.InsertService(service)>0)
            {
                FillServices();
                CleanFields();
                WarningMessages.WarningMessage(lblWarning, "Service was Added Succsesfully!");
            }
            else
                WarningMessages.WarningMessage(lblWarning, "Service Not Added!");
            
        }

        /*
         * Function  event for updating service in data base
         * If Service updated: Clean all textbox fields and Fill Data Grid again        
         * Else: message about this
         */
        private void btnServiceUpdate_Click(object sender, EventArgs e)
        {
            Service service = new Service( ID , textBoxServiceName.Text, Convert.ToInt64(textBoxPrice.Text), Convert.ToInt64(textBoxExecutingTime.Text));

            
            if (mySQL.UpdateService(service) > 0)
            {
                FillServices();
                CleanFields();
                WarningMessages.WarningMessage(lblWarning, "Service was Updated Succsesfully!");
            }
            else
                WarningMessages.WarningMessage(lblWarning, "Service Not Update!");

            
        }


        /*
        * Function  event for soft-deleting of service from data base
        * If Service deleted: Clean all textbox fields and Fill Data Grid again        
        * Else: message about this
        */
        private void btnServiceDel_Click(object sender, EventArgs e)
        {
            Service service = new Service( ID , textBoxServiceName.Text, Convert.ToInt64(textBoxPrice.Text), Convert.ToInt64(textBoxExecutingTime.Text));

            DialogResult result = MessageBox.Show($"After operation 'Delete'\n all records of Service: {service.Name} are deleted from database\n Are you sure?",
                "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (mySQL.DeleteService(service) > 0)
                {
                    FillServices();
                    CleanFields();
                    WarningMessages.ShortMessage(lblWarning, "Service Delete Succsesfully");
                }
                else WarningMessages.ShortMessage(lblWarning, "Service not Deleted!");
            }

            ID = 0;
        }

        /*
         * Search Button
         */
        private void btnSearchService_Click(object sender, EventArgs e)
        {
            Service[] services = null;
            if (!textBoxSearchService.Text.Equals(""))
            {
                services = mySQL.SearchService(textBoxSearchService.Text);         // sql query function(return array of customers)
                if (services == null)                 //check if customer array is not empty 
                {
                    FillServices();
                }
                else
                {
                    FillServices(services);
                }

            }
            else
            {
                FillServices();
            }
        }
        //----------------------------------------------------------------------------------------|


        // ----------------------- Event - if at least one text field empty "btnServiceInsert" is lock------|


        private void textBoxServiceName_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.TextInputValidation(sender);
            CheckFields();
        }
        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.NumericInputValidation(sender);
            CheckFields();
        }
        private void textBoxExecutingTime_TextChanged(object sender, EventArgs e)
        {
            GeneralInputValidation.NumericInputValidation(sender);
            CheckFields();
        }
        /*
         * Function check fields for correct input data 
         * And Do enabling for buttons or block them
         */
        private void CheckFields()
        {
            if (textBoxServiceName.Text.Length == 0 || textBoxPrice.Text.Length == 0 || textBoxExecutingTime.Text.Length == 0)//check if fields empty
            {
                btnServiceInsert.Enabled = false;
                btnServiceUpdate.Enabled = false;
                btnServiceDel.Enabled = false;
            }
            else if ( GeneralInputValidation.NumericInput(textBoxExecutingTime.Text)
                && GeneralInputValidation.NumericInput(textBoxPrice.Text) && 
                GeneralInputValidation.NumericAndAlphabetInput(textBoxServiceName.Text))//check input data on correct type
            {
                try
                {
                    foreach (Service service in myServices)
                    {
                        if (service.Name.ToUpper() == textBoxServiceName.Text.ToUpper())// check if Service Exixsts
                        {
                            btnServiceInsert.Enabled = false;
                            btnServiceUpdate.Enabled = true;
                            btnServiceDel.Enabled = true;
                            return;
                        }
                        else
                        {
                            btnServiceInsert.Enabled = true;
                            btnServiceUpdate.Enabled = true;
                            btnServiceDel.Enabled = false;
                        }

                    }
                }
                catch (Exception) { return; }
            }
            else
            {
                btnServiceInsert.Enabled = false;
                btnServiceUpdate.Enabled = false;
                btnServiceDel.Enabled = false;
            }

        }

        //------------------------------------------------------------------------|

        //Changing of Search text field
        private void textBoxSearchService_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSearchService.Text))
            {
                FillServices();
            }
        }

        //Fill input Fields(textBoxes) by data from table after click
        private void servicesDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if(servicesDataGrid.CurrentRow.Index != -1)
            {
                ID = Convert.ToInt32(servicesDataGrid.CurrentRow.Cells[0].Value);
                textBoxServiceName.Text = servicesDataGrid.CurrentRow.Cells[1].Value.ToString();
                textBoxExecutingTime.Text = servicesDataGrid.CurrentRow.Cells[2].Value.ToString().Replace(" min","");
                textBoxPrice.Text = servicesDataGrid.CurrentRow.Cells[3].Value.ToString();
                CheckFields();

            }
        }

        //clean all by click  on left panel
        private void servicePanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CleanFields();
        }

        /// <summary>
        /// In search processing auotofill results
        /// </summary>
        private void CheckBoxAutoFillSource()
        {
            source = new AutoCompleteStringCollection();
            textBoxSearchService.AutoCompleteCustomSource = textBoxServiceName.AutoCompleteCustomSource = source;
            textBoxSearchService.AutoCompleteMode = textBoxServiceName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxSearchService.AutoCompleteSource = textBoxServiceName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
         
        /// <summary>
        ///  clean all textBox fields
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {            
            CleanFields();
        }
    }
}
