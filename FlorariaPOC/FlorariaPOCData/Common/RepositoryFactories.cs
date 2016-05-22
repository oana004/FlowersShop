using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlorariaPOCData;
using PocFlowerPower.Data.Contracts;


namespace EventsIT.Data.Common
{
    public class RepositoryFactories
    {

        private readonly IDictionary<Type, Func<DbContext, object>> _repositoryFactories;
        private IDictionary<Type, Func<DbContext, object>> GetCodeCamperFactories()
        {
            return new Dictionary<Type, Func<DbContext, object>>
                {
                   {typeof(IEfUserRolesRepository), dbContext => new EFUserRoleRepository(dbContext)},
                    {typeof(IEfUserRepository), dbContext => new EFUserRepository(dbContext)},

                };
        }


        public RepositoryFactories()
        {
            _repositoryFactories = GetCodeCamperFactories();
        }


        public RepositoryFactories(IDictionary<Type, Func<DbContext, object>> factories)
        {
            _repositoryFactories = factories;
        }


        public Func<DbContext, object> GetRepositoryFactory<T>()
        {

            Func<DbContext, object> factory;
            _repositoryFactories.TryGetValue(typeof(T), out factory);
            return factory;
        }


        public Func<DbContext, object> GetRepositoryFactoryForEntityType<T>() where T : class
        {
            return GetRepositoryFactory<T>() ?? DefaultEntityRepositoryFactory<T>();
        }


        protected virtual Func<DbContext, object> DefaultEntityRepositoryFactory<T>() where T : class
        {
            return dbContext => new EFRepository<T>(dbContext);
        }
        
    

    }
}
