namespace CaherdavinCollege
{
    partial class formHOC
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
            this.feedbacktab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.viewfeedbackbtn = new MetroFramework.Controls.MetroButton();
            this.listoffeedback = new System.Windows.Forms.ListView();
            this.feedbackheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseidheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coursenamedropdown = new MetroFramework.Controls.MetroComboBox();
            this.searchFeedBack = new MetroFramework.Controls.MetroButton();
            this.LableCourseNameFeedback = new MetroFramework.Controls.MetroLabel();
            this.BtnExit = new MetroFramework.Controls.MetroButton();
            this.feedbacktab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // feedbacktab
            // 
            this.feedbacktab.Controls.Add(this.metroTabPage1);
            this.feedbacktab.Location = new System.Drawing.Point(22, 50);
            this.feedbacktab.Margin = new System.Windows.Forms.Padding(2);
            this.feedbacktab.Name = "feedbacktab";
            this.feedbacktab.SelectedIndex = 0;
            this.feedbacktab.Size = new System.Drawing.Size(739, 335);
            this.feedbacktab.TabIndex = 2;
            this.feedbacktab.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.viewfeedbackbtn);
            this.metroTabPage1.Controls.Add(this.listoffeedback);
            this.metroTabPage1.Controls.Add(this.coursenamedropdown);
            this.metroTabPage1.Controls.Add(this.searchFeedBack);
            this.metroTabPage1.Controls.Add(this.LableCourseNameFeedback);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 6;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(731, 293);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "View Course Feedback";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 7;
            // 
            // viewfeedbackbtn
            // 
            this.viewfeedbackbtn.Location = new System.Drawing.Point(195, 179);
            this.viewfeedbackbtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewfeedbackbtn.Name = "viewfeedbackbtn";
            this.viewfeedbackbtn.Size = new System.Drawing.Size(89, 25);
            this.viewfeedbackbtn.TabIndex = 31;
            this.viewfeedbackbtn.Text = "view";
            this.viewfeedbackbtn.UseSelectable = true;
            this.viewfeedbackbtn.Click += new System.EventHandler(this.viewfeedbackbtn_Click);
            // 
            // listoffeedback
            // 
            this.listoffeedback.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.feedbackheader,
            this.courseidheader,
            this.nameheader});
            this.listoffeedback.Location = new System.Drawing.Point(393, 46);
            this.listoffeedback.Margin = new System.Windows.Forms.Padding(2);
            this.listoffeedback.Name = "listoffeedback";
            this.listoffeedback.Size = new System.Drawing.Size(190, 197);
            this.listoffeedback.TabIndex = 30;
            this.listoffeedback.UseCompatibleStateImageBehavior = false;
            this.listoffeedback.View = System.Windows.Forms.View.Details;
            // 
            // feedbackheader
            // 
            this.feedbackheader.Text = "feedback";
            // 
            // courseidheader
            // 
            this.courseidheader.Text = "course ID";
            // 
            // nameheader
            // 
            this.nameheader.Text = "name";
            // 
            // coursenamedropdown
            // 
            this.coursenamedropdown.FormattingEnabled = true;
            this.coursenamedropdown.ItemHeight = 23;
            this.coursenamedropdown.Location = new System.Drawing.Point(165, 59);
            this.coursenamedropdown.Margin = new System.Windows.Forms.Padding(2);
            this.coursenamedropdown.Name = "coursenamedropdown";
            this.coursenamedropdown.Size = new System.Drawing.Size(111, 29);
            this.coursenamedropdown.TabIndex = 28;
            this.coursenamedropdown.UseSelectable = true;
            this.coursenamedropdown.SelectedIndexChanged += new System.EventHandler(this.coursenamedropdown_SelectedIndexChanged);
            // 
            // searchFeedBack
            // 
            this.searchFeedBack.Location = new System.Drawing.Point(182, 110);
            this.searchFeedBack.Margin = new System.Windows.Forms.Padding(2);
            this.searchFeedBack.Name = "searchFeedBack";
            this.searchFeedBack.Size = new System.Drawing.Size(55, 18);
            this.searchFeedBack.TabIndex = 27;
            this.searchFeedBack.Text = "Search";
            this.searchFeedBack.UseSelectable = true;
            this.searchFeedBack.Click += new System.EventHandler(this.searchFeedBack_Click);
            // 
            // LableCourseNameFeedback
            // 
            this.LableCourseNameFeedback.AutoSize = true;
            this.LableCourseNameFeedback.Location = new System.Drawing.Point(63, 59);
            this.LableCourseNameFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LableCourseNameFeedback.Name = "LableCourseNameFeedback";
            this.LableCourseNameFeedback.Size = new System.Drawing.Size(93, 19);
            this.LableCourseNameFeedback.TabIndex = 26;
            this.LableCourseNameFeedback.Text = "Course Name:";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnExit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnExit.Location = new System.Drawing.Point(687, 393);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(74, 34);
            this.BtnExit.Style = MetroFramework.MetroColorStyle.Black;
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnExit.UseSelectable = true;
            this.BtnExit.UseStyleColors = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // formHOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.feedbacktab);
            this.Name = "formHOC";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.formHOC_Load);
            this.feedbacktab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl feedbacktab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton viewfeedbackbtn;
        private System.Windows.Forms.ListView listoffeedback;
        private System.Windows.Forms.ColumnHeader feedbackheader;
        private System.Windows.Forms.ColumnHeader courseidheader;
        private System.Windows.Forms.ColumnHeader nameheader;
        private MetroFramework.Controls.MetroComboBox coursenamedropdown;
        private MetroFramework.Controls.MetroButton searchFeedBack;
        private MetroFramework.Controls.MetroLabel LableCourseNameFeedback;
        private MetroFramework.Controls.MetroButton BtnExit;
    }
}