using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class FormaPagoConfiguration : IEntityTypeConfiguration<FormaPago>
    {
        public void Configure(EntityTypeBuilder<FormaPago> builder)
        {
            builder.ToTable("formaPago");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(e => e.Descripcion)
                        .HasColumnName("descripcion")
                        .HasColumnType("varchar")
                        .HasMaxLength(60)
                        .IsRequired();
        }
    }
}