using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public static class UserFactory
    {
        private static IUser user = null;
        private static IStaff staffMember = null;
        private static IDepartment department = null;
        private static ICourse course = null;
        private static IGrade grade = null;
        private static IApplicant applicant = null;
        private static IModule module = null;
        private static IRoom room = null;
        private static IStudent student = null;
        private static IFeedback feedbacks = null;
        private static ITemplate template = null;
        private static ILetter letter = null;
        public static IUser GetUser(string userID, string firstname, string lastname, string password, object type)
        {
            if (user != null)
                return user;
            else if(type.ToString() == "SuperAdministrator")
                return new SuperAdministrator(firstname, lastname, password, userID);
            else if (type.ToString() == "Administrator")
                return new Administrator(firstname, lastname, password, userID);
            else if (type.ToString() == "Student")
                return new Student(firstname, lastname, password, userID);
            else if (type.ToString() == "Lecturer")
                return new Lecturer(firstname, lastname, password, userID);
            else if (type.ToString() == "HOC")
                return new HOC(firstname, lastname, password, userID);
            else if (type.ToString() == "ITTechnician")
                return new ITTechnician(firstname, lastname, password, userID);
            else if (type.ToString() == "HOD")
                return new HOD(firstname, lastname, password, userID);
            return null;
        }

        public static IStaff GetStaffMember(string userID, int hod, string pps, string email, string phone, object type)
        {
            if (staffMember != null)
                return staffMember;
            else if (type.ToString() == "SuperAdministrator")
                return new SuperAdministrator(userID, pps, phone, email, hod);
            else if (type.ToString() == "Administrator")
                return new Administrator(userID, pps, phone, email, hod);
            else if (type.ToString() == "Lecturer")
                return new Lecturer(userID, pps, phone, email, hod);
            else if (type.ToString() == "HOC")
                return new HOC(userID, pps, phone, email, hod);
            else if (type.ToString() == "ITTechnician")
                return new ITTechnician(userID, pps, phone, email, hod);
            else if (type.ToString() == "HOD")
                return new HOD(userID, pps, phone, email, hod);

            else
                return null;
        }

        public static IStudent GetStudent(string StudentID, string CourseID_fk, int NonEU, int FeesPaid, int NightStudent, int Year, int isPartTime, DateTime dob)
        {
            if (student != null)
                return student;
            else
                return new Student(StudentID, CourseID_fk, NonEU, FeesPaid, NightStudent, Year, isPartTime, dob);
        }

        public static IApplicant GetApplicantMember(string appID, string fname, string lname, int nonEU, int nightStudent, int partTime, int points, DateTime dob, string course)
        {
            if (applicant != null)
                return applicant;
            else
                return new Applicant(appID, fname, lname, nonEU, nightStudent, partTime, points, dob, course);

        }

        public static ICourse GetCourse(string courseID, string Name, string depID, double PriceEU, double PriceNonEU, string desc, int points, int capacity, int curCapacity, int isNight)
        {

            if (course != null)
                return course;
            else
                return new Course(courseID, Name, depID, PriceEU, PriceNonEU, desc, points, capacity, curCapacity, isNight);

        }

        public static IDepartment GetDepartment(string depID, string name, string hodID)
        {
            if (department != null)
                return department;
            else
                return new Department(depID, name, hodID);
        }
        public static IGrade GetGrade(string stuID, string modID, string grades)
        {
            if (course != null)
                return grade;
            else
                return new Grade(stuID, modID, grades);
        }

        public static void SetUser(IUser aUser)
        {
            user = aUser;
        }
        public static IModule GetModule(string modID, string name, string CourseID,int Credits)
        {
            if (module != null)
                return module;
            else
                return new Module( modID,  name,  CourseID,  Credits);
        }
        public static IRoom GetRoom(string Name, int Capacity,string Type)
        {
            if (room != null)
                return room;
            else
                return new Room( Name,  Capacity,  Type);
        }
        public static IFeedback GetFeedback(string stdname, string CourseN, string Desc)
        {

            if (feedbacks != null)
                return feedbacks;
            else
            {
                IFeedback theFeedback = new Feedback(stdname, CourseN, Desc);
                return theFeedback;
            }
            // return feedbacks;
        }
        public static ITemplate GetTemplate(string tname, string tcontent)
        {
            if (course != null)
                return template;
            else
                return new Template(tname, tcontent);
        }
        public static ILetter GetLetter(string senderid, string recieverid, string tname, string lcontent, string date, string letterid)
        {
            if (course != null)
                return letter;
            else
                return new Letter(senderid, recieverid, tname, lcontent, date, letterid);
        }
    }
}
