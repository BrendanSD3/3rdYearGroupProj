using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public interface IGrade
    {
        string StudentID { get; set; }
        string ModID { get; set; }
        string Grades { get; set; }


    }
}
