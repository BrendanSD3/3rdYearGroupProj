using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string UserID { get; set; }
        string UserType { get; set; }
        string FullName { get; }


    }
}
