using _2C_Company.DataBase.DataModels;
using _2C_Company.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C_Company.DataBase
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("ConnectionString") { 

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Refill> Refills { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
