using Common.SHES_Components;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class ShesDbContext : DbContext
    {
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<SolarPanel> SolarPanels { get; set; }
        public DbSet<Battery> Battery { get; set; }
        public ShesDbContext() : base("SHES")
        {

        }

    }
}
