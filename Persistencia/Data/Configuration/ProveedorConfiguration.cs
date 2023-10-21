using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Proveedor");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(e => e.Nombre)
                        .HasColumnName("nombre")
                        .HasMaxLength(30)
                        .IsRequired();

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Proveedores)
            .HasForeignKey(p => p.Id_TipoPersona);

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Proveedores)
            .HasForeignKey(p => p.Id_Municipio);
        }
    }
}