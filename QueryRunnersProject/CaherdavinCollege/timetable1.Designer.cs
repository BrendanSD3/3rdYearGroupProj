namespace CaherdavinCollege
{
    partial class timetable1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this._9to10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._10to11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._11to12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._12to1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._1to2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._2to3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._3to4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._4to5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._5to6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Saveit = new MetroFramework.Controls.MetroButton();
            this.comboBoxModules = new System.Windows.Forms.ComboBox();
            this.Module_LABEL_Timetable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timedropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxLecturers = new System.Windows.Forms.ComboBox();
            this.comboBoxRooms = new System.Windows.Forms.ComboBox();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.listView6 = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Monday9to10 = new System.Windows.Forms.ListBox();
            this.Monday10to11 = new System.Windows.Forms.ListBox();
            this.Monday11to12 = new System.Windows.Forms.ListBox();
            this.Monday12to1 = new System.Windows.Forms.ListBox();
            this.Monday1to2 = new System.Windows.Forms.ListBox();
            this.Monday2to3 = new System.Windows.Forms.ListBox();
            this.Monday3to4 = new System.Windows.Forms.ListBox();
            this.Monday4to5 = new System.Windows.Forms.ListBox();
            this.Monday5to6 = new System.Windows.Forms.ListBox();
            this.Btn_SubmitTimetable = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._9to10,
            this._10to11,
            this._11to12,
            this._12to1,
            this._1to2,
            this._2to3,
            this._3to4,
            this._4to5,
            this._5to6});
            this.tableLayoutPanel1.SetColumnSpan(this.listView1, 9);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1341, 43);
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(200, 30);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // _9to10
            // 
            this._9to10.Text = "9:00-10:00";
            this._9to10.Width = 140;
            // 
            // _10to11
            // 
            this._10to11.Text = "10:00-11:00";
            this._10to11.Width = 145;
            // 
            // _11to12
            // 
            this._11to12.Text = "11:00-12:00";
            this._11to12.Width = 155;
            // 
            // _12to1
            // 
            this._12to1.Text = "12:00-1:00";
            this._12to1.Width = 150;
            // 
            // _1to2
            // 
            this._1to2.Text = "1:00-2:00";
            this._1to2.Width = 145;
            // 
            // _2to3
            // 
            this._2to3.Text = "2:00-3:00";
            this._2to3.Width = 150;
            // 
            // _3to4
            // 
            this._3to4.Text = "3:00-4:00";
            this._3to4.Width = 150;
            // 
            // _4to5
            // 
            this._4to5.Text = "4:00-5:00";
            this._4to5.Width = 150;
            // 
            // _5to6
            // 
            this._5to6.Text = "5:00-6:00";
            this._5to6.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Saveit);
            this.panel1.Controls.Add(this.comboBoxModules);
            this.panel1.Controls.Add(this.Module_LABEL_Timetable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timedropdown);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxLecturers);
            this.panel1.Controls.Add(this.comboBoxRooms);
            this.panel1.Controls.Add(this.comboBoxCourses);
            this.panel1.Controls.Add(this.listView6);
            this.panel1.Controls.Add(this.listView5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listView4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listView3);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.Btn_SubmitTimetable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 1031);
            this.panel1.TabIndex = 1;
            // 
            // Saveit
            // 
            this.Saveit.BackColor = System.Drawing.SystemColors.GrayText;
            this.Saveit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Saveit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Saveit.Highlight = true;
            this.Saveit.Location = new System.Drawing.Point(1168, 789);
            this.Saveit.Name = "Saveit";
            this.Saveit.Size = new System.Drawing.Size(218, 54);
            this.Saveit.TabIndex = 14;
            this.Saveit.Text = "Save timetable as image";
            this.Saveit.UseSelectable = true;
            this.Saveit.Click += new System.EventHandler(this.Saveit_Click);
            // 
            // comboBoxModules
            // 
            this.comboBoxModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModules.FormattingEnabled = true;
            this.comboBoxModules.Location = new System.Drawing.Point(1333, 750);
            this.comboBoxModules.Name = "comboBoxModules";
            this.comboBoxModules.Size = new System.Drawing.Size(121, 32);
            this.comboBoxModules.TabIndex = 13;
            // 
            // Module_LABEL_Timetable
            // 
            this.Module_LABEL_Timetable.AutoSize = true;
            this.Module_LABEL_Timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Module_LABEL_Timetable.Location = new System.Drawing.Point(1211, 754);
            this.Module_LABEL_Timetable.Name = "Module_LABEL_Timetable";
            this.Module_LABEL_Timetable.Size = new System.Drawing.Size(89, 25);
            this.Module_LABEL_Timetable.TabIndex = 12;
            this.Module_LABEL_Timetable.Text = "Module";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 753);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Courses";
            // 
            // timedropdown
            // 
            this.timedropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timedropdown.FormattingEnabled = true;
            this.timedropdown.Location = new System.Drawing.Point(193, 750);
            this.timedropdown.Name = "timedropdown";
            this.timedropdown.Size = new System.Drawing.Size(244, 28);
            this.timedropdown.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 753);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time Slot";
            // 
            // comboBoxLecturers
            // 
            this.comboBoxLecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecturers.FormattingEnabled = true;
            this.comboBoxLecturers.Location = new System.Drawing.Point(1063, 747);
            this.comboBoxLecturers.Name = "comboBoxLecturers";
            this.comboBoxLecturers.Size = new System.Drawing.Size(121, 32);
            this.comboBoxLecturers.TabIndex = 11;
            // 
            // comboBoxRooms
            // 
            this.comboBoxRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRooms.FormattingEnabled = true;
            this.comboBoxRooms.Location = new System.Drawing.Point(801, 746);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(121, 32);
            this.comboBoxRooms.TabIndex = 10;
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(570, 746);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(121, 32);
            this.comboBoxCourses.TabIndex = 9;
            // 
            // listView6
            // 
            this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14});
            this.listView6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView6.Location = new System.Drawing.Point(11, 594);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(119, 68);
            this.listView6.TabIndex = 6;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Friday";
            this.columnHeader14.Width = 109;
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13});
            this.listView5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView5.Location = new System.Drawing.Point(11, 463);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(119, 68);
            this.listView5.TabIndex = 5;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Thursday";
            this.columnHeader13.Width = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(941, 751);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lecturer";
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12});
            this.listView4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView4.Location = new System.Drawing.Point(11, 338);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(119, 68);
            this.listView4.TabIndex = 4;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Wednesday";
            this.columnHeader12.Width = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(718, 753);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Room";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11});
            this.listView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3.Location = new System.Drawing.Point(11, 218);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(119, 68);
            this.listView3.TabIndex = 3;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tuesday";
            this.columnHeader11.Width = 109;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.Location = new System.Drawing.Point(11, 109);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(119, 68);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Monday";
            this.columnHeader1.Width = 109;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.88889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.03704F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Monday9to10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Monday10to11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Monday11to12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Monday12to1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Monday1to2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Monday2to3, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.Monday3to4, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.Monday4to5, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.Monday5to6, 8, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(133, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.499075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.53632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.81037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.29434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.8599F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1353, 658);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Monday9to10
            // 
            this.Monday9to10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Monday9to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday9to10.FormattingEnabled = true;
            this.Monday9to10.ItemHeight = 20;
            this.Monday9to10.Location = new System.Drawing.Point(6, 58);
            this.Monday9to10.Name = "Monday9to10";
            this.Monday9to10.Size = new System.Drawing.Size(138, 106);
            this.Monday9to10.TabIndex = 0;
            // 
            // Monday10to11
            // 
            this.Monday10to11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Monday10to11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday10to11.FormattingEnabled = true;
            this.Monday10to11.ItemHeight = 20;
            this.Monday10to11.Location = new System.Drawing.Point(153, 58);
            this.Monday10to11.Name = "Monday10to11";
            this.Monday10to11.Size = new System.Drawing.Size(140, 106);
            this.Monday10to11.TabIndex = 1;
            // 
            // Monday11to12
            // 
            this.Monday11to12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Monday11to12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday11to12.FormattingEnabled = true;
            this.Monday11to12.ItemHeight = 20;
            this.Monday11to12.Location = new System.Drawing.Point(302, 58);
            this.Monday11to12.Name = "Monday11to12";
            this.Monday11to12.Size = new System.Drawing.Size(141, 106);
            this.Monday11to12.TabIndex = 2;
            // 
            // Monday12to1
            // 
            this.Monday12to1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Monday12to1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday12to1.FormattingEnabled = true;
            this.Monday12to1.ItemHeight = 20;
            this.Monday12to1.Location = new System.Drawing.Point(452, 58);
            this.Monday12to1.Name = "Monday12to1";
            this.Monday12to1.Size = new System.Drawing.Size(141, 106);
            this.Monday12to1.TabIndex = 3;
            // 
            // Monday1to2
            // 
            this.Monday1to2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Monday1to2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday1to2.FormattingEnabled = true;
            this.Monday1to2.ItemHeight = 20;
            this.Monday1to2.Location = new System.Drawing.Point(602, 58);
            this.Monday1to2.Name = "Monday1to2";
            this.Monday1to2.Size = new System.Drawing.Size(141, 106);
            this.Monday1to2.TabIndex = 4;
            // 
            // Monday2to3
            // 
            this.Monday2to3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Monday2to3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday2to3.FormattingEnabled = true;
            this.Monday2to3.ItemHeight = 20;
            this.Monday2to3.Location = new System.Drawing.Point(752, 58);
            this.Monday2to3.Name = "Monday2to3";
            this.Monday2to3.Size = new System.Drawing.Size(141, 106);
            this.Monday2to3.TabIndex = 5;
            // 
            // Monday3to4
            // 
            this.Monday3to4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Monday3to4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday3to4.FormattingEnabled = true;
            this.Monday3to4.ItemHeight = 20;
            this.Monday3to4.Location = new System.Drawing.Point(902, 58);
            this.Monday3to4.Name = "Monday3to4";
            this.Monday3to4.Size = new System.Drawing.Size(141, 106);
            this.Monday3to4.TabIndex = 6;
            // 
            // Monday4to5
            // 
            this.Monday4to5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Monday4to5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday4to5.FormattingEnabled = true;
            this.Monday4to5.ItemHeight = 20;
            this.Monday4to5.Location = new System.Drawing.Point(1052, 58);
            this.Monday4to5.Name = "Monday4to5";
            this.Monday4to5.Size = new System.Drawing.Size(141, 106);
            this.Monday4to5.TabIndex = 7;
            // 
            // Monday5to6
            // 
            this.Monday5to6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Monday5to6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday5to6.FormattingEnabled = true;
            this.Monday5to6.ItemHeight = 20;
            this.Monday5to6.Location = new System.Drawing.Point(1202, 58);
            this.Monday5to6.Name = "Monday5to6";
            this.Monday5to6.Size = new System.Drawing.Size(145, 106);
            this.Monday5to6.TabIndex = 8;
            // 
            // Btn_SubmitTimetable
            // 
            this.Btn_SubmitTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SubmitTimetable.Location = new System.Drawing.Point(1392, 789);
            this.Btn_SubmitTimetable.Name = "Btn_SubmitTimetable";
            this.Btn_SubmitTimetable.Size = new System.Drawing.Size(112, 54);
            this.Btn_SubmitTimetable.TabIndex = 4;
            this.Btn_SubmitTimetable.Text = "Submit";
            this.Btn_SubmitTimetable.UseVisualStyleBackColor = true;
            this.Btn_SubmitTimetable.Click += new System.EventHandler(this.btntimetable_click);
            // 
            // timetable1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 1031);
            this.Controls.Add(this.panel1);
            this.Name = "timetable1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "timetable1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader _9to10;
        private System.Windows.Forms.ColumnHeader _10to11;
        private System.Windows.Forms.ColumnHeader _11to12;
        private System.Windows.Forms.ColumnHeader _12to1;
        private System.Windows.Forms.ColumnHeader _1to2;
        private System.Windows.Forms.ColumnHeader _2to3;
        private System.Windows.Forms.ColumnHeader _3to4;
        private System.Windows.Forms.ColumnHeader _4to5;
        private System.Windows.Forms.ColumnHeader _5to6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox Monday9to10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_SubmitTimetable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListBox Monday10to11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox timedropdown;
        private System.Windows.Forms.ListBox Monday11to12;
        private System.Windows.Forms.ListBox Monday12to1;
        private System.Windows.Forms.ListBox Monday1to2;
        private System.Windows.Forms.ListBox Monday2to3;
        private System.Windows.Forms.ListBox Monday3to4;
        private System.Windows.Forms.ListBox Monday4to5;
        private System.Windows.Forms.ListBox Monday5to6;
        private System.Windows.Forms.ComboBox comboBoxLecturers;
        private System.Windows.Forms.ComboBox comboBoxRooms;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.ComboBox comboBoxModules;
        private System.Windows.Forms.Label Module_LABEL_Timetable;
        private MetroFramework.Controls.MetroButton Saveit;
    }
}

