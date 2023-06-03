using OnlineShoppingProject.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShoppingProject.Context
{
    public class DataContext:DbContext
    {
        public DataContext() : base("SQL")
        {

        }
        public DbSet<User> users { get; set; }
    }
}