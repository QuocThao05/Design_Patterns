using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class Ford: BasicCar
    {
        public Ford(string m, int price)
        {
            ModelName = m;
            basePrice = price;
        }
        public override BasicCar Clone()
        {
            Console.WriteLine("Cloning Ford car...");
            return (Ford)this.MemberwiseClone();
        }

       

    }
}
