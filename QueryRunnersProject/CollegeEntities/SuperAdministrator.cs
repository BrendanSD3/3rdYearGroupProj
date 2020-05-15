using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public class SuperAdministrator : Administrator
    {
        #region Constructors

        public SuperAdministrator(string firstname, string lastname, string password, string userID) : base(firstname, lastname, password, userID)
        {
            this.UserType = "SuperAdministrator";
        }


        public SuperAdministrator(string userID, string pps, string phone, string email, int hod) : base(userID, pps, phone, email, hod)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserType = "SuperAdministrator";
            //this.Password = password;
        }
        #endregion


    }
}
