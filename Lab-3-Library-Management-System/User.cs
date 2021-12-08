using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class User
    {
        public string UserID;
        public string UserName;
        public string Address;
        public string BookID;
        public string BookName;
        public string GetInfo()
        {
            string ReturnValue = UserID + "\t" + UserName + "\t" + BookID + "\t" + BookName;
            return ReturnValue;
        }
    }
}
