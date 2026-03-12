using Buoi7.Strategy;
using Buoi7.Template_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài 1
            // Prepare strategies
            var normalStrategy = new NormalStrategy();
            var happyHourStrategy = new HappyHourStrategy();
            var firstCustomer = new CustomerBill(normalStrategy);

            // Normal billing
            firstCustomer.Add(1.0, 1);

            // Start Happy Hour
            firstCustomer.Strategy = happyHourStrategy;
            firstCustomer.Add(1.0, 2);

            // New Customer
            CustomerBill secondCustomer = new CustomerBill(happyHourStrategy);
            secondCustomer.Add(0.8, 1);

            // The Customer pays
            firstCustomer.Print();

            // End Happy Hour
            secondCustomer.Strategy = normalStrategy;
            secondCustomer.Add(1.3, 2);
            secondCustomer.Add(2.5, 1);
            secondCustomer.Print();



            //    //Bài 2
            //    Sourdough sourdough = new Sourdough();
            //    sourdough.Make();

            //    TwelveGrain twelveGrain = new TwelveGrain();
            //    twelveGrain.Make();

            //    WholeWheat wholeWheat = new WholeWheat();
            //    wholeWheat.Make();

            //    Console.ReadKey();
        }
    }
}
