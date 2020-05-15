using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
  
        public class Letter : ILetter
        {
            private string senderid;
            private string recieverid;
            private string tname;
            private string lcontent;
            private string date;
            private string letterid;


            public Letter(string sid, string rid, string tn, string lc, string dat, string lid)
            {
                this.senderid = sid;
                this.recieverid = rid;
                this.tname = tn;
                this.lcontent = lc;
                this.date = dat;
                this.letterid = lid;
            }
            #region InstanceProperties
            public string senderID
            {
                get
                {
                    return this.senderid;
                }
                set
                {
                    this.senderid = value;
                }
            }
            public string recieverID
            {
                get
                {
                    return this.recieverid;


                }
                set
                {
                    this.recieverid = value;
                }
            }
            public string tName
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
            public string lContent
            {
                get
                {
                    return this.lcontent;
                }
                set
                {
                    this.lcontent = value;
                }
            }
            public string Date
            {
                get
                {
                    return this.date;
                }
                set
                {
                    this.date = value;
                }
            }
            public string Letterid
            {
                get
                {
                    return this.letterid;
                }
                set
                {
                    this.letterid = value;
                }
            }

        }
        #endregion
    }

