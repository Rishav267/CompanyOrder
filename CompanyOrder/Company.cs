using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    public class Company
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();
       //private Customer Customers { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public double getTotalWorthOfOrders()
        {
            double worth = 0;
            double splAmount = 0;
            foreach(var v in Customers)
            {
                //if(v is RegCustomer)
                //{

                //    splAmount += (v as RegCustomer).GetDiscount();
                //}

                worth += v.GetAllCustomerShop();
                    
                //foreach(var o in v.orders)   //customer class loop
                //{
                //    foreach(var oi in o.orderedItems)   //order class loop
                //    {
                //        int quan = oi.GetQuantity();
                //        double Tprice = quan * (oi.theItem.GetRate());
                //        worth += Tprice;
                //    }
                //}
            }
            return worth-splAmount;
        }
        
    }
}
