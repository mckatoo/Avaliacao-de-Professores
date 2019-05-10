using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dados.Config {
    public class ProfessorConfig : IEntityTypeConfiguration<Professor> {
        public void Configure (EntityTypeBuilder<Professor> builder) {
            builder
                .HasKey (p => p.Id);
            builder
                .Property (t => t.Nome)
                .IsRequired ()
                .HasMaxLength (100);
        }
    }
}