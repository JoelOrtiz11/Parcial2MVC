using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Parcial2MVC.Models;

namespace Parcial2MVC.Controllers
{
    public class registrosController : Controller
    {
        private readonly casoscovidContext _casoscovidContext;

        public registrosController(casoscovidContext casoscovidContext) 
        {
            _casoscovidContext = casoscovidContext;
        }
        public IActionResult Index()
        {
            var listadeDepar = (from m in _casoscovidContext.departamento
                                select m).ToList();
            ViewData["listadodeDepar"] = new SelectList(listadeDepar, "id_departamento", "nombre_departamento");

            return View();
        }
    }
}
