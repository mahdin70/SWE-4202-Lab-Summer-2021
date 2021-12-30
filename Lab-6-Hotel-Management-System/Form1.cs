using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6_Hotel_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Account(object sender, EventArgs e)
        {
            User temp = new User(tb_Create_UserID.Text, tb_Create_Name.Text, tb_Create_Address.Text,tb_Create_Contact.Text );
            HMS.Userlist.Add( temp );
            MessageBox.Show("Account Has been Created Successfully");
        }

        private void Set_Status(object sender, EventArgs e)
        {
            foreach (Booking i in HMS.Bookinglist)
            {
                if (i.getID() ==Convert.ToInt32(tb_OS_BookingID.Text))
                {
                   if (cb_OS_SetStatus.Text == "Confirmed")
                    {
                        i.setRoomNo(HMS.RoomNo);
                        HMS.RoomNo++;
                        HMS.Balance += i.getCost();
                        MessageBox.Show("Status Updated Succesfully");
                    }
                   i.setStatus(cb_OS_SetStatus.Text);
                   tb_OS_CurrentBalance.Text = HMS.Balance.ToString();
                   if (cb_OS_SetStatus.Text == "Pending")                
                      MessageBox.Show("Status Updated Succesfully");
                      return;
                }
            }                     
        }

        private void Place_Booking(object sender, EventArgs e)
        {
            Booking temp = new Booking(tb_Booking_UserID.Text, cb_Booking_Room.Text, cb_Booking_Quantity.Text, DT_Entry.Text, DT_Departure.Text);
            temp.setID(HMS.Bookinglist.Count+1);
            temp.setStatus("Pending");
            HMS.Bookinglist.Add(temp); 
            MessageBox.Show("Booking Completed.\nBooking ID : "+ temp.getID());          
        }

        private void RoomDetailsOnClick(object sender, EventArgs e)
        {
            lb_Room_Details.Items.Clear();
            foreach (Booking i in HMS.Bookinglist)
            {
                lb_Room_Details.Items.Add(i.getInfo());
            }

        }

        private void BookingDetailsOnClick(object sender, EventArgs e)
        {
            foreach (Booking i in HMS.Bookinglist)
            {
                if (i.getID() == int.Parse(tb_RD_BookingID.Text))
                {
                    tb_RD_Status.Text = i.getStatus();
                    if (i.getRoomNo() == 0)
                      tb_RD_RoomNo.Text = "Null";
                    else
                      tb_RD_Name.Text = i.getName();
                      tb_RD_Address.Text = i.getAddress();
                      tb_RD_RoomNo.Text = i.getRoomNo().ToString();
                      tb_RD_Amount.Text = i.getCost().ToString();
                                          
                }
            }
        }
    }
}
