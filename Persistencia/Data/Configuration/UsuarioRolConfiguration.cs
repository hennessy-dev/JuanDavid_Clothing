using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class UsuarioRolConfiguration : IEntityTypeConfiguration<UsuarioRol>
    {
        public void Configure(EntityTypeBuilder<UsuarioRol> builder)
        {
            builder.ToTable("UsuarioRol");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.HasKey(t => new {t.Id_Usuario, t.Id_Rol});
        }
    }
}