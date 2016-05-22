using PocFlowerPower.Data.Contracts;
using POCFlowerPower.Model;

namespace PocFlowerPower.Data.Contracts
{
    public interface IEfUserRepository : IEFRepository<User>
    {
        User GetUserByUsername(string userName);
    }
}