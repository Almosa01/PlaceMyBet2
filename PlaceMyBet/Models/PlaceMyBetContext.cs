using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class PlaceMyBetContext : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; } //Taula
        public DbSet<Apuesta> apuestas { get; set; } //Taula
        public DbSet<Evento> eventos { get; set; } //Taula
        public DbSet<Mercado> mercados { get; set; } //Taula
        public DbSet<CasaApuestas> casaApuestas { get; set; } //Taula


        public PlaceMyBetContext()
        {
        }

        public PlaceMyBetContext(DbContextOptions options)
        : base(options)
        {
        }

        //Mètode de configuració
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=placemybet2;Uid=root;Pwd=''; SslMode = none");//màquina retos

            }
        }

        //Inserció inicial de dades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(new Usuario(1, "Pablo", "Escobar", 50, 1.5));
            modelBuilder.Entity<CasaApuestas>().HasData(new CasaApuestas(1, 4000, "Caixa", 12345678, "pabloescobar@gmail.com"));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(1, 1.5, 60, 40, 200, 500));
            modelBuilder.Entity<Evento>().HasData(new Evento(1, "Valencia", "Real Madrid", "12-12-2040", 1.5));
            modelBuilder.Entity<Apuesta>().HasData(new Apuesta(1, "over", 4000, 1.5, "pabloescobar@gmail.com"));
        }
    }
}