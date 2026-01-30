using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    public class Dog: IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says: Tôi là Thành Nghĩa");
        }
        public void Action()
        {
            Console.WriteLine("3 mũi 900k");
        }
        public void AboutMe()
        {
            Console.WriteLine("Tôi là con chó");
        }
    }
}
