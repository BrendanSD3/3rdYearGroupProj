namespace CaherdavinCollege
{
    partial class formApplicant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonExit = new MetroFramework.Controls.MetroButton();
            this.ListViewApplicantDepartments = new MetroFramework.Controls.MetroListView();
            this.columnHeaderfordepartmentinapplicant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonSearchCourses = new MetroFramework.Controls.MetroButton();
            this.TextBoxSearchCourse = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxCourseDescription = new MetroFramework.Controls.MetroTextBox();
            this.ButtonSubmitCourseChoice = new MetroFramework.Controls.MetroButton();
            this.ListViewCoursesApplicants = new System.Windows.Forms.ListView();
            this.colForCourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForPointsofCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(947, 555);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(108, 48);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseSelectable = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ListViewApplicantDepartments
            // 
            this.ListViewApplicantDepartments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderfordepartmentinapplicant});
            this.ListViewApplicantDepartments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListViewApplicantDepartments.FullRowSelect = true;
            this.ListViewApplicantDepartments.Location = new System.Drawing.Point(103, 129);
            this.ListViewApplicantDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewApplicantDepartments.Name = "ListViewApplicantDepartments";
            this.ListViewApplicantDepartments.OwnerDraw = true;
            this.ListViewApplicantDepartments.Size = new System.Drawing.Size(200, 246);
            this.ListViewApplicantDepartments.TabIndex = 1;
            this.ListViewApplicantDepartments.UseCompatibleStateImageBehavior = false;
            this.ListViewApplicantDepartments.UseSelectable = true;
            this.ListViewApplicantDepartments.View = System.Windows.Forms.View.Details;
            this.ListViewApplicantDepartments.SelectedIndexChanged += new System.EventHandler(this.ListViewApplicantDepartments_SelectedIndexChanged);
            this.ListViewApplicantDepartments.Click += new System.EventHandler(this.ListViewApplicantDepartments_SelectedIndexChanged);
            // 
            // columnHeaderfordepartmentinapplicant
            // 
            this.columnHeaderfordepartmentinapplicant.Text = "Department";
            this.columnHeaderfordepartmentinapplicant.Width = 147;
            // 
            // ButtonSearchCourses
            // 
            this.ButtonSearchCourses.Location = new System.Drawing.Point(613, 407);
            this.ButtonSearchCourses.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSearchCourses.Name = "ButtonSearchCourses";
            this.ButtonSearchCourses.Size = new System.Drawing.Size(100, 28);
            this.ButtonSearchCourses.TabIndex = 3;
            this.ButtonSearchCourses.Text = "Search";
            this.ButtonSearchCourses.UseSelectable = true;
            this.ButtonSearchCourses.Click += new System.EventHandler(this.ButtonSearchCourses_Click);
            // 
            // TextBoxSearchCourse
            // 
            // 
            // 
            // 
            this.TextBoxSearchCourse.CustomButton.Image = null;
            this.TextBoxSearchCourse.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.TextBoxSearchCourse.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSearchCourse.CustomButton.Name = "";
            this.TextBoxSearchCourse.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TextBoxSearchCourse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxSearchCourse.CustomButton.TabIndex = 1;
            this.TextBoxSearchCourse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxSearchCourse.CustomButton.UseSelectable = true;
            this.TextBoxSearchCourse.CustomButton.Visible = false;
            this.TextBoxSearchCourse.Lines = new string[0];
            this.TextBoxSearchCourse.Location = new System.Drawing.Point(385, 407);
            this.TextBoxSearchCourse.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSearchCourse.MaxLength = 32767;
            this.TextBoxSearchCourse.Name = "TextBoxSearchCourse";
            this.TextBoxSearchCourse.PasswordChar = '\0';
            this.TextBoxSearchCourse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxSearchCourse.SelectedText = "";
            this.TextBoxSearchCourse.SelectionLength = 0;
            this.TextBoxSearchCourse.SelectionStart = 0;
            this.TextBoxSearchCourse.ShortcutsEnabled = true;
            this.TextBoxSearchCourse.Size = new System.Drawing.Size(192, 28);
            this.TextBoxSearchCourse.TabIndex = 4;
            this.TextBoxSearchCourse.UseSelectable = true;
            this.TextBoxSearchCourse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxSearchCourse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxCourseDescription
            // 
            // 
            // 
            // 
            this.TextBoxCourseDescription.CustomButton.Image = null;
            this.TextBoxCourseDescription.CustomButton.Location = new System.Drawing.Point(375, 2);
            this.TextBoxCourseDescription.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCourseDescription.CustomButton.Name = "";
            this.TextBoxCourseDescription.CustomButton.Size = new System.Drawing.Size(125, 125);
            this.TextBoxCourseDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxCourseDescription.CustomButton.TabIndex = 1;
            this.TextBoxCourseDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxCourseDescription.CustomButton.UseSelectable = true;
            this.TextBoxCourseDescription.CustomButton.Visible = false;
            this.TextBoxCourseDescription.Lines = new string[0];
            this.TextBoxCourseDescription.Location = new System.Drawing.Point(385, 473);
            this.TextBoxCourseDescription.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCourseDescription.MaximumSize = new System.Drawing.Size(503, 130);
            this.TextBoxCourseDescription.MaxLength = 32767;
            this.TextBoxCourseDescription.Multiline = true;
            this.TextBoxCourseDescription.Name = "TextBoxCourseDescription";
            this.TextBoxCourseDescription.PasswordChar = '\0';
            this.TextBoxCourseDescription.ReadOnly = true;
            this.TextBoxCourseDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxCourseDescription.SelectedText = "";
            this.TextBoxCourseDescription.SelectionLength = 0;
            this.TextBoxCourseDescription.SelectionStart = 0;
            this.TextBoxCourseDescription.ShortcutsEnabled = true;
            this.TextBoxCourseDescription.Size = new System.Drawing.Size(503, 130);
            this.TextBoxCourseDescription.TabIndex = 5;
            this.TextBoxCourseDescription.UseSelectable = true;
            this.TextBoxCourseDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxCourseDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ButtonSubmitCourseChoice
            // 
            this.ButtonSubmitCourseChoice.Location = new System.Drawing.Point(947, 473);
            this.ButtonSubmitCourseChoice.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSubmitCourseChoice.Name = "ButtonSubmitCourseChoice";
            this.ButtonSubmitCourseChoice.Size = new System.Drawing.Size(108, 48);
            this.ButtonSubmitCourseChoice.TabIndex = 6;
            this.ButtonSubmitCourseChoice.Text = "Next";
            this.ButtonSubmitCourseChoice.UseSelectable = true;
            this.ButtonSubmitCourseChoice.Click += new System.EventHandler(this.ButtonSubmitCourseChoice_Click);
            // 
            // ListViewCoursesApplicants
            // 
            this.ListViewCoursesApplicants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colForCourseName,
            this.colForPointsofCourse});
            this.ListViewCoursesApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewCoursesApplicants.FullRowSelect = true;
            this.ListViewCoursesApplicants.Location = new System.Drawing.Point(391, 122);
            this.ListViewCoursesApplicants.MultiSelect = false;
            this.ListViewCoursesApplicants.Name = "ListViewCoursesApplicants";
            this.ListViewCoursesApplicants.Size = new System.Drawing.Size(497, 252);
            this.ListViewCoursesApplicants.TabIndex = 7;
            this.ListViewCoursesApplicants.UseCompatibleStateImageBehavior = false;
            this.ListViewCoursesApplicants.View = System.Windows.Forms.View.Details;
            this.ListViewCoursesApplicants.SelectedIndexChanged += new System.EventHandler(this.ListViewCoursesApplicants_SelectedIndexChanged);
            // 
            // colForCourseName
            // 
            this.colForCourseName.Text = "Course Name";
            this.colForCourseName.Width = 312;
            // 
            // colForPointsofCourse
            // 
            this.colForPointsofCourse.Text = "Points";
            // 
            // formApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 654);
            this.ControlBox = false;
            this.Controls.Add(this.ListViewCoursesApplicants);
            this.Controls.Add(this.ButtonSubmitCourseChoice);
            this.Controls.Add(this.TextBoxCourseDescription);
            this.Controls.Add(this.TextBoxSearchCourse);
            this.Controls.Add(this.ButtonSearchCourses);
            this.Controls.Add(this.ListViewApplicantDepartments);
            this.Controls.Add(this.ButtonExit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1107, 654);
            this.MinimizeBox = false;
            this.Name = "formApplicant";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Choose a Course";
            this.Load += new System.EventHandler(this.formApplicant_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton ButtonExit;
        private MetroFramework.Controls.MetroListView ListViewApplicantDepartments;
        private System.Windows.Forms.ColumnHeader columnHeaderfordepartmentinapplicant;
        private MetroFramework.Controls.MetroButton ButtonSearchCourses;
        private MetroFramework.Controls.MetroTextBox TextBoxSearchCourse;
        private MetroFramework.Controls.MetroTextBox TextBoxCourseDescription;
        private MetroFramework.Controls.MetroButton ButtonSubmitCourseChoice;
        private System.Windows.Forms.ListView ListViewCoursesApplicants;
        private System.Windows.Forms.ColumnHeader colForCourseName;
        private System.Windows.Forms.ColumnHeader colForPointsofCourse;
    }
}