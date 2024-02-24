using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Entities;

namespace ProEventos.Infra.Data.Mappings
{
    public class PalestranteMap : IEntityTypeConfiguration<Palestrante>
    {
        public void Configure(EntityTypeBuilder<Palestrante> builder)
        {
            builder.ToTable("PALESTRANTE");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.Nome)
               .HasColumnName("NOME")
               .HasMaxLength(30)
               .IsRequired();

            builder.Property(p => p.Telefone)
                .HasColumnName("TELEFONE")
                .IsRequired();


            builder.Property(p => p.MiniCurriculo)
                .HasColumnName("MINICURRICULO")
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnName("EMAIL")
                .IsRequired();


            builder.Property(p => p.ImagemUrl)
                .HasColumnName("IMAGEMURL")
                .IsRequired();
        }
    }
}
