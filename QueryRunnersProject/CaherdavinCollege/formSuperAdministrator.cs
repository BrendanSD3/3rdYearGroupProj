using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeLayer;
using MetroFramework;
using CollegeEntities;
using System.Numerics;

namespace CaherdavinCollege
{
    public partial class formSuperAdministrator : MetroFramework.Forms.MetroForm
    {
        private string depID;
        private string name;
        private string hodID;
        private IModel Model;
        private formContainer fc;
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetCreateLettercomboboxtext = "";
        public static string templatecontent = "";

        public formSuperAdministrator(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            
        }

        private void formSuperAdministrator_Load(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = Application.StartupPath + "\\default.jpg";
            #region ViewStudents
            listViewViewAllStudents.Items.Clear();
            string fname = ""; string lname = "";
            foreach(IStudent student in Model.StudentList)
            {
                foreach(IUser user in Model.UserList)
                {
                    if (student.UserID.Equals(user.UserID))
                    {
                        fname = user.FirstName; lname = user.LastName;
                        break;
                    }

                }
                ListViewItem item = new ListViewItem(student.StudentID);
                item.SubItems.Add(fname + " " + lname);
                item.SubItems.Add(student.CourseID_fk);
                item.SubItems.Add(student.DOB.ToString("yyyy'/'MM'/'dd"));
                listViewViewAllStudents.Items.Add(item);
            }
            #endregion

            #region transferstudent on Load
            CoursesDropDown.Items.Clear();

            CoursesDropDown_Fill(sender, e);

            TransferCourse.Enabled = false;
            listofstudents.Items.Clear();
            foreach (IStudent s in Model.StudentList)
            {
                foreach (IUser user in Model.UserList)
                {
                    if (s.UserID.Equals(user.UserID))
                    {
                        fname = user.FirstName; lname = user.LastName;
                        break;
                    }

                }
                ListViewItem List = new ListViewItem(s.UserID);
                List.SubItems.Add(s.CourseID_fk);
                List.SubItems.Add(fname);
                List.SubItems.Add(lname);
                listofstudents.Items.Add(List);

            }
            #endregion

            #region Department on load
            ListStaff.Items.Clear();
            foreach (IStaff s in Model.StaffList)
            {
                if (s.isHOD.Equals(1))
                    continue;
                ListViewItem List = new ListViewItem(s.UserID);
                List.SubItems.Add(s.FirstName);
                List.SubItems.Add(s.LastName);
                List.SubItems.Add(s.UserType);
                ListStaff.Items.Add(List);
            }
            // Edit Department Staff List //
            ListStaff_HOD_Edit.Items.Clear();
            foreach (IStaff s in Model.StaffList)
            {
                ListViewItem List = new ListViewItem(s.UserID);
                List.SubItems.Add(s.FirstName);
                List.SubItems.Add(s.LastName);
                List.SubItems.Add(s.UserType);
                ListStaff_HOD_Edit.Items.Add(List);

            }
            // Edit departments combobox //
            ComboBoxDepartments.Items.Clear();
            ComboBoxDepartments_Fill(sender, e);

            // Fill Head of Department List //
            ListDisplayHODs.Items.Clear();
            var hodList = Model.StaffList.Where(user => user.isHOD == 1);
            foreach (IDepartment d in Model.DepartmentList)
            {
                foreach (IStaff s in hodList)
                {
                    if (d.HeadOfDepartmentID.Equals(s.UserID))
                    {
                        ListViewItem List = new ListViewItem(s.FullName);
                        List.SubItems.Add(s.UserType);
                        List.SubItems.Add(d.Name);
                        ListDisplayHODs.Items.Add(List);
                    }
                }
            }
            #endregion

            #region Rooms
            listViewEditRooms.Items.Clear();
            listViewDeleteRooms.Items.Clear();
            foreach (IRoom r in Model.RoomList)
            {
                ListViewItem edit = new ListViewItem(r.Name);
                edit.SubItems.Add(r.Capacity.ToString());
                edit.SubItems.Add(r.Type);
                listViewEditRooms.Items.Add(edit);
                //listViewDeleteRooms.Items.Add(edit);
            }

            foreach (IRoom r in Model.RoomList)
            {
                ListViewItem delete = new ListViewItem(r.Name);
                delete.SubItems.Add(r.Capacity.ToString());
                delete.SubItems.Add(r.Type);
                listViewDeleteRooms.Items.Add(delete);
            }
            #endregion


            //edit courses list

            FillCourseList(sender, e);

            //modules view 
            FillModuleList(sender, e);

            Combo_Department.Items.Clear();
            Combo_Department_Fill(sender, e);


           



           

            #region Applicant on Load
            // Add applicants to ListBox //
            TextBoxApplicantName.Text = "";
            TextBoxStudentYear.Text = "";
            ListViewApplicantsToAddStudent.Items.Clear();
            string eu = ""; string night = ""; string parttime = "";
            foreach (IApplicant a in Model.ApplicantList)
            {
                ListViewItem items = new ListViewItem(a.FullName);
                if (a.NonEU == 1) eu = "Yes"; else eu = "No";
                items.SubItems.Add(eu);
                if (a.NightStudent == 1) night = "Yes"; else night = "No";
                items.SubItems.Add(night);
                if (a.IsPartTime == 1) parttime = "Yes"; else parttime = "No";
                items.SubItems.Add(parttime);
                items.SubItems.Add(a.DOB.ToString("yyyy/MM/dd"));
                items.SubItems.Add(a.LeavingCertPoints.ToString());
                items.SubItems.Add(a.CourseID_fk);
                ListViewApplicantsToAddStudent.Items.Add(items);
            }
            //View Letters

            //foreach (ILetter l in Model.LetterList)
            //{

            //    ListViewItem items = new ListViewItem(l.senderID);
            //    items.SubItems.Add(l.recieverID);
            //    items.SubItems.Add(l.Date);

            //    ViewLetterList1.Items.Add(items);
            //}

            ComboBoxSelectCourseApplicant.Items.Clear();
            foreach (ICourse c in Model.CourseList)
            {
                ComboBoxSelectCourseApplicant.Items.Add(c.Name);
            }

            RadioButtonYesEU.Checked = true;
            RadioButtonYesNS.Checked = true;
            RadioButtonYesFees.Checked = true;
            RadioButtonNoParttime.Checked = true;

            //Create StudentID
            string userID = "";
            int[] code = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

            foreach (IStudent s in Model.StudentList)
            {
                string[] token = s.UserID.Split(new[] { "CC" }, StringSplitOptions.None);
                for (int i = 0; i < token[1].Length; i++)
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
            TextBoxStudentID.Text = userID;

            #region dobApplicant
            ComboBoxMonthApplicant.Items.Clear();
            ComboBoxYearApplicant.Items.Clear();
            DateTime now = DateTime.Now;

            for (int i = 1; i <= 12; i++)
                ComboBoxMonthApplicant.Items.Add(i);

            for (int i = 15; i < 65; i++)
                ComboBoxYearApplicant.Items.Add(now.Year - i);


            ComboBoxYearApplicant.SelectedItem = now.Year - 15;
            ComboBoxMonthApplicant.SelectedItem = 1;
            ComboBoxDayApplicant.SelectedItem = 1;

            #endregion
            #endregion
        }
    


    

    private void BtnExit_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Are You Sure you want to exit ?", "Warning", MessageBoxButtons.OKCancel);
            //if (result == DialogResult.OK)
            // Application.Exit();
            this.Close();
            this.fc.formContainer_Shown(sender, e);

        }
        #region CreateITTechnician
        private void AddnewITTech_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ITTechFirstNameTextBox.Text) || String.IsNullOrEmpty(ITTechLastNameTextBox.Text) || String.IsNullOrEmpty(ITTechPasswordTextBox.Text))
            {
                MessageBox.Show("Please enter correct credentials");
            }
            else
            {
                if ((Model.addNewUser(ITTechFirstNameTextBox.Text, ITTechLastNameTextBox.Text, ITTechPasswordTextBox.Text, "ITTechnician")) && (Model.addNewStaffMember(ITTechFirstNameTextBox.Text, ITTechLastNameTextBox.Text, "ITTechnician", ITTechPPSTextBox.Text, ITTechPhoneNumberTextBox.Text, ITTechEmailTextBox.Text, 0)))
                {
                    MessageBox.Show("User created");
                    ITTechFirstNameTextBox.Text = "";
                    ITTechLastNameTextBox.Text = "";
                    ITTechPasswordTextBox.Text = "";
                    ITTechPPSTextBox.Text = "";
                    ITTechPhoneNumberTextBox.Text = "";
                    ITTechEmailTextBox.Text = "";
                    formSuperAdministrator_Load(sender, e);
                }
                else
                    MessageBox.Show("Error creating user!");
            }
        }
        #endregion
        #region CreateHOD

       

        #endregion

        #region CreateAdmin
        private void ButtonConfirmAdmin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoxFName.Text) || String.IsNullOrEmpty(TextBoxLName.Text) || String.IsNullOrEmpty(TextBoxPassword.Text))
            {
                MessageBox.Show("Please enter correct credentials");
            }
            else
            {
                if ((Model.addNewUser(TextBoxFName.Text, TextBoxLName.Text, TextBoxPassword.Text, "Administrator")) && (Model.addNewStaffMember(TextBoxFName.Text, TextBoxLName.Text, "Administrator", TextBoxPPS.Text, TextBoxPhone.Text, TextBoxEmail.Text, 0)))
                {
                    MessageBox.Show("User created");
                    TextBoxFName.Text = "";
                    TextBoxLName.Text = "";
                    TextBoxPassword.Text = "";
                    TextBoxPPS.Text = "";
                    TextBoxPhone.Text = "";
                    TextBoxEmail.Text = "";
                    formSuperAdministrator_Load(sender, e);
                }
                else
                    MessageBox.Show("Error creating user!");
            }
        }

        #endregion
        private void Confirm_addHOC_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Fname_addHOC.Text) || String.IsNullOrEmpty(LName_addHOC.Text) || String.IsNullOrEmpty(Password_addHOC.Text))
            {
                MessageBox.Show("Please enter correct credentials");
            }
            else
            {
                if ((Model.addNewUser(Fname_addHOC.Text, LName_addHOC.Text, Password_addHOC.Text, "HOC")) && (Model.addNewStaffMember(Fname_addHOC.Text, LName_addHOC.Text, "HOC", PPSN_addHOC.Text, Phone_addHOC.Text, Email_addHOC.Text, 0)))
                {
                    MessageBox.Show("New HOC created");
                    Fname_addHOC.Text = "";
                    LName_addHOC.Text = "";
                    Password_addHOC.Text = "";
                    PPSN_addHOC.Text = "";
                    Phone_addHOC.Text = "";
                    Email_addHOC.Text = "";
                    formSuperAdministrator_Load(sender, e);
                }
                else
                    MessageBox.Show("Error creating user!");
            }
        }
        private void AddLect_Confirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Fname_addLect.Text) || String.IsNullOrEmpty(LName_addLect.Text) || String.IsNullOrEmpty(Password_addLect.Text))
            {
                MessageBox.Show("Please enter correct credentials");
            }
            else
            {
                if ((Model.addNewUser(Fname_addLect.Text, LName_addLect.Text, Password_addLect.Text, "Lecturer")) && (Model.addNewStaffMember(Fname_addLect.Text, LName_addLect.Text, "Lecturer", ppsn_addLect.Text, phone_addLect.Text, Email_addLect.Text, 0)))
                {
                    MessageBox.Show("new Lecturer created");
                    Fname_addLect.Text = "";
                    LName_addLect.Text = "";
                    Password_addLect.Text = "";
                    ppsn_addLect.Text = "";
                    phone_addLect.Text = "";
                    Email_addLect.Text = "";
                    formSuperAdministrator_Load(sender, e);
                }
                else
                    MessageBox.Show("Error creating user!");
            }
        }

        #region CreateDepartment

        private void ButtonSearchForHOD_Click(object sender, EventArgs e)
        {
            var matchStaff = Model.StaffList.Where(user => user.FullName.Contains(TextBoxSearch.Text));

            if (matchStaff != null)
            {
                ListStaff.Items.Clear();
                foreach (IStaff s in matchStaff)
                {
                    if (s.isHOD.Equals(1))
                        continue;
                    ListViewItem List = new ListViewItem(s.UserID);
                    List.SubItems.Add(s.FirstName);
                    List.SubItems.Add(s.LastName);
                    List.SubItems.Add(s.UserType);
                    ListStaff.Items.Add(List);
                }
            }
        }

        private void ButtonSubmit_Department_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoxDepartmentID.Text) || String.IsNullOrEmpty(TextBoxDepartmentName.Text))
                MessageBox.Show("Do it again");
            else
            {
                if (ListStaff.SelectedItems.Count <= 0)
                {
                    if (Model.addDepartment(TextBoxDepartmentID.Text, TextBoxDepartmentName.Text, "null"))
                    {
                        MessageBox.Show("Department has been created without Head of Department");
                        TextBoxDepartmentID.Text = "";
                        TextBoxDepartmentName.Text = "";
                        formSuperAdministrator_Load(sender, e);
                    }
                }
                else
                {
                    IUser matchUser = Model.UserList.FirstOrDefault(user => user.UserID == ListStaff.FocusedItem.Text);

                    if (matchUser != null)
                    {
                        if (Model.addDepartment(TextBoxDepartmentID.Text, TextBoxDepartmentName.Text, matchUser.UserID))
                        {
                            MessageBox.Show("Department has been created");
                            TextBoxDepartmentID.Text = "";
                            TextBoxDepartmentName.Text = "";
                            formSuperAdministrator_Load(sender, e);
                        }
                    }
                }

            }
        }

        #endregion

        #region EditDepartments

        private void ComboBoxDepartments_Fill(object sender, EventArgs e)
        {
            foreach (IDepartment d in Model.DepartmentList)
                ComboBoxDepartments.Items.Add(d.Name);
        }

        private void ComboBoxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            IStaff st = null;
            foreach (IDepartment d in Model.DepartmentList)
            {
                st = Model.StaffList.Find(user => user.UserID.Equals(d.HeadOfDepartmentID));
                if (ComboBoxDepartments.Text == d.Name)
                {
                    TextBoxDepartmentID_Edit.Text = d.DepartmentID;
                    TextBoxDepartmentName_Edit.Text = d.Name;

                    if (st is null)
                    {
                        TextBoxDepartmentHOD_Search.Text = "";
                        hodID = null;
                    }
                    else
                    {
                        TextBoxDepartmentHOD_Search.Text = st.FullName;
                        hodID = st.UserID;
                    }
                }
            }
            depID = TextBoxDepartmentID_Edit.Text;
            name = TextBoxDepartmentName_Edit.Text;
        }

        private void ButtonSearchHOD_Edit_Click(object sender, EventArgs e)
        {
            var matchStaff = Model.StaffList.Where(user => user.FullName.Contains(TextBoxDepartmentHOD_Search.Text));

            if (matchStaff != null)
            {
                ListStaff_HOD_Edit.Items.Clear();
                foreach (IStaff s in matchStaff)
                {

                    ListViewItem List = new ListViewItem(s.UserID);
                    List.SubItems.Add(s.FirstName);
                    List.SubItems.Add(s.LastName);
                    List.SubItems.Add(s.UserType);
                    ListStaff_HOD_Edit.Items.Add(List);
                }
            }

        }

        private void ButtonSubmitEditDepartments_Click(object sender, EventArgs e)
        {
            if (ListStaff_HOD_Edit.SelectedItems.Count <= 0)
                MessageBox.Show("Please select the new Head of Department");
            else
            {
                IStaff hod = Model.StaffList.FirstOrDefault(user => user.UserID.Equals(ListStaff_HOD_Edit.FocusedItem.Text));

                if (hod.isHOD == 1)
                    MessageBox.Show("Staff member is already a Head of Department");
                else
                {
                    if (String.IsNullOrEmpty(TextBoxDepartmentID_Edit.Text) || String.IsNullOrEmpty(TextBoxDepartmentName_Edit.Text))
                        MessageBox.Show("Enter correct details");
                    else
                    {
                        if (Model.updateDepartment(depID, name, hodID, TextBoxDepartmentID_Edit.Text, TextBoxDepartmentName_Edit.Text, hod.UserID))
                        {
                            MessageBox.Show("Department has been edited");
                            formSuperAdministrator_Load(sender, e);
                        }
                    }
                }
            }

        }


        #endregion

        #region Courses
        private void AddCourse_submit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoxCourseID.Text) || String.IsNullOrEmpty(TextBoxCourseName.Text) || String.IsNullOrEmpty(TextBoxPriceEU.Text) || String.IsNullOrEmpty(TextBoxPriceNonEU.Text) || String.IsNullOrEmpty(courseDesc_add.Text) || String.IsNullOrEmpty(Points_add.Text) || String.IsNullOrEmpty(CourseCap_add.Text) || String.IsNullOrEmpty(curCapacity_add.Text))
            {
                MessageBox.Show("All fields must be filled", "Error Submiting", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            else
            {
                int isNight;
                if (CheckBox_Add_IsNight.Checked)
                    isNight = 1;
                else
                    isNight = 0;

                if (Model.addCourse(TextBoxCourseID.Text, TextBoxCourseName.Text, Combo_Department.Text, Convert.ToDouble(TextBoxPriceEU.Text), Convert.ToDouble(TextBoxPriceNonEU.Text), courseDesc_add.Text, Convert.ToInt32(Points_add.Text), Convert.ToInt32(CourseCap_add.Text), Convert.ToInt32(curCapacity_add.Text), isNight))
                {
                    MessageBox.Show("Course has been created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBoxCourseID.Text = "";
                    TextBoxCourseName.Text = "";
                    TextBoxPriceEU.Text = "";
                    TextBoxPriceNonEU.Text = "";
                    courseDesc_add.Text = "";
                    Points_add.Text = "";
                    CourseCap_add.Text = "";
                    curCapacity_add.Text = "";
                    FillCourseList(sender, e);
                }
                else
                {

                    MessageBox.Show("Error creating Course!");


                }
            }
        }

        private void FillCourseList(object sender, EventArgs e)
        {

            ListofCourses.Items.Clear();
            foreach (ICourse c in Model.CourseList)
            {
                ListViewItem courselist = new ListViewItem(c.CourseID);
                //courselist.SubItems.Add(c.CourseID);
                courselist.SubItems.Add(c.Name);
                courselist.SubItems.Add(c.DeptID);
                courselist.SubItems.Add(Convert.ToString(c.PriceNonEU));
                courselist.SubItems.Add(Convert.ToString(c.PriceEU));

                courselist.SubItems.Add(Convert.ToString(c.Points));
                courselist.SubItems.Add(Convert.ToString(c.Capacity));
                courselist.SubItems.Add(Convert.ToString(c.CurCapacity));
                courselist.SubItems.Add(c.Desc);

                ListofCourses.Items.Add(courselist);
            }
            courses_edit_List.Items.Clear();
            foreach (ICourse c in Model.CourseList)
            {
                ListViewItem courseslist = new ListViewItem(c.CourseID);
                //courselist.SubItems.Add(c.CourseID);
                courseslist.SubItems.Add(c.Name);
                courseslist.SubItems.Add(c.DeptID);
                courseslist.SubItems.Add(Convert.ToString(c.PriceNonEU));
                courseslist.SubItems.Add(Convert.ToString(c.PriceEU));
                courseslist.SubItems.Add(Convert.ToString(c.Points));
                courseslist.SubItems.Add(Convert.ToString(c.Capacity));
                courseslist.SubItems.Add(Convert.ToString(c.CurCapacity));
                courseslist.SubItems.Add(c.Desc);
                courses_edit_List.Items.Add(courseslist);
            }
        }
        private void Combo_Department_Fill(object sender, EventArgs e)
        {
            Combo_Department.Items.Clear();
            //string d_id;
            foreach (IDepartment d in Model.DepartmentList)
            {
                Combo_Department.Items.Add(d.DepartmentID);
                //d_id = (d.DepartmentID);
            }
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {

        }

       
        //private void courseslistForediting_DoubleClick(object sender, EventArgs e)
        //{
        //    //courseID_edit.Text = listofcoursesForediting.SelectedItems.ToString();

        //    string Cid = courseslistForediting.SelectedItems[0].SubItems[0].Text;
        //    courseID_edit.Text = Cid;

        //    string CName = courseslistForediting.SelectedItems[0].SubItems[1].Text;
        //    CourseName_edit.Text = CName;

        //    string Department = courseslistForediting.SelectedItems[0].SubItems[2].Text;
        //    departmentidtextbox.Text = Department;

        //    string PriceEU = courseslistForediting.SelectedItems[0].SubItems[3].Text;
        //    EU_edit.Text = PriceEU;

        //    string noneu = courseslistForediting.SelectedItems[0].SubItems[4].Text;
        //    nonEU_edit.Text = noneu;

        //    string points = courseslistForediting.SelectedItems[0].SubItems[5].Text;
        //    Points_edit.Text = points;

        //    string capacity = courseslistForediting.SelectedItems[0].SubItems[6].Text;
        //    CourseCap_edit.Text = capacity;

        //    string curcapacity = courseslistForediting.SelectedItems[0].SubItems[7].Text;
        //    curCapacity_edit.Text = curcapacity;

        //    string desc = courseslistForediting.SelectedItems[0].SubItems[8].Text;
        //    courseDesc_edit.Text = desc;


        //}

        //private void ListCourses_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        

        private void StudentNameTextBox_Click(object sender, EventArgs e)
        {
            var matchStudent = Model.StudentList.Where(user => user.FullName.Contains(StudentNameTextBox.Text));

            if (matchStudent != null)
            {
                listofstudents.Items.Clear();
                foreach (IStudent s in matchStudent)
                {

                    ListViewItem List = new ListViewItem(s.UserID);
                    List.SubItems.Add(s.CourseID_fk);
                    List.SubItems.Add(s.FirstName);
                    List.SubItems.Add(s.LastName);



                    listofstudents.Items.Add(List);
                }
            }
        }
        //private void ListStudent_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    TransferCourse.Enabled = ListStudent.SelectedItems.Count > 0;
        //    StudentNameSearch.Enabled = false;
        //   // if (ListStudent.SelectedItems.Count > 0) ;

        //}






        #endregion

        #region Add Student

        private void ListViewApplicantsToAddStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TextBoxApplicantName.Text = "";
            if (ListViewApplicantsToAddStudent.SelectedItems.Count > 0)
            {
                ListViewItem item = ListViewApplicantsToAddStudent.SelectedItems[0];
                TextBoxApplicantName.Text = item.SubItems[0].Text;
                ComboBoxSelectCourseApplicant.SelectedItem = item.SubItems[6].Text;

                int[] dob = new int[3];
                int i = 0;
                string[] tokens = item.SubItems[4].Text.Split('/');
                foreach (string s in tokens)
                {
                    dob[i] = Convert.ToInt32(s);
                    i++;
                }

                ComboBoxYearApplicant.SelectedItem = dob[0];
                ComboBoxMonthApplicant.SelectedItem = dob[1];
                ComboBoxDayApplicant.SelectedItem = dob[2];

                if (item.SubItems[1].Text.Equals("No"))
                    RadioButtonNoEU.Checked = true;
                else
                    RadioButtonYesEU.Checked = true;

                if (item.SubItems[2].Text.Equals("No"))
                    RadioButtonNoNS.Checked = true;
                else
                    RadioButtonYesNS.Checked = true;

                if (item.SubItems[3].Text.Equals("No"))
                    RadioButtonNoParttime.Checked = true;
                else
                    RadioButtonYesParttime.Checked = true;
            }
        }

        private void ComboBoxMonthApplicant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int day = Convert.ToInt32(ComboBoxDayApplicant.SelectedItem) - 1;
                ComboBoxDayApplicant.Items.Clear();
                int days = DateTime.DaysInMonth(Convert.ToInt16(ComboBoxYearApplicant.SelectedItem), Convert.ToInt16(ComboBoxMonthApplicant.SelectedItem));
                for (int i = 1; i <= days; i++)
                    ComboBoxDayApplicant.Items.Add(i);
                ComboBoxDayApplicant.SelectedIndex = day;
            }
            catch(Exception ex)
            {
                ComboBoxDayApplicant.SelectedIndex = 0;
            }
        }

        private void ButtonCreateStudent_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoxApplicantName.Text) ||
                (ComboBoxSelectCourseApplicant.SelectedIndex < 0) ||
                (ComboBoxDayApplicant.SelectedIndex < 0) ||
                (ComboBoxMonthApplicant.SelectedIndex < 0) ||
                (ComboBoxYearApplicant.SelectedIndex < 0) ||
                String.IsNullOrEmpty(TextBoxStudentYear.Text))
            {
                MessageBox.Show("Please enter all fields");
            }
            else
            {
                string[] tokens = TextBoxApplicantName.Text.Split(' ');
                string pass = ComboBoxDayApplicant.SelectedItem.ToString() + ComboBoxMonthApplicant.SelectedItem.ToString() + ComboBoxYearApplicant.SelectedItem.ToString();
                int noneu; int fees; int nightstu; int parttime;

                if (RadioButtonYesEU.Checked == true)
                    noneu = 1;
                else noneu = 0;
                if (RadioButtonYesFees.Checked == true)
                    fees = 1;
                else fees = 0;
                if (RadioButtonYesNS.Checked == true)
                    nightstu = 1;
                else nightstu = 0;
                if (RadioButtonYesParttime.Checked == true)
                    parttime = 1;
                else parttime = 0;
                if ((Model.addNewUser(tokens[0], tokens[1], pass, "Student")) && (Model.addNewStudent(TextBoxStudentID.Text, ComboBoxSelectCourseApplicant.SelectedItem.ToString(), noneu, fees, nightstu, Convert.ToInt32(TextBoxStudentYear.Text), parttime, new DateTime(Convert.ToInt32(ComboBoxYearApplicant.Text), Convert.ToInt32(ComboBoxMonthApplicant.Text), Convert.ToInt32(ComboBoxDayApplicant.Text)))))
                {
                    MessageBox.Show("Student has been created");
                    Model.DeleteApplicant(tokens[0], tokens[1], noneu, nightstu, parttime, new DateTime(Convert.ToInt32(ComboBoxYearApplicant.Text), Convert.ToInt32(ComboBoxMonthApplicant.Text), Convert.ToInt32(ComboBoxDayApplicant.Text)), ComboBoxSelectCourseApplicant.SelectedItem.ToString());
                    formSuperAdministrator_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Error creating Student");
                }

            }
        }

        private void TextBoxStudentYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region Transfer Student Course


        private void CoursesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void CoursesDropDown_Fill(object sender, EventArgs e)
        {
            foreach (ICourse c in Model.CourseList)
            {
                CoursesDropDown.Items.Add(c.CourseID);
                CombocourseID_addModule.Items.Add(c.CourseID);
            }
            //CoursesDropDown.SelectedIndex = 0;


        }













        private void StudentNameSearch_Click(object sender, EventArgs e)
        {
            var matchStudent = Model.StudentList.Where(user => user.FullName.Contains(StudentNameTextBox.Text));

            if (matchStudent != null)
            {
                listofstudents.Items.Clear();
                string fname = ""; string lname = "";
                foreach (IStudent s in matchStudent)
                {
                    foreach (IUser user in Model.UserList)
                    {
                        if (s.UserID.Equals(user.UserID))
                        {
                            fname = user.FirstName; lname = user.LastName;
                            break;
                        }

                    }
                    ListViewItem List = new ListViewItem(s.UserID);
                    List.SubItems.Add(s.CourseID_fk);
                    List.SubItems.Add(fname);
                    List.SubItems.Add(lname);



                    listofstudents.Items.Add(List);
                }
            }
        }

        private void listofstudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransferCourse.Enabled = listofstudents.SelectedItems.Count > 0;
            //  StudentNameSearch.Enabled = false;
            //if (ListStudent.SelectedItems.Count > 0) ;
        }

        private void TransferCourse_Click(object sender, EventArgs e)
        {
            if (listofstudents.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a student");
            }
            else
            {
                foreach (Student user in Model.StudentList)
                {

                    if (listofstudents.Items[0].Text.Equals(user.UserID))
                    {


                        user.CourseID_fk = CoursesDropDown.SelectedItem.ToString();
                        Model.EditStudentCourse(user);
                    }
                }
                MessageBox.Show("Student Changed Course Successfully ");
            }
            formSuperAdministrator_Load(sender, e);
        }


        #endregion

        private void timtablebtn_Click(object sender, EventArgs e)
        {
            timetable1 t = new timetable1(Model);
            t.Show();
        }

        private void btnSubmit_addModule_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextModID_add.Text) || String.IsNullOrEmpty(textModuleName.Text) || String.IsNullOrEmpty(textcredits_addModule.Text))
            {
                MessageBox.Show("Please enter correct credentials");
            }
            else
            {
                if (Model.addModule(TextModID_add.Text, textModuleName.Text, CombocourseID_addModule.SelectedItem.ToString(), Convert.ToInt32(textcredits_addModule.Text)))
                {
                    MessageBox.Show("New Module created");
                    TextModID_add.Text = "";
                    textModuleName.Text = "";
                    CombocourseID_addModule.SelectedIndex = 0;
                    textcredits_addModule.Text = "";
                    formSuperAdministrator_Load(sender, e);
                }
                else
                    MessageBox.Show("Error creating user!");
            }
        }
        private void FillModuleList(object sender, EventArgs e)
        {

            ListOfModules_add.Items.Clear();
            foreach (IModule m in Model.ModuleList)
            {
                ListViewItem moduleList= new ListViewItem(m.ModuleID);
                //courselist.SubItems.Add(c.CourseID);
                //moduleList.SubItems.Add(m.ModuleID);
                moduleList.SubItems.Add(m.Name);
                moduleList.SubItems.Add(m.CourseID);
                moduleList.SubItems.Add(Convert.ToString(m.Credits));


                ListOfModules_add.Items.Add(moduleList);
            }

        }

        private void courses_edit_List_DoubleClick(object sender, EventArgs e)
        {
            string Cid = courses_edit_List.SelectedItems[0].SubItems[0].Text;
            courseID_edit.Text = Cid;

            string CName = courses_edit_List.SelectedItems[0].SubItems[1].Text;
            CourseName_edit.Text = CName;

            string Department = courses_edit_List.SelectedItems[0].SubItems[2].Text;
            departmentidtextbox.Text = Department;

            string PriceEU = courses_edit_List.SelectedItems[0].SubItems[3].Text;
            EU_edit.Text = PriceEU;

            string noneu = courses_edit_List.SelectedItems[0].SubItems[4].Text;
            nonEU_edit.Text = noneu;

            string points = courses_edit_List.SelectedItems[0].SubItems[5].Text;
            Points_edit.Text = points;

            string capacity = courses_edit_List.SelectedItems[0].SubItems[6].Text;
            CourseCap_edit.Text = capacity;

            string curcapacity = courses_edit_List.SelectedItems[0].SubItems[7].Text;
            curCapacity_edit.Text = curcapacity;

            string desc = courses_edit_List.SelectedItems[0].SubItems[8].Text;
            courseDesc_edit.Text = desc;
        }

        private void Btnupdate_courses_edit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(courseID_edit.Text) || String.IsNullOrEmpty(CourseName_edit.Text) || String.IsNullOrEmpty(EU_edit.Text) || String.IsNullOrEmpty(nonEU_edit.Text) || String.IsNullOrEmpty(courseDesc_edit.Text) || String.IsNullOrEmpty(Points_edit.Text) || String.IsNullOrEmpty(CourseCap_edit.Text) || String.IsNullOrEmpty(curCapacity_edit.Text))
            {
                MessageBox.Show("All fields must be filled", "Error Submiting", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                int isNight;
                if (CheckBox_Edit_IsNight.Checked)
                    isNight = 1;
                else
                    isNight = 0;

                if (Model.editCourse(courseID_edit.Text, CourseName_edit.Text, departmentidtextbox.Text, Convert.ToDouble(EU_edit.Text), Convert.ToDouble(nonEU_edit.Text), courseDesc_edit.Text, Convert.ToInt32(Points_edit.Text), Convert.ToInt32(CourseCap_edit.Text), Convert.ToInt32(curCapacity_edit.Text), isNight))
                {
                    MessageBox.Show("Course has been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    courseID_edit.Text = "";
                    CourseName_edit.Text = "";
                    EU_edit.Text = "";
                    nonEU_edit.Text = "";
                    courseDesc_edit.Text = "";
                    Points_edit.Text = "";
                    CourseCap_edit.Text = "";
                    curCapacity_edit.Text = "";
                    FillCourseList(sender, e);
                }
                else
                {
                    MessageBox.Show("Error updating Course!");
                }
            }//
        }
        #region Room
        private void listViewEditRooms_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewEditRooms.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewEditRooms.SelectedItems[0];
                textBoxEditRoomsRoomName.Text = item.SubItems[0].Text;
                textBoxEditRoomsRoomCapacity.Text = item.SubItems[1].Text;
                textBoxEditRoomsRoomType.Text = item.SubItems[2].Text;
            }
        }

        private void ButtonAddRoomSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoxRoomNameAdd.Text) || String.IsNullOrEmpty(TextBoxRoomCapacityAdd.Text) || String.IsNullOrEmpty(TextBoxRoomTypeAdd.Text))
            {
                MessageBox.Show("Please enter details correctly");
            }
            else
            {
                foreach (IRoom r in Model.RoomList)
                {
                    if (r.Name.Equals(TextBoxRoomNameAdd.Text))
                    {
                        MessageBox.Show("Room already exists");
                        return;
                    }
                }

                if (Model.addRoom(TextBoxRoomNameAdd.Text, Convert.ToInt16(TextBoxRoomCapacityAdd.Text), TextBoxRoomTypeAdd.Text))
                {
                    MessageBox.Show("Room has been added");
                    TextBoxRoomNameAdd.Text = "";
                    TextBoxRoomCapacityAdd.Text = "";
                    TextBoxRoomTypeAdd.Text = "";
                    formSuperAdministrator_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonEditRoomsSubmit_Click(object sender, EventArgs e)
        {
            if (listViewEditRooms.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewEditRooms.SelectedItems[0];
                string originalName = item.SubItems[0].Text;
                string originalType = item.SubItems[2].Text;
                int originalCapacity = Convert.ToInt16(item.SubItems[1].Text);
                if (Model.editRoom(originalName, originalCapacity, originalType, textBoxEditRoomsRoomName.Text, Convert.ToInt16(textBoxEditRoomsRoomCapacity.Text), textBoxEditRoomsRoomType.Text))
                {
                    MessageBox.Show("Update Complete");
                    formSuperAdministrator_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Error editing room. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a room");
            }
        }

        private void ButtonDeleteRoom_Click(object sender, EventArgs e)
        {
            if (listViewDeleteRooms.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewDeleteRooms.SelectedItems[0];
                string Name = item.SubItems[0].Text;
                string Type = item.SubItems[2].Text;
                int Capacity = Convert.ToInt16(item.SubItems[1].Text);

                if (Model.deleteRoom(Name, Capacity, Type))
                {
                    MessageBox.Show("Delete Complete");
                    formSuperAdministrator_Load(sender, e);
                }
                else
                    MessageBox.Show("Error editing room. Try again.");
            }
            else
            {
                MessageBox.Show("Please select a room");
            }
        }

        #endregion

        // Generic function for not allowing numbers to be entered //
        private void TextBoxNumberCheck_TextChanged(object sender, EventArgs e)
        {

            if (sender is MetroFramework.Controls.MetroTextBox)
            {
                MetroFramework.Controls.MetroTextBox textBox = sender as MetroFramework.Controls.MetroTextBox;
                try
                {
                    if (String.IsNullOrEmpty(textBox.Text))
                    {

                    }
                    else
                    {
                        
                        BigInteger testInt = BigInteger.Parse(textBox.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Only input numbers");
                    textBox.Text = "";
                }
            }
            else
            {
                TextBox textBox = sender as TextBox;
                try
                {
                    if (String.IsNullOrEmpty(textBox.Text))
                    {

                    }
                    else
                    {
                        BigInteger testInt = BigInteger.Parse(textBox.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Only input numbers");
                    textBox.Text = "";
                }
            }
        }
        #region ViewResults
        private void Man_Stu_Res_View_Btn_Click(object sender, EventArgs e)
        {
            Man_Stu_Res_ViewListbox1.Items.Clear();

            foreach (IUser u in Model.UserList)
                foreach (IGrade d in Model.GradeList)
                {

                    ListViewItem dourselist = new ListViewItem(d.StudentID);
                    dourselist.SubItems.Add(d.ModID);
                    dourselist.SubItems.Add(d.Grades);
                    if (string.IsNullOrWhiteSpace(Man_Stu_Res_TextBox3.Text))
                    {
                        if (Man_Stu_Res_TextBox1.Text == u.FirstName && Man_Stu_Res_TextBox2.Text == u.LastName)
                        {
                            if (u.UserID == d.StudentID)
                                Man_Stu_Res_ViewListbox1.Items.Add(dourselist);
                        }
                        else if (Man_Stu_Res_TextBox1.Text == u.FirstName)
                        {
                            if (u.UserID == d.StudentID)
                                Man_Stu_Res_ViewListbox1.Items.Add(dourselist);
                        }
                        else if (Man_Stu_Res_TextBox2.Text == u.LastName)
                        {
                            if (u.UserID == d.StudentID)
                                Man_Stu_Res_ViewListbox1.Items.Add(dourselist);
                        }
                    }
                    else if (Man_Stu_Res_TextBox1.Text == u.FirstName && Man_Stu_Res_TextBox2.Text == u.LastName && Man_Stu_Res_TextBox3.Text == d.ModID)
                    {
                        if (u.UserID == d.StudentID)
                            Man_Stu_Res_ViewListbox1.Items.Add(dourselist);
                    }
                    else if (Man_Stu_Res_TextBox1.Text == u.FirstName && Man_Stu_Res_TextBox3.Text == d.ModID)
                    {
                        if (u.UserID == d.StudentID)
                            Man_Stu_Res_ViewListbox1.Items.Add(dourselist);
                    }
                    else if (Man_Stu_Res_TextBox1.Text == u.FirstName && Man_Stu_Res_TextBox3.Text == d.ModID)
                    {
                        if (u.UserID == d.StudentID)
                            Man_Stu_Res_ViewListbox1.Items.Add(dourselist);
                    }
                    else if (Man_Stu_Res_TextBox3.Text == d.ModID)
                    {
                        if (u.UserID == d.StudentID)
                            Man_Stu_Res_ViewListbox1.Items.Add(dourselist);
                    }

                }
        }

        //private void Man_Stu_Cr8Letrbtn_Click(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrEmpty(Man_Stu_Cr8LtrTB0.Text) || String.IsNullOrEmpty(Man_Stu_Cr8LtrTB1.Text) || String.IsNullOrEmpty(Man_Stu_Cr8LtrTB2.Text))
        //    {
        //        MessageBox.Show("All fields must be filled", "Error Submiting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        formStudentLetter settingsForm = new formStudentLetter(Model);
        //        SetValueForText1 = Man_Stu_Cr8LtrTB2.Text;
        //        SetValueForText2 = Man_Stu_Cr8LtrTB0.Text + " " + Man_Stu_Cr8LtrTB1.Text;
        //        var matchTemplate = Model.TemplateList.Where(user => user.Tname.Contains(formSuperAdministrator.SetCreateLettercomboboxtext));
        //        if (matchTemplate != null)
        //        {
        //            foreach (ITemplate s in matchTemplate)
        //            {
        //                templatecontent = s.Tcontent;
        //            }
        //        }
        //         SetCreateLettercomboboxtext = Man_Stu_Cr8LtrCB0.SelectedItem.ToString();
        //        SetCreateLettercomboboxtext = templatecontent;
        //        settingsForm.Show();
        //    }
        //}
        private void Man_Stu_Cr8LtrCB0_Fill(object sender, EventArgs e)
        {
            foreach (ITemplate t in Model.TemplateList)
            {
                Man_Stu_Cr8LtrCB0.Items.Add(t.Tname);
            }
        }


        private void CreateTemplateBtn1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(StudentTemplatetxtbox0.Text) || String.IsNullOrEmpty(StudentTemplatetxtbox1.Text))
            {
                MessageBox.Show("All fields must be filled", "Error Submiting", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            else
            {
                if (Model.addTemplate(StudentTemplatetxtbox0.Text, StudentTemplatetxtbox1.Text))
                {
                    MessageBox.Show("Template has been created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentTemplatetxtbox0.Text = "";
                    StudentTemplatetxtbox1.Text = "";
                    Man_Stu_Cr8LtrCB0.Items.Clear();
                    Man_Stu_Cr8LtrCB0_Fill(sender, e);
                    //FillTemplateList(sender, e);
                }
                else
                {

                    MessageBox.Show("Error creating Course!");


                }
            }
        }
        private void ViewLetterList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewLettertxtbox1.Clear();
            var letter = Model.LetterList.FirstOrDefault(c => c.senderID.Equals(ViewLetterList1.FocusedItem.Text));
            ViewLettertxtbox1.Text = letter.lContent;
        }
        private void Man_Stu_SendLetrbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Man_Stu_Cr8LtrTB2.Text) || String.IsNullOrEmpty(Man_Stu_Cr8LtrTB3.Text) || String.IsNullOrEmpty(Man_Stu_Cr8LtrTB4.Text))
            {
                MessageBox.Show("All fields must be filled", "Error Submiting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                if ((Model.addLetter(Man_Stu_Cr8LtrTB4.Text, Man_Stu_Cr8LtrTB2.Text, formSuperAdministrator.SetCreateLettercomboboxtext, Man_Stu_Cr8LtrTB3.Text, metroDateTime1.Text, "12")))
                   // if ((Model.addLetter("Hello", "Hello", "Hello", "Hello", "Hello")))
                    {
                        MessageBox.Show("The message has been successfully sent!");
                        ViewLetterList1.Items.Clear();
                        foreach (ILetter l in Model.LetterList)
                        {

                            ListViewItem items = new ListViewItem(l.senderID);
                            items.SubItems.Add(l.recieverID);
                            items.SubItems.Add(l.Date);

                            ViewLetterList1.Items.Add(items);
                        }
                    }
                    else
                        MessageBox.Show("Error sending new message!");
            }
        }
        private void Man_Stu_Cr8LtrCB0_SelectedIndexChanged(object sender, EventArgs e)
        {
            Man_Stu_Cr8LtrTB3.Clear();
            var matchTemplate = Model.TemplateList.Where(user => user.Tname.Contains(formSuperAdministrator.SetCreateLettercomboboxtext));
            if (matchTemplate != null)
            {
                foreach (ITemplate s in matchTemplate)
                {
                    Man_Stu_Cr8LtrTB3.Text = s.Tcontent;
                }
            }
        }

        private void Man_Stu_ClearLetrbtn_Click(object sender, EventArgs e)
        {
            Man_Stu_Cr8LtrTB3.Clear();
        }

        private void Clearviewlettertxtboxbtn0_Click(object sender, EventArgs e)
        {
            ViewLettertxtbox1.Clear();
        }


        #endregion
    }
}
