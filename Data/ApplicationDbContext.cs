using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebSecurity.Models;

namespace WebSecurity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, String>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<SecurityParams> SecurityParams { get; set; }
        public DbSet<EntriesRecord> JournalEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SecurityParams>().ToTable("SecurityParams");
            builder.Entity<EntriesRecord>().ToTable("JournalEntries");

            base.OnModelCreating(builder);
          
        }
    }
}
