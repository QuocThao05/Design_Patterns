using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.Adapter
{
    class RectangleAdapter : IRectangle
    {
        Triangle triangle;//Adaptee 
        public RectangleAdapter(Triangle t)
        {
            this.triangle = t;
        }
        public void AboutMe()
        {
            triangle.AboutTriangle();
        }
        public double CalculateArea()
        { 
            return triangle.CalculateAreaOfTriangle(); 
        }

    }
}
