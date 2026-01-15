using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Point2D
    {
        private int x, y;

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }

        public Point2D(){ }

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point2D(Point2D p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        public void Input()
        {
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = int.Parse(Console.ReadLine());
        }
        
        public string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

        public void Move(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }
        
        public void Move(Point2D p)
        {
            this.x += p.x;
            this.y += p.y;
        }

        public bool isOrigin()
        {
           if (x == 0 && y == 0)
                return true;
           else 
                return false;
        }

        public double Distance(Point2D p)
        {
            return Math.Sqrt(Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2));
        }

        public static double Distance(Point2D p1, Point2D p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }


    }
}
