using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using MySql.Data.EntityFramework;
using ProductCatalogApp.Models;

namespace ProductCatalogApp.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DBORMContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DBORMContext() : base("WebAppCon")
        {

        }
    }
}