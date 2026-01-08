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

                entity.Property(e => e.Titulo)
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Descricao)
                    .HasColumnType("VARCHAR(1000)");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("DATETIME");
            });
        }

        public DbSet<Todo> Todos {get; set;}

    }
}