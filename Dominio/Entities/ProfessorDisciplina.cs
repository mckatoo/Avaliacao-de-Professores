namespace Dominio.Entidades {
    public class ProfessorDisciplina {
        public int ProfessorId { get; set; }
        public virtual Professor Professor { get; set; }
        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }
    }
}