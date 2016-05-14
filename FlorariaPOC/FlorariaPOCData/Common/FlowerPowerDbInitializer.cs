using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorariaPOCData.Common
{
  public class FlowerPowerDbInitializer : DropCreateDatabaseIfModelChanges<FlowerPowerDbContext>
    {

        protected override void Seed(FlowerPowerDbContext context)
        {

            context.SaveChanges();
        }
    }
}
