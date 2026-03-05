using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.Composite
{
    interface IEmployee
    {
        // To set an employee name
        string Name { get; set; }
        // To set an employee department
        string Dept { get; set; }
        // To set an employee designation
        string Designation { get; set; }
        // To display an employee details
        void DisplayDetails();
    }
}
