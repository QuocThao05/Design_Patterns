using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.Bridge
{
    public class DVD : ElectronicGoods
    {
        public DVD(IPrice price) : base(price)
        {
            this.type = "DVD";
            this.cost = 3000;
        }
        // Specic method in DVD
        public void DoubleDiscount()
        {
            // Normal discount(10%)
            Discount(10);
            // Festive season additional discount
            Discount(5);
        }
    }
}
