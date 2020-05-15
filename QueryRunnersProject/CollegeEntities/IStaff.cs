using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public interface IStaff : IUser
    {
        string PPS { get; set; }
        string PhoneNum { get; set; }
        string Email { get; set; }
        int isHOD { get; set; }
        string FullName { get; }
    }
}
