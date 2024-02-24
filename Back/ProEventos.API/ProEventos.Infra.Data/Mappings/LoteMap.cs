using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;

namespace ProEventos.Infra.Data.Mappings
{
    public class LoteMap : IEntityTypeConfiguration<Lote>
    {
        public void Configure(EntityTypeBuilder<Lote> builder)
        {
            builder.ToTable("LOTE");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Id)
                .HasColumnName("ID");

            builder.Property(l => l.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(l => l.Quantidade)
                .HasColumnName("QUANTIDADE")
                .IsRequired();


            builder.Property(l => l.Preco)
                .HasColumnName("PRECO")
                .IsRequired();

            builder.Property(l => l.DataInicio)
                .HasColumnName("DATAINICIO")
                .IsRequired();


            builder.Property(l => l.DataFim)
                .HasColumnName("DATAFIM")
                .IsRequired();


            builder.HasOne(l => l.Evento)
                .WithMany(l => l.Lotes)
                .HasForeignKey(l => l.EventoId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
