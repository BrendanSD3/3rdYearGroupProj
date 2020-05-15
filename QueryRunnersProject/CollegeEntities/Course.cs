using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public class Course:ICourse
    {
        private string courseID;
        private string name;
        private string deptID;
        private double priceNonEU;
        private double priceEU;
        private string desc;
        private int points;
        private int capacity;
        private int curCapacity;
        private int isNightCourse;


        public Course(string c_id, string N, string Dept_id, double NonEU, double EU, string c_desc, int c_points, int Capacity, int curcap, int isnight)
        {
            this.CourseID = c_id;
            this.Name = N;
            this.DeptID = Dept_id;
            this.PriceNonEU = NonEU;
            this.PriceEU = EU;
            this.Desc = c_desc;
            this.Points = c_points;
            this.capacity = Capacity;
            this.CurCapacity = curcap;
            this.isNightCourse = isnight;
        }

        public int IsNightCourse { get { return this.isNightCourse; } set { this.isNightCourse = value; } }
        public string CourseID { get => courseID; set => courseID = value; }
        public string Name { get => name; set => name = value; }
        public string DeptID { get => deptID; set => deptID = value; }
        public double PriceNonEU { get => priceNonEU; set => priceNonEU = value; }
        public double PriceEU { get => priceEU; set => priceEU = value; }
        public string Desc { get => desc; set => desc = value; }
        public int Points { get => points; set => points = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int CurCapacity { get => curCapacity; set => curCapacity = value; }


        //#region InstanceProperties
        //public string CourseID
        //{
        //    get
        //    {
        //        return this.courseID;
        //    }
        //    set
        //    {
        //        this.courseID = value;
        //    }
        //}
        //public string Name
        //{
        //    get
        //    {
        //        return this.name;


        //    }
        //    set
        //    {
        //        this.name = value;
        //    }
        //}
        //public string DeptID
        //{
        //    get
        //    {
        //        return this.deptID;


        //    }

        //    set
        //    {
        //        this.deptID = value;

        //    }

        //}
        //public double PriceNonEU
        //{
        //    get
        //    {
        //        return this.priceNonEU;
        //    }
        //    set
        //    {
        //        this.priceNonEU = value;
        //    }
        //}

        //public double PriceEU
        //{
        //    get
        //    {
        //        return this.priceEU;
        //    }
        //    set
        //    {
        //        this.priceEU = value;
        //    }
        //}
        ////public int courseYr
        ////{

        ////    get
        ////    {
        ////        return this.courseYear;
        ////    }
        ////    set
        ////    {
        ////        this.courseYear = value;

        ////    }


        ////}




        //#endregion



    }
}
