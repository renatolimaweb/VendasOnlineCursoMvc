using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VendasOnlineCursoMvc.Models;

namespace VendasOnlineCursoMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            ViewData["TextoDaPagina"] = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi a accumsan elit. Cras arcu turpis, rhoncus et interdum tincidunt, sodales ut justo. Vivamus dui lectus, fringilla at tincidunt a, aliquet id metus. Cras non feugiat arcu, at faucibus dui. Morbi accumsan ornare ipsum a sollicitudin. Donec pellentesque ornare hendrerit. Nulla fringilla nisl non dui euismod sollicitudin. Sed nec fermentum sapien. Etiam eu mauris ac magna luctus consequat non eu odio. Morbi non justo eu orci sagittis aliquet vel et arcu. Quisque ultricies dictum tortor quis efficitur";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
