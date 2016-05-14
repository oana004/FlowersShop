using System;

namespace Singleton
{
    internal class Program
    {
        private static void Main()
        {
            var s1 = Singleton.Instance();
            var s2 = Singleton.Instance();

            if(s1 == s2)
            {
                Console.WriteLine("Same instance");
            }
            Console.ReadLine();
        }
    }
}
