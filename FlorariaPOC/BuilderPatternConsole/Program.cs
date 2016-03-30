using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPatternConsole
{
    public class Program
    {
        static void Main(string[] args)
        {

            var bouquetCreator = new EntireBouquetDirector(new BuilderBouquet());
            bouquetCreator.TheBeautifulBouquetConstruction();
            var beauytifulBouquet = bouquetCreator.GetBeaufifulBouquet();
            Console.WriteLine("Bouquet has 3 types of flowers:");
            Console.WriteLine("Flower 1: {0}", beauytifulBouquet.Flower1);
            Console.WriteLine("Flower 2: {0}", beauytifulBouquet.Flower2);
            Console.WriteLine("Flower 3: {0}", beauytifulBouquet.Flower3);

            Console.ReadKey();

        }
    }
}
