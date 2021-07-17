using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    public class Order
    {
        public List<OrderedItem> orderedItems { get; set; } = new List<OrderedItem>();

        public double GetTotalBusiness()
        {
            double total = 0;
            foreach(var v in orderedItems)
            {
                int q = v.GetQuantity();
                total += (q * v.theItem.GetRate());
            }
            return total;
        }
    }
}
