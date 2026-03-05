using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.Bridge
{
    public class OnlinePrice : IPrice
    {
        public void DisplayDetails(string productType, double price)
        {
            Console.Write($"\n{productType} price at online is : {price}$");
        }
        public void GetDiscount(int percentage)
        {
            Console.Write($"\nAt online, you can get upto {percentage}% discount.");
        }
    }
}
