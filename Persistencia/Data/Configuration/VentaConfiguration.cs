using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(e => e.Fecha)
                        .HasColumnName("fecha")
                        .HasColumnType("datetime")
                        .IsRequired();

            builder.HasOne(p => p.Empleado)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.Id_Empleado);

            builder.HasOne(p => p.Cliente)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.Id_Cliente);

            builder.HasOne(p => p.FormaPago)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.Id_FormaPago);
        }
    }
}