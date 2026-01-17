using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Circle : Shape
    {
        protected double radius;
        public Circle() { }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(string color, bool filled, double radius) : base(color, filled)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return $"A Circle with radius={radius}, which is a subclass of {base.ToString()}";
        }

    } 
}
