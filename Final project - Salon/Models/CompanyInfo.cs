using System;

namespace Final_project___Salon
{
    /// <summary>
    /// Class contains Company Infomation, Pass and Login
    /// And if User Admin or secretary
    /// 
    /// Used To authorization, for pdf Reports and could been changed in settings form
    /// </summary>
    public class CompanyInfo
    {
        private string userName;
        private string password;
        private Boolean ifBoss;
        private int compId;
        private string compName;
        private string compEmail;
        private string compPhone;
        private string compAddress;
        private int compLicense;



        public string UserName { get; set; }
        public string Password { get; set; }
        public Boolean IfBoss { get; set; }
        public int CompId { get; set; }
        public string CompName { get; set; }
        public string CompEmail { get; set; }
        public string CompPhone { get; set; }
        public string CompAddress { get; set; }
        public int CompLicense { get; set; }

        public override string ToString()
        {
            return ($"{compId}\n{compName}\n{compEmail}\n{compPhone}\n{compAddress}\n{compLicense}");
        }

    }
}
