using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Buoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //BT1();
            //BT2();
            //BT3();
            //BT4();
            BT5();

        }

        public static void BT1()
        {
            Point2D p1 = new Point2D();
            p1.Input();
            Console.WriteLine("Toa do diem p1: " + p1.ToString());

            Console.WriteLine("Toa do diem p2: ");
            Point2D p2 = new Point2D(3, 6);
            Console.WriteLine("Toa do diem p2: " + p2.ToString());

            p2.Move(0, 0);
            Console.WriteLine(p2.ToString());
            if (p2.isOrigin())
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");


            Console.WriteLine("Khoang cach giua 2 diem la: ");
            Console.WriteLine(p1.Distance(new Point2D(0, 0)));

            Console.WriteLine("Khoang cach giua 2 diem la: ");
            Console.WriteLine(Point2D.Distance(p1, p2));
        }

        public static void BT2()
        {
            Point2D p1 = new Point2D(7,9);
            Console.WriteLine("Toa do x: " + p1.ToString());          

            Point2D p2 = new Point2D(3,6);
            Console.WriteLine("Toa do y: " + p2.ToString());

            Line line = new Line(p1, p2);

            Console.WriteLine("Do dai doan thang: " + line.Magnitude());
            Console.WriteLine("Trung diem doan thang: " + line.Center().ToString());



        }

        public static void BT3()
        {
            Point2D p1 = new Point2D(7, 9);
            Console.WriteLine("Toa do x: " + p1.ToString());

            Point2D p2 = new Point2D(3, 6);
            Console.WriteLine("Toa do y: " + p2.ToString());

            Point2D p3 = new Point2D(3, 6);
            Console.WriteLine("Toa do y: " + p2.ToString());

            Triangle triangle = new Triangle(p1, p2, p3);

            Console.WriteLine("Chu vi :" + triangle.Perimeter().ToString());
            Console.WriteLine("Dien tich: " + triangle.Area().ToString());

        }

        public static void BT4()
        {

            // g
            //Desktop[] desktop = new Desktop[]
            //{
            //    new Desktop("a", "a1", 2024, 2000, 24),
            //    new Desktop("b", "b1", 2025, 3000, 36),
            //    new Desktop("c", "c1", 2025, 3500, 48),
            //    new Desktop("d", "d1", 2025, 3500, 12),
            //    new Desktop("e", "e1", 2025, 2500, 18)
            //};

            //Console.WriteLine("Desktop co bao hanh duoi 36 thang: ");
            //for(int i =0; i < desktop.Length; i++) // desktop.Length dùng để duyệt qua mảng của Desktop
            //{
            //    if (desktop[i].getGuaranteeYear() < 36)
            //    {
            //        desktop[i].Output(); // cw(desktop[i].ToString()) vì cw và Output đều xuất ra giá trị
            //        Console.WriteLine("--------");
            //    }
            //}


            // g
            //Computer[] laptop = new Computer[]
            //{
            //    new Laptop("a", "a1", 2024, 2000, 2.4),
            //    new Laptop("b", "b1", 2024, 2100, 2.4),
            //    new Laptop("c", "c1", 2024, 2200, 2.4),
            //    new Laptop("d", "d1", 2024, 2300, 2.4),

            //};
            //// khi khởi tạo mảng thì phải dùng dòng for để duyệt qua từng đối tượng i của mảng để xuất ra từng đối tượng
            //for (int i = 0; i < laptop.Length; i++) 
            //{
            //    laptop[i].Running();
            //}
            
            



                ////e
                //Console.WriteLine("Nhap so luong san pham: ");
                //int n = int.Parse(Console.ReadLine());
                //Computer[] computers = new Computer[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Nhap thong tin may thu: {i + 1}");
            //    Console.Write("Chon loai may (D = Desktop, khac = Laptop): ");
            //    string choice = Console.ReadLine();
            //    if (choice.Equals("D"))
            //    {
            //        computers[i] = new Desktop();
            //    }
            //    else
            //    {
            //        computers[i] = new Laptop();
            //    }
            //    computers[i].Input();
            //}

            //Console.WriteLine("\nDanh sach vua nhap:");
            //// duyệt lại đối tượng i vừa nhập dữ liệu vào và gọi hàm Output() để in thông tin
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"May thu {i + 1}:");
            //    computers[i].Output();   // cw(computers[i].ToString) vì cw và Output đều để xuất ra giá trị
            //    Console.WriteLine("------------------");
            //}



            //d, f
            //Computer computer = new Computer("a", "b", 2020, 1500);
            //Laptop laptop = new Laptop("c", "d", 2021, 2000, 2.5);
            //Desktop desktop = new Desktop("e", "f", 2019, 1200, 24);
            //Console.Write("\nComputer: " + computer.ToString() + "\nLaptop: " + laptop.ToString() + "\nDesktop: " + desktop.ToString());


            //double totalPrice = computer.getPrice() + laptop.getPrice() + desktop.getPrice();
            //Console.Write("\nTong so tien la: " + totalPrice);



            //a,b,c
            //Computer computer1 = new Computer();
            //computer1.Input();
            //computer1.Running();


        }

        public static void BT5()
        {
            Shape shape = new Shape("red", true);
            Console.WriteLine(shape.ToString());

            Circle circle = new Circle("blue", true,5.5);
            Console.WriteLine(circle.ToString());
            Console.WriteLine("Radius: " + circle.getRadius());
            Console.WriteLine("Area: " + circle.Area());
            Console.WriteLine("Perimeter: " + circle.Perimeter());
            Console.WriteLine("----------------");

            Rectangle rectangle = new Rectangle("green", true,2.0, 4.0);
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine("Width: " + rectangle.getWidth());
            Console.WriteLine("Length: " + rectangle.getLength());
            Console.WriteLine("Area: " + rectangle.Area());
            Console.WriteLine("Perimeter: " + rectangle.Perimeter());
            Console.WriteLine("--------------------------------");

            Square square = new Square("violet",true,6.6);
            Console.WriteLine(square.ToString());
            Console.WriteLine("Side: " + square.getSide());
            Console.WriteLine("Area: " + square.Area());
            Console.WriteLine("Perimeter: " + square.Perimeter());
        }
    }
}
