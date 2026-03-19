using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8.ChainsOfRes
{
    public class DenominationHandler : BillHandler
    {
        private readonly int _denomination;

        public DenominationHandler(int denomination)
        {
            _denomination = denomination;
        }

        public override void Handle(int amount)
        {
            int count = amount / _denomination;
            int remainder = amount % _denomination;

            if (count > 0)
                Console.WriteLine($"  {count} tờ x {_denomination} = {count * _denomination}");

            if (remainder > 0 && NextHandler != null)
                NextHandler.Handle(remainder);
        }
    }
}
