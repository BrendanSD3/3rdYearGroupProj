using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public interface ILetter
    {
        string senderID { get; set; }
        string recieverID { get; set; }
        string tName { get; set; }
        string lContent { get; set; }
        string Date { get; set; }
        string Letterid { get; set; }
    }
}
