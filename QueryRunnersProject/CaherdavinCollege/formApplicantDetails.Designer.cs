namespace CaherdavinCollege
{
    partial class formApplicantDetails
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
            this.ComboBoxYear = new MetroFramework.Controls.MetroComboBox();
            this.ComboBoxMonth = new MetroFramework.Controls.MetroComboBox();
            this.ComboBoxDay = new MetroFramework.Controls.MetroComboBox();
            this.LabelDOB = new MetroFramework.Controls.MetroLabel();
            this.ButtonSubmit = new MetroFramework.Controls.MetroButton();
            this.ButtonExit = new MetroFramework.Controls.MetroButton();
            this.LabelChosenCourse = new MetroFramework.Controls.MetroLabel();
            this.RadioButtonPartTime = new MetroFramework.Controls.MetroRadioButton();
            this.RadioButtonFullTime = new MetroFramework.Controls.MetroRadioButton();
            this.CheckBoxEU = new MetroFramework.Controls.MetroCheckBox();
            this.TextBoxPoints = new MetroFramework.Controls.MetroTextBox();
            this.LabelPoints = new MetroFramework.Controls.MetroLabel();
            this.TextBoxLastname = new MetroFramework.Controls.MetroTextBox();
            this.LabelLastname = new MetroFramework.Controls.MetroLabel();
            this.TextBoxFirstName = new MetroFramework.Controls.MetroTextBox();
            this.LabelFirstname = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ComboBoxYear
            // 
            this.ComboBoxYear.FormattingEnabled = true;
            this.ComboBoxYear.ItemHeight = 24;
            this.ComboBoxYear.Location = new System.Drawing.Point(437, 335);
            this.ComboBoxYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxYear.Name = "ComboBoxYear";
            this.ComboBoxYear.Size = new System.Drawing.Size(80, 30);
            this.ComboBoxYear.TabIndex = 32;
            this.ComboBoxYear.UseSelectable = true;
            // 
            // ComboBoxMonth
            // 
            this.ComboBoxMonth.FormattingEnabled = true;
            this.ComboBoxMonth.ItemHeight = 24;
            this.ComboBoxMonth.Location = new System.Drawing.Point(387, 335);
            this.ComboBoxMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxMonth.Name = "ComboBoxMonth";
            this.ComboBoxMonth.Size = new System.Drawing.Size(41, 30);
            this.ComboBoxMonth.TabIndex = 31;
            this.ComboBoxMonth.UseSelectable = true;
            this.ComboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMonth_SelectedIndexChanged);
            // 
            // ComboBoxDay
            // 
            this.ComboBoxDay.FormattingEnabled = true;
            this.ComboBoxDay.ItemHeight = 24;
            this.ComboBoxDay.Location = new System.Drawing.Point(321, 335);
            this.ComboBoxDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxDay.Name = "ComboBoxDay";
            this.ComboBoxDay.Size = new System.Drawing.Size(56, 30);
            this.ComboBoxDay.TabIndex = 30;
            this.ComboBoxDay.UseSelectable = true;
            // 
            // LabelDOB
            // 
            this.LabelDOB.AutoSize = true;
            this.LabelDOB.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelDOB.Location = new System.Drawing.Point(104, 335);
            this.LabelDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDOB.Name = "LabelDOB";
            this.LabelDOB.Size = new System.Drawing.Size(112, 25);
            this.LabelDOB.TabIndex = 29;
            this.LabelDOB.Text = "Date of Birth";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(411, 574);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(108, 48);
            this.ButtonSubmit.TabIndex = 28;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseSelectable = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(167, 574);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(108, 48);
            this.ButtonExit.TabIndex = 27;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseSelectable = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LabelChosenCourse
            // 
            this.LabelChosenCourse.AutoSize = true;
            this.LabelChosenCourse.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelChosenCourse.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelChosenCourse.Location = new System.Drawing.Point(180, 92);
            this.LabelChosenCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelChosenCourse.Name = "LabelChosenCourse";
            this.LabelChosenCourse.Size = new System.Drawing.Size(112, 25);
            this.LabelChosenCourse.TabIndex = 26;
            this.LabelChosenCourse.Text = "description";
            // 
            // RadioButtonPartTime
            // 
            this.RadioButtonPartTime.AutoSize = true;
            this.RadioButtonPartTime.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.RadioButtonPartTime.Location = new System.Drawing.Point(383, 468);
            this.RadioButtonPartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioButtonPartTime.Name = "RadioButtonPartTime";
            this.RadioButtonPartTime.Size = new System.Drawing.Size(176, 25);
            this.RadioButtonPartTime.TabIndex = 25;
            this.RadioButtonPartTime.Text = "Part Time Student";
            this.RadioButtonPartTime.UseSelectable = true;
            // 
            // RadioButtonFullTime
            // 
            this.RadioButtonFullTime.AutoSize = true;
            this.RadioButtonFullTime.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.RadioButtonFullTime.Location = new System.Drawing.Point(104, 468);
            this.RadioButtonFullTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioButtonFullTime.Name = "RadioButtonFullTime";
            this.RadioButtonFullTime.Size = new System.Drawing.Size(173, 25);
            this.RadioButtonFullTime.TabIndex = 24;
            this.RadioButtonFullTime.Text = "Full Time Student";
            this.RadioButtonFullTime.UseSelectable = true;
            // 
            // CheckBoxEU
            // 
            this.CheckBoxEU.AutoSize = true;
            this.CheckBoxEU.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.CheckBoxEU.Location = new System.Drawing.Point(104, 391);
            this.CheckBoxEU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxEU.Name = "CheckBoxEU";
            this.CheckBoxEU.Size = new System.Drawing.Size(228, 25);
            this.CheckBoxEU.TabIndex = 23;
            this.CheckBoxEU.Text = "Are you born in the EU?";
            this.CheckBoxEU.UseSelectable = true;
            // 
            // TextBoxPoints
            // 
            // 
            // 
            // 
            this.TextBoxPoints.CustomButton.Image = null;
            this.TextBoxPoints.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.TextBoxPoints.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxPoints.CustomButton.Name = "";
            this.TextBoxPoints.CustomButton.Size = new System.Drawing.Size(47, 43);
            this.TextBoxPoints.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxPoints.CustomButton.TabIndex = 1;
            this.TextBoxPoints.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxPoints.CustomButton.UseSelectable = true;
            this.TextBoxPoints.CustomButton.Visible = false;
            this.TextBoxPoints.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TextBoxPoints.Lines = new string[0];
            this.TextBoxPoints.Location = new System.Drawing.Point(321, 273);
            this.TextBoxPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxPoints.MaxLength = 32767;
            this.TextBoxPoints.Name = "TextBoxPoints";
            this.TextBoxPoints.PasswordChar = '\0';
            this.TextBoxPoints.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPoints.SelectedText = "";
            this.TextBoxPoints.SelectionLength = 0;
            this.TextBoxPoints.SelectionStart = 0;
            this.TextBoxPoints.ShortcutsEnabled = true;
            this.TextBoxPoints.Size = new System.Drawing.Size(197, 37);
            this.TextBoxPoints.TabIndex = 22;
            this.TextBoxPoints.UseSelectable = true;
            this.TextBoxPoints.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxPoints.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxPoints.TextChanged += new System.EventHandler(this.TextBoxNumberCheck_TextChanged);
            this.TextBoxPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPoints_KeyPress);
            // 
            // LabelPoints
            // 
            this.LabelPoints.AutoSize = true;
            this.LabelPoints.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelPoints.Location = new System.Drawing.Point(104, 279);
            this.LabelPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPoints.Name = "LabelPoints";
            this.LabelPoints.Size = new System.Drawing.Size(166, 25);
            this.LabelPoints.TabIndex = 21;
            this.LabelPoints.Text = "Leaving Cert Points";
            // 
            // TextBoxLastname
            // 
            // 
            // 
            // 
            this.TextBoxLastname.CustomButton.Image = null;
            this.TextBoxLastname.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.TextBoxLastname.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxLastname.CustomButton.Name = "";
            this.TextBoxLastname.CustomButton.Size = new System.Drawing.Size(47, 43);
            this.TextBoxLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxLastname.CustomButton.TabIndex = 1;
            this.TextBoxLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxLastname.CustomButton.UseSelectable = true;
            this.TextBoxLastname.CustomButton.Visible = false;
            this.TextBoxLastname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TextBoxLastname.Lines = new string[0];
            this.TextBoxLastname.Location = new System.Drawing.Point(321, 214);
            this.TextBoxLastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxLastname.MaxLength = 32767;
            this.TextBoxLastname.Name = "TextBoxLastname";
            this.TextBoxLastname.PasswordChar = '\0';
            this.TextBoxLastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxLastname.SelectedText = "";
            this.TextBoxLastname.SelectionLength = 0;
            this.TextBoxLastname.SelectionStart = 0;
            this.TextBoxLastname.ShortcutsEnabled = true;
            this.TextBoxLastname.Size = new System.Drawing.Size(197, 37);
            this.TextBoxLastname.TabIndex = 20;
            this.TextBoxLastname.UseSelectable = true;
            this.TextBoxLastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxLastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LabelLastname
            // 
            this.LabelLastname.AutoSize = true;
            this.LabelLastname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelLastname.Location = new System.Drawing.Point(104, 214);
            this.LabelLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLastname.Name = "LabelLastname";
            this.LabelLastname.Size = new System.Drawing.Size(96, 25);
            this.LabelLastname.TabIndex = 19;
            this.LabelLastname.Text = "Last Name";
            // 
            // TextBoxFirstName
            // 
            // 
            // 
            // 
            this.TextBoxFirstName.CustomButton.Image = null;
            this.TextBoxFirstName.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.TextBoxFirstName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxFirstName.CustomButton.Name = "";
            this.TextBoxFirstName.CustomButton.Size = new System.Drawing.Size(47, 43);
            this.TextBoxFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxFirstName.CustomButton.TabIndex = 1;
            this.TextBoxFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxFirstName.CustomButton.UseSelectable = true;
            this.TextBoxFirstName.CustomButton.Visible = false;
            this.TextBoxFirstName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TextBoxFirstName.Lines = new string[0];
            this.TextBoxFirstName.Location = new System.Drawing.Point(321, 154);
            this.TextBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxFirstName.MaxLength = 32767;
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.PasswordChar = '\0';
            this.TextBoxFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxFirstName.SelectedText = "";
            this.TextBoxFirstName.SelectionLength = 0;
            this.TextBoxFirstName.SelectionStart = 0;
            this.TextBoxFirstName.ShortcutsEnabled = true;
            this.TextBoxFirstName.Size = new System.Drawing.Size(197, 37);
            this.TextBoxFirstName.TabIndex = 18;
            this.TextBoxFirstName.UseSelectable = true;
            this.TextBoxFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LabelFirstname
            // 
            this.LabelFirstname.AutoSize = true;
            this.LabelFirstname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelFirstname.Location = new System.Drawing.Point(104, 160);
            this.LabelFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFirstname.Name = "LabelFirstname";
            this.LabelFirstname.Size = new System.Drawing.Size(97, 25);
            this.LabelFirstname.TabIndex = 17;
            this.LabelFirstname.Text = "First Name";
            // 
            // formApplicantDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 654);
            this.Controls.Add(this.ComboBoxYear);
            this.Controls.Add(this.ComboBoxMonth);
            this.Controls.Add(this.ComboBoxDay);
            this.Controls.Add(this.LabelDOB);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelChosenCourse);
            this.Controls.Add(this.RadioButtonPartTime);
            this.Controls.Add(this.RadioButtonFullTime);
            this.Controls.Add(this.CheckBoxEU);
            this.Controls.Add(this.TextBoxPoints);
            this.Controls.Add(this.LabelPoints);
            this.Controls.Add(this.TextBoxLastname);
            this.Controls.Add(this.LabelLastname);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.LabelFirstname);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1107, 654);
            this.Name = "formApplicantDetails";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Enter your Details";
            this.Load += new System.EventHandler(this.formApplicantDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ComboBoxYear;
        private MetroFramework.Controls.MetroComboBox ComboBoxMonth;
        private MetroFramework.Controls.MetroComboBox ComboBoxDay;
        private MetroFramework.Controls.MetroLabel LabelDOB;
        private MetroFramework.Controls.MetroButton ButtonSubmit;
        private MetroFramework.Controls.MetroButton ButtonExit;
        private MetroFramework.Controls.MetroLabel LabelChosenCourse;
        private MetroFramework.Controls.MetroRadioButton RadioButtonPartTime;
        private MetroFramework.Controls.MetroRadioButton RadioButtonFullTime;
        private MetroFramework.Controls.MetroCheckBox CheckBoxEU;
        private MetroFramework.Controls.MetroTextBox TextBoxPoints;
        private MetroFramework.Controls.MetroLabel LabelPoints;
        private MetroFramework.Controls.MetroTextBox TextBoxLastname;
        private MetroFramework.Controls.MetroLabel LabelLastname;
        private MetroFramework.Controls.MetroTextBox TextBoxFirstName;
        private MetroFramework.Controls.MetroLabel LabelFirstname;
    }
}