using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace BuilderPatternConsole
{
   public class BuilderBouquet  :IBouquetBuilder
    {
         private Bouquet _bouquet = new Bouquet();

       public void AddFlower1()
       {
           _bouquet.Flower1 = "Roses"; 

       }
        public void AddFlower2()
        {
            _bouquet.Flower2 = "Tulips";

        }
        public void AddFlower3()
        {
            _bouquet.Flower3 = "Peony";

        }

       public Bouquet GetBouquet()
       {
           return _bouquet;
       }


    }
}
