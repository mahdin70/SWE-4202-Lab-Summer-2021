using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class DoubleRoom : ParentRoom
    {
        private bool ExtraTV;
        private bool Breakfast;

        public int calculatecost()
        {
            return (3500 + (this.AC ? 500 : 0) + (this.ExtraTV ? 1000 : 0) + (this.Breakfast ? 1000 : 0));
        }
        
        public DoubleRoom(string Name, string TV, string Refrigerator, string Quantity, string AC, string ExtraTV, string Breakfast)
        {
            this.Name = Name;
            this.TV = (TV == "" ? 1 : Convert.ToInt32(TV));
            this.Refrigerator = (Refrigerator == "" ? 1 : Convert.ToInt32(Refrigerator));
            this.Quantity = Convert.ToInt32(Quantity);
            this.ExtraTV = (ExtraTV == "Yes" ? true : false);
            this.AC = (AC == "Yes" ? true : false);
            this.Breakfast = (Breakfast == "Yes" ? true : false);
        }
    }
}
