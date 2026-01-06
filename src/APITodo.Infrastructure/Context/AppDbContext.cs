using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITodo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace APITodo.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();
            });
        }

        public DbSet<Todo> Todos {get; set;}

    }
}