using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public abstract class Staff : User, IStaff
    {
        private string pps;
        private string email;
        private string phoneNum;
        int ishod = 0;

        #region InstanceProperties
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public int isHOD
        {
            get
            {
                return this.ishod;
            }
            set
            {
                this.ishod = value;
            }
        }

        public string PPS
        {
            get
            {
                return this.pps;
            }
            set
            {
                this.pps = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string PhoneNum
        {
            get
            {
                return this.phoneNum;
            }
            set
            {
                this.phoneNum = value;
            }
        }

        #endregion


        #region Constructors
        
        public Staff(string firstname, string lastname, string password, string userID):base(firstname,lastname,password,userID)
        {

        }

        public Staff(string userID, string pps, string phone, string email, int isHOD) : base(userID)
        {
            this.PhoneNum = phone;
            this.PPS = pps;
            this.Email = email;
            this.isHOD = isHOD;
        }
        #endregion

        
    }
}
