using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    public class ConcreteSubject : Subject
    {
        public override void DoHomework()
        {
            Console.WriteLine("ConcreteSubject is doing homework.");
        }
    }
}
