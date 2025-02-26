using System;
using Microsoft.EntityFrameworkCore;

namespace Entity
{
    public class Ligacao : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        // Método correto: OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=GerenciamentoImoveis;Username=postgres;Password=123456");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("pessoa");
        }
    }
}