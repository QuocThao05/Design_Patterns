using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    public class SimpleFactory : ISimpleFactory
    {
        public override IAnimal CreateAnimal()
        {
            IAnimal animal = null; 
            Console.WriteLine("Enter your choice( 0 for Dog, 1 for Tiger)"); 
            string b1 = Console.ReadLine(); // dữ liệu nhập từ bàn phím vào đều là dạng chuỗi và readline chỉ đọc dữ liệu dạng chuỗi
            int choice; //số mà người dùng nhập vào
            if (int.TryParse(b1, out choice)) // chuyển đổi chuỗi mà người dùng nhập vào thành số nguyên
            {
                Console.WriteLine("You have entered {0}", choice);
                switch (choice)
                {
                    case 0:
                        animal = new Dog();
                        break;
                    case 1:
                        animal = new Tiger();
                        break;
                    default:
                        Console.WriteLine("You must enter either 0 or 1");
                        throw new ArgumentOutOfRangeException((String.Format(" Unknown Animal cannot be instantiated")));
                }
            }
            return animal;


            //int choice = int.Parse(Console.ReadLine());
            //if ( choice != 0 && choice != 1)
            //{
            //    Console.WriteLine("You must enter either 0 or 1");
            //    throw new ArgumentOutOfRangeException((String.Format(" Unknown Animal cannot be instantiated")));
            //}
            //else 
            //    switch (choice)
            //    {
            //        case 0:
            //            animal = new Dog();
            //            return animal;
            //        case 1:
            //            animal = new Tiger();
            //            return animal;
            //    }
            //return animal;
        }
    }
}
