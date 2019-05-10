using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dados.Config {
    public class ProfessorDisciplinaConfig : IEntityTypeConfiguration<ProfessorDisciplina> {
        public void Configure (EntityTypeBuilder<ProfessorDisciplina> builder) {
            builder
                .HasKey (t => new { t.ProfessorId, t.DisciplinaId });
        }
    }
}