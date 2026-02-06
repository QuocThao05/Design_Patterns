using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài 1 - Singleton Pattern
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Singleton Pattern Demo");

            Console.WriteLine("Tạo instance 1:");
            Singleton i1 = Singleton.Instance;
            Console.WriteLine("---------------");
            Console.WriteLine("Tạo instance 2:");
            Singleton i2 = Singleton.Instance;
            if (i1 == i2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exist");
            }


            // Bài 2 - Prototype Pattern
            //Console.WriteLine("\nPrototype Pattern Demo");
            //// gán giá trị cho các đối tượng Nano và Ford
            //BasicCar nano_base = new Nano("C300",15000000);
            //BasicCar ford_base = new Ford("Mustang GT",25000000);
            //// khởi tạo BasicCar bc1 để tham chiếu đến các đối tượng Nano và Ford
            //BasicCar bc1;

            //// sao chép đối tượng nano_base và tính toán giá trị onRoadPrice
            //bc1 = nano_base.Clone();
            //bc1.SetAdditionalPrice();
            //Console.WriteLine("Car is: {0}, Base Price: {1} ,On road price is Rs.{2}", bc1.ModelName,bc1.basePrice, bc1.onRoadPrice);

            //Console.WriteLine("-----------------------");

            //// sao chép đối tượng ford_base và tính toán giá trị onRoadPrice
            //bc1 = ford_base.Clone();
            //bc1.SetAdditionalPrice();
            //Console.WriteLine("Car is: {0}, Base Price: {1}, on road price is Rs.{2}", bc1.ModelName,bc1.basePrice, bc1.onRoadPrice);


        }
    }
}
