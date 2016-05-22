using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCFlowerPower.Model;

namespace PocFlowerPower.Data.Contracts
{
  public interface IFlowerPowerUnitOfWork
    {
        void Commit();

        // Repositories

        IEfUserRepository Users { get; }
        IEFRepository<Role> Roles { get; }
        IEfUserRolesRepository UserRoles { get; }
        IEFRepository<Order> Orders { get; }
        IEFRepository<OrderProduct> OrderProducts { get; }
        IEFRepository<Payment> Payments { get; }
        IEFRepository<Product> Products { get; }
        IEFRepository<ProductFamily> ProductFamilies { get; }



    }
}
