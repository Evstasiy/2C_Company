using _2C_Company.DataBase.DataModels;
using _2C_Company.DataModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C_Company.DataBase
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("ConnectionString") {
            context = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)this).ObjectContext;
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Refill> Refills { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }

        public event RefreshDb isRefreshDb;
        public delegate void RefreshDb();

        private ObjectContext context;

        public bool Refresh(IEnumerable dataList) {
            try
            {
                context.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, dataList);
                isRefreshDb();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
            

        }

    }
}
