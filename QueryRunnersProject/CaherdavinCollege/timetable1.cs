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
using System.IO;
using System.Drawing.Imaging;

namespace CaherdavinCollege
{
    public partial class timetable1 : Form
    {
        private IModel Model;
        private formContainer fc;
        public timetable1( IModel Model)
        {
            InitializeComponent();
            //MdiParent = parent;
            //fc = parent;
            this.Model = Model;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //string monday = listView1.Columns.ToString();
            List<string> times = new List<string>();
            times.Add(_9to10.Text);
            times.Add(_10to11.Text);
            times.Add(_11to12.Text);
            times.Add(_12to1.Text);
            times.Add(_1to2.Text);
            times.Add(_2to3.Text);
            times.Add(_3to4.Text);
            times.Add(_4to5.Text);
            times.Add(_5to6.Text);

            foreach (ICourse course in Model.CourseList)
            {
                comboBoxCourses.Items.Add(course.Name);

            }
            foreach (IModule Module in Model.ModuleList)
            {
                comboBoxModules.Items.Add(Module.Name);

            }
            foreach (IRoom Room in Model.RoomList)
            {
                comboBoxRooms.Items.Add(Room.Name);
            }
            foreach (IStaff s in Model.StaffList)
            {
                if (s.UserType =="Lecturer")
                {
                    comboBoxLecturers.Items.Add(s.FirstName+s.LastName);



                }

            }

            foreach (string time in times)
            {
                timedropdown.Items.Add(time);
            }
        }

        private void btntimetable_click(object sender, EventArgs e)
        {

            if (comboBoxCourses.SelectedItem == null)
            {
                MessageBox.Show("Please select a Time, Course, Lecturer and Module");
            }
           else
            {
                switch (timedropdown.SelectedItem.ToString())
                {
                    case "9:00-10:00":
                        {
                            Monday9to10.Items.Add("Course: " + comboBoxCourses.SelectedItem.ToString());
                            Monday9to10.Items.Add("Lecturer: " + comboBoxLecturers.SelectedItem.ToString());
                            Monday9to10.Items.Add("Module: " + comboBoxModules.SelectedItem.ToString());
                            Monday9to10.Items.Add("Room: " + comboBoxRooms.SelectedItem.ToString());
                            break;
                        }
                    case "10:00-11:00":
                        {
                            Monday10to11.Items.Add(comboBoxCourses.SelectedItem.ToString());
                            Monday10to11.Items.Add(comboBoxLecturers.SelectedItem.ToString());
                            Monday10to11.Items.Add(comboBoxModules.SelectedItem.ToString());
                            Monday10to11.Items.Add(comboBoxRooms.SelectedItem.ToString());
                            break;
                        }
                    case "11:00-12:00":
                        {
                            Monday11to12.Items.Add(comboBoxCourses.SelectedItem.ToString());
                            Monday11to12.Items.Add(comboBoxLecturers.SelectedItem.ToString());
                            Monday11to12.Items.Add(comboBoxModules.SelectedItem.ToString());
                            Monday11to12.Items.Add(comboBoxRooms.SelectedItem.ToString());
                            break;
                        }
                    case "12:00-1:00":
                        {
                            Monday12to1.Items.Add(comboBoxCourses.SelectedItem.ToString());
                            Monday12to1.Items.Add(comboBoxLecturers.SelectedItem.ToString());
                            Monday12to1.Items.Add(comboBoxModules.SelectedItem.ToString());
                            Monday12to1.Items.Add(comboBoxRooms.SelectedItem.ToString());
                            break;
                        }
                    case "1:00-2:00":
                        {
                            Monday1to2.Items.Add(comboBoxCourses.SelectedItem.ToString());
                            Monday1to2.Items.Add(comboBoxLecturers.SelectedItem.ToString());
                            Monday1to2.Items.Add(comboBoxModules.SelectedItem.ToString());
                            Monday1to2.Items.Add(comboBoxRooms.SelectedItem.ToString());
                            break;
                        }
                    case "2:00-3:00":
                        {
                            Monday2to3.Items.Add(comboBoxCourses.SelectedItem.ToString());
                            Monday2to3.Items.Add(comboBoxLecturers.SelectedItem.ToString());
                            Monday2to3.Items.Add(comboBoxModules.SelectedItem.ToString());
                            Monday2to3.Items.Add(comboBoxRooms.SelectedItem.ToString());
                            break;
                        }
                    case "3:00-4:00":
                        {
                            Monday3to4.Items.Add(comboBoxCourses.SelectedItem.ToString());
                            Monday3to4.Items.Add(comboBoxLecturers.SelectedItem.ToString());
                            Monday3to4.Items.Add(comboBoxModules.SelectedItem.ToString());
                            Monday3to4.Items.Add(comboBoxRooms.SelectedItem.ToString());
                            break;
                        }
                    case "4:00-5:00":
                        {
                            Monday4to5.Items.Add(comboBoxCourses.SelectedItem.ToString());
                            Monday4to5.Items.Add(comboBoxLecturers.SelectedItem.ToString());
                            Monday4to5.Items.Add(comboBoxModules.SelectedItem.ToString());
                            Monday4to5.Items.Add(comboBoxRooms.SelectedItem.ToString());
                            break;
                        }
                    case "5:00-6:00":
                        {
                            Monday5to6.Items.Add(comboBoxCourses.SelectedItem.ToString());
                            Monday5to6.Items.Add(comboBoxLecturers.SelectedItem.ToString());
                            Monday5to6.Items.Add(comboBoxModules.SelectedItem.ToString());
                            Monday5to6.Items.Add(comboBoxRooms.SelectedItem.ToString());
                            break;
                        }

                     
                }


            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Saveit_Click(object sender, EventArgs e)
        {
            //this.Hide();
            bool didWork;
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            string Path = "img";
            int increment = 1;

            Image img = null;

            try
            {
                img = Clipboard.GetImage();
                Clipboard.SetImage(img);
                didWork = true;
            }
            catch(Exception ex)
            {
                didWork = false;
            }

            if (didWork == true)
            {
                string FilePath = Application.StartupPath + "\\Images\\img.jpg";

                if (!System.IO.Directory.Exists(Application.StartupPath + "\\Images\\"))
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Images\\");


                //if (File.Exists("C:\\Users\\k00214874\\Desktop\\img.jpg"))
                //{
                //   increment++;
                //   img.Save("C:\\Users\\k00214874\\Desktop\\" + Path + increment.ToString() + ".jpg");
                //}
                //else
                //{
                //img = Clipboard.GetImage();

                img.Save(FilePath);
                //}
                imageform imgfrm = new imageform(img);
                imgfrm.Show();
            }
            else
            {
                MessageBox.Show("Please take screenshot again");
            }
            
        }
    }
}
