using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            builder.ToTable("InventarioTalla");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(e => e.Cantidad)
                        .HasColumnName("cantidad")
                        .HasColumnType("int")
                        .HasMaxLength(10)
                        .IsRequired();

            builder.HasKey(t => new {t.Id_Inv, t.Id_Talla});
        }
    }
}