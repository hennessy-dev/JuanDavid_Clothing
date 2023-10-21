using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("InsumoPrenda");

            builder.Property(e => e.Cantidad)
                        .HasColumnName("cantidad")
                        .HasColumnType("int")
                        .HasMaxLength(4)
                        .IsRequired();

            builder.HasKey(t => new {t.Id_Prenda, t.Id_Insumo});
        }
    }
}