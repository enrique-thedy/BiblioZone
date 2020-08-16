using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Entidades;
using Microsoft.Extensions.Configuration;

namespace Datos
{
  public class ContextoPublicaciones : DbContext
  {
    private readonly IConfiguration _config;

    public DbSet<Publicacion> Publicaciones { get; set; }

    public DbSet<Autor> Autores { get; set; }

    public ContextoPublicaciones(IConfiguration config)
    {
      _config = config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      string conexion = _config["conexion"] ?? "localdb";
      string conn = _config.GetConnectionString(conexion);

      /*
       *  Tener en cuenta que podemos usar el mismo contexto con las mismas configuraciones porque no estamos
       *  usando ninguna customizacion dependiente de algun tipo de datos o sintaxis particular de MS SQL o MySQL
       *
       */
      switch (conexion)
      {
        case "mysql":
          optionsBuilder.UseMySql(conn);
          break;

        case "localdb":
        case "sql":
          optionsBuilder.UseSqlServer(conn);
          break;

        default:
          throw new ApplicationException("Debe haber un proveedor...");
      }

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
