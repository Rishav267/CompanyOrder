using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    public class Customer
    {
        public List<Order> orders { get; set; } = new List<Order>();

        public virtual double GetAllCustomerShop()
        {
            double AddOrd = 0;
            foreach(var c in orders)
            {
                AddOrd += c.GetTotalBusiness();
            }
            return AddOrd;
        }

    }
}
