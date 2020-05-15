using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public class Administrator : Staff 
    {
        

        #region Constructors
        
        public Administrator(string firstname, string lastname, string password, string userID) : base(firstname, lastname,password,userID)
        {
            this.UserType = "Administrator";
        }

        public Administrator(string userID, string pps, string phone, string email, int hod) : base(userID, pps,phone,email, hod)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserType = "Administrator";
            //this.Password = password;
        }
        #endregion
    }
}
