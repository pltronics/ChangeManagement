using System;
using System.Linq;
using System.Threading.Tasks;
using ChangeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ChangeManagement.Data
{
    public class ChangeContext : DbContext
    {
        public ChangeContext(DbContextOptions<ChangeContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Change>().HasNoKey();
            //modelBuilder.Entity<Stake>().HasNoKey();
        }
        
    }
}
