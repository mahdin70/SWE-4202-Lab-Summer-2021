using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Student_Course_Enrollment
{
    public class Course
    {
        public string Title, Level, EnrollDate;
        public int Fee;
        public Course(string Title, string Level, int Fee)
        {
            this.Title = Title;
            this.Level = Level;
            this.Fee = Fee;
        }
        public string getCourseInfo()
        {
            string Info = Title + "\t" + Level + "\t" + EnrollDate;
            return Info;
        }
    }
}
