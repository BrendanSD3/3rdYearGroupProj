using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public interface IStudent :IUser
    {
        string StudentID { get; set; }
        string CourseID_fk { get; set; }
        int NonEU { get; set; }
        int FeesPaid { get; set; }
        int NightStudent { get; set; }
        int Year { get; set; }
        int IsPartTime { get; set; }
        DateTime DOB { get; set; }
    }
}
