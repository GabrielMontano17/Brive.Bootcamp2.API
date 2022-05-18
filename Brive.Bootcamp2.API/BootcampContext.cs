using Brive.Bootcamp2.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp2.API
{
    public class BootcampContext : DbContext
    {
        public BootcampContext(DbContextOptions<BootcampContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(eb => 
            {
                eb.HasKey(c => new { c.Id });
            });
        }

        public DbSet<Person> Person { get; set; }

    }
}
