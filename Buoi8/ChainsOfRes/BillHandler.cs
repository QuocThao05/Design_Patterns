using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8.ChainsOfRes
{
    public abstract class BillHandler
    {
        protected BillHandler NextHandler;

        public BillHandler SetNext(BillHandler next)
        {
            NextHandler = next;
            return next; // fluent interface
        }

        public abstract void Handle(int amount);
    }
}
