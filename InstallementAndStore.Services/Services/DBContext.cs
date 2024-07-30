using InstallementAndStore.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallementAndStore.Services.Services
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=InstallementDataDemo;Encrypt=False; Integrated Security=True");
        }

        public DbSet<ProductCategory > ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Payment> payments  { get; set; }
        public DbSet<InvoiceItem>  invoiceItems { get; set; }
    }
}
