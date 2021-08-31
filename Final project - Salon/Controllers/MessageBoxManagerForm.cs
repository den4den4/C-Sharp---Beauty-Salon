using System;
using System.Windows.Forms;

namespace Final_project___Salon
{
    public partial class MessageBoxManagerForm : Form
    {
        private DBSql mySQL;    //var to use Silgelton connection  
        public MessageBoxManagerForm()
        {
            InitializeComponent();
            FillRecordLabel();
            mySQL = DBSql.Instance;

        }
        /// <summary>
        /// Method to Fill Label with selected record from datagridview Tavlel with timetables 
        /// </summary>
        private void FillRecordLabel()
        {
            for (int i = 0; i < 7; ++i)     //10 - count of properties in datagrid view table but we need 7 properties  
            {
                RecordViewlabel.Text += Scueduling.dataString[i].ToString() + ' ';
            }

        }
        /// <summary>
        ///   Event Update button click =>call to Timetable input form to update 
        /// </summary>

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            TimetableInputForm inputForm = new TimetableInputForm();
            this.Hide();
            inputForm.Show();
            inputForm.UpdateProperties();

            inputForm.FormClosed += InputFormClosed;


        }
        /// <summary>
        ///      Event ot close this.Form after closing TimetableInputForm
        /// </summary>
        private void InputFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        ///   Event Cancel button to close this form 
        /// </summary
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        ///   Delete ivent => delete selected record from db 
        /// </summary>

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Timetable timetable = new Timetable();
            

            DialogResult result = MessageBox.Show("After operation 'Delete'\n selected record is deleted from database\n Are you sure?",
                 "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                timetable.FromStaticStringToTimetableOblect();
                mySQL.DeleteTimetable(timetable);                       //func delete emp from BD 
            }

            this.Close();

        }
    


    }
}
