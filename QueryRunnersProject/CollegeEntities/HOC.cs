using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    class HOC:Staff
    {
        public HOC(string firstname, string lastname, string password, string userID) : base(firstname, lastname, password, userID)
        {
            this.UserType = "HOC";
        }

        public HOC(string userID, string pps, string phone, string email, int hod) : base(userID, pps, phone, email, hod)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserType = "HOC";
            //this.Password = password;
        }



    }
}
