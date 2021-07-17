using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    public class OrderedItem
    {
        private int Quantity;
        public Item theItem { get; set; }

        public void SetQuantity(int count)
        {
            Quantity = count;
        }

        public int GetQuantity()
        {
            int res = Quantity;
            return res;
        }
    }
}
