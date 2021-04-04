using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductWebApi_MVC.Models
{
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> products { get; set; }
    }
}