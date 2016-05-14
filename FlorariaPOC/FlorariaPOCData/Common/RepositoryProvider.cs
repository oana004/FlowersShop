using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using PocFlowerPower.Data.Contracts;

namespace EventsIT.Data.Common
{
    public class RepositoryProvider: IRepositoryProvider
    {
        private RepositoryFactories _repositoryFactories;
        protected Dictionary<Type, object> Repositories { get; private set; }
       // InjectionConstructor]
        public RepositoryProvider()
        {
            _repositoryFactories =new RepositoryFactories();
            Repositories = new Dictionary<Type, object>();

        }
        public RepositoryProvider(RepositoryFactories repositoryFactories)
        {
            _repositoryFactories = repositoryFactories;
            Repositories = new Dictionary<Type, object>();

        }
        public DbContext DbContext { get; set; }

        public IEFRepository<T> GetRepositoryForEntityType<T>() where T : class
        {
            return GetRepository<IEFRepository<T>>(_repositoryFactories.GetRepositoryFactoryForEntityType<T>());
        }

        public virtual T GetRepository<T>(Func<DbContext, object> factory = null) where T : class
        {
            object repositoryObj;
            Repositories.TryGetValue(typeof (T), out repositoryObj);
            if (repositoryObj != null)
            {
                return (T) repositoryObj; 
            }

            return MakeRepository<T>(factory, DbContext);
        }

        protected virtual T MakeRepository<T>(Func<DbContext, object> factory, DbContext dbContext)
        {
            var f = factory ?? _repositoryFactories.GetRepositoryFactory<T>();
            if (f == null)
            {
                
                throw new  NotImplementedException("no factory for repo" + typeof(T).FullName);
            }
            var repository = (T) f(dbContext);
            Repositories[typeof (T)] = repository;
            return repository;
        }

        public void SetRepository<T>(T repository)
        {
            Repositories[typeof (T)] = repository;
        }
    }
}
