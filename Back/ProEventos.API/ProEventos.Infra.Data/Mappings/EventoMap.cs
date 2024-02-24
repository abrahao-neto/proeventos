using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Entities;

namespace ProEventos.Infra.Data.Mappings
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.ToTable("EVENTOS");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("ID");

            builder.Property(e => e.Tema)
                .HasColumnName("TEMA")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.Email)
               .HasColumnName("EMAIL")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(e => e.Telefone)
                .HasColumnName("TELEFONE")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(e => e.DataEvento)
                .HasColumnName("DATAEVENTO")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.QtdPessoas)
                .HasColumnName("QTDPESSOAS")
                .IsRequired();

            builder.Property(e => e.ImagemURL)
                .HasColumnName("IMAGEMURL")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.Local)
                .HasColumnName("LOCAL")
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
