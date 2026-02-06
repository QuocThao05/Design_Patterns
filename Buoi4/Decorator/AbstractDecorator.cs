using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4.Decorator
{
    abstract class AbstractDecorator : AbstractHome
    {
        // Định nghĩa một tham chiếu đến AbstractHome để có thể sử dụng các phương thức của nó 
        protected AbstractHome home;
        // Constructor nhận một AbstractHome làm tham số
        public AbstractDecorator(AbstractHome home)
        {
            this.home = home;
            this.AdditionalPrice = 0;
        }
        public override void MakeHome()
        {
            home.MakeHome();//Delegating task
        }
    }
}
