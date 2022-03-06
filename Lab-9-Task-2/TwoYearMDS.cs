using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Task_2
{
    internal class TwoYearMDS: MonthlyDepositScheme
    {
        private int maximuminterest;
        public int getmaximuminterest() { return maximuminterest; }
        public void setmaximuminterest(int maximuminterest) { this.maximuminterest = maximuminterest; } 
    }
}
