using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public abstract class User : CollegeEntities.IUser
    {
        private string firstname;
        private string lastname;
        private string password;
        private string userID;
        private string userType;
        

        #region Instance Propertiess

        public string UserType
        {
            get
            {
                return userType;
            }
            set
            {
                userType = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        public string FullName { get { return this.firstname + " " + this.lastname; } }
        #endregion

        #region Constructors
        public User()
        {
            throw new System.NotImplementedException();
        }


        public User(string userID)
        {
            this.userID = userID;
        }
        public User(string firstname, string lastname, string userID)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.userID = userID;
        }

        public User(string firstname, string lastname, string password, string userID)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.userID = userID;
        }

        #endregion
    }
}
