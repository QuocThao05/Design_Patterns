using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.Bridge
{
    public class Television: ElectronicGoods
    {
        public Television(IPrice price) : base(price)
        {
            this.type = "Television";
            this.cost = 2000;
        }
        // No additional method exists for Television
    }
}
