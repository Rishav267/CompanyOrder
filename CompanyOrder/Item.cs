using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrder
{
    public class Item
    {
        private string Desc;
        private double Rate;

        public void SetRate(double rate)
        {
            Rate = rate;
        }

        public double GetRate()
        {
            double res = Rate;
            return res;
        }
    }
}
