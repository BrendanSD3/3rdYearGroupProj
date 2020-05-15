using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public interface IRoom
    {
        string Name { get; set; }
        int Capacity { get; set; }
        string Type { get; set; }
    }
}
