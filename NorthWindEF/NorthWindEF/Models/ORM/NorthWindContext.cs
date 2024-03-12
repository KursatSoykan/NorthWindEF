using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEF.Models.ORM
{
    public class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KKUKD45\\SQLEXPRESS01;Database=NorthWindEF;Trusted_Connection=true;TrustServerCertificate=true;");
           
        }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
