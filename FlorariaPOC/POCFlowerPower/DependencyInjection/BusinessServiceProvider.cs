using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EventsIT.Data.Common;
using FlorariaPOCData;
using Microsoft.Practices.Unity;
using PocFlowerPower.Data.Contracts;

namespace POCFlowerPower.DependencyInjection
{
    public class BusinessServiceProvider : UnityContainer
    {

        public BusinessServiceProvider()
        {

            this.RegisterType<DbContext, FlowerPowerDbContext>(
                new HierarchicalLifetimeManager());
            //this.RegisterType<IRepositoryProvider, RepositoryProvider>(new InjectionConstructor(new ResolvedParameter<RepositoryFactories>()));

            this.RegisterType<IRepositoryProvider, RepositoryProvider>(new InjectionConstructor());
            this.RegisterType<IFlowerPowerUnitOfWork, FlowerPowerUnitOfWork>(
                new InjectionConstructor(new ResolvedParameter<IRepositoryProvider>()));



        }
    }
}