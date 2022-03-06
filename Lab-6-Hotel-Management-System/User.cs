using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Hotel_Management_System
{
    internal class User
    {
        private int ID;
        private string Name;
        private string Address;
        private string Contact;

        public int getID() { return this.ID; }
        public string getName() { return this.Name; }
        public string getAddress() { return this.Address; }
        public string getContact() { return this.Contact; }

        public User() 
        { 
        }
        public User(string UserID, string Name, string Address,string Contact)
        {
            this.ID = Convert.ToInt32(ID);
            this.Name = Name;
            this.Address = Address;
            this.Contact = Contact;
        }
    }
}
