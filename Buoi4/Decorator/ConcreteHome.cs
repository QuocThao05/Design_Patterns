using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4.Decorator
{
    class ConcreteHome : AbstractHome
    {
        // Giá gốc của ngôi nhà
        public ConcreteHome()
        {
            AdditionalPrice = 0;
        }
        public override void MakeHome()
        {
            Console.WriteLine($"Original House is constructed.Price for this $10000");
        }
    }
}
