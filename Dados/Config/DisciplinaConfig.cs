using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dados.Config {
    public class DisciplinaConfig : IEntityTypeConfiguration<Disciplina> {
        public void Configure (EntityTypeBuilder<Disciplina> builder) {
            builder
                .HasKey (t => t.Id);
            builder
                .Property (t => t.Nome)
                .IsRequired ()
                .HasMaxLength (100);
        }
    }
}