using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Student_Course_Enrollment
{
    public class Professional : Participant
    {
        public double getCourseFee(int Fee)
        {
            double ExtraFee = Fee * 0.1;
            return Fee + ExtraFee;
            this.Fee = Fee + ExtraFee;
        }
        public Professional(string Name, string Reg, string Contact, string Email, string Level)
        {
            this.Name = Name;
            this.Reg = Reg;
            this.Contact = Contact;
            this.Email = Email;
            this.Level = Level;
        }
        public Professional(string Name, string Reg, string Contact, string Email)
        {
            this.Name = Name;
            this.Reg = Reg;
            this.Contact = Contact;
            this.Email = Email;
            this.Level = "Beginner";
        }
    }
}
