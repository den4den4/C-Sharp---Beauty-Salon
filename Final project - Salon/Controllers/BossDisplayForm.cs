using System;
using System.Windows.Forms;

namespace Final_project___Salon
{


    public partial class BossDisplayForm : Form
    {
        
        Form[] forms = new Form[8];// array of ref to forms
        CustomerForm customers;// customers form
        Scueduling timeTable;// TimeTable form
        HomeForm home; //Home form 
        
        ReportForm report;  //report form 
        PayingForm paying;//Paying form 
        EmployeeWorkerForm employee; //Employee form 
        SettingsForm settings;  //Settings form 
        ServiceManagerForm service ; //Service Manager form 
        CompanyInfo company;//all user and company information

        //ButtonNames ==> array of menu buttons 
        string[] ButtonNames = { "Clients", "Squeduling", "Home", "Report", "Paying", "Workers", "Settings", "Services"};
        //LogoNames ==> array of menu logos 
        string[] LogoNames = { "ClientsPictureBox", "SchuedulingPictureBox", "HomePictureBox", "ReportPictureBox", "PayingPictureBox", "EmployeePictureBox", "SettingsPictureBox", "ServiceManagerPictureBox" };

        public BossDisplayForm(CompanyInfo company)
        {
            InitializeComponent();
            //SetFonts();
            this.company = company;
            //intializing of array of forms
            forms[0] = customers = new CustomerForm(); ;
            forms[1] = timeTable = new Scueduling();
            forms[2] = home = new HomeForm();
            forms[3] = report = new ReportForm(company);
            forms[4] = paying = new PayingForm();
            forms[5] = employee = new EmployeeWorkerForm();
            forms[6] = settings = new SettingsForm(company);
            forms[7] = service = new ServiceManagerForm();
        }


        //method hide all forms except currently working form
        //refForm - currently form
        private void HideForm(Form refForm)
        {
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] != refForm) forms[i].Hide();
            }
        }

        /// <summary>
        /// Function find form user want to open 
        /// </summary>
        private void SearchAndOpenForm(object sender, EventArgs e)
        {
            

            string s = (sender as Button).Text;      // get text from sender Button  /////////////////////////////
            for (int i = 0; i < forms.Length; i++)   //run in array of names button 
            {
                if(s.Equals(ButtonNames[i]))   //check if button  == form name we want 
                {
                    forms[i].TopLevel = false;
                    WorkspaceMainPanel.Controls.Add(forms[i]);
                    forms[i].FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    forms[i].Dock = DockStyle.Fill;
                    forms[i].Show();
                }
            }
        }
        /// <summary>
        /// Function find form user want to open clicked on logo
        /// </summary>
        private void SearchAndOpenFormFromLogo(object sender, EventArgs e)
        {
            HideForm(this);

            string s = (sender as PictureBox).Name;
            for (int i = 0; i < forms.Length; i++)   //run in array of names logos 
            {
                if (s.Equals(LogoNames[i]))   //check if logo  == form name we want 
                {
                    forms[i].TopLevel = false;
                    WorkspaceMainPanel.Controls.Add(forms[i]);
                    forms[i].FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    forms[i].Dock = DockStyle.Fill;
                    forms[i].Show();
                }
            }
        }

        /// <summary>
        /// Log out button => close main app and return to authorization form 
        /// </summary>
        private void logOutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? Exit from program?","Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (Form form in forms)
                    form.Close();
                this.Close();
                RegistrationForm registrationForm = new RegistrationForm();
                registrationForm.Show();
            }
                     
        }
        /// <summary>
        /// Main form in this class load 
        /// </summary>
        private void BossDisplayForm_Load(object sender, EventArgs e)
        {
            OpenAndHidePayingForm();// Don`t delete this method, must for opening paying form from timetable form

            WindowState = FormWindowState.Maximized;
            home.TopLevel = false;            
            WorkspaceMainPanel.Controls.Add(home);           
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            home.Show();
        }

        /// <summary>
        /// Open and hide paying form on load of Boss Display form
        /// </summary>
        private void OpenAndHidePayingForm()
        {
            WindowState = FormWindowState.Maximized;
            paying.TopLevel = false;
            WorkspaceMainPanel.Controls.Add(paying);
            paying.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            paying.Dock = DockStyle.Fill;
            paying.Show();
            paying.Hide();
        }

     /// <summary>
     /// Burger menu button to hide main menu 
     /// </summary>
        private void BurgerMenuPictureBox_Click(object sender, EventArgs e)
        {
            //panelSidebar.Width = 40;
            if (panelSidebar.Width == 40)
                panelSidebar.Width = 170;
            else
                panelSidebar.Width = 40;
        }

        /// <summary>
        /// Event button click 
        /// </summary>
        private void ScuedulingButton_Click(object sender, EventArgs e)
        {
            HideForm(this);
            SearchAndOpenForm(sender, e);
        }
        /// <summary>
        /// Event button click 
        /// </summary>
        private void ClientsButton_Click(object sender, EventArgs e)
        {
            HideForm(this);
            SearchAndOpenForm(sender, e);
        }
        /// <summary>
        /// Event button click 
        /// </summary>
        private void WorkersButton_Click(object sender, EventArgs e)
        {
            HideForm(this);
            SearchAndOpenForm(sender, e);
        }
        /// <summary>
        /// Event button click 
        /// </summary>
        private void homeButton_Click(object sender, EventArgs e)
        {
            HideForm(this);
            SearchAndOpenForm(sender, e);
        }
 
        /// <summary>
        /// Event button click 
        /// </summary>
        private void ReportButton_Click(object sender, EventArgs e)
        {
            HideForm(this);
            SearchAndOpenForm(sender, e);
        }
    
        /// <summary>
        /// Event button click 
        /// </summary>
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            HideForm(this);
            SearchAndOpenForm(sender, e);
        }
        /// <summary>
        /// Event button click 
        /// </summary>
        private void ServiceManagerButton_Click(object sender, EventArgs e)
        {
            HideForm(this);
            SearchAndOpenForm(sender, e);
        }

        /// <summary>
        ///  Picture reference Home menu 
        /// </summary>
        private void HomePictureBox_Click(object sender, EventArgs e)
        {
            SearchAndOpenFormFromLogo(sender, e);
        }
 
        /// <summary>
        /// Picture referense Report menu 
        /// </summary>
        private void ReportPictureBox_Click(object sender, EventArgs e)
        {
            SearchAndOpenFormFromLogo(sender, e);
        }

        /// <summary>
        /// Picture referense Schueduling menu
        /// </summary>
        private void SchuedulingPictureBox_Click(object sender, EventArgs e)
        {
            SearchAndOpenFormFromLogo(sender, e);
        }
        /// <summary>
        /// Picture referense Clients menu
        /// </summary>
        private void ClientsPictureBox_Click(object sender, EventArgs e)
        {
            SearchAndOpenFormFromLogo(sender, e);
        }
        /// <summary>
        /// Picture referense Workers menu
        /// </summary>
        private void EmployeePictureBox_Click(object sender, EventArgs e)
        {
            SearchAndOpenFormFromLogo(sender, e);
        }
        /// <summary>
        /// Picture referense Settings menu
        /// </summary>
        private void SettingsPictureBox_Click(object sender, EventArgs e)
        {
            SearchAndOpenFormFromLogo(sender, e);
        }
        /// <summary>
        /// Picture referense Services menu
        /// </summary>
        private void ServiceManagerPictureBox_Click(object sender, EventArgs e)
        {
            SearchAndOpenFormFromLogo(sender, e);
        }
        /// <summary>
        /// Picture referense LogOut menu
        /// </summary>
        private void LogOutPictureBox_Click(object sender, EventArgs e)
        {
            logOutButton_Click(sender, e);
        }


  
    }
}
