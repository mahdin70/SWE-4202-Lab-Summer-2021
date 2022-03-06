using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_CSV
{
    public class Employee
    {
        private string employeeID, firstname, lastname, email, phonenumber, hiring, jobID, salary, managerID, deptID, commission;
        public Employee(string employeeID, string firstname, string lastname, string email, string phonenumber, string hiring, string jobID, string salary, string managerID, string deptID, string commission)
        {
            this.employeeID = employeeID;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phonenumber = phonenumber;
            this.hiring = hiring;
            this.jobID = jobID;
            this.salary = salary;
            this.managerID = managerID;
            this.deptID = deptID;
            this.commission = commission;
        }

        public string getInfo()
        {
            return this.employeeID + " " + "\t" + this.firstname + " " + this.lastname;
        }
        public string getEmployeeID()
        {
            return this.employeeID;
        }

        public string getDetailedInformation()
        {
            return "Employee ID: " + this.employeeID + "\n" + "Name: " + this.firstname + " " + this.lastname + "\n" + "Salary: " + this.salary + "\n";
        }
    }
}
