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
    }
}