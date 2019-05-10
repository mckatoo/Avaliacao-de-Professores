using Dados.Config;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Dados {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) {

        }

        public IConfiguration Configuration { get; }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration (new ProfessorConfig ());
            modelBuilder.ApplyConfiguration (new DisciplinaConfig ());
            modelBuilder.ApplyConfiguration (new ProfessorDisciplinaConfig ());
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Ano> Anos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<ProfessorDisciplina> ProfessorDisciplinas { get; set; }
    }
}