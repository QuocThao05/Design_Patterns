using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Laptop: Computer
    {
        private double weight;
        public Laptop() { }
        public Laptop(string id, string name, int year, double price, double weight) : base(id, name, year, price)
        {
            this.weight = weight;
        }
        public double getWeight() { return weight; }
        public void setWeight(double weight) { this.weight = weight; }
        //xem lai override input
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap so luong can nang: ");
            weight = double.Parse(Console.ReadLine());
        }

        public override void Output() 
        {
            base.Output();
            Console.WriteLine("So can nang la: " + weight);
        }

        public string ToString()
        {
            return "ID:" + getId() + ", Name: " + getName() + ", Year: " + getYear() + ", Price: " + getPrice() + ", Weight: " + weight;
        }
    }

}
