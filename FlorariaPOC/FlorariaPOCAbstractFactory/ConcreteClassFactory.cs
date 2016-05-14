using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorariaPOCAbstractFactory
{
    public class BlackTulipsFactory :IFlowersAbsFactory
    {
        public IBouquets GetBouquets()
        {
            return new BlackTulipsBouquet();
        }


        public ISimpleFlowers GetSimpleFlowers()
        {
            return new Roses();
        }
        }

    class SimpleFlowersFactory: IFlowersAbsFactory
    {
        public ISimpleFlowers GetSimpleFlowers()
        {
            return new Tulips();
        }
        public IBouquets GetBouquets()
        {
            return new RosesBouquet();
        }
    }





}
