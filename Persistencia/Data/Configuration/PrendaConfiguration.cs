using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            builder.ToTable("Prenda");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(e => e.Nombre)
                        .HasColumnName("nombre")    
                        .HasMaxLength(30)
                        .IsRequired();

            builder.Property(e => e.ValorUnitCop)
                        .HasColumnName("valorUnitCop")
                        .HasColumnType("double")
                        .HasMaxLength(10)
                        .IsRequired();

            builder.Property(e => e.ValorUnitUsd)
                        .HasColumnName("valorUnitUsd")
                        .HasColumnType("double")
                        .HasMaxLength(10)
                        .IsRequired();

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.Id_Estado);

            builder.HasOne(p => p.TipoProteccion)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.Id_TipoProteccion);

            builder.HasOne(p => p.Genero)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.Id_Genero);
        }
    }
}