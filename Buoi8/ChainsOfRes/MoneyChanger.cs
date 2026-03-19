using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8.ChainsOfRes
{
    public class MoneyChanger
    {
        private readonly BillHandler _chain;

        public MoneyChanger()
        {
            var h100 = new DenominationHandler(100);
            var h50 = new DenominationHandler(50);
            var h20 = new DenominationHandler(20);
            var h10 = new DenominationHandler(10);
            var h5 = new DenominationHandler(5);
            var h2 = new DenominationHandler(2);
            var h1 = new DenominationHandler(1);

            h100.SetNext(h50)
                .SetNext(h20)
                .SetNext(h10)
                .SetNext(h5)
                .SetNext(h2)
                .SetNext(h1);

            _chain = h100;
        }

        public void Change(int amount)
        {
            Console.WriteLine($"Đổi {amount} thành:");
            _chain.Handle(amount);
        }
    }
}
