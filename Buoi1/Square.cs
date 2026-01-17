using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Square: Rectangle
    {
        public Square() { }
        public Square(double side) : base(side, side) { }
        public Square(string color, bool filled, double side) : base(color, filled, side, side) { }
        public double getSide()
        {
            return width;
        }
        public void setSide(double side)
        {
            this.width = side;
            this.length = side;
        }
        public override void setWidth(double side)
        {
            this.width = side;
            this.length = side;
        }
        public override void setLength(double side)
        {
            this.width = side;
            this.length = side;
        }
        public override string ToString()
        {
            return $"A Square with side={width}, which is a subclass of {base.ToString()}";
        }


    }
}
