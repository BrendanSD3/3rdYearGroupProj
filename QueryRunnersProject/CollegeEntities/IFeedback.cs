using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public interface IFeedback
    {
        string stdname { get; set; }
        string CourseN { get; set; }
        string Desc { get; set; }
    }
}
