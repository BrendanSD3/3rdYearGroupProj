using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public class Template : ITemplate
    {
        private string tname;
        private string tcontent;


        public Template(string tn, string tc)
        {
            this.tname = tn;
            this.tcontent = tc;
        }
        #region InstanceProperties
        public string Tname
        {
            get
            {
                return this.tname;
            }
            set
            {
                this.tname = value;
            }
        }
        public string Tcontent
        {
            get
            {
                return this.tcontent;


            }
            set
            {
                this.tcontent = value;
            }
        }

    }
    #endregion
}
