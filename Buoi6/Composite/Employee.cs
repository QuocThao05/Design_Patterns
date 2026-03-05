using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.Composite
{
    class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; }
        // Details of a leaf node
        public void DisplayDetails()
        {
            Console.WriteLine($"\t{Name} works in {Dept} department. Designation:{Designation}");
        }
    }
}
