using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using CollegeEntities;

namespace DataAccessLayer
{
    public class DataLayer : IDataLayer
    {
        SqlCommandBuilder cb;
        SqlDataAdapter da;
        DataSet ds;
        List<IUser> UserList = null;
        private SqlConnection connection;
        DataSet dataset;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        int totUsers;
        int totDepartments;
        int totCourses;
        int totModules;
        int totRooms;
        int totFeedback;
        public static IDataLayer dataLayerSingleInstance;
        static readonly object padlock = new object();

        #region Constructors
        public static IDataLayer GetInstance()
        {
            lock (padlock)
            {
                if (dataLayerSingleInstance == null)
                {
                    dataLayerSingleInstance = new DataLayer();
                }
                return dataLayerSingleInstance;
            }
        }
        public DataLayer()
        {
            openConnection();
        }
        #endregion

        public virtual void openConnection()
        {
            connection = new SqlConnection();

            //connection.ConnectionString = "Data Source=SQL1.student.litdom.lit.ie\\INST18SDT8;Initial Catalog=CaherdavinDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection.ConnectionString = "Data Source=localhost;Initial Catalog=CaherdavinDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(0);
            }
        }

        public virtual void closeConnection()
        {
            connection.Close();
        }

        public virtual SqlConnection getConnection()
        {
            return connection;
        }


        
        public virtual List<IStaff> getStaffMembers()
        {
            List<IStaff> StaffList = new List<IStaff>();
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * FROM Staff";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataset, "StaffData");
                totUsers = dataset.Tables["StaffData"].Rows.Count;
                for (int i = 0; i < totUsers; i++)
                {
                    DataRow dRow = dataset.Tables["StaffData"].Rows[i];
                    IStaff staff = UserFactory.GetStaffMember(dRow.ItemArray.GetValue(0).ToString(),
                                                               Convert.ToInt16(dRow.ItemArray.GetValue(1).ToString()),
                                                               dRow.ItemArray.GetValue(2).ToString(),
                                                               dRow.ItemArray.GetValue(3).ToString(),
                                                               dRow.ItemArray.GetValue(4).ToString(),
                                                               dRow.ItemArray.GetValue(5).ToString());

                    foreach(IUser user in UserList)
                    {
                        if (dRow.ItemArray.GetValue(0).ToString().Equals(user.UserID))
                        {
                            staff.FirstName = user.FirstName;
                            staff.LastName = user.LastName;
                        }
                    }
                    
                    StaffList.Add(staff);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return StaffList;
        }

        public virtual List<IDepartment> getAllDepartments()
        {
            List<IDepartment> DepartmentList = new List<IDepartment>();
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * FROM Department";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataset, "DepartmentsData");
                totDepartments = dataset.Tables["DepartmentsData"].Rows.Count;
                for (int i = 0; i < totDepartments; i++)
                {
                    DataRow dRow = dataset.Tables["DepartmentsData"].Rows[i];
                    IDepartment dep = UserFactory.GetDepartment(dRow.ItemArray.GetValue(0).ToString(),
                                                                dRow.ItemArray.GetValue(1).ToString(),
                                                                dRow.ItemArray.GetValue(2).ToString());
                    DepartmentList.Add(dep);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return DepartmentList;
        }

        public virtual List<ICourse> GetAllCourses()
        {
            List<ICourse> CourseList = new List<ICourse>();
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * FROM Course";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataset, "CourseData");
                totCourses = dataset.Tables["CourseData"].Rows.Count;
                for (int i = 0; i < totCourses; i++)
                {
                    DataRow dRow = dataset.Tables["CourseData"].Rows[i];
                    ICourse course = UserFactory.GetCourse(dRow.ItemArray.GetValue(0).ToString(),
                                                                dRow.ItemArray.GetValue(1).ToString(),
                                                                dRow.ItemArray.GetValue(2).ToString(),
                                                                Convert.ToInt32(dRow.ItemArray.GetValue(3).ToString()),
                                                                Convert.ToInt32(dRow.ItemArray.GetValue(4).ToString()),
                                                                dRow.ItemArray.GetValue(5).ToString(),
                                                                Convert.ToInt32(dRow.ItemArray.GetValue(6).ToString()),
                                                                Convert.ToInt32(dRow.ItemArray.GetValue(7).ToString()),
                                                                Convert.ToInt32(dRow.ItemArray.GetValue(8).ToString()),
                                                                Convert.ToInt32(dRow.ItemArray.GetValue(9).ToString()));




                    CourseList.Add(course);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return CourseList;
        }
        public virtual List<IModule> GetAllModules()
        {
            List<IModule> ModuleList = new List<IModule>();
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * FROM Module";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataset, "ModuleData");
                totModules = dataset.Tables["ModuleData"].Rows.Count;
                for (int i = 0; i < totModules; i++)
                {
                    DataRow dRow = dataset.Tables["ModuleData"].Rows[i];
                    IModule module = UserFactory.GetModule(dRow.ItemArray.GetValue(0).ToString(),
                                                                dRow.ItemArray.GetValue(1).ToString(),
                                                                dRow.ItemArray.GetValue(2).ToString(),
                                                                Convert.ToInt32(dRow.ItemArray.GetValue(3).ToString()));
                                                               




                    ModuleList.Add(module);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return ModuleList;
        }
        public virtual List<IRoom> GetAllRooms()
        {
            List<IRoom> RoomList = new List<IRoom>();
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * FROM Rooms";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataset, "RoomData");
                totRooms = dataset.Tables["RoomData"].Rows.Count;
                for (int i = 0; i < totRooms; i++)
                {
                    DataRow dRow = dataset.Tables["RoomData"].Rows[i];
                    IRoom room = UserFactory.GetRoom(dRow.ItemArray.GetValue(0).ToString(),
                                                    Convert.ToInt32(dRow.ItemArray.GetValue(1).ToString()),
                                                                dRow.ItemArray.GetValue(2).ToString());





                    RoomList.Add(room);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return RoomList;
        }
        public virtual List<IUser> getAllUsers()
        {
            UserList = new List<IUser>();
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * From Users";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);  //Generates
                dataAdapter.Fill(dataset, "UsersData");
                totUsers = dataset.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < totUsers; i++)
                {
                    DataRow dRow = dataset.Tables["UsersData"].Rows[i];
                    // Using a Factory to create the user entity object. ie seperating object creation from business logic

                    IUser user = UserFactory.GetUser(dRow.ItemArray.GetValue(0).ToString(),
                                                    dRow.ItemArray.GetValue(1).ToString(),
                                                    dRow.ItemArray.GetValue(2).ToString(),
                                                    dRow.ItemArray.GetValue(3).ToString(),
                                                    dRow.ItemArray.GetValue(4).ToString());

                    UserList.Add(user);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return UserList;
        }

        public virtual List<IApplicant> getAllApplicants()
        {
            List<IApplicant> ApplicantList = new List<IApplicant>();
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * From Applicants";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);  //Generates
                dataAdapter.Fill(dataset, "ApplicantsData");
                totUsers = dataset.Tables["ApplicantsData"].Rows.Count;
                for (int i = 0; i < totUsers; i++)
                {
                    DataRow dRow = dataset.Tables["ApplicantsData"].Rows[i];
                    // Using a Factory to create the user entity object. ie seperating object creation from business logic

                    IApplicant user = UserFactory.GetApplicantMember(dRow.ItemArray.GetValue(0).ToString(),
                                                                    dRow.ItemArray.GetValue(1).ToString(),
                                                                    dRow.ItemArray.GetValue(2).ToString(),
                                                                    Convert.ToInt32(dRow.ItemArray.GetValue(3).ToString()),
                                                                    Convert.ToInt32(dRow.ItemArray.GetValue(4).ToString()),
                                                                    Convert.ToInt32(dRow.ItemArray.GetValue(5).ToString()),
                                                                     Convert.ToInt32(dRow.ItemArray.GetValue(6).ToString()),
                                                                    Convert.ToDateTime(dRow.ItemArray.GetValue(7).ToString()),
                                                                    dRow.ItemArray.GetValue(8).ToString());

                    ApplicantList.Add(user);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return ApplicantList;
        }

        public virtual void addApplicant(IApplicant applicant)
        {
            try
            {

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.CreateNewApplicant", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@appID", applicant.UserID));
                cmd.Parameters.Add(new SqlParameter("@fname", applicant.FirstName));
                cmd.Parameters.Add(new SqlParameter("@lname", applicant.LastName));
                cmd.Parameters.Add(new SqlParameter("@noneu", applicant.NonEU));
                cmd.Parameters.Add(new SqlParameter("@night", applicant.NightStudent));
                cmd.Parameters.Add(new SqlParameter("@parttime", applicant.IsPartTime));
                cmd.Parameters.Add(new SqlParameter("@points", applicant.LeavingCertPoints));
                cmd.Parameters.Add(new SqlParameter("@dob", applicant.DOB));
                cmd.Parameters.Add(new SqlParameter("@course", applicant.CourseID_fk));
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public virtual void addNewDepartmentToDB(IDepartment theDep)
        {
            try
            {

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.CreateNewDepartment", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@depID", theDep.DepartmentID));
                cmd.Parameters.Add(new SqlParameter("@name", theDep.Name));
                cmd.Parameters.Add(new SqlParameter("@userID", theDep.HeadOfDepartmentID));
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public virtual void UpdateDepartmentInDB(IStaff staff, IDepartment dep, string oldDepID)
        {
            try
            {
                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.UpdateDepartmentAndHOD", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@depID", dep.DepartmentID));
                cmd.Parameters.Add(new SqlParameter("@name", dep.Name));
                cmd.Parameters.Add(new SqlParameter("@hodID", staff.UserID));
                cmd.Parameters.Add(new SqlParameter("@oldDepID", oldDepID));
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public virtual void addNewUserToDB(IUser theUser)
        {
            try
            {

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.CreateNewUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UserID", theUser.UserID));
                cmd.Parameters.Add(new SqlParameter("@firstname", theUser.FirstName));
                cmd.Parameters.Add(new SqlParameter("@lastname", theUser.LastName));
                cmd.Parameters.Add(new SqlParameter("@password", theUser.Password));
                cmd.Parameters.Add(new SqlParameter("@usertype", theUser.UserType));
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public virtual void AddNewModule(IModule module)
        {
            try
            {

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.AddNewModule", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ModuleID", module.ModuleID));
                cmd.Parameters.Add(new SqlParameter("@name", module.Name));
                cmd.Parameters.Add(new SqlParameter("@courseID", module.CourseID));
                cmd.Parameters.Add(new SqlParameter("@credits", module.Credits));
                
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public virtual void addNewStaffMemberToDB(IStaff theUser)
        {
            try
            {

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.CreateNewStaffMember", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UserID", theUser.UserID));
                cmd.Parameters.Add(new SqlParameter("@isHod", theUser.isHOD));
                cmd.Parameters.Add(new SqlParameter("@pps", theUser.PPS));
                cmd.Parameters.Add(new SqlParameter("@email", theUser.Email));
                cmd.Parameters.Add(new SqlParameter("@phone", theUser.PhoneNum));
                cmd.Parameters.Add(new SqlParameter("@usertype", theUser.UserType));
                rdr = cmd.ExecuteReader();
                rdr.Close();

            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public virtual bool updateStaffMemberToOrFromHODinDB(IStaff user, int isHod)
        {
            try
            {

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.UpdateStaffMemberToOrFromHOD", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userID", user.UserID));
                cmd.Parameters.Add(new SqlParameter("@bool", isHod));
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return true;
        }

        // Remember is you are deleting a staff member you also have to delete from the staff table
        // If you are deleting a student you also have to delete from the student table
        public virtual bool deleteUserFromDB(IUser user)
        {
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * From Users";
                dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                commandBuilder = new SqlCommandBuilder(dataAdapter);  //Generates
                dataAdapter.Fill(dataset, "UsersData");
                DataRow findRow = dataset.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                dataAdapter.Update(dataset, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        public virtual bool editUserInDB(IUser user)
        {
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * From Users";
                dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                commandBuilder = new SqlCommandBuilder(dataAdapter);  //Generates
                dataAdapter.Fill(dataset, "UsersData");
                DataRow findRow = dataset.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow[0] = user.UserID;
                    findRow[1] = user.Password;
                }
                dataAdapter.Update(dataset, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public virtual bool editCourseInDB(ICourse Course)
        {
            try
            {
                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.UpdateCourse", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CourseID", Course.CourseID));
                cmd.Parameters.Add(new SqlParameter("@Coursename", Course.Name));
                cmd.Parameters.Add(new SqlParameter("@DepartmentID",Course.DeptID));
                cmd.Parameters.Add(new SqlParameter("@courseEUPrice", Course.PriceEU));
                cmd.Parameters.Add(new SqlParameter("@CourseNonEUPrice", Course.PriceNonEU));
                cmd.Parameters.Add(new SqlParameter("@courseDesc", Course.Desc));
                cmd.Parameters.Add(new SqlParameter("@points", Course.Points));
                cmd.Parameters.Add(new SqlParameter("@Capacity", Course.Capacity));
                cmd.Parameters.Add(new SqlParameter("@curCapacity", Course.CurCapacity));
                cmd.Parameters.Add(new SqlParameter("@isnight", Course.IsNightCourse));

                rdr = cmd.ExecuteReader();
                rdr.Close();

                //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    connection.Close();


               // Application.Exit();
            }
            MessageBox.Show("Course Updated");
            return true;
        }

        public virtual List<IStudent> getAllStudents()
        {
            List<IStudent> StudentList = new List<IStudent>();
            try
            {

                dataset = new DataSet();
                string sql = "SELECT * From Student";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);  //Generates
                dataAdapter.Fill(dataset, "StudentsData");
                totUsers = dataset.Tables["StudentsData"].Rows.Count;
                for (int i = 0; i < totUsers; i++)
                {
                    DataRow dRow = dataset.Tables["StudentsData"].Rows[i];
                    // Using a Factory to create the user entity object. ie seperating object creation from business logic
                    IStudent student = UserFactory.GetStudent(dRow.ItemArray.GetValue(0).ToString(),
                                                    dRow.ItemArray.GetValue(1).ToString(),
                                                    Convert.ToInt32(dRow.ItemArray.GetValue(2).ToString()),
                                                    Convert.ToInt32(dRow.ItemArray.GetValue(3).ToString()),
                                                    Convert.ToInt32(dRow.ItemArray.GetValue(4).ToString()),
                                                    Convert.ToInt32(dRow.ItemArray.GetValue(5).ToString()),
                                                    Convert.ToInt32(dRow.ItemArray.GetValue(6).ToString()),
                                                    Convert.ToDateTime(dRow.ItemArray.GetValue(7).ToString()));

                    var user = this.UserList.FirstOrDefault(u => u.UserID.Equals(dRow.ItemArray.GetValue(0).ToString()));
                    student.FirstName = user.FirstName;
                    student.LastName = user.LastName;

                    StudentList.Add(student);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return StudentList;
        }
       

        public virtual void addNewCourseToDB(ICourse acourse)
        {
            try
            {

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.CreateNewCourse", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CourseID", acourse.CourseID));
                cmd.Parameters.Add(new SqlParameter("@name", acourse.Name));
                cmd.Parameters.Add(new SqlParameter("@departmentID_fk", acourse.DeptID));
                cmd.Parameters.Add(new SqlParameter("@priceEU", acourse.PriceEU));
                cmd.Parameters.Add(new SqlParameter("@priceNonEU", acourse.PriceNonEU));
                cmd.Parameters.Add(new SqlParameter("@courseDesc", acourse.Desc));
                cmd.Parameters.Add(new SqlParameter("@points", acourse.Points));
                cmd.Parameters.Add(new SqlParameter("@Capacity", acourse.Capacity));
                cmd.Parameters.Add(new SqlParameter("@curCapacity", acourse.CurCapacity));
                cmd.Parameters.Add(new SqlParameter("@isnight", acourse.IsNightCourse));
                rdr = cmd.ExecuteReader();
                rdr.Close();

            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                {
                    connection.Close();
                   // MessageBox.Show("Error");
                }
                //Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public virtual List<IGrade> GetSomeGrades()
        {
            List<IGrade> GradeList = new List<IGrade>();
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * From StudentGrade";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);  //Generates
                dataAdapter.Fill(dataset, "UsersData");
                totUsers = dataset.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < totUsers; i++)
                {
                    DataRow dRow = dataset.Tables["UsersData"].Rows[i];
                    // Using a Factory to create the user entity object. ie seperating object creation from business logic

                    IGrade grade = UserFactory.GetGrade(dRow.ItemArray.GetValue(0).ToString(),
                                                    dRow.ItemArray.GetValue(1).ToString(),
                                                    dRow.ItemArray.GetValue(2).ToString());
                    GradeList.Add(grade);


                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return GradeList;
        }
        public bool EditStudentCourseinDB(IStudent user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Student";
                da = new SqlDataAdapter(sql, connection);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "StudentsData");
                DataRow findRow = ds.Tables["StudentsData"].Rows.Find(user.UserID);
                if (findRow != null)
                {

                    findRow[1] = user.CourseID_fk;
                }
                da.Update(ds, "StudentsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public virtual void addNewStudenttoDB(IStudent theStudent)
        {
            try
            {
                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.CreateNewStudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userID", theStudent.UserID));
                cmd.Parameters.Add(new SqlParameter("@course", theStudent.CourseID_fk));
                cmd.Parameters.Add(new SqlParameter("@noneu", theStudent.NonEU));
                cmd.Parameters.Add(new SqlParameter("@feespaid", theStudent.FeesPaid));
                cmd.Parameters.Add(new SqlParameter("@night", theStudent.NightStudent));
                cmd.Parameters.Add(new SqlParameter("@year", theStudent.Year));
                cmd.Parameters.Add(new SqlParameter("@parttime", theStudent.IsPartTime));
                cmd.Parameters.Add(new SqlParameter("@dob", theStudent.DOB));
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public virtual void DeleteApplicantFromDB(IApplicant applicant)
        {
            try
            {
                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.DeleteApplicant", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@fname", applicant.FirstName));
                cmd.Parameters.Add(new SqlParameter("@lname", applicant.LastName));
                cmd.Parameters.Add(new SqlParameter("@noneu", applicant.NonEU));
                cmd.Parameters.Add(new SqlParameter("@night", applicant.NightStudent));
                cmd.Parameters.Add(new SqlParameter("@parttime", applicant.IsPartTime));
                //cmd.Parameters.Add(new SqlParameter("@points", applicant.LeavingCertPoints));
                cmd.Parameters.Add(new SqlParameter("@dob", applicant.DOB));
                cmd.Parameters.Add(new SqlParameter("@course", applicant.CourseID_fk));
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (Exception ex)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }
        #region RoomStuff
        public virtual void addRoomToDB(IRoom room)
        {
            try
            {
                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.AddRoom", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@RoomName", room.Name));
                cmd.Parameters.Add(new SqlParameter("@Capacity", room.Capacity));
                cmd.Parameters.Add(new SqlParameter("@type", room.Type));
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (Exception ex)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public virtual Boolean editRoomInDB(IRoom oldRoom, IRoom newRoom)
        {
            try
            {
                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.EditRoom", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@oldRName", oldRoom.Name));
                cmd.Parameters.Add(new SqlParameter("@newRName", newRoom.Name));
                cmd.Parameters.Add(new SqlParameter("@newRCapacity", newRoom.Capacity));
                cmd.Parameters.Add(new SqlParameter("@newRType", newRoom.Type));
                rdr = cmd.ExecuteReader();
                rdr.Close();
                return true;
            }
            catch (Exception ex)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                return false;
            }
        }

        public virtual void deleteRoomInDB(IRoom room)
        {
            try
            {
                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.DeleteRoom", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@name", room.Name));
                cmd.Parameters.Add(new SqlParameter("@capacity", room.Capacity));
                cmd.Parameters.Add(new SqlParameter("@type", room.Type));
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (Exception ex)
            {
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }
        #endregion
        public void addNewFeedBackToDB(IFeedback thefb)
        {
            try
            {

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.CreateNewFeedBack", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@STDNAME", thefb.stdname));
                cmd.Parameters.Add(new SqlParameter("@COURSNAME", thefb.CourseN));
                cmd.Parameters.Add(new SqlParameter("@DESCRIP", thefb.Desc));

                rdr = cmd.ExecuteReader();
                rdr.Close();

            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                {
                    connection.Close();
                    // MessageBox.Show("Error");
                }
                //Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public List<IFeedback> getAllFeedback()
        {
            List<IFeedback> FeedbackList = new List<IFeedback>();
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * FROM FeedBack";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataset, "FeedbackData");
                totFeedback = dataset.Tables["FeedbackData"].Rows.Count;
                for (int i = 0; i < totFeedback; i++)
                {
                    DataRow dRow = dataset.Tables["FeedbackData"].Rows[i];
                    IFeedback feedback = UserFactory.GetFeedback(dRow.ItemArray.GetValue(2).ToString(),
                                                               dRow.ItemArray.GetValue(1).ToString(),
                                                               dRow.ItemArray.GetValue(0).ToString());
                    FeedbackList.Add(feedback);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return FeedbackList;
        }
        public virtual List<ITemplate> GetAllTemplate()
        {
            List<ITemplate> TemplateList = new List<ITemplate>();
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * From Templates";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);  //Generates
                dataAdapter.Fill(dataset, "UsersData");
                totUsers = dataset.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < totUsers; i++)
                {
                    DataRow dRow = dataset.Tables["UsersData"].Rows[i];
                    // Using a Factory to create the user entity object. ie seperating object creation from business logic

                    ITemplate template = UserFactory.GetTemplate(dRow.ItemArray.GetValue(0).ToString(),
                                                    dRow.ItemArray.GetValue(1).ToString());
                    TemplateList.Add(template);


                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return TemplateList;
        }
        public virtual void addNewTemplateToDB(ITemplate atemplate)
        {
            try
            {

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.CreateNewTemplate", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tName", atemplate.Tname));
                cmd.Parameters.Add(new SqlParameter("@tCone", atemplate.Tcontent));

                rdr = cmd.ExecuteReader();
                rdr.Close();

            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                {
                    connection.Close();
                    // MessageBox.Show("Error");
                }
                //Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public virtual List<ILetter> GetAllLetters()
        {
            List<ILetter> LetterList = new List<ILetter>();
            try
            {
                dataset = new DataSet();
                string sql = "SELECT * From StoredLetters";
                dataAdapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);  //Generates
                dataAdapter.Fill(dataset, "UsersData");
                totUsers = dataset.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < totUsers; i++)
                {
                    DataRow dRow = dataset.Tables["UsersData"].Rows[i];
                    // Using a Factory to create the user entity object. ie seperating object creation from business logic

                    ILetter letter = UserFactory.GetLetter(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                    dRow.ItemArray.GetValue(4).ToString(),
                                                    dRow.ItemArray.GetValue(5).ToString());

                    LetterList.Add(letter);


                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return LetterList;
        }
        public virtual void addNewLetterToDB(ILetter aletter)
        {
            try
            {

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand("dbo.CreateNewStoredLetter", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Senderid", aletter.senderID));
                cmd.Parameters.Add(new SqlParameter("@Recieverid", aletter.senderID));
                cmd.Parameters.Add(new SqlParameter("@Tname", aletter.tName));
                cmd.Parameters.Add(new SqlParameter("@Lcontent", aletter.lContent));
                cmd.Parameters.Add(new SqlParameter("@date", aletter.Date));
                cmd.Parameters.Add(new SqlParameter("@letterID", aletter.Letterid));



                rdr = cmd.ExecuteReader();
                rdr.Close();

            }
            catch (System.Exception excep)
            {
                if (connection.State.ToString() == "Open")
                {
                    connection.Close();
                    // MessageBox.Show("Error");
                }
                //Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
    }
}
