using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio2.Models;

namespace Ejercicio2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Operacion");
        }
        [HttpGet]
        public IActionResult Operacion()
        {          
            return View();
        }
        [HttpPost]
        public IActionResult Ecuacion(int nume1, int nume2, int nume3)
        {
            
            var resultadoA = -nume2 + ((Math.Sqrt(((nume2 * nume2) - (4 * nume1 * nume3)))));
            var resultadoB = -nume2 - ((Math.Sqrt(((nume2 * nume2) - (4 * nume1 * nume3)))));
            
            ViewBag.ResultadoA = resultadoA;
            ViewBag.ResultadoB = resultadoB;
            ViewBag.divisor = nume1*2;

            return View("Total");
        }

    }
}
