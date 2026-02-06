using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4.Decorator
{
    class PaintDecorator : AbstractDecorator
    {
        public PaintDecorator(AbstractHome home) : base(home)
        {
            //this.home = home;
            this.AdditionalPrice = 5000;
        }
        public override void MakeHome()
        {
            base.MakeHome();
            // Painting home.
            PaintHome();
        }
        private void PaintHome()
        {
            Console.WriteLine($"--Painting done.Pay additional ${AdditionalPrice} for it .");
        }
    }
}
