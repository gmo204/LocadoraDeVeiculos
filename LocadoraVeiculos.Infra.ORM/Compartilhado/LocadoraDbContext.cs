﻿using LocadoraVeiculos.Dominio;
using LocadoraVeiculos.Dominio.GrupoDeVeiculos;
using LocadoraVeiculos.Dominio.ModuloPlanos;
using LocadoraVeiculos.Infra.ORM.ModuloGrupoDeVeiculos;
using LocadoraVeiculos.Infra.ORM.ModuloPlanos;
using LocadoraVeiculos.Infra.ORM.ModuloVeiculo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LocadoraVeiculos.Infra.ORM.Compartilhado
{
    public class LocadoraDbContext : DbContext
    {
        public DbSet<GrupoDeVeiculos> GruposVeiculos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<PlanoCobranca> Planos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var conectionString = config.GetConnectionString("SqlServer");

            optionsBuilder.UseSqlServer(conectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(LocadoraDbContext).Assembly;

	        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}