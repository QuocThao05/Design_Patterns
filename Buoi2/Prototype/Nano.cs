using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class Nano : BasicCar
    {
        public Nano(string m, int price)
        {
            ModelName = m;
            basePrice = price;
        }

        public override BasicCar Clone()
        {
            Console.WriteLine("Cloning Nano car...");
            return (Nano)this.MemberwiseClone();
        }

       

    }
}
