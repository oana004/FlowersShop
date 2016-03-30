using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorariaPOCAbstractFactory
{
   class RosesBouquet :IBouquets
    {
        public string Name()
        {
            return "Roses bouqet";
        }
    }

   
    class BlackTulipsBouquet:IBouquets
    {
        public string Name()
        {
            return "BlackTulipsBouquet";
        }
    }


    class Roses: ISimpleFlowers
    {
        public string Name()
        {
            return "Roses";
        }
    }

    class Tulips: ISimpleFlowers
    {
        public string Name()
        {
            return "Tulips";
        }
    }

}
