using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecapProject1.Entities;

namespace RecapProject1
{
    class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; } //elimdeki product veri tabanındaki products a karşılık geliyor
        public DbSet<Category> Categories { get; set; }

    }
}
