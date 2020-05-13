using ChatApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           //modelBuilder.Entity<Channel>().Property(c => c.Id)
           // .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }

        public DbSet<KeyHolder> KeyHolders { get; set; }
        public DbSet<Channel> Channels { get; set; }
    }
}
