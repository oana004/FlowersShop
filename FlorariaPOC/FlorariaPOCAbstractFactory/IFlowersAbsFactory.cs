using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorariaPOCAbstractFactory
{
    interface IFlowersAbsFactory
    {
        IBouquets GetBouquets();
        ISimpleFlowers GetSimpleFlowers();
    }
  
}
