using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CollegeLayer;
using MetroFramework;

namespace CaherdavinCollege
{
    public partial class formLogin : MetroFramework.Forms.MetroForm
    {
        private IModel Model;
       
        public formLogin(IModel Model)
        {

            InitializeComponent();
            this.Model = Model;
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool validUser = Model.login(textBoxUserID.Text, textBoxPassword.Text);

                if (validUser)
                    this.Close();
                else
                {
                    MessageBox.Show("Invalid name or password");
                    textBoxUserID.Text = "";
                    textBoxPassword.Text = "";
                    textBoxUserID.Select();
                }
        }

        private void ButtonApplyForCourse_Click(object sender, EventArgs e)
        {
            bool validApplicant = Model.returnApplicant();
            if(validApplicant)
                this.Close();
        }

        private void formLogin_Shown(object sender, EventArgs e)
        {
            this.textBoxUserID.Focus();
            //this.ActiveControl = textBoxUserID;
        }

        
    }
}
