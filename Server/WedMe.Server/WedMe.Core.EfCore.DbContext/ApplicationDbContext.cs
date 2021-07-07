using System;
using Microsoft.EntityFrameworkCore;
using WedMe.Core.Models;

namespace WedMe.Core.EfCore.DbContext
{
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BaseEntity>(builder =>
            {
                builder.HasOne(e => e.CreatedBy);
                builder.HasOne(e => e.ModifiedBy);
            });
        }
    }
}