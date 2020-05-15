using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccessLayer;
using CollegeEntities;

namespace CollegeLayer
{
    public class Model : IModel
    {
        #region Static Attributes
        private static IModel modelSingletonInstance;  // Model object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the Model singleton creation. ie in GetInstance () method
        #endregion
        #region Instance Attribures
        private IDataLayer dataLayer;
        private IUser currentUser;
        private List<IUser> userList;
        private List<IStaff> staffList;
        private List<IDepartment> departmentList;
        private List<ICourse> courseList;
        private List<IGrade> gradeList;
        private List<IApplicant> applicantList;
        private List<IModule> moduleList;
        //private List<IStudent> studentList;
        private List<IFeedback> feedbackList;
        private List<IStudent> studentList;
        private List<IRoom> roomList;
        private List<ITemplate> templateList;
        private List<ILetter> letterList;

        #endregion
        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }

        

        public IUser CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }

        public List<IApplicant> ApplicantList
        {
            get
            {
                return this.applicantList;
            }
            set
            {
                this.applicantList = value;
            }
        }
        public List<IStudent> StudentList
        {
            get
            {
                return this.studentList;
            }
            set
            {
                this.studentList = value;
            }
        }
        public List<IDepartment> DepartmentList
        {
            get
            {
                return this.departmentList;
            }
            set
            {
                this.departmentList = value;
            }
        }
        public List<IModule> ModuleList
        {
            get
            {
                return this.moduleList;
            }
            set
            {
                this.moduleList = value;
            }
        }
        public List<IRoom> RoomList
        {
            get
            {
                return this.roomList;
            }
            set
            {
                this.roomList = value;
            }
        }
        public List<IStaff> StaffList
        {
            get
            {
                return staffList;
            }
        }
        //public List<IStudent> StudentList
        //{
        //    get
        //    {
        //        return this.studentList;
        //    }
        //    set
        //    {
        //        this.studentList = value;
        //    }
        //}

        public List<IUser> UserList
        {
            get
            {
                return userList;
            }
        }
        public List<ICourse> CourseList
        {

            get
            {
                return courseList;

            }
            set
            {
                this.courseList = value;
            }
        }
        public List<IGrade> GradeList
        {
            get
            {
                return gradeList;
            }
            set
            {
                this.gradeList = value;
            }
        }
        public List<IFeedback> FeedbackList
        {
            get
            {
                return feedbackList;
            }
            set
            {
                this.feedbackList = value;
            }
        }
        public List<ITemplate> TemplateList
        {
            get
            {
                return templateList;
            }
            set
            {
                this.templateList = value;
            }
        }
        public List<ILetter> LetterList
        {
            get
            {
                return letterList;
            }
            set
            {
                this.letterList = value;
            }
        }

        #endregion

        #region Constructors/Destructors
        public static IModel GetInstance(IDataLayer _DataLayer) // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (modelSingletonInstance == null)
                {
                    modelSingletonInstance = new Model(_DataLayer);
                }
                return modelSingletonInstance;
            }
        }
        private Model(IDataLayer _DataLayer)  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            userList = new List<IUser>();
            staffList = new List<IStaff>();
            courseList = new List<ICourse>();
            //moduleList = new List<IModule>();
            feedbackList = new List<IFeedback>();
            dataLayer = _DataLayer;
            roomList = dataLayer.GetAllRooms();
            moduleList = dataLayer.GetAllModules();
            userList = dataLayer.getAllUsers();
            staffList = dataLayer.getStaffMembers();
            gradeList = new List<IGrade>();
            studentList = dataLayer.getAllStudents();
            studentList = dataLayer.getAllStudents();
            departmentList = dataLayer.getAllDepartments();
            courseList = dataLayer.GetAllCourses();
            gradeList = dataLayer.GetSomeGrades();
            applicantList = dataLayer.getAllApplicants();
            feedbackList = dataLayer.getAllFeedback();
            templateList = dataLayer.GetAllTemplate();
            letterList = dataLayer.GetAllLetters();
            letterList = new List<ILetter>();
        }

        ~Model()
        {
            tearDown();
        }
        #endregion
        public Boolean login(string userID, string password)
        {

            IUser matchUser = this.UserList.FirstOrDefault(user => user.UserID == userID && user.Password == password);
            if (matchUser == null)
            {
                return false;
            }
            else
            {
                CurrentUser = matchUser;
                return true;
            }
        }

        public Boolean returnApplicant()
        {
            int maxID = 0;

            foreach(IApplicant a in ApplicantList)
                if(Convert.ToInt32(a.UserID) > maxID)
                    maxID = Convert.ToInt32(a.UserID);

            maxID++;
            CurrentUser = new Applicant(maxID.ToString());
            return true;
        }

        public Boolean addNewUser(string firstname, string lastname, string password, object userType)
        {
            string userID = "";
            if (!(userType.ToString().Equals("Student")))
                userID = firstname + "." + lastname;
            else // StudentID //
            {
                int[] code = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

                foreach (IStudent s in this.StudentList)
                {
                    string[] token = s.UserID.Split(new[] { "CC" }, StringSplitOptions.None);
                    for (int i = 0; i < code.Length; i++)
                        code[i] = Int32.Parse(token[1][i].ToString());
                }

                int before = 0;
                for (int i = 7; i >= 0; i--)
                {
                    before = i;
                    if (code[i].Equals(9))
                    {
                        code[before] = 0;
                        continue;
                    }
                    code[i] += 1;
                    break;
                }
                userID = "CC";
                foreach (int i in code)
                    userID += i;
            }


            //IUser duplicateUser = this.UserList.FirstOrDefault(user => user.UserID == userID.Trim());

            //if (duplicateUser != null)
            //{
            //    return false;
            //}
                
            //else
            //{

                try
                {
                    int count = 0;
                    string id = userID;
                    foreach (IUser user in UserList)
                    {
                        if (user.FirstName.Equals(firstname) && user.LastName.Equals(lastname))
                        {
                            count++;
                            
                        }
                    }
                if (count == 0)
                {

                }
                else
                    userID += count.ToString();

                if (password.Length < 5)
                        return false; // Maybe password policy such as at least one Upper case, one number etc see

                    IUser theUser = UserFactory.GetUser(userID, firstname, lastname, password, userType.ToString()); // Using a Factory to create the user entity object. ie seperating object creation from business logic
                    UserList.Add(theUser); // Add a reference to the newly created object to the Models UserList
                    DataLayer.addNewUserToDB(theUser); //Gets the DataLayer to add the new user to the DB.
                    return true;
                }
                catch (System.Exception excep)
                {
                    return false;
                }
            //}
        }

        public Boolean addNewStaffMember(string firstname, string lastname,object userType, string pps, string phone, string email, int hod)
        {
            
            string userID = firstname + "." + lastname;

            // some validation on userID. No duplicate userIDs;
            //IUser duplicateUser = this.StaffList.FirstOrDefault(user => user.UserID == userID.Trim());
            
            //if (duplicateUser != null)
            //    return false;
            //else
            //{
                try
                {
                int count = 0;
                string id = userID;
                foreach (IUser user in UserList)
                {
                    if (user.FirstName.Equals(firstname) && user.LastName.Equals(lastname))
                    {
                        count++;
                    }
                }
                if (count == 1)
                {

                }
                else
                {
                    count--;
                    userID += count.ToString();
                }
                    

                IStaff theUser = UserFactory.GetStaffMember(userID, hod, pps, email, phone, userType.ToString());

                    IUser usernameDetails = UserList.FirstOrDefault(user => user.UserID == theUser.UserID);
                    theUser.FirstName = usernameDetails.FirstName;
                    theUser.LastName = usernameDetails.LastName;

                    StaffList.Add(theUser); // Add a reference to the newly created object to the Models UserList
                    DataLayer.addNewStaffMemberToDB(theUser); //Gets the DataLayer to add the new user to the DB.
                    return true;
                }
                catch (System.Exception excep)
                {
                    return false;
                }
            //}
        }

        public bool updateDepartment(string depID, string name, string hodID, string newDepID, string newName, string newhodID)
        {
            IDepartment Dep = this.DepartmentList.FirstOrDefault(dep => dep.DepartmentID == depID.Trim());
            if (hodID is null)
            {
                IStaff hod = this.StaffList.FirstOrDefault(user => user.UserID.Equals(newhodID));
                this.StaffList.Remove(hod);
                hod.isHOD = 1;
                this.StaffList.Add(hod);
                DataLayer.updateStaffMemberToOrFromHODinDB(hod, hod.isHOD);
                DepartmentList.Remove(Dep);
                Dep.HeadOfDepartmentID = newhodID;
                DepartmentList.Add(Dep);
                DataLayer.UpdateDepartmentInDB(hod, Dep, depID);
            }
            else
            {
                
                IStaff hod = this.StaffList.FirstOrDefault(user => user.UserID.Equals(hodID));
                // Remove department and hod from their lists //
                this.DepartmentList.Remove(Dep);
                this.StaffList.Remove(hod);

                // Add them back with changes //
                hod.isHOD = 0;
                DataLayer.updateStaffMemberToOrFromHODinDB(hod, hod.isHOD);
                this.StaffList.Add(hod);

                hod = this.StaffList.FirstOrDefault(user => user.UserID.Equals(newhodID));
                this.StaffList.Remove(hod);
                hod.isHOD = 1;
                this.StaffList.Add(hod);
                DataLayer.updateStaffMemberToOrFromHODinDB(hod, hod.isHOD);

                Dep.DepartmentID = newDepID;
                Dep.HeadOfDepartmentID = newhodID;
                Dep.Name = newName;
                this.DepartmentList.Add(Dep);

                DataLayer.UpdateDepartmentInDB(hod, Dep, depID);
            }
            
            return true;
        }

        public bool addDepartment(string depID, string name, string hodID)
        {

            IDepartment duplicateDep = this.DepartmentList.FirstOrDefault(dep => dep.DepartmentID == depID.Trim());

            if (duplicateDep != null)
                return false;
            else
            {
                IStaff newHOD = null;
                if (hodID.Equals("null"))
                    newHOD = null;

                else
                {
                    newHOD = this.StaffList.FirstOrDefault(hod => hod.UserID == hodID.Trim());
                    this.StaffList.Remove(newHOD);
                    newHOD.isHOD = 1;
                    this.StaffList.Add(newHOD);
                    DataLayer.updateStaffMemberToOrFromHODinDB(newHOD, newHOD.isHOD);
                }

                try
                {
                    IDepartment theDep = UserFactory.GetDepartment(depID, name, hodID);
                    DepartmentList.Add(theDep);
                    DataLayer.addNewDepartmentToDB(theDep);
                    return true;
                }
                catch (System.Exception excep)
                {
                    return false;
                }
            }
        }
        bool IModel.addModule(string moduleID, string name, string courseID, int credits)
        {
            IModule duplicateModule = this.ModuleList.FirstOrDefault(cour => cour.ModuleID == moduleID.Trim());
            if (duplicateModule != null)
            { return false;
            }
            else
            {
                try
                {
                    IModule amodule = UserFactory.GetModule(moduleID, name, courseID, credits);
                    ModuleList.Add(amodule);
                    DataLayer.AddNewModule(amodule);
                    return true;
                }
                catch (System.Exception ex)
                {
                    return false;
                }
            }

        }

        bool IModel.addCourse(string courseID, string name, string deptid, double priceEU, double priceNonEU, string desc, int points, int capacity, int curCapacity, int isNight)
        {

            ICourse duplicateCourse = this.CourseList.FirstOrDefault(cour => cour.CourseID == courseID.Trim());
            if (duplicateCourse != null)
                return false;
            else
            {
                try
                {
                    ICourse acourse = UserFactory.GetCourse(courseID, name, deptid, priceEU, priceNonEU, desc, points, capacity, curCapacity, isNight);
                    CourseList.Add(acourse);
                    DataLayer.addNewCourseToDB(acourse);
                    return true;
                }
                catch (System.Exception excep)
                {
                    return false;
                }
            }
        }

        #region Applicants

        Boolean IModel.addApplicant(int appID, string fname, string lname, int nonEU, int nightStu, int isPartTime, int points, DateTime dob, string course)
        {
            try
            {
                IApplicant app = UserFactory.GetApplicantMember(appID.ToString(), fname, lname, nonEU, nightStu, isPartTime, points, dob, course);
                applicantList.Add(app);
                DataLayer.addApplicant(app);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        Boolean IModel.DeleteApplicant(string fname, string lname, int noneu, int night, int parttime, DateTime dob, string course)
        {
            IApplicant app = UserFactory.GetApplicantMember("", fname, lname, noneu, night, parttime, 0, dob, course);
            foreach (IApplicant a in ApplicantList)
            {
                if (a.FirstName.Equals(fname) && a.LastName.Equals(lname) && a.NonEU == noneu && a.IsPartTime == parttime && a.DOB == dob && a.CourseID_fk.Equals(course))
                {
                    ApplicantList.Remove(a);
                    break;
                }
            }
            DataLayer.DeleteApplicantFromDB(app);
            return true;
        }

        #endregion

        public bool deleteUser(IUser user)
        {

            DataLayer.deleteUserFromDB(user);
            UserList.Remove(user); //remove object from collection
            return true;

        }
        public bool editUser(IUser user)
        {
            DataLayer.editUserInDB(user);
            return true;
        }
    
        public String getUserTypeForCurrentuser()
        {
            return currentUser.UserType;
        }

        

        public void tearDown()
        {
            DataLayer.closeConnection();
        }


        Boolean IModel.addNewStudent(string userID, string course, int noneu, int feespaid, int nightstudent, int year, int isparttime, DateTime dob)
        {
            try
            {
                IStudent stu = UserFactory.GetStudent(userID, course, noneu, feespaid, nightstudent, year, isparttime, dob);
                studentList.Add(stu);
                DataLayer.addNewStudenttoDB(stu);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool editCourse(string courseID, string name, string deptid, double priceEU, double priceNonEU, string desc, int points, int capacity, int curCapacity, int isNight)
        {
            try
            {
                //ICourse Updatedcourse = UserFactory.GetCourse(courseID, name, deptid, priceEU, priceNonEU, courseYr);

                // ICourse Updatedcourse = UserFactory.GetCourse(courseID, name, deptid, priceEU, priceNonEU, courseYr);
                bool iscourseedited = false;

                foreach (ICourse c in CourseList)
                {
                    if (c.CourseID == courseID)
                    {
                        c.CourseID = courseID;
                        c.Name = name;
                        c.DeptID = deptid;
                        c.PriceEU = priceEU;
                        c.PriceNonEU = priceNonEU;
                        c.Desc = desc;
                        c.Points = points;
                        c.Capacity = capacity;
                        c.CurCapacity = curCapacity;
                        c.IsNightCourse = isNight;
                        DataLayer.editCourseInDB(c);
                        iscourseedited = true;

                    }
                    if (iscourseedited == true)
                        return true;
                    else
                        continue;
                }
                return true;


                //CourseList.Add(Updatedcourse);
                //DataLayer.editCourseInDB(Updatedcourse);


            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public bool EditStudentCourse(IStudent user)
        {
            DataLayer.EditStudentCourseinDB(user);
            return true;
        }

        #region Room
        Boolean IModel.addRoom(string roomName, int capacity, string type)
        {
            try
            {
                IRoom room = UserFactory.GetRoom(roomName, capacity, type);
                roomList.Add(room);
                DataLayer.addRoomToDB(room);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        Boolean IModel.editRoom(string originalName, int originalCapacity, string originalType, string newName, int newCapacity, string newType)
        {
            try
            {
                List<IRoom> list = new List<IRoom>();
                IRoom oldRoom = UserFactory.GetRoom(originalName, originalCapacity, originalType);
                IRoom newRoom = UserFactory.GetRoom(newName, newCapacity, newType);
                DataLayer.editRoomInDB(oldRoom, newRoom);
                foreach (IRoom r in roomList)
                {
                    if (r.Name.Equals(oldRoom.Name))
                        continue;
                    list.Add(r);
                }
                RoomList = list;
                //roomList.Remove(oldRoom);
                roomList.Add(newRoom);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        Boolean IModel.deleteRoom(string name, int capacity, string type)
        {
            try
            {
                List<IRoom> list = new List<IRoom>();
                IRoom room = UserFactory.GetRoom(name, capacity, type);

                DataLayer.deleteRoomInDB(room);
                foreach (IRoom r in roomList)
                {
                    if (r.Name.Equals(room.Name))
                        continue;
                    list.Add(r);
                }
                RoomList = list;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        public bool AddFeedBack(string stdname, string CourseN, string Desc)
        {
            try
            {

                IFeedback thefb = UserFactory.GetFeedback(stdname, CourseN, Desc);
                FeedbackList.Add(thefb);
                DataLayer.addNewFeedBackToDB(thefb);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }

        }
        bool IModel.addTemplate(string tName, string tContent)
        {

            //ITemplate duplicateTemplate = this.TemplateList.FirstOrDefault(cour => cour.Tname == tName.Trim());
            //if (duplicateTemplate != null)
            //    return false;
            //else
            //{
                try
                {
                    ITemplate atemplate = UserFactory.GetTemplate(tName, tContent);
                    TemplateList.Add(atemplate);
                    DataLayer.addNewTemplateToDB(atemplate);
                    return true;
                }
                catch (System.Exception excep)
                {
                    return false;
                }
           // }
        }
        bool IModel.addLetter(string senderID, string recieverID, string tName, string lContent, string Date, string Letterid)
        {


            try
            {
                ILetter aletter = UserFactory.GetLetter(senderID, recieverID, tName, lContent, Date, Letterid);
                LetterList.Add(aletter);
                DataLayer.addNewLetterToDB(aletter);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }



    }
}
