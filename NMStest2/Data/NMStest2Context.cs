using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NMStest.Models;

namespace NMStest2.Models
{
    public class NMStest2Context : DbContext
    {
        public NMStest2Context (DbContextOptions<NMStest2Context> options)
            : base(options)
        {
        }

        public DbSet<NMStest.Models.StarSystems> StarSystems { get; set; }
        public DbSet<NMStest.Models.Planet> Planet { get; set; }

        public DbSet<NMStest.Models.Resource> Resource { get; set; }

        // test
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<StarSystems>()
        //        .HasMany(s => s.ListPlanets)
        //        .WithOne();
                
                

        //    modelBuilder.Entity<Planet>()
        //        .HasMany(p => p.ListResources)
        //        .WithOne();

        //    //modelBuilder.Entity<Resource>()
        //      //  .HasOne(r => r.resourceName)
        //        //.WithMany(r => 

        //}


    }

    
}
