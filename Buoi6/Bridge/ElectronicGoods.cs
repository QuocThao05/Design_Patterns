using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.Bridge
{
    public abstract class ElectronicGoods
    {
        //public IPrice Price { get; set; }
        private IPrice price;
        public string type;
        public double cost;
        public ElectronicGoods(IPrice price)

        {
            this.price = price;
        }
        public void Details()
        {
            price.DisplayDetails(type, cost);
        }
        // additional method
        public void Discount(int percentage)
        {
            price.GetDiscount(percentage);
        }
    }
}
