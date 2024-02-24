using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;

namespace ProEventos.Infra.Data.Mappings
{
    public class RedeSocialMap : IEntityTypeConfiguration<RedeSocial>
    {
        public void Configure(EntityTypeBuilder<RedeSocial> builder)
        {
            builder.ToTable("REDESOCIAL");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("ID");

            builder.Property(l => l.Nome)
               .HasColumnName("NOME")
               .HasMaxLength(30)
               .IsRequired();

            builder.Property(l => l.Url)
                .HasColumnName("URL")
                .IsRequired();

            builder.HasOne(l => l.Evento)
               .WithMany(l => l.RedesSociais)
               .HasForeignKey(l => l.EventoId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.Palestrante)
              .WithMany(l => l.RedesSociais)
              .HasForeignKey(l => l.PalestranteId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
