using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Student_Course_Enrollment
{
    public class Student : Participant
    {
        public int getCourseFee(int Fee)
        {
            this.Fee = Fee;
            return Fee;
        }
        public Student(string Name, string Reg, string Contact, string Email, string Level)
        {
            this.Name = Name;
            this.Reg = Reg;
            this.Contact = Contact;
            this.Email = Email;
            this.Level = Level;
        }
        public Student(string Name, string Reg, string Contact, string Email)
        {
            this.Name = Name;
            this.Reg = Reg;
            this.Contact = Contact;
            this.Email = Email;
            this.Level = "Beginner";
        }
    }
}
