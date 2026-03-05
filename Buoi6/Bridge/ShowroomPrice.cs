using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.Bridge
{
    public class ShowroomPrice : IPrice
    {
        public virtual void DisplayDetails(string productType, double price)
        {
            // Showroom price is 300$ more
            Console.Write($"\n{productType} price at showroom is : {price + 300}$");
        }
        public void GetDiscount(int percentage)
        {
            Console.Write($"\nAt showroom, additional {percentage}% discount can be approved.");
        }
    }
}
