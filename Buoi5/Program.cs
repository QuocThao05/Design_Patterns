using Buoi5.Adapter;
using Buoi5.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Bài 1
            Console.WriteLine("***Adapter Pattern Modified Demo***\n");
            //CalculatorAdapter cal = new CalculatorAdapter(); 
            Rectangle r = new Rectangle(20, 10);
            Console.WriteLine("Area of Rectangle is :{0} Square unit", r.CalculateArea());
            Triangle t = new Triangle(20, 10);
            Console.WriteLine("Area of Triangle is :{0} Square unit", t.CalculateAreaOfTriangle());
            IRectangle adapter = new RectangleAdapter(t);
            //Passing a Triangle instead of a Rectangle 
            Console.WriteLine("Area of Triangle using the triangle adapter is :{0} Square unit", GetArea(adapter));
            Console.ReadKey();
        }
        /*GetArea(IRectangle r) method  does not know that through RectangleAdapter , it is getting a Triangle instead of a Rectangle*/
        static double GetArea(IRectangle r)
        {
            r.AboutMe();
            return r.CalculateArea();



            //// Bài 2
            //Console.WriteLine("***Facade Pattern Demo.***\n");
            //    // Making a Milano robot with green color.
            //    RobotFacade facade = new RobotFacade("Milano", "Green");
            //    facade.ConstructRobot();

            //    // Making a robonaut robot with default steel color.
            //    facade = new RobotFacade("Robonaut"); 
            //    facade.ConstructRobot();

            //    // Destroying one robot
            //    facade.DestroyRobot();

            //    // Destroying another robot
            //    facade.DestroyRobot();

            //    // This destrcution attempt should fail.
            //    facade.DestroyRobot();
            //    Console.ReadKey();





        }

    }
}

