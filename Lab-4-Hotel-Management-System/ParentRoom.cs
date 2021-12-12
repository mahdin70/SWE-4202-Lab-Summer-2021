using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class ParentRoom
    {
        protected string Name;
        protected int TV;
        protected int Bed;
        protected int Refrigerator;
        protected int Quantity;
        protected bool AC;

        public string getname()
        {
            return this.Name;
        }
        public int getcount()
        {
            return this.Quantity;
        }
        public void setcount(int Quantity)
        {
            this.Quantity = Quantity;
        }
        protected ParentRoom()
        {

        }
    }
}
