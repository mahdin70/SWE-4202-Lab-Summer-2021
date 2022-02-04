using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Employee_Management_System
{
    internal class Manager : Employee
    {
        public Manager(string name, string contact, string joining_date, string leave, int salary)
        {
            id = initnumber++;
            this.name = name;
            category = "Manager";
            this.contact = contact;
            this.joining_date = joining_date;
            this.leave = leave;
            this.salary = salary;
        }
    }
}