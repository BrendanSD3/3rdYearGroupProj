using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public interface IDepartment
    {
        string DepartmentID { get; set; }
        string Name { get; set; }
        string HeadOfDepartmentID { get; set; }
    }
}
