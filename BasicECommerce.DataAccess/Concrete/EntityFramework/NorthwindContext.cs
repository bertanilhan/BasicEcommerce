using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicECommerce.Entities.Concrete;

namespace BasicECommerce.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
