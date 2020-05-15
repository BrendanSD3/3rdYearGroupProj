using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public interface IApplicant : IStudent
    {
        int LeavingCertPoints { get; set; }
    }
}
