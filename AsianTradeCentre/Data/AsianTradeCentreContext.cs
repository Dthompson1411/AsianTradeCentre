using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AsianTradeCentre.Models;

namespace AsianTradeCentre.Models
{
    public class AsianTradeCentreContext : DbContext
    {
        public AsianTradeCentreContext (DbContextOptions<AsianTradeCentreContext> options)
            : base(options)
        {
        }

        public DbSet<AsianTradeCentre.Models.Business> Business { get; set; }

        public DbSet<AsianTradeCentre.Models.Person> Person { get; set; }
    }
}
