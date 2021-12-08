using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class TeachersClass
    {
        private string TeachersID;
        public void setID(string TeachersID)
        {
            this.TeachersID = TeachersID;
        }
        public string getID(string TeachersID)
        {
            return TeachersID;
        }
        private string TeachersName;
        public void setname(string TeachersName)
        {
            this.TeachersName = TeachersName;
        }
        public string getName(string TeachersName)
        {
            return TeachersName;
        }
        private string TeachersDepart;
        public void setdept(string TeachersDepart)
        {
            this.TeachersDepart = TeachersDepart;
        }
        public string getdept(string TeachersDepart)
        {
            return TeachersDepart;
        }
        private string TeachersDesignation;
        public void setdes(string TeachersDesignation)
        {
            this.TeachersDesignation = TeachersDesignation;
        }
        public string getdes(string TeachersDesignation)
        {
            return TeachersDesignation;
        }
        private string TeachersSalary;
        public void setsalary (string TeachersSalary)
        {
            this.TeachersSalary = TeachersSalary;
        }
        public string getsalary(string TeachersSalary)
        {
            return TeachersSalary;
        }


        public string getInfo()
        {
            string teachersInfo = TeachersID + " " + TeachersName + " " + TeachersDepart + " " + TeachersDesignation + " " + TeachersSalary;
            return teachersInfo;
        }

    }
}
