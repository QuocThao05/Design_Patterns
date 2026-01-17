using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Shape
    {
        protected string color;
        protected bool filled;

        public Shape() { }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }

        public bool isFilled()
        {
            return filled;
        }
        public void setFilled(bool filled)
        {
            this.filled = filled;
        }

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimeter()
        {
            return 0;
        }

        public virtual string ToString()
        {
            return $"A Shape with color of: {color} and {(filled ? "filled" : "not filled")}";
        }




    }
}
