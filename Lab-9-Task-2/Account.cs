using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Task_2
{
    internal class Account
    {
        private string accountNo;
        private string accountName;
        private float balance;


        public string getaccountNo() { return accountNo; }
        public string getaccountName() { return accountName; }
        public float getbalance() { return balance; }
        public void setaccountNo(string accountNo) { this.accountNo = accountNo; }
        public void setaccountName(string accountName) { this.accountName = accountName; }
        public void setbalance(float balance) { this.balance = balance; }
    }
}
