using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class SingleRoom : ParentRoom
    {
        private bool GamingSetup;
        public int calculatecost()
        {
            return (2000 + (this.AC ? 500 : 0) + (this.GamingSetup ? 1000 : 0));
        }

        public SingleRoom(string Name, string TV, string Refrigerator, string Quantity, string GamingSetup, string AC)
        {
            this.Name = Name;
            this.TV = (TV == "" ? 1 : Convert.ToInt32(TV));
            this.Refrigerator = (Refrigerator == "" ? 1 : Convert.ToInt32(Refrigerator));
            this.Bed = 1;
            this.Quantity = Convert.ToInt32(Quantity);
            this.GamingSetup = (GamingSetup == "Yes" ? true : false);
            this.AC = (AC == "Yes" ? true : false);
        }
    }
}
