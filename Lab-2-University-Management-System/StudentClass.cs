using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class StudentClass
    {
        private string studentsID;
        public void setID(string studentsID)
        {
            this.studentsID = studentsID;
        }
        public string getID(string studentsID)
        {
            return studentsID;  
        }
        private string studentsName;
        public void setName(string studentsName)
        {
            this.studentsName = studentsName;
        }
        public string getName(string studentName)
        {
            return studentsName;
        }

        private string studentsSemester;
        public void setSem(string studentsSemester)
        {
            this.studentsSemester = studentsSemester;
        }
        public string getSem(string studentsSemester)
        {
            return studentsSemester;
        }
        private string studentsDepart;
        public void setdept(string studentsDepart)
        {
            this.studentsDepart = studentsDepart;
        }
        public string getdept(string studentsDepart)
        {
            return studentsDepart;
        }

        public string getInfo()
        {
            string stdInfo = studentsID + " " + studentsName + " " + studentsSemester + " " + studentsDepart;
            return stdInfo;
        }
    }   
}
