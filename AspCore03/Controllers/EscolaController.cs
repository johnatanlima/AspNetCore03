using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AspCore03.Models;
using AspCore03.Data;
using System.Collections.Generic;

namespace AspCore03.Controllers
{
    public class EscolaController : Controller
    {
        private readonly EscolaDbContext _context;
        
        public EscolaController(EscolaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
          //  IList<Escola> lista = new List<Escola>();
            //lista =_context.Escolas.ToList();

            return View(_context.Escolas.ToList());
        }

        [HttpGet]
        public IActionResult NovaEscola()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NovaEscola(Escola escolaParam){
            
            if (ModelState.IsValid)
            {
                _context.Add(escolaParam);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(escolaParam);
        } 

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
