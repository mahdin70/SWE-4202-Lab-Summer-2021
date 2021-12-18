using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Pharmacy_Management_System
{
    internal class Medicine
    {
        private string name;
        private string company;
        private string mfg;
        private string exp;
        private int quantity;
        private int price;

        public string getName() { return this.name; }
        public string getCompany() { return this.company; }
        public int getQuantity() { return this.quantity; }
        public string getMfg() { return this.mfg; } 
        public string getExp() { return this.exp; }
        public int getPrice() { return this.price; }

        public void setName(string name) { this.name = name;}
        public void setCompany(string company) { this.company = company; }
        public void setQuantity(int quantity) { this.quantity = quantity;}
        public void setPrice(int price) { this.price = price;}
        public void setMfg(string mfg) { this.mfg = mfg;}
        public void setExp(string exp) { this.exp = exp;}   



        public Medicine(string name, string company, string mfg, string exp, int quantity, string price)
        {
            this.name = name;
            this.company = company;
            this.mfg = mfg;
            this.exp = exp;
            this.quantity = quantity;
            this.price = Convert.ToInt32(price);
        }

        public int getprice()
        {
            int total = quantity * price;
            return total;
        }
    }
}
