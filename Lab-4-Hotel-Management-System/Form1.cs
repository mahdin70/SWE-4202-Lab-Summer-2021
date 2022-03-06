using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        List<SingleRoom> SingleRoomlist = new List<SingleRoom>();
        List<DoubleRoom> DoubleRoomlist = new List<DoubleRoom>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddSingleRoomOnClick(object sender, EventArgs e)
        {

            SingleRoom dummy = new SingleRoom(tb_SName.Text,tb_STV.Text,tb_SRefrigerator.Text,tb_SQuantity.Text,cb_singleac.Text, cb_gamingsetup.Text);
            foreach (SingleRoom i in SingleRoomlist)
            {
                if (i.getname() == dummy.getname())
                {
                    i.setcount(i.getcount() + dummy.getcount());
                    string show1 = "You have created " + dummy.getcount().ToString() + " " + dummy.getname();
                    show1 += " rooms which cost " + dummy.calculatecost().ToString() + " per day.";
                    MessageBox.Show(show1);
                    return;
                }
            }
            cb_RentName.Items.Add(dummy.getname());
            SingleRoomlist.Add(dummy);
            string show2 = "You have created " + dummy.getcount().ToString() + " " + dummy.getname();
            show2 += " rooms which cost " + dummy.calculatecost().ToString() + " per day.";
            MessageBox.Show(show2);

        }

        private void AddDoubleRoomOnClick(object sender, EventArgs e)
        {
            DoubleRoom dummy = new DoubleRoom(tb_DName.Text, tb_DTV.Text, tb_DRefrigerator.Text, tb_DQuantity.Text, cb_doubleac.Text, cb_DoubleExtraTV.Text, cb_DoubleBreakfast.Text );
            foreach (DoubleRoom i in DoubleRoomlist)
            {
                if (i.getname() == dummy.getname())
                {
                    i.setcount(i.getcount() + dummy.getcount());
                    string show3 = "You have created " + dummy.getcount().ToString() + " " + dummy.getname();
                    show3 += " rooms which cost " + dummy.calculatecost().ToString() + " per day.";
                    MessageBox.Show(show3);
                    return;
                }
            }
            cb_RentName.Items.Add(dummy.getname());
            DoubleRoomlist.Add(dummy);
            string show4 = "You have created " + dummy.getcount().ToString() + " " + dummy.getname();
            show4 += " rooms which cost " + dummy.calculatecost().ToString() + " per day.";
            MessageBox.Show(show4);
         }

        private void RentRoomOnClick(object sender, EventArgs e)
        {
            foreach (SingleRoom i in SingleRoomlist)
            {
                if (i.getname() == cb_RentName.Text)
                {
                    if (i.getcount() - Convert.ToInt32(tb_RentQuantity.Text) < 0)
                    {
                        MessageBox.Show(i.getcount() + " rooms are available.");
                        return;
                    }
                    i.setcount(i.getcount() - Convert.ToInt32(tb_RentQuantity.Text));
                    string show = "Successfully rented " + tb_RentQuantity.Text + " " + i.getname() + " rooms.";
                    MessageBox.Show(show);
                    return;
                }
            }

            foreach (DoubleRoom i in DoubleRoomlist)
            {
                if (i.getname() == cb_RentName.Text)
                {
                    if (i.getcount() - Convert.ToInt32(tb_RentQuantity.Text) < 0)
                    {
                        MessageBox.Show(i.getcount() + " rooms are available.");
                        return;
                    }
                    i.setcount(i.getcount() - Convert.ToInt32(tb_RentQuantity.Text));
                    string show = "Successfully rented " + tb_RentQuantity.Text + " " + i.getname() + " rooms.";
                    MessageBox.Show(show);
                    return;
                }
            }
        }

        private void ShowAvailabilityOnClick(object sender, EventArgs e)
        {
            foreach (SingleRoom i in SingleRoomlist)
            {
                if (i.getname() == tb_Avail.Text)
                {
                    MessageBox.Show(i.getcount().ToString() + " " + i.getname() + " rooms are available.");
                    return;
                }
            }
            foreach (DoubleRoom i in DoubleRoomlist)
            {
                if (i.getname() == tb_Avail.Text)
                {
                    MessageBox.Show(i.getcount().ToString() + " " + i.getname() + " rooms are available.");
                    return;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
