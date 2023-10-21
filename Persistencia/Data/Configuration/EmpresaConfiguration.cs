using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("empresa");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(e => e.RazonSocial)
                        .HasColumnName("razonSocial")
                        .HasColumnType("varchar")
                        .HasMaxLength(50)
                        .IsRequired();

            builder.Property(e => e.RepresentanteLegal)
                        .HasColumnName("representanteLegal")
                        .HasColumnType("varchar")
                        .HasMaxLength(50)
                        .IsRequired();

            builder.Property(e => e.FechaCreacion)
                        .HasColumnName("fechaCreacion")
                        .HasColumnType("datetime")
                        .IsRequired();

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Empresas)
            .HasForeignKey(p => p.Id_Municipio);
        }
    }
}