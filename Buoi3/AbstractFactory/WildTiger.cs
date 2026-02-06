using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class WildTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Wild Tiger says: Halum.");
        }
        public void Action()
        {
            Console.WriteLine("Wild Tigers prefer hunting in jungles.\n");
        }
    }
}
