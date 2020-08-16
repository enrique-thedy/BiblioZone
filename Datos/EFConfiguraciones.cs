using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos
{
  public class ConfigurarPublicaciones : IEntityTypeConfiguration<Publicacion>
  {
    public void Configure(EntityTypeBuilder<Publicacion> builder)
    {
      builder
        .HasKey(pub => pub.Clave);

      //  builder.ToTable("Publicaciones");

      builder
        .Property(pub => pub.ISBN13)
        .HasColumnName("ISBN_13");

      builder
        .Property(pub => pub.Clave)
        .HasColumnName("ID_Pub");

      builder.Ignore(pub => pub.Vendidos);

      builder.HasOne(pub => pub.Autor)
        .WithMany()
        .HasForeignKey("ID_Autor");
    }
  }

  public class ConfigurarAutores : IEntityTypeConfiguration<Autor>
  {
    public void Configure(EntityTypeBuilder<Autor> builder)
    {
      //  builder.HasKey(aut => aut.ID);
      builder.ToTable("Autores");
      //  builder.Property(aut => aut.ID).HasColumnName("ID");
    }
  }
}
