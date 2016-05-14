using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlorariaPOCData.Common;
using POCFlowerPower.Model;

namespace FlorariaPOCData
{
   public class FlowerPowerDbContext : DbContext
    {

       public FlowerPowerDbContext() : base(nameOrConnectionString: "FlowerPowerContext")
        {
           
       }




        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        //
        public DbSet<ProductFamily> ProductFamilies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Payment> Payments { get; set; }




        static FlowerPowerDbContext()
        {
            Database.SetInitializer(new FlowerPowerDbInitializer());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


        }

    }
}
