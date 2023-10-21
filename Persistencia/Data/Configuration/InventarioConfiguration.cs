using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("inventario");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.ValorVtaTotal)
                        .HasColumnName("valorVtaTotal")
                        .HasColumnType("double")
                        .HasMaxLength(10)
                        .IsRequired();

            builder.Property(e => e.ValorVtaUsd)
                        .HasColumnName("valorVtaUsd")
                        .HasColumnType("double")
                        .HasMaxLength(10)
                        .IsRequired();


        }
    }
}