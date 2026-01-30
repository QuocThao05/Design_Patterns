using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal abstract class BasicCar
    {
        public int basePrice { get; set; }
        public int onRoadPrice { get; set; }
        public string ModelName { get; set; }


        public abstract BasicCar Clone();
        public double SetAdditionalPrice()
        {
            if (basePrice > 10000000)
            {
                onRoadPrice = basePrice + (int)(basePrice * 0.1);
            }
            else if (basePrice > 20000000 )
            {
                onRoadPrice = basePrice + (int)(basePrice * 0.05);
            }
            return onRoadPrice;
        }

    }
}
