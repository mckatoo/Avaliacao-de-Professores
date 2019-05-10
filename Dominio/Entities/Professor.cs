using System.Collections.Generic;

namespace Dominio.Entidades {
    public class Professor {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<ProfessorDisciplina> Disciplinas { get; set; }
    }
}