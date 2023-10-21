using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("detalleVenta");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.HasOne(p => p.Venta)
            .WithMany(p => p.DetallesVentas)
            .HasForeignKey(p => p.Id_Venta);

            builder.HasOne(p => p.Inventario)
            .WithMany(p => p.DetallesVentas)
            .HasForeignKey(p => p.Id_Producto);

            builder.HasOne(p => p.Talla)
            .WithMany(p => p.DetallesVentas)
            .HasForeignKey(p => p.Id_Talla);

            builder.Property(e => e.Cantidad)
                        .HasColumnName("cantidad")
                        .HasColumnType("int")
                        .HasMaxLength(4)
                        .IsRequired();
        }
    }
}