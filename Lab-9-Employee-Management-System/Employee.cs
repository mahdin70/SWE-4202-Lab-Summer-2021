using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Employee_Management_System
{ 
     public class exceptionbyId : ApplicationException
      {
         public exceptionbyId(string message) : base(message)
         {

         }
      }
internal abstract class Employee
    {
        public static int initnumber = 0;
        public string name;
        public int id;
        public string category;
        public string contact;
        public int salary;
        public string joining_date;
        public string leave;
    }
}
