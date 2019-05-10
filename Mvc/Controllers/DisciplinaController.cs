using System;
using System.Linq;
using System.Threading.Tasks;
using Dados;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mvc.Controllers {
    public class DisciplinaController : Controller {
        private readonly ApplicationDbContext _contexto;

        public DisciplinaController (ApplicationDbContext contexto) {
            _contexto = contexto;
        }

        [HttpGet]
        public IActionResult Index () {
            ViewData["Title"] = "Disciplinas";
            var disciplinas = _contexto.Disciplinas.Include (t => t.Professores).ToList ();
            return View (disciplinas);
        }

        [HttpGet]
        public IActionResult Salvar () {
            return View ();
        }

        [HttpPost]
        public async Task<IActionResult> Salvar (Disciplina modelo) {
            if (modelo.Id == 0) {
                _contexto.Disciplinas.Add (modelo);
            } else {
                var disciplina = _contexto.Disciplinas.First (c => c.Id == modelo.Id);
                disciplina.Nome = modelo.Nome;
            }
            await _contexto.SaveChangesAsync ();
            return RedirectToAction ("Index");
        }

        public IActionResult Editar (int id) {
            var disciplina = _contexto.Disciplinas.First (c => c.Id == id);
            return View ("Salvar", disciplina);
        }

        public async Task<IActionResult> Apagar (int id) {
            if (id != 0) {
                var disciplina = _contexto.Disciplinas.First (c => c.Id == id);
                _contexto.Disciplinas.Remove (disciplina);
            }
            await _contexto.SaveChangesAsync ();
            return RedirectToAction ("Index");
        }

    }
}