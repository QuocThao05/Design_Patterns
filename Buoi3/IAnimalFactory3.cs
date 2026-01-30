using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    public interface IAnimalFactory3
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
