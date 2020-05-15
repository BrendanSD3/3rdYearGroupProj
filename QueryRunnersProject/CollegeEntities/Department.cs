using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public class Department : IDepartment
    {
        private string departmentID;
        private string name;
        private string headOfdepartmentID;


        public Department(string d_id, string n, string hod_id)
        {
            this.departmentID = d_id;
            this.name = n;
            this.headOfdepartmentID = hod_id;
        }

        #region InstanceProperties
        public string DepartmentID
        {
            get
            {
                return this.departmentID;
            }
            set
            {
                this.departmentID = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string HeadOfDepartmentID
        {
            get
            {
                return this.headOfdepartmentID;
            }
            set
            {
                this.headOfdepartmentID = value;
            }
        }
        #endregion


    }
}
