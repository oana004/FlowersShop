using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocFlowerPower.Data.Contracts;
using POCFlowerPower.Model;

namespace FlorariaPOCData
{
    public class EFUserRepository : EFRepository<User>, IEfUserRepository
    {
        public EFUserRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public User GetUserByUsername(string userName)
        {
            var user =
                DbSet
                    .FirstOrDefault(u => u.UserName.ToLower().Equals(userName.ToLower()));
            return user;
        }
    }
}
