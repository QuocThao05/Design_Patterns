using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7.Strategy
{
     interface IBillingStrategy
    {
        double GetActPrice(double rawPrice);
    }
}
