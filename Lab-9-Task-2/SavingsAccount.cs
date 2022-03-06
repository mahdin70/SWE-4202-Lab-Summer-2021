using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Task_2
{
    internal class SavingsAccount : Account
    {
        private float interestrate;
        private float monthlyDeposit;
        private static string accountPrefix = "200";

        public float getinterestrate() { return interestrate; }
        public float getmonthlyDeposit() { return monthlyDeposit; }
        public void setinterestrate(float interesrate) { this.interestrate = interesrate; }
        public void setmonthlyDeposit(float monthlyDeposit) { this.monthlyDeposit = monthlyDeposit; }

        public string getNextAccount()
        {
            return accountPrefix + getaccountNo();
        }
    }
}
