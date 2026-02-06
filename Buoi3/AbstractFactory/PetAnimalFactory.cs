using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    public class PetAnimalFactory: IAnimalFactory3
    {
        public IDog GetDog()
        {
            return new PetDog();
        }

        public ITiger GetTiger()
        {
            return new PetTiger();
        }
    }
}
