using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using PocFlowerPower.Data.Contracts;
using POCFlowerPower.DependencyInjection;

namespace POCFlowerPower.Common
{
    public class UnitOfWorkManager
    {
        private readonly BusinessServiceProvider _businessServiceProvider;

        public UnitOfWorkManager()
        {
            _businessServiceProvider  = new BusinessServiceProvider();
         
        }

        public IFlowerPowerUnitOfWork GetUofContext()
        {
            var uofContext = _businessServiceProvider.Resolve<IFlowerPowerUnitOfWork>();
            return uofContext;

        }

         
    }
}