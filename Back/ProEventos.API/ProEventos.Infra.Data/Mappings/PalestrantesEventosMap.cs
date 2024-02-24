using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Entities;

namespace ProEventos.Infra.Data.Mappings
{
    public class PalestrantesEventosMap : IEntityTypeConfiguration<PalestranteEvento>
    {
        public void Configure(EntityTypeBuilder<PalestranteEvento> builder)
        {
            builder.ToTable("PALESTRANTESEVENTOS");

            builder.HasKey(pe => new { pe.EventoId, pe.PalestranteId});

            builder.HasOne(pe => pe.Evento)
               .WithMany(e => e.PalestrantesEventos)
               .HasForeignKey(pe => pe.EventoId);

            builder.HasOne(pe => pe.Palestrante)
                .WithMany(p => p.PalestrantesEventos)
                .HasForeignKey(pe => pe.PalestranteId);

           

        }
    }
}
