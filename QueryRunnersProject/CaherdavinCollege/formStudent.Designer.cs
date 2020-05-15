namespace CaherdavinCollege
{
    partial class formStudent
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
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.Feedbackdesc_text = new MetroFramework.Controls.MetroTextBox();
            this.FeedBackFormButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CoursesDropDownList = new MetroFramework.Controls.MetroComboBox();
            this.Coursefbftitle = new MetroFramework.Controls.MetroLabel();
            this.studentNametxtbox = new MetroFramework.Controls.MetroTextBox();
            this.FBFnameTitle = new MetroFramework.Controls.MetroLabel();
            this.studentWholeTab = new MetroFramework.Controls.MetroTabControl();
            this.BtnExit = new MetroFramework.Controls.MetroButton();
            this.metroTabPage1.SuspendLayout();
            this.studentWholeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.Feedbackdesc_text);
            this.metroTabPage1.Controls.Add(this.FeedBackFormButton);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.CoursesDropDownList);
            this.metroTabPage1.Controls.Add(this.Coursefbftitle);
            this.metroTabPage1.Controls.Add(this.studentNametxtbox);
            this.metroTabPage1.Controls.Add(this.FBFnameTitle);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 6;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(581, 253);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Feedback Form";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 7;
            // 
            // Feedbackdesc_text
            // 
            // 
            // 
            // 
            this.Feedbackdesc_text.CustomButton.Image = null;
            this.Feedbackdesc_text.CustomButton.Location = new System.Drawing.Point(43, 2);
            this.Feedbackdesc_text.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.Feedbackdesc_text.CustomButton.Name = "";
            this.Feedbackdesc_text.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.Feedbackdesc_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Feedbackdesc_text.CustomButton.TabIndex = 1;
            this.Feedbackdesc_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Feedbackdesc_text.CustomButton.UseSelectable = true;
            this.Feedbackdesc_text.CustomButton.Visible = false;
            this.Feedbackdesc_text.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Feedbackdesc_text.Lines = new string[0];
            this.Feedbackdesc_text.Location = new System.Drawing.Point(121, 90);
            this.Feedbackdesc_text.MaxLength = 32767;
            this.Feedbackdesc_text.Multiline = true;
            this.Feedbackdesc_text.Name = "Feedbackdesc_text";
            this.Feedbackdesc_text.PasswordChar = '\0';
            this.Feedbackdesc_text.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Feedbackdesc_text.SelectedText = "";
            this.Feedbackdesc_text.SelectionLength = 0;
            this.Feedbackdesc_text.SelectionStart = 0;
            this.Feedbackdesc_text.ShortcutsEnabled = true;
            this.Feedbackdesc_text.Size = new System.Drawing.Size(107, 66);
            this.Feedbackdesc_text.TabIndex = 31;
            this.Feedbackdesc_text.UseSelectable = true;
            this.Feedbackdesc_text.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Feedbackdesc_text.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FeedBackFormButton
            // 
            this.FeedBackFormButton.Location = new System.Drawing.Point(271, 116);
            this.FeedBackFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.FeedBackFormButton.Name = "FeedBackFormButton";
            this.FeedBackFormButton.Size = new System.Drawing.Size(50, 15);
            this.FeedBackFormButton.TabIndex = 9;
            this.FeedBackFormButton.Text = "Send";
            this.FeedBackFormButton.UseSelectable = true;
            this.FeedBackFormButton.Click += new System.EventHandler(this.FeedBackFormButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 110);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Feed Back:";
            // 
            // CoursesDropDownList
            // 
            this.CoursesDropDownList.FormattingEnabled = true;
            this.CoursesDropDownList.ItemHeight = 23;
            this.CoursesDropDownList.Location = new System.Drawing.Point(121, 54);
            this.CoursesDropDownList.Margin = new System.Windows.Forms.Padding(2);
            this.CoursesDropDownList.Name = "CoursesDropDownList";
            this.CoursesDropDownList.Size = new System.Drawing.Size(76, 29);
            this.CoursesDropDownList.TabIndex = 28;
            this.CoursesDropDownList.UseSelectable = true;
            // 
            // Coursefbftitle
            // 
            this.Coursefbftitle.AutoSize = true;
            this.Coursefbftitle.Location = new System.Drawing.Point(32, 54);
            this.Coursefbftitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Coursefbftitle.Name = "Coursefbftitle";
            this.Coursefbftitle.Size = new System.Drawing.Size(57, 19);
            this.Coursefbftitle.TabIndex = 10;
            this.Coursefbftitle.Text = "Course :";
            // 
            // studentNametxtbox
            // 
            // 
            // 
            // 
            this.studentNametxtbox.CustomButton.Image = null;
            this.studentNametxtbox.CustomButton.Location = new System.Drawing.Point(57, 2);
            this.studentNametxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.studentNametxtbox.CustomButton.Name = "";
            this.studentNametxtbox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.studentNametxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.studentNametxtbox.CustomButton.TabIndex = 1;
            this.studentNametxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.studentNametxtbox.CustomButton.UseSelectable = true;
            this.studentNametxtbox.CustomButton.Visible = false;
            this.studentNametxtbox.Lines = new string[0];
            this.studentNametxtbox.Location = new System.Drawing.Point(121, 11);
            this.studentNametxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.studentNametxtbox.MaxLength = 32767;
            this.studentNametxtbox.Name = "studentNametxtbox";
            this.studentNametxtbox.PasswordChar = '\0';
            this.studentNametxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.studentNametxtbox.SelectedText = "";
            this.studentNametxtbox.SelectionLength = 0;
            this.studentNametxtbox.SelectionStart = 0;
            this.studentNametxtbox.ShortcutsEnabled = true;
            this.studentNametxtbox.Size = new System.Drawing.Size(75, 20);
            this.studentNametxtbox.TabIndex = 8;
            this.studentNametxtbox.UseSelectable = true;
            this.studentNametxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.studentNametxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FBFnameTitle
            // 
            this.FBFnameTitle.AutoSize = true;
            this.FBFnameTitle.Location = new System.Drawing.Point(32, 11);
            this.FBFnameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FBFnameTitle.Name = "FBFnameTitle";
            this.FBFnameTitle.Size = new System.Drawing.Size(52, 19);
            this.FBFnameTitle.TabIndex = 7;
            this.FBFnameTitle.Text = "Name :";
            // 
            // studentWholeTab
            // 
            this.studentWholeTab.Controls.Add(this.metroTabPage1);
            this.studentWholeTab.Location = new System.Drawing.Point(22, 86);
            this.studentWholeTab.Margin = new System.Windows.Forms.Padding(2);
            this.studentWholeTab.Name = "studentWholeTab";
            this.studentWholeTab.SelectedIndex = 0;
            this.studentWholeTab.Size = new System.Drawing.Size(589, 295);
            this.studentWholeTab.TabIndex = 1;
            this.studentWholeTab.UseSelectable = true;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnExit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnExit.Location = new System.Drawing.Point(682, 376);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(74, 34);
            this.BtnExit.Style = MetroFramework.MetroColorStyle.Black;
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnExit.UseSelectable = true;
            this.BtnExit.UseStyleColors = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // formStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.studentWholeTab);
            this.Name = "formStudent";
            this.Text = "Welcome Student";
            this.Load += new System.EventHandler(this.formStudent_Load);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.studentWholeTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox Feedbackdesc_text;
        private MetroFramework.Controls.MetroButton FeedBackFormButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox CoursesDropDownList;
        private MetroFramework.Controls.MetroLabel Coursefbftitle;
        private MetroFramework.Controls.MetroTextBox studentNametxtbox;
        private MetroFramework.Controls.MetroLabel FBFnameTitle;
        private MetroFramework.Controls.MetroTabControl studentWholeTab;
        private MetroFramework.Controls.MetroButton BtnExit;
    }
}