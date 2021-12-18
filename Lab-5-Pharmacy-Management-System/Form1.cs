using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        List<Medicine> medicines = new List<Medicine>();
        public Form1()
        {
            InitializeComponent();
        }
        private int money = 0;
        private void AddMoneyOnClick(object sender, EventArgs e)
        {
            if (NUM_WalletAmount.Value <= 0)
            {
                MessageBox.Show("Please Enter a valid amount.");
                return;
            }
            money += (int)NUM_WalletAmount.Value;
            MessageBox.Show("Money has been added to your wallet"); 
        }

        private void ClearWalletOnClick(object sender, EventArgs e)
        {
            NUM_WalletAmount.ResetText();
            MessageBox.Show("Cleared Successfully");
        }

        private void ShowBalance(object sender, EventArgs e)
        {
            MessageBox.Show("Your Current Balance is BDT " + money.ToString() + ".");
        }

        private void ClearAddmedicine(object sender, EventArgs e)
        {
            tb_AddName.Clear();
            tb_AddCompany.Clear();
            tb_AddPrice.Clear();
            DT_AddMfg.ResetText();
            DT_AddExp.ResetText();
            Num_AddQunatity.ResetText();

            MessageBox.Show("Cleared Successfully");
        }

        private void SaveAddMedicine(object sender, EventArgs e)
        {
            Medicine dummy = new Medicine(tb_AddName.Text, tb_AddCompany.Text, DT_AddMfg.Text, DT_AddExp.Text, (int)Num_AddQunatity.Value, tb_AddPrice.Text);
            if (dummy.getprice() > money)
            {
                MessageBox.Show("Not Enough Balance to complete this purchase");
                return;
            }
            money-=dummy.getprice();
            foreach (Medicine i in medicines)
            {
                if (i.getName() == dummy.getName())
                {
                    i.setQuantity(i.getQuantity() +dummy.getQuantity());
                    MessageBox.Show("Medicines have been Added");
                    return;                
                }
            }
            medicines.Add(dummy);
            cb_SalesMedicineName.Items.Add(dummy.getName());
            cb_HistoryMedicineName.Items.Add(dummy.getName());
            MessageBox.Show("Medicines have been Added");
        }

        private void ClearSales(object sender, EventArgs e)
        {
            cb_SalesMedicineName.ResetText();
            NUM_SalesQuantity.ResetText();
        }

        private void SellOnClick(object sender, EventArgs e)
        {
            foreach (Medicine i in medicines)
            {
                if (i.getName() == cb_SalesMedicineName.Text)
                {
                    if (i.getQuantity() < (int)NUM_SalesQuantity.Value)
                    {
                        MessageBox.Show("Not Enough Medicines Available in the Inventory !");
                        return;
                    }
                    i.setQuantity(i.getQuantity() - (int)NUM_SalesQuantity.Value);
                    money += (i.getPrice() * (int)NUM_SalesQuantity.Value);
                    MessageBox.Show("Medicines Have Been Sold !");
                }
            }
        }

        private void ClearHistoryOnClick(object sender, EventArgs e)
        {
            cb_HistoryMedicineName.ResetText();
            tb_HistoryCompany.Clear();
            tb_HistoryMfgDate.Clear();
            tb_HistoryExpDate.Clear();  
            tb_HistoryPrice.Clear();    
            tb_HistoryQunatity.Clear();
        }

        private void ShowHistoryonClick(object sender, EventArgs e)
        {
            foreach (Medicine i in medicines)
            {
                if (i.getName() == cb_HistoryMedicineName.Text)
                {
                    tb_HistoryCompany.Text = i.getCompany();
                    tb_HistoryMfgDate.Text = i.getMfg();
                    tb_HistoryExpDate.Text = i.getExp();    
                    tb_HistoryPrice.Text = i.getPrice().ToString();
                    tb_HistoryQunatity.Text = i.getQuantity().ToString();
                } 
            }
        }
    }
}
