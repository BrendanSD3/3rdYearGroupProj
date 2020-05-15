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
    public partial class formApplicantDetails : MetroFramework.Forms.MetroForm
    {
        private IModel Model;
        private formContainer fc;
        private string chosenCourse;
        public formApplicantDetails(formContainer parent, IModel model, string course)
        {
            InitializeComponent();
            this.Model = model;
            this.fc = parent;
            MdiParent = parent;
            this.chosenCourse = course;
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.fc.formContainer_Shown(sender, e);
        }

        private void formApplicantDetails_Load(object sender, EventArgs e)
        {
            LabelChosenCourse.Text = this.chosenCourse;

            #region dob
            DateTime now = DateTime.Now;

            for (int i = 1; i <= 12; i++)
                ComboBoxMonth.Items.Add(i);

            for (int i = 15; i < 65; i++)
                ComboBoxYear.Items.Add(now.Year - i);


            ComboBoxYear.SelectedItem = now.Year - 15;
            ComboBoxDay.SelectedItem = 1;
            ComboBoxMonth.SelectedItem = 1;

            //MessageBox.Show(ComboBoxMonth.Text);
            #endregion
        }

        private void TextBoxPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var course = Model.CourseList.FirstOrDefault(c => c.Name.Equals(this.chosenCourse));
            if (String.IsNullOrEmpty(TextBoxFirstName.Text) && String.IsNullOrEmpty(TextBoxLastname.Text) && String.IsNullOrEmpty(TextBoxPoints.Text)
                && ComboBoxDay.SelectedIndex > -1 && ComboBoxMonth.SelectedIndex > -1 && ComboBoxYear.SelectedIndex > -1)
                MessageBox.Show("Please enter your details");
            else
            {
                DateTime dob = new DateTime(Convert.ToInt32(ComboBoxYear.Text), Convert.ToInt32(ComboBoxMonth.Text), Convert.ToInt32(ComboBoxDay.Text));
                if (RadioButtonFullTime.Checked)
                {
                    if (CheckBoxEU.Checked)
                    {
                        if (Model.addApplicant(Convert.ToInt32(Model.CurrentUser.UserID), TextBoxFirstName.Text, TextBoxLastname.Text,
                           1, course.IsNightCourse, 0, Convert.ToInt32(TextBoxPoints.Text), dob, this.chosenCourse))
                        {
                            MessageBox.Show("Your Application has been sent to the Caherdavin College Admin Staff\nGood Luck!\n" +
                                "First Name: " + TextBoxFirstName.Text + "\n" +
                                "Last Name: " + TextBoxLastname.Text + "\n" +
                                "Leaving Cert Points: " + TextBoxPoints.Text + "\n" +
                                "From the EU: " + "Yes" + "\n" +
                                "Student Type: " + "FullTime");

                            TextBoxFirstName.Text = "";
                            TextBoxLastname.Text = "";
                            TextBoxPoints.Text = "";
                        }
                    }
                    else
                    {
                        if (Model.addApplicant(Convert.ToInt32(Model.CurrentUser.UserID), TextBoxFirstName.Text, TextBoxLastname.Text,
                           0, course.IsNightCourse, 0, Convert.ToInt32(TextBoxPoints.Text), dob, this.chosenCourse))
                        {
                            MessageBox.Show("Your Application has been sent to the Caherdavin College Admin Staff\nGood Luck!\n" +
                                "First Name: " + TextBoxFirstName.Text + "\n" +
                                "Last Name: " + TextBoxLastname.Text + "\n" +
                                "Leaving Cert Points: " + TextBoxPoints.Text + "\n" +
                                "From the EU: " + "No" + "\n" +
                                "Student Type: " + "FullTime");
                            TextBoxFirstName.Text = "";
                            TextBoxLastname.Text = "";
                            TextBoxPoints.Text = "";
                        }
                    }
                }
                else if (RadioButtonPartTime.Checked)
                {
                    if (CheckBoxEU.Checked)
                    {
                        if (Model.addApplicant(Convert.ToInt32(Model.CurrentUser.UserID), TextBoxFirstName.Text, TextBoxLastname.Text,
                           1, course.IsNightCourse, 1, Convert.ToInt32(TextBoxPoints.Text), dob, this.chosenCourse))
                        {
                            MessageBox.Show("Your Application has been sent to the Caherdavin College Admin Staff\nGood Luck!\n" +
                                "First Name: " + TextBoxFirstName.Text + "\n" +
                                "Last Name: " + TextBoxLastname.Text + "\n" +
                                "Leaving Cert Points: " + TextBoxPoints.Text + "\n" +
                                "From the EU: " + "Yes" + "\n" +
                                "Student Type: " + "PartTime");
                            TextBoxFirstName.Text = "";
                            TextBoxLastname.Text = "";
                            TextBoxPoints.Text = "";
                        }
                    }
                    else
                    {
                        if (Model.addApplicant(Convert.ToInt32(Model.CurrentUser.UserID), TextBoxFirstName.Text, TextBoxLastname.Text,
                           0, course.IsNightCourse, 1, Convert.ToInt32(TextBoxPoints.Text), dob, this.chosenCourse))
                        {
                            MessageBox.Show("Your Application has been sent to the Caherdavin College Admin Staff\nGood Luck!\n" +
                                "First Name: " + TextBoxFirstName.Text + "\n" +
                                "Last Name: " + TextBoxLastname.Text + "\n" +
                                "Leaving Cert Points: " + TextBoxPoints.Text + "\n" +
                                "From the EU: " + "No" + "\n" +
                                "Student Type: " + "PartTime");
                            TextBoxFirstName.Text = "";
                            TextBoxLastname.Text = "";
                            TextBoxPoints.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select whether you are a part time or full time student");
                }
            }
        }

        private void ComboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int day = Convert.ToInt32(ComboBoxDay.SelectedItem) - 1;
                ComboBoxDay.Items.Clear();
                int days = DateTime.DaysInMonth(Convert.ToInt16(ComboBoxYear.SelectedItem), Convert.ToInt16(ComboBoxMonth.SelectedItem));
                for (int i = 1; i <= days; i++)
                    ComboBoxDay.Items.Add(i);
                ComboBoxDay.SelectedIndex = day;
            }
            catch(Exception ex)
            {
                ComboBoxDay.SelectedIndex = 0;
            }
        }

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
                        int testInt = Convert.ToInt16(textBox.Text);
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
                        int testInt = Convert.ToInt16(textBox.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Only input numbers");
                    textBox.Text = "";
                }
            }
        }
    }
}
