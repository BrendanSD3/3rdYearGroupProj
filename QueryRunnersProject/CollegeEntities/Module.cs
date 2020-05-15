using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public class Module : IModule
    {
        private string moduleID;
        private string name;
        private string courseID;
        private int credits;

        public Module(string modID, string modName, string CID, int Credit)
        {
            this.moduleID = modID;
            this.name = modName;
            this.courseID = CID;
            this.credits = Credit;



        }

        public string ModuleID
        {
            get
            {
                return this.moduleID;
            }
            set {
                this.moduleID = value;
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
        public string CourseID
        {
            get
            {
                return this.courseID;

            }
            set
            {
                this.courseID = value;

            }


        }
        public int Credits
        {
            get
            {
                return this.credits;


            }
            set
            {
                this.credits = value;
            }


        }




    }
}
