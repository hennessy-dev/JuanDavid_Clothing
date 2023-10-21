using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("Orden");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(e => e.Fecha)
                        .HasColumnName("fecha")
                        .HasColumnType("datetime")
                        .IsRequired();

            builder.HasOne(p => p.Empleado)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.Id_Empleado);

            builder.HasOne(p => p.Cliente)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.Id_Cliente);

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.Id_Estado);
        }
    }
}