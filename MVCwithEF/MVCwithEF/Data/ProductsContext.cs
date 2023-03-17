using Microsoft.EntityFrameworkCore;
using MVCwithEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCwithEF.Data
{
    public class ProductsContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductsContext(DbContextOptions<ProductsContext> options)
          : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }


    }
}
