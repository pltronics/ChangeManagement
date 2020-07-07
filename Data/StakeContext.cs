using System;
using System.Linq;
using System.Threading.Tasks;
using ChangeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ChangeManagement.Data
{
    public class StakeContext : DbContext
    {
        public StakeContext(DbContextOptions<StakeContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Stake>().HasNoKey();
        }
        
    }
}
