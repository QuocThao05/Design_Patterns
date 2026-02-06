using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    public class TigerFactory: IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Tiger();
        }
    }
}
