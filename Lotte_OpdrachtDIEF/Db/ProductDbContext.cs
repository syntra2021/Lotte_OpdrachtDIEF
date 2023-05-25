using Lotte_OpdrachtDIEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDIEF.Db
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=products.db");
    }
}
