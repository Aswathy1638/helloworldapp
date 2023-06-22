using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication
{
     class ECommerceDbContext:DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Customer> customers { get; set; }
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {

        }
    }

}
