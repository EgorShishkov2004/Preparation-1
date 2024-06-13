using Microsoft.EntityFrameworkCore;
using Preparation__1.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation__1.Database
{
    public class DB: DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<PointIssue> PointIssues { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = GOGA-PC; Database = DB_OOO_Posuda_4; Trusted_Connection = true; TrustServerCertificate = true;");
        }
    }
}
