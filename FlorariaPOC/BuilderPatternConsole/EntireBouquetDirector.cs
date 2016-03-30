using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPatternConsole
{
    public class EntireBouquetDirector
    {
        private readonly IBouquetBuilder _bouquetBuilder; 
        public EntireBouquetDirector(IBouquetBuilder bouquetBuilder)
        {
            _bouquetBuilder = bouquetBuilder; 

        }
        public void TheBeautifulBouquetConstruction()
        {
            _bouquetBuilder.AddFlower1();
            _bouquetBuilder.AddFlower2();
            _bouquetBuilder.AddFlower3();
        }

        public Bouquet GetBeaufifulBouquet()
        {
            return _bouquetBuilder.GetBouquet();
        }

      
    }
}
