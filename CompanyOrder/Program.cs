using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            Item item1 = new Item();
            item1.SetRate(500);
            Item item2 = new Item();
            item2.SetRate(1000);

            //OrderedItem orderedItem = new OrderedItem();
            OrderedItem orderedItem1 = new OrderedItem();
            OrderedItem orderedItem2 = new OrderedItem();

            orderedItem1.theItem = item1;
            orderedItem1.theItem.GetRate();
            orderedItem1.SetQuantity(2);  //1000

            orderedItem2.theItem = item2;
            orderedItem2.theItem.GetRate();
            orderedItem2.SetQuantity(2);  //2000

            Order order1 = new Order();  //3000
            Order order2 = new Order();  //3000

            order1.orderedItems.Add(orderedItem1);
            order1.orderedItems.Add(orderedItem2);
            order2.orderedItems.Add(orderedItem1);
            order2.orderedItems.Add(orderedItem2);

            Customer customer1 = new Customer();  //6000
            customer1.orders.Add(order1);
            customer1.orders.Add(order2);

            Customer customer2 = new RegCustomer();
            //RegCustomer customer2 = new RegCustomer();  // 3000-150=2850

            if(customer2 is RegCustomer)
                (customer2 as RegCustomer).SetDiscount(150);
            customer2.orders.Add(order2);

            company.Customers.Add(customer1);
            
            company.Customers.Add(customer2);

            //company.Customers.Add(new Customer());
            //company.Customers.Add(new Customer());
            //company.Customers.Add(new Customer());

            Console.WriteLine(company.getTotalWorthOfOrders());

           //for(int i=0;i<2;i++)
           // {
           //     company.Customers.Add(new Customer());
           //     for(int j=0;j<2;j++)
           //     {
           //         company.Customers[j].orders.Add(new Order());
           //         for(int k=0;k<2;k++)
           //         {
           //             company.Customers[j].orders[k].orderedItems.Add(new OrderedItem());
           //         }
           //     }
           // }

        }
    }
}
