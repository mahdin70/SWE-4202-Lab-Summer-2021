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
        public string getID(string TeachersID)
        {
            return TeachersID;
        }
        public void setID(string TeachersID)
        {
            this.TeachersID = TeachersID;
        }

        private string TeachersName;
        public string getName(string TeachersName)
        {
            return TeachersName;
        }
        public void setname(string TeachersName)
        {
            this.TeachersName = TeachersName;
        }

        private string TeachersDepart;
        public string getdept(string TeachersDepart)
        {
            return TeachersDepart;
        }
        public void setdept(string TeachersDepart)
        {
            this.TeachersDepart = TeachersDepart;
        }

        private string TeachersDesignation;
        public string getdes(string TeachersDesignation)
        {
            return TeachersDesignation;
        }
        public void setdes(string TeachersDesignation)
        {
            this.TeachersDesignation = TeachersDesignation;
        }

        private string TeachersSalary;
        public string getsalary(string TeachersSalary)
        {
            return TeachersSalary;
        }
        public void setsalary (string TeachersSalary)
        {
            this.TeachersSalary = TeachersSalary;
        }
       

        public string getInfo()
        {
            string teachersInfo = TeachersID + " " + TeachersName + " " + TeachersDepart + " " + TeachersDesignation + " " + TeachersSalary;
            return teachersInfo;
        }

    }
}
