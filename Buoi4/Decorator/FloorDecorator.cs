using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4.Decorator
{
    class FloorDecorator : AbstractDecorator
    {
        public FloorDecorator(AbstractHome home) : base(home)
        {
            //this.home = home; 
            this.AdditionalPrice = 2500;
        }
        public override void MakeHome()
        {
            base.MakeHome();
            // Adding a floor on top of original house.
            AddFloor();
        }
        // dùng private để chỉ phương thức này chỉ được sử dụng trong lớp này
        private void AddFloor()
        {
            Console.WriteLine($"-Additional Floor added.Pay additional ${AdditionalPrice} for it.");
        }
    }
}
