using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7.Template_Method
{
    // <summary>
    /// The AbstractClass participant which contains the template method.
    /// </summary>
    abstract class Bread
    {
        public abstract void MixIngredients();
        public abstract void Bake();
        public virtual void Slice()
        {
            Console.WriteLine("Slicing the " + GetType().Name + " bread!\n");
        }

        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }




    }
}
