using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Desktop : Computer
    {
        private int GuaranteeYear;

        public Desktop() { }

        public Desktop(string id, string name, int year, double price, int GuaranteeYear) : base (id, name, year, price)
        {
            this.GuaranteeYear = GuaranteeYear;
        } 
        public int getGuaranteeYear() { return GuaranteeYear; }
        public void setGuaranteeYear(int GuaranteeYear) { this.GuaranteeYear = GuaranteeYear; }

        //xem lai override input
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap so nam bao hanh: ");
            GuaranteeYear = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Bao hanh: " + GuaranteeYear);


        }

        public string ToString()
        {
            return "ID:" + getId() + ", Name: " + getName() + ", Year: " + getYear() + ", Price: " + getPrice() + ", Guarantee Year: " + GuaranteeYear;
        }







    }
}
