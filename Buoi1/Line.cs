using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Line
    {
        private Point2D p1, p2;
        public Line(Point2D p1, Point2D p2)
        {
            this.p1 = new Point2D(p1);
            this.p2 = new Point2D(p2);
        }

        public double Magnitude()
        {
            return Point2D.Distance(p1, p2);
        }

        public Point2D Center()
        {
            int x = (p1.getX() + p2.getX()) / 2;
            int y = (p1.getY() + p2.getY()) / 2;
            return new Point2D(x, y);
        }

    }
}
