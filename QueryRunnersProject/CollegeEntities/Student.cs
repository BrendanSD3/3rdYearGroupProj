using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public class Student : User, IStudent
    {
        private string studentID;
        private string courseID_fk;
        private int nonEU;
        private int feesPaid;
        private int nightStudent;
        private int year;
        private int partTime;
        private DateTime dob;

        #region InstanceProperties
        public DateTime DOB { get { return this.dob; } set { this.dob = value; } }

        public int IsPartTime
        {
            get
            {
                return this.partTime;
            }
            set
            {
                this.partTime = value;
            }
        }
        public string StudentID
        {
            get
            {
                return this.studentID;
            }
            set
            {
                this.studentID = value;
            }
        }

        public string CourseID_fk
        {
            get
            {
                return this.courseID_fk;
            }
            set
            {
                this.courseID_fk = value;
            }
        }

        public int NonEU
        {
            get
            {
                return this.nonEU;
            }
            set
            {
                this.nonEU = value;
            }
        }
        public int FeesPaid
        {
            get
            {
                return this.feesPaid;
            }
            set
            {
                this.feesPaid = value;
            }
        }

        public int NightStudent
        {
            get
            {
                return this.nightStudent;
            }
            set
            {
                this.nightStudent = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

        #endregion


        #region Constructors
        public Student(string userID) : base(userID)
        {

        }

        public Student(string firstname, string lastname, string password) : base(firstname, lastname, password)
        {

        }

        public Student(string StudentID, string CourseID_fk, int NonEU, int FeesPaid, int NightStudent, int Year, int isPartTime, DateTime dob) : base(StudentID)
        {
            this.studentID = StudentID;
            this.year = Year;
            this.courseID_fk = CourseID_fk;
            this.nonEU = NonEU;
            this.feesPaid = FeesPaid;
            this.nightStudent = NightStudent;
            this.dob = dob;
        }

        public Student(string firstname, string lastname, string password, string userID) : base(firstname, lastname, password, userID)
        {
            this.UserType = "Student";
        }
        #endregion


    }
}
