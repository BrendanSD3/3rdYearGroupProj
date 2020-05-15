using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public class Grade : IGrade
    {
        private string studentID;
        private string modID;
        private string grade;

        public Grade(string s_id, string m_id, string G)
        {
            this.studentID = s_id;
            this.modID = m_id;
            this.grade = G;




        }
        #region InstanceProperties
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
        public string ModID
        {
            get
            {
                return this.modID;


            }
            set
            {
                this.modID = value;
            }
        }
        public string Grades
        {
            get
            {
                return this.grade;


            }
            set
            {
                this.grade = value;
            }
        }
    }
    #endregion
}
