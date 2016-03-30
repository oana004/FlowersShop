using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorariaPOCAbstractFactory
{
    class ClientUsage
    {
        IFlowersAbsFactory flowersFactory; 
        public void Test()
        {
            flowersFactory = new BlackTulipsFactory();
            //or
            flowersFactory = new SimpleFlowersFactory();

            var flower = flowersFactory.GetBouquets().Name();

        }


        
    }
}
