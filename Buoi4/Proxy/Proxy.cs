using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    public class Proxy : Subject
    {
        Subject cs;
        public override void DoHomework()
        {
            Console.WriteLine("Proxy call happening now...");
            if (cs == null)
            {
                cs = new ConcreteSubject();
            }
            Console.WriteLine("Proxy delegating homework to ConcreteSubject.");
            cs.DoHomework();
        }
    }
}
