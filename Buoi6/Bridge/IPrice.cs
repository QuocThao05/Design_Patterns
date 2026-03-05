using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.Bridge
{
    public interface IPrice
    {
        void DisplayDetails(string product, double price);
        // additional method
        void GetDiscount(int percentage);
    }
}
