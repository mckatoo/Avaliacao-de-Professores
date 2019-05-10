using System;
using System.Linq;
using System.Threading.Tasks;
using Dados;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc.Models;

namespace Mvc.Controllers {
    public class ProfessorController : Controller {
        private readonly ApplicationDbContext _contexto;

        public ProfessorController (ApplicationDbContext contexto) {
            _contexto = contexto;
        }

        [HttpGet]
        public IActionResult Index () {
            ViewData["Title"] = "Professores";
            var professores = _contexto.Professores.Include (p => p.Disciplinas).ToList ();
            return View (professores);
        }

        [HttpGet]
        public IActionResult Salvar () {
            ViewData["Title"] = "Professores";
            ViewBag.Disciplinas = _contexto.Disciplinas.ToList ();
            return View ();
        }

        [HttpPost]
        public async Task<IActionResult> Salvar (Professor modelo) {
            if (modelo.Id == 0) {
                _contexto.Professores.Add (modelo);
            } else {
                var professor = _contexto.Professores.First (c => c.Id == modelo.Id);
                professor.Nome = modelo.Nome;
            }
            await _contexto.SaveChangesAsync ();
            return RedirectToAction ("Index");
        }

        public IActionResult Editar (int id) {
            var professor = _contexto.Professores.First (c => c.Id == id);
            var disciplinas = professor.Disciplinas;
            return View ("Salvar", new { professor, disciplinas });
        }

        public async Task<IActionResult> Apagar (int id) {
            if (id != 0) {
                var professor = _contexto.Professores.First (c => c.Id == id);
                _contexto.Professores.Remove (professor);
            }
            await _contexto.SaveChangesAsync ();
            return RedirectToAction ("Index");
        }

    }
}