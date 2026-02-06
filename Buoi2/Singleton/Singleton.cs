using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal sealed class Singleton
    {

        // 3 bước xây dựng Singleton
        private static readonly Singleton instance = new Singleton();    
        private int numberOfInstances = 0;

        private Singleton()
        {
            numberOfInstances++;
            Console.WriteLine("Number of instances: " + numberOfInstances);
        }

        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now. Use it. ");
                return instance;
            }
        }

    }
}
