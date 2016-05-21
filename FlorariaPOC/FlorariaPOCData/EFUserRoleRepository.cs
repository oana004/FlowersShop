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
   public class EFUserRoleRepository: EFRepository<UserRole>, IEfUserRolesRepository
   {
       public EFUserRoleRepository(DbContext dbContext) : base(dbContext)
       {
       }

       public string GetUserRoleByUsername(string userName)
       {
           var role =
               DbSet.Where(u => u.User.UserName.ToLower().Equals(userName.ToLower()) && u.Active)
                   .Select(r => r.Role.RoleName)
                   .FirstOrDefault();
           return role;
       }
   }
}
