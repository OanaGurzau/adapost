using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Adapost.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

// Create the Database Context

namespace Adapost.DAL
{
    public class AdapostContext : DbContext
    {
        public AdapostContext(): base("AdapostContext")
        { }
        public DbSet<Angajati> Angajati { get; set; }
        public DbSet<Voluntari> Vountari { get; set; }
        public DbSet<Veterinari> Veterinari { get; set; }
        public DbSet<Animal> Animal { get; set; }

    }
}