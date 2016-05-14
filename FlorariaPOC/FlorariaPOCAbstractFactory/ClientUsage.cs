using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorariaPOCAbstractFactory
{
    public class ClientUsage
    {
        IFlowersAbsFactory flowersFactory; 
        public string Test()
        {
            flowersFactory = new BlackTulipsFactory();
            //or
          // flowersFactory = new SimpleFlowersFactory();

            var flower = flowersFactory.GetBouquets().Name();
            //var flower = flowersFactory.GetSimpleFlowers().Name();
            return flower;

        }


        
    }
}
