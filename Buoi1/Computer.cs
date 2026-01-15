using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Computer
    {
        private string id, name;
        private int year;
        private double price;

        public Computer() { }

        public Computer(string id, string name, int year, double price)
        {
            this.id = id;
            this.name = name;
            this.year = year;
            this.price = price;
        }

        public string getId()   { return id; }
        public void setId(string id) { this.id = id; }
        public string getName() { return name; }
        public void setName(string name) { this.name = name; }

        public int getYear() { return year; }
        public void setYear(int year) { this.year = year; }

        public double getPrice() { return price; }
        public void setPrice(double price) { this.price = price; }

        public virtual void Input()
        {
            Console.Write("Nhap id: ");
            id = Console.ReadLine();
            Console.Write("Nhap name: ");
            name = Console.ReadLine();
            Console.Write("Nhap year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Nhap price: ");
            price = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine("ID:" + id + ", Name: " + name + ", Year: " + year + ", Price: " + price);
        }

        public  void Running()
        {
            Console.WriteLine("ID:" + id + ", Name: " + name + ", Year: " + year + ", Price: " + price + " is running");

        }

        public string ToString()
        {
            return "ID:" + id + ", Name: " + name + ", Year: " + year + ", Price: " + price;
        }




    }
}
