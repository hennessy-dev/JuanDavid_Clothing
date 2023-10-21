using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class TallaConfiguration : IEntityTypeConfiguration<Talla>
    {
        public void Configure(EntityTypeBuilder<Talla> builder)
        {
            builder.ToTable("Talla");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(e => e.Descripcion)
                        .HasColumnName("descripcion")
                        .HasColumnType("varchar")
                        .HasMaxLength(40)
                        .IsRequired();
        }
    }
}