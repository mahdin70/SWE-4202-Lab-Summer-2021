using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Task_2
{
    internal class CurrentAccount : Account
    {
        private static int serviceCharge;
        private static string accountPrefix = "100";

        public int getserviceCharge() { return serviceCharge; }
        public string getaccountPrefix() { return accountPrefix; }

        public string getNextAccount()
        {
           return accountPrefix + getaccountNo();
        }
    }
}
