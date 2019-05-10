using System.Collections.Generic;

namespace Dominio.Entidades {
    public class Disciplina {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<ProfessorDisciplina> Professores { get; set; }
    }
}