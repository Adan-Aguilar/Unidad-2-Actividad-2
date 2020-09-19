using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unidad_2_A2.Models;

namespace Unidad_2_A2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            villancicosContext context = new villancicosContext();
            var autores = context.Villancico.OrderByDescending(x => x.Nombre);
            return View(autores);
        }

        public IActionResult Villancico(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("Index");

            }
            villancicosContext context = new villancicosContext();
            var autores = context.Villancico.FirstOrDefault(x => x.Id==id);
            if (autores==null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(autores);
            }
        }
    }
}
