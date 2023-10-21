using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("detalleOrden");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(e => e.CantidadProducida)
                        .HasColumnName("cantidadProducida")
                        .HasColumnType("int")
                        .HasMaxLength(4)
                        .IsRequired();

            builder.HasOne(p => p.Orden)
            .WithMany(p => p.DetallesOrdenes)
            .HasForeignKey(p => p.Id_Orden);

            builder.HasOne(p => p.Prenda)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.Id_Prenda);

            builder.HasOne(p => p.Color)
            .WithMany(p => p.DetallesOrdenes)
            .HasForeignKey(p => p.Id_Color);

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.DetallesOrdenes)
            .HasForeignKey(p => p.Id_Estado);
        }
    }
}