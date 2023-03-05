using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodevices.Model
{
    public class AppDBContext: DbContext 
    {
        public AppDBContext() : base("DefaultConnection") { }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Electrodevice> Electrodevices { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
