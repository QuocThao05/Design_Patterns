using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    public  class Tiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Tiger says: Tôi là Huy Hoàng");
        }
        public void Action()
        {
            Console.WriteLine("Mộ xanh cỏ");
        }
        public void AboutMe()
        {
            Console.WriteLine("Tôi là con hổ");
        }

    }
}
