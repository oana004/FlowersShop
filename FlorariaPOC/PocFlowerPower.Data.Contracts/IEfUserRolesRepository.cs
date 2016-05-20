using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using POCFlowerPower.Model;

namespace PocFlowerPower.Data.Contracts
{
    public interface IEfUserRolesRepository :IEFRepository<UserRole>
    {
        string GetUserRoleByUsername(string userName);
    }
}
