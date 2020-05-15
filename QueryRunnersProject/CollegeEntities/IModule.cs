using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public interface IModule
    {
        string ModuleID { get; set; }
        string Name { get; set; }
        string CourseID { get; set; }
        int Credits { get; set; }



    }
}
