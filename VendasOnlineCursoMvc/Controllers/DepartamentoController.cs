using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendasOnlineCursoMvc.Models;

namespace VendasOnlineCursoMvc.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Name = "Eletrônicos" });
            list.Add(new Departamento { Id = 2, Name = "Moda" });
            list.Add(new Departamento { Id = 3, Name = "Móveis" });

            return View(list);
        }
    }
}
