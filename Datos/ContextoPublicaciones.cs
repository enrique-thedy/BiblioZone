using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Entidades;

namespace Datos
{
  public class ContextoPublicaciones : DbContext
  {
    private readonly string _conn;

    public DbSet<Publicacion> Publicaciones { get; set; }

    public ContextoPublicaciones(string conn)
    {
      _conn = conn;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(_conn);

      base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new ConfigurarPublicaciones());
      modelBuilder.ApplyConfiguration(new ConfigurarAutores());

      base.OnModelCreating(modelBuilder);
    }
  }
}
