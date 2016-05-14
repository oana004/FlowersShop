using FlorariaPOCAbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientUsage = new ClientUsage();
            var flower = clientUsage.Test();
            Console.WriteLine("Flower: {0}", flower);
            Console.ReadKey();

        }
    }
}
