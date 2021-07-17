using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    public class RegCustomer : Customer
    {
        private double splDiscount;

        public void SetDiscount(double disc)
        {
            splDiscount = disc;
        }

        public double GetDiscount()
        {
            return splDiscount;
        }

        public override double GetAllCustomerShop()
        {
            double amount = 0;
            foreach (var v in orders)
            {
                
                amount += (v.GetTotalBusiness() - GetDiscount());
            }
            return amount;
        }
    }
}
