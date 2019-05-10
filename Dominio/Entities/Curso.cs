using System.Collections.Generic;

namespace Dominio.Entidades {
    public class Curso {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Disciplina> Disciplina { get; set; }
        public virtual ICollection<Ano> Ano { get; set; }
    }
}