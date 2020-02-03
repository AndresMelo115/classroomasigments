using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio1.Models;

namespace Ejercicio_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Captura");
        }

        [HttpGet]
        public IActionResult Captura()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signozod(string nom, int nume1, int nume2)
        {
            switch (nume2)
            {
                case 1:
                    if (nume1 <= 20)
                    {
                        ViewBag.Resultado = " Capricornio ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Acuario ";
                    }
                    break;
                case 2:
                    if (nume1 <= 19)
                    {
                        ViewBag.Resultado = " Acuario ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Piscis ";
                    }
                    break;
                case 3:
                    if (nume1 <= 20)
                    {
                        ViewBag.Resultado = " Piscis ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Aries ";
                    }
                    break;
                case 4:
                    if (nume1 <= 20)
                    {
                        ViewBag.Resultado = " Aries ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Tauro ";
                    }
                    break;
                case 5:
                    if (nume1 <= 21)
                    {
                        ViewBag.Resultado = " Tauro ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Geminis ";
                    }
                    break;
                case 6:
                    if (nume1 <= 21)
                    {
                        ViewBag.Resultado = " Geminis ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Cancer ";
                    }
                    break;
                case 7:
                    if (nume1 <= 23)
                    {
                        ViewBag.Resultado = " Cancer ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Leo ";
                    }
                    break;
                case 8:
                    if (nume1 <= 23)
                    {
                        ViewBag.Resultado = " Leo ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Virgo ";
                    }
                    break;
                case 9:
                    if (nume1 <= 23)
                    {
                        ViewBag.Resultado = " Virgo ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Libra ";
                    }
                    break;
                case 10:
                    if (nume1 <= 23)
                    {
                        ViewBag.Resultado = " Libra ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Escorpio ";
                    }
                    break;
                case 11:
                    if (nume1 <= 22)
                    {
                        ViewBag.Resultado = " Escorpio ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Sagitario ";
                    }
                    break;
                case 12:
                    if (nume1 <= 21)
                    {
                        ViewBag.Resultado = " Sagitario ";
                    }
                    else
                    {
                        ViewBag.Resultado = " Capricornio ";
                    }
                    break;

                default:
                    ViewBag.Resultado = " Ha colocado una numeracion que no coincide con dias o meses ";
                    break;

            }

            ViewBag.Nombre = nom;

            return View("Horoscopo");
        }
    }
}