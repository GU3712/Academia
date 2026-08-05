using Academia.Data;
using Academia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Academia.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AcademiaContext _context;

        public AlunosController(AcademiaContext context)
        {
            _context = context;
        }

        // Listar Alunos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alunos.ToListAsync());
        }

        // GET: Create
        public IActionResult Create() => View();

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }
    }
}