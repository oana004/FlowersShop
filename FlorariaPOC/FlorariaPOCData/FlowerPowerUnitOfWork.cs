using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsIT.Data.Common;
using PocFlowerPower.Data.Contracts;
using POCFlowerPower.Model;

namespace FlorariaPOCData
{
    public class FlowerPowerUnitOfWork : IFlowerPowerUnitOfWork, IDisposable
    {

        public FlowerPowerUnitOfWork(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        // FlowerPower repositories

        public IEFRepository<User> Users { get { return GetStandardRepo<User>(); } }
        public IEFRepository<Role> Roles { get { return GetStandardRepo<Role>(); } }
        public IEFRepository<UserRole> UserRoles { get { return GetStandardRepo<UserRole>(); } }
        public IEFRepository<Order> Orders { get { return GetStandardRepo<Order>(); } }
        public IEFRepository<OrderProduct> OrderProducts { get { return GetStandardRepo<OrderProduct>(); } }
        public IEFRepository<Payment> Payments { get { return GetStandardRepo<Payment>(); } }
        public IEFRepository<Product> Products { get { return GetStandardRepo<Product>(); } }
        public IEFRepository<ProductFamily> ProductFamilies { get { return GetStandardRepo<ProductFamily>(); } }

        public void Commit()
        {
            DbContext.SaveChanges();
        }

        protected void CreateDbContext()
        {
            DbContext = new FlowerPowerDbContext();

            DbContext.Configuration.ProxyCreationEnabled = false;

            DbContext.Configuration.LazyLoadingEnabled = false;

            DbContext.Configuration.ValidateOnSaveEnabled = false;

        }

        protected IRepositoryProvider RepositoryProvider { get; set; }

        private IEFRepository<T> GetStandardRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }
        private T GetRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        private DbContext DbContext { get; set; }

     /*   IEFRepository<User> IFlowerPowerUnitOfWork.Users
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IEFRepository<Role> IFlowerPowerUnitOfWork.Roles
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IEFRepository<UserRole> IFlowerPowerUnitOfWork.UserRoles
        {
            get
            {
                throw new NotImplementedException();
            }
        }
*/
        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }
        }

        #endregion

    }
}
