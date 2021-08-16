using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lagersystem.Models;

namespace Lagersystem.Data
{
    public class LagersystemContext : DbContext
    {
        public LagersystemContext (DbContextOptions<LagersystemContext> options)
            : base(options)
        {
        }

        public DbSet<Lagersystem.Models.Product> Product { get; set; }
    }
}
