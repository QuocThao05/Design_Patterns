using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Triangle
    {
        public Point2D p1, p2, p3;

        public Triangle(Point2D p1, Point2D p2, Point2D p3)
        {
            this.p1 = new Point2D(p1);
            this.p2 = new Point2D(p2);
            this.p3 = new Point2D(p3);
        }

        public double Perimeter()
        {
            return Point2D.Distance(p1, p2) + Point2D.Distance(p2, p3) + Point2D.Distance(p1, p3);
        }
        

        public  double Area()
        {
            double p = Perimeter() / 2;
            double a = p * (p - Point2D.Distance(p1, p2)) + (p - Point2D.Distance(p2, p3)) + (p - Point2D.Distance(p1, p3));
            return Math.Sqrt(a);
        }
    }
}
