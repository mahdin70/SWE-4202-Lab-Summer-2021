using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Hotel_Management_System
{
    internal class Booking
    {
        private int ID;
        private User user;
        private string Room;
        public int RoomNo;
        private int Quantity;
        private string Entry;
        private string Departure;
        private string Status;

        public int getID() { return this.ID; }
        public string getRoom() { return this.Room; }
        public int getQuantity() { return this.Quantity;}
        public string getName() { return user.getName(); }
        public string getAddress() { return user.getAddress(); }

        public string getStatus() { return this.Status; }
        public int getRoomNo() { return RoomNo; }
        public void setRoomNo(int RoomNo) { this.RoomNo = RoomNo; }
        public void setStatus(string Status) { this.Status = Status; }
        public void setID(int ID) { this.ID =ID; }

        public int getCost()
        {
            switch (Room)
            {
                case "Single": return Quantity * 2000;
                case "Double": return Quantity * 2500;
                case "Deluxe": return Quantity * 3000;
                case "Suite": return Quantity * 3500;
                default:return 0;
            }
        }
        public string getInfo()
        {
            return Room+ "        " + Quantity.ToString() + "        " + getCost().ToString() + "        " + getStatus();
        }
        public Booking(string ID, string Room, string Quantity, string Entry, string Departure)
        {
            foreach (User i in HMS.Userlist)
            {
                if (i.getID() == Convert.ToInt32(ID))
                {
                   this.user = i;
                   break;
                }
            }
            this.Room = Room;
            this.Quantity = Convert.ToInt32(Quantity);
            this.Entry = Entry;
            this.Departure = Departure;
        }
        public Booking() { }
    }
}
