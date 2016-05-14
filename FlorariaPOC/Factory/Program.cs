using System;
using Factory.Bouquet;

namespace Factory
{
    internal class Program
    {
        private static void Main()
        {
            var bouquets = new Bouquet.Bouquet[] { new SmallBouquet(), new BigBouquet() };

            foreach(var bouquet in bouquets)
            {
                Console.WriteLine("\n" + bouquet.GetType().Name + "--");
                foreach(var item in bouquet.Items)
                {
                    Console.WriteLine(" " + item.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
