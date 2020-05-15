using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public interface ICourse
    {
         string CourseID { get; set; }
         string Name { get; set; }
         string DeptID { get; set; }
        double PriceNonEU { get; set; }
        double PriceEU { get; set; }
      string Desc { get; set; }

         int Points { get; set; }
         int Capacity { get; set; }
         int CurCapacity { get; set; }
        int IsNightCourse { get; set; }

    }
}
