using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    public class WildAnimalFactory : IAnimalFactory3
    {
        public IDog GetDog()
        {
            return new WildDog();
        }

        public ITiger GetTiger()
        {
            return new WildTiger();
        }
    }
}
