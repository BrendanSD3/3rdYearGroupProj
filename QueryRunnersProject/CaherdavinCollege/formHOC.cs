using CollegeEntities;
using CollegeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaherdavinCollege
{
    public partial class formHOC : MetroFramework.Forms.MetroForm
    {
        private IModel Model;
        private formContainer fc;
        public formHOC(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            

        }

        private void formHOC_Load(object sender, EventArgs e)
        {
            //this.Text = "Welcome Head of College";
            coursenamedropdown.Items.Clear();
            coursenamedropdown_Fill(sender, e);

            listoffeedback.Items.Clear();
            foreach (IFeedback f in Model.FeedbackList)
            {

                ListViewItem List = new ListViewItem(f.stdname);
                List.SubItems.Add(f.CourseN);
                List.SubItems.Add(f.Desc);




                listoffeedback.Items.Add(List);
            }
        }
        private void searchFeedBack_Click(object sender, EventArgs e)
        {
            var matchfeedback = Model.FeedbackList.Where(user => user.CourseN.Contains(coursenamedropdown.SelectedItem.ToString()));

            if (matchfeedback != null)
            {
                listoffeedback.Items.Clear();
                foreach (IFeedback s in matchfeedback)
                {

                    ListViewItem List = new ListViewItem(s.stdname);
                    List.SubItems.Add(s.CourseN);
                    List.SubItems.Add(s.Desc);




                    listoffeedback.Items.Add(List);
                }
            }
        }
        private void coursenamedropdown_Fill(object sender, EventArgs e)
        {
            foreach (ICourse c in Model.CourseList)
                coursenamedropdown.Items.Add(c.Name);
            //   CoursesDropDownList.SelectedIndex = 0;
        }
        //foreach (ICourse c in Model.CourseList)
        //       CoursesDropDownList.Items.Add(c.Name);

        private void coursenamedropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewfeedbackbutton_Click(object sender, EventArgs e)
        {
            if (listoffeedback.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a student");
            }
            else
            {
                foreach (Student user in Model.FeedbackList)
                {

                    if (listoffeedback.Items[0].Text.Equals(user.UserID))
                    {


                        user.CourseID_fk = coursenamedropdown.SelectedItem.ToString();
                        Model.EditStudentCourse(user);
                        // MessageBox.Show();
                    }
                }
                //MessageBox.Show("Student Changed Course Successfully ");



            }
        }

        private void listoffeedback_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string feedback = listoffeedback.SelectedItems.ToString();
            //MessageBox.Show("Feedback{0}"+feedback);
            MessageBox.Show(listoffeedback.SelectedItems.ToString());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.fc.formContainer_Shown(sender, e);
        }

        private void viewfeedbackbtn_Click(object sender, EventArgs e)
        {

            if (listoffeedback.SelectedItems.Count > 0)
            {
                MessageBox.Show(listoffeedback.SelectedItems[0].Text);
            }
            else
            {
                MessageBox.Show("please select a student");
            }
        }
    }
}
