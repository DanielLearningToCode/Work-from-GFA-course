﻿using Microsoft.EntityFrameworkCore;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        //sets GETDATE function in the database. Cannot be done via annotations.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                    .Property(s => s.CreatedDate)
                    .HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Post>().Property(p => p.UserId).HasDefaultValueSql("1");
        }
    }
}
