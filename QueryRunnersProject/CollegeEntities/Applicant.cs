using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public class Applicant : Student, IApplicant
    {
        private int leavingCertPoints;


        public int LeavingCertPoints
        {
            get
            {
                return this.leavingCertPoints;
            }
            set
            {
                this.leavingCertPoints = value;
            }
        }

        #region Constructors
        public Applicant(string userID) : base(userID)
        {
            this.UserType = "Applicant";
        }

        public Applicant(string appID, string fname, string lname, int nonEU, int nightStudent, int partTime, int points, DateTime dob, string course) : base(appID)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.NonEU = nonEU;
            this.DOB = dob;
            this.NightStudent = nightStudent;
            this.IsPartTime = partTime;
            this.leavingCertPoints = points;
            this.CourseID_fk = course;
            this.UserType = "Applicant";
        }
        #endregion
    }
}
