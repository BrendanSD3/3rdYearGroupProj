using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public class Feedback : IFeedback
    {
        private string SN;
        private string CN;
        private string desc;


        public Feedback(string SN, string CN, string desc)
        {
            this.stdname = SN;
            this.CourseN = CN;
            this.Desc = desc;

        }



        public string stdname
        {
            get
            {
                return this.SN;
            }
            set
            {
                this.SN = value;
            }
        }
        public string CourseN
        {
            get
            {
                return this.CN;
            }
            set
            {
                this.CN = value;
            }
        }

        public string Desc
        {
            get
            {
                return this.desc;
            }
            set
            {
                this.desc = value;
            }
        }


    }
}
