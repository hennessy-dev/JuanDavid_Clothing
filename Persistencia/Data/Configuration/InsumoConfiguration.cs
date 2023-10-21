using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.ToTable("insumo");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.ValorUnit)
                        .HasColumnName("valorUnit")
                        .HasColumnType("double")
                        .HasMaxLength(10)
                        .IsRequired();

            builder.Property(e => e.StockMin)
                        .HasColumnName("stockMin")
                        .HasColumnType("int")
                        .HasMaxLength(4)
                        .IsRequired();  

            builder.Property(e => e.StockMax)
                        .HasColumnName("stockMax")
                        .HasColumnType("int")
                        .HasMaxLength(4)
                        .IsRequired();
        }
    }
}