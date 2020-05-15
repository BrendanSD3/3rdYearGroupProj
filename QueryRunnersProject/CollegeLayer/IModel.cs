using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeEntities;

namespace CollegeLayer
{
    public interface IModel
    {
        IUser CurrentUser { get; set; }
        bool updateDepartment(string depID, string name, string hodID, string newDepID, string newName, string newhodID);
        string getUserTypeForCurrentuser();
        Boolean login(string userID, string password);
        Boolean addNewStaffMember(string firstname, string lastname, object userType, string pps, string phone, string email, int hod);
        Boolean addNewUser(string firstname, string lastname, string password, object userType);
        Boolean returnApplicant();
        Boolean addApplicant(int appID, string fname, string lname, int nonEU, int nightStu, int isPartTime, int points, DateTime dob, string course);
        bool addDepartment(string depID, string name, string hodID);
        bool deleteUser(IUser user);
        bool editUser(IUser user);
        void tearDown();
        List<IStaff> StaffList { get; }
        List<IUser> UserList { get; }
        List<IDepartment> DepartmentList { get; set; }
        List<ICourse> CourseList { get; set; }
        List<IGrade> GradeList { get; set; }
        List<IStudent> StudentList { get; set; }
        List<IModule> ModuleList { get; set; }
        List<IRoom> RoomList { get; set; }
        List<IApplicant> ApplicantList { get; set; }
        List<IFeedback> FeedbackList { get; set; }

        // List<ITemplate> TemplateList { get; set; }
        Boolean DeleteApplicant(string fname, string lname, int noneu, int night, int parttime, DateTime dob, string course);
        Boolean addNewStudent(string userID, string course, int noneu, int feespaid, int nightstudent, int year, int isparttime, DateTime dob);
        bool addCourse(string courseID, string name, string deptid, double priceEU, double priceNonEU, string desc, int points, int capacity, int curCapacity, int isNight);
        bool editCourse(string courseID, string name, string deptid, double priceEU, double priceNonEU, string desc, int points, int capacity, int curCapacity,int isNight);
        
        bool EditStudentCourse(IStudent user);
        bool addModule(string ModuleID,string name,string courseID,int credits);
        Boolean deleteRoom(string name, int capacity, string type);
        Boolean addRoom(string roomName, int capacity, string type);
        Boolean editRoom(string originalName, int originalCapacity, string originalType, string newName, int newCapacity, string newType);
        bool AddFeedBack(string stdname, string CourseN, string desc);
        List<ITemplate> TemplateList { get; set; }
        bool addTemplate(string tName, string tContent);
        List<ILetter> LetterList { get; set; }
        bool addLetter(string senderID, string recieverID, string tName, string lContent, string Date, string Letterid);
    }
}
