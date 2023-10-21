using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Nombre)
                        .HasColumnName("nombre")
                        .HasColumnType("varchar")
                        .HasMaxLength(50)
                        .IsRequired();

            builder.Property(e => e.FechaRegistro)
                        .HasColumnName("fechaRegistro")
                        .HasColumnType("datetime")
                        .IsRequired();

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.Id_TipoPersona);

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.Id_Municipio);
        }
    }
}