using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("cargo");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Descripcion)
                        .HasColumnName("descripcion")
                        .HasColumnType("varchar")
                        .HasMaxLength(50)
                        .IsRequired();

            builder.Property(e => e.SueldoBase)
                        .HasColumnName("sueldoBase")
                        .HasColumnType("double")
                        .IsRequired();
        }
    }
}