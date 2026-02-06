using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    abstract class AbstractHome
    {
        public double AdditionalPrice { get; set; } // Giá phụ thêm cho các tiện ích khác nhau 
        public abstract void MakeHome();
    }
}
