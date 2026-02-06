using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    public class DogFactory: IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
        
    }
}
