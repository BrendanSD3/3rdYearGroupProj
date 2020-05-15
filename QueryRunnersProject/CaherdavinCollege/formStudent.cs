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
    public partial class formStudent : MetroFramework.Forms.MetroForm
    {
        private IModel Model;
        private formContainer fc;



        public formStudent(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }







        private void formStudent_Load(object sender, EventArgs e)
        {

            CoursesDropDownList.Items.Clear();
            CoursesDropDownList_Fill(sender, e);

            //FillCourseList(sender, e);

        }



        //private void CoursesDropDown_Fill(object sender, EventArgs e)
        //{
        //    foreach (ICourse c in Model.CourseList)
        //        CoursesDropDown.Items.Add(c.CourseID);
        //    CoursesDropDown.SelectedIndex = 0;
        //}

        private void CoursesDropDownList_Fill(object sender, EventArgs e)
        {
            foreach (ICourse c in Model.CourseList)
                CoursesDropDownList.Items.Add(c.Name);
            //   CoursesDropDownList.SelectedIndex = 0;
        }

        private void FeedBackFormButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(studentNametxtbox.Text) || String.IsNullOrEmpty(CoursesDropDownList.Text) || String.IsNullOrEmpty(Feedbackdesc_text.Text))
            {
                MessageBox.Show("All fields must be filled", "Error Submiting", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string value = CoursesDropDownList.SelectedItem.ToString();
                if ((Model.AddFeedBack(studentNametxtbox.Text, value, Feedbackdesc_text.Text)))
                {
                    MessageBox.Show("FeedBack Sent");
                    studentNametxtbox.Text = "";
                    //  CoursesDropDownList.Text = "";
                    Feedbackdesc_text.Text = "";

                    formStudent_Load(sender, e);
                }
                else
                    MessageBox.Show("Error Sending Feedback!");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.fc.formContainer_Shown(sender, e);
        }
    }
}
