using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_LMS_System
{
    internal class Lecturer:Teacher
    {
        private List<Course> lab_courses = new List<Course>();
        private static double lab_credit = 1.5;

      
        public void AddCourse(Course dummy_course)
        {
            this.lab_courses.Add(dummy_course);
        }

        public List<Course> getCourseList()
        {
            return this.lab_courses;
        }

     
        public double CalcCredit()
        {
            return lab_credit * lab_courses.Count;
        }

        public override void setTeacherType()
        {
            this.teacher_type = "Lecturer";
        }

   
        public Lecturer(string teacher_name) : base(teacher_name)
        {
            setTeacherType();
        }
    }
}
