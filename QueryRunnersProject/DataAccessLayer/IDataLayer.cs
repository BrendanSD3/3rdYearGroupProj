using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeEntities;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void addNewStaffMemberToDB(CollegeEntities.IStaff theUser);
        void addNewUserToDB(IUser theUser);
        bool deleteUserFromDB(CollegeEntities.IUser user);
        bool editUserInDB(CollegeEntities.IUser user);
        bool updateStaffMemberToOrFromHODinDB(IStaff user, int isHod);
        void closeConnection();
        void addNewCourseToDB(ICourse acourse);
        void UpdateDepartmentInDB(IStaff staff, IDepartment dep, string oldDepID);
        List<IApplicant> getAllApplicants();
        void addApplicant(IApplicant applicant);
        List<IUser> getAllUsers();
        List<IStudent> getAllStudents();
        List<IStaff> getStaffMembers();
        List<IDepartment> getAllDepartments();
        List<ICourse> GetAllCourses();
        List<IModule> GetAllModules();
        List<IRoom> GetAllRooms();
        System.Data.SqlClient.SqlConnection getConnection();
        void addNewDepartmentToDB(IDepartment theDep);
        void openConnection();
        void DeleteApplicantFromDB(IApplicant applicant);
        //List<IUser> getAllStudents();
        bool editCourseInDB(ICourse Course);
        bool EditStudentCourseinDB(IStudent user);
        void AddNewModule(IModule module);
        List<IGrade> GetSomeGrades();
        void addNewStudenttoDB(IStudent theStudent);
        void deleteRoomInDB(IRoom room);
        Boolean editRoomInDB(IRoom oldRoom, IRoom newRoom);
        void addRoomToDB(IRoom room);
        void addNewFeedBackToDB(IFeedback thefb);
        List<IFeedback> getAllFeedback();
        List<ITemplate> GetAllTemplate();
        void addNewTemplateToDB(ITemplate atemplate);
        List<ILetter> GetAllLetters();
        void addNewLetterToDB(ILetter aletter);

    }
}
