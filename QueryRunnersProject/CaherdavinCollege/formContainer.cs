using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CollegeLayer;

namespace CaherdavinCollege
{
    public partial class formContainer : MetroFramework.Forms.MetroForm
    {
        private IModel Model;

        public formContainer(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;
            
        }


        public void formContainer_Shown(object sender, EventArgs e)
        {
            formLogin formLgn = new formLogin(Model);
            formLgn.ShowDialog();
            //formLgn.Focus();
            switch (Model.getUserTypeForCurrentuser().ToString())
            {
                case "SuperAdministrator":
                    formSuperAdministrator superAdmin = new formSuperAdministrator(this, Model);
                    superAdmin.Dock = DockStyle.Fill;
                    superAdmin.Show();
                    break;
                case "Administrator":
                    formAdministrator form2 = new formAdministrator(this, Model);// All forms get passed the formContainer and a reference to the model object. 
                    form2.Dock = DockStyle.Fill;
                    form2.Show();
                    break;
                case "Applicant":
                    formApplicant applicant = new formApplicant(this, Model);
                    applicant.Dock = DockStyle.Fill;
                    applicant.Show();
                    break;
                case "Lecturer":
                    formLecturer lecturer = new formLecturer(this, Model);
                    lecturer.Dock = DockStyle.Fill;
                    lecturer.Show();
                    break;
                case "HOC":
                    formHOC Hoc = new formHOC(this, Model);
                    Hoc.Dock = DockStyle.Fill;
                    Hoc.Show();
                    break;
                case "ITTechnician":
                    formITTechnician ittech = new formITTechnician(this, Model);// All forms get passed the formContainer and a reference to the model object. 
                    ittech.Dock = DockStyle.Fill;
                    ittech.Show();
                    break;
                case "Student":
                    formStudent std = new formStudent(this, Model);
                    std.Dock = DockStyle.Fill;
                    std.Show();
                    break;

            }

        }
        
        private void formContainer_Load(object sender, EventArgs e)
        {

           // this.ActiveControl = formLogin;


        }

    }
}
