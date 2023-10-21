using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("departamento");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.HasOne(p => p.Pais)
            .WithMany(p => p.Departamentos)
            .HasForeignKey(p => p.Id_Pais);

            builder.Property(e => e.Nombre)
                        .HasColumnName("nombre")
                        .HasColumnType("varchar")
                        .HasMaxLength(40)
                        .IsRequired();
        }
    }
}