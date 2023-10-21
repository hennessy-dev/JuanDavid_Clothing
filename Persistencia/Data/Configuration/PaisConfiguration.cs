using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Pais");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(e => e.Nombre)
                        .HasColumnName("nombre")
                        .HasMaxLength(50)
                        .IsRequired();
        }
    }
}