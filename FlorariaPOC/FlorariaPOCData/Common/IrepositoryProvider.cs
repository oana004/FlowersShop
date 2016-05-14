using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocFlowerPower.Data.Contracts;

namespace EventsIT.Data.Common
{
    public interface IRepositoryProvider
    {
        DbContext DbContext { get; set; }
        IEFRepository<T> GetRepositoryForEntityType<T>() where T : class;
        T GetRepository<T>(Func<DbContext, object> factory = null) where T : class;
        void SetRepository<T>(T repository);
    }
}
