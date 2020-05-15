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
using CollegeEntities;
using MetroFramework;


namespace CaherdavinCollege
{
    public partial class formApplicant : MetroFramework.Forms.MetroForm
    {
        private IModel Model;
        private formContainer fc;
        public formApplicant(formContainer parent, IModel model)
        {
            InitializeComponent();
            this.Model = model;
            this.fc = parent;
            MdiParent = parent;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.fc.formContainer_Shown(sender, e);
        }

        private void formApplicant_Load(object sender, EventArgs e)
        {
            ListViewApplicantDepartments.Items.Clear();
            foreach (IDepartment d in Model.DepartmentList)
            {
                ListViewItem lv = new ListViewItem(d.Name);
                ListViewApplicantDepartments.Items.Add(lv);
            }
        }

        private void ListViewApplicantDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            var theDep = Model.DepartmentList.FirstOrDefault(dep => dep.Name.Equals(ListViewApplicantDepartments.FocusedItem.Text));
            ListViewCoursesApplicants.Items.Clear();
            foreach(ICourse c in Model.CourseList)
            {
                if (c.DeptID.Equals(theDep.DepartmentID))
                {
                    ListViewItem lv = new ListViewItem(c.Name);
                    lv.SubItems.Add(c.Points.ToString());
                    ListViewCoursesApplicants.Items.Add(lv);
                }
            }
        }

        private void ButtonSearchCourses_Click(object sender, EventArgs e)
        {
            ListViewCoursesApplicants.Items.Clear();
            var list = Model.CourseList.Where(course => course.Name.Contains(TextBoxSearchCourse.Text));
            foreach(ICourse c in list)
            {
                ListViewItem lv = new ListViewItem(c.Name);
                lv.SubItems.Add(c.Points.ToString());
                ListViewCoursesApplicants.Items.Add(lv);
            }
        }

        private void ListViewCoursesApplicants_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxCourseDescription.Clear();
            var course = Model.CourseList.FirstOrDefault(c => c.Name.Equals(ListViewCoursesApplicants.FocusedItem.Text));
            TextBoxCourseDescription.Text = course.Desc;
        }

        private void ButtonSubmitCourseChoice_Click(object sender, EventArgs e)
        {
            if(ListViewCoursesApplicants.SelectedItems.Count <= 0)
                MessageBox.Show("Please select a course");
            else
            {
                formApplicantDetails form = new formApplicantDetails(this.fc, Model, ListViewCoursesApplicants.FocusedItem.Text);
                form.Dock = DockStyle.Fill;
                form.Show();
                this.Close();
            }
        }
    }
}
