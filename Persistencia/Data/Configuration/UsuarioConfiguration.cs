using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(e => e.Username)
                        .HasColumnName("username")
                        .HasMaxLength(30)
                        .IsRequired();

            builder.Property(e => e.Email)
                        .HasColumnName("email")
                        .HasMaxLength(30)
                        .IsRequired();

            builder.Property(e => e.Password)
                        .HasColumnName("password")
                        .HasMaxLength(100)
                        .IsRequired();
        }
    }
}