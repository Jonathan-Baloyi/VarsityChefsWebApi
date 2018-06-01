using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VarsityChefsWebApi.Models;

namespace VarsityChefsWebApi.data.DbContext
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Application> Applications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Application>().OwnsOne(a => a.ResidentialAddress);
            modelBuilder.Entity<Application>().OwnsOne(p => p.AlternativePerson).OwnsOne(x => x.AlternativeAddress);
            modelBuilder.Entity<Application>().OwnsOne(u => u.PostalAddress);
        }

    }
}
