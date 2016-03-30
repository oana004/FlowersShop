using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPatternConsole
{
    public interface IBouquetBuilder
    {
        void AddFlower1();
        void AddFlower2();
        void AddFlower3();

        Bouquet GetBouquet();


    }
}
