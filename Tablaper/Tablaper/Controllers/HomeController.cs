using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tablaper.Models;

namespace Tablaper.Controllers
{

   
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var Elemental = Tablaview();

            return View("Tablaview",Elemental);
        }

        public IActionResult Tablaview()
        {
            List<Elementosp> elementoper = new List<Elementosp>();

          
            var elemento1 = new Elementosp("H", "Onometal", "on");
            var elemento2 = new Elementosp("He", "GasNob", "on");
            var elemento3 = new Elementosp("Li", "Alcalino", "on");
            var elemento4 = new Elementosp("Be", "Alcalinoterreo", "on");
            var elemento5 = new Elementosp("B", "Metaloide", "on");
            var elemento6 = new Elementosp("C", "Onometal", "on");
            var elemento7 = new Elementosp("N", "Onometal", "on");
            var elemento8 = new Elementosp("O", "Onometal", "on");
            var elemento9 = new Elementosp("F", "Halogeno", "on");
            var elemento10 = new Elementosp("Ne", "GasNob", "on");

            var elemento11 = new Elementosp("Na", "Alcalino", "on");
            var elemento12 = new Elementosp("Mg", "Alcalinoterreo", "on");
            var elemento13 = new Elementosp("Al", "Otrometal", "on");
            var elemento14 = new Elementosp("Si", "Metaloide", "on");
            var elemento15 = new Elementosp("P", "Onometal", "on");
            var elemento16 = new Elementosp("S", "Onometal", "on");
            var elemento17 = new Elementosp("Cl", "Halogeno", "on");
            var elemento18 = new Elementosp("Ar", "GasNob", "on");
            var elemento19 = new Elementosp("K", "Alcalino", "on");
            var elemento20 = new Elementosp("Ca", "Alcalinoterreo", "on");

            var elemento21 = new Elementosp("Sc", "Metalestrans", "on");
            var elemento22 = new Elementosp("Ti", "Metalestrans", "on");
            var elemento23 = new Elementosp("V", "Metalestrans", "on");
            var elemento24 = new Elementosp("Cr", "Metalestrans", "on");
            var elemento25 = new Elementosp("Mn", "Metalestrans", "on");
            var elemento26 = new Elementosp("Fe", "Metalestrans", "on");
            var elemento27 = new Elementosp("Co", "Metalestrans", "on");
            var elemento28 = new Elementosp("Ni", "Metalestrans", "on");
            var elemento29 = new Elementosp("Cu", "Metalestrans", "on");
            var elemento30 = new Elementosp("Zn", "Metalestrans", "on");

            var elemento31 = new Elementosp("Ga", "Otrometal", "on");
            var elemento32 = new Elementosp("Ge", "Metaloide", "on");
            var elemento33 = new Elementosp("As", "Metaloide", "on");
            var elemento34 = new Elementosp("Se", "Onometal", "on");
            var elemento35 = new Elementosp("Br", "Halogeno", "on");
            var elemento36 = new Elementosp("Kr", "GasNob", "on");
            var elemento37 = new Elementosp("Rb", "Alcalino", "on");
            var elemento38 = new Elementosp("Sr", "Alcalinoterreo", "on");
            var elemento39 = new Elementosp("Y", "Metalestrans", "on");
            var elemento40 = new Elementosp("Zr", "Metalestrans", "on");

            var elemento41 = new Elementosp("Nb", "Metalestrans", "on");
            var elemento42 = new Elementosp("Mo", "Metalestrans", "on");
            var elemento43 = new Elementosp("Tc", "Metalestrans", "on");
            var elemento44 = new Elementosp("Ru", "Metalestrans", "on");
            var elemento45 = new Elementosp("Rh", "Metalestrans", "on");
            var elemento46 = new Elementosp("Pd", "Metalestrans", "on");
            var elemento47 = new Elementosp("Ag", "Metalestrans", "on");
            var elemento48 = new Elementosp("Cd", "Metalestrans", "on");
            var elemento49 = new Elementosp("In", "Otrometal", "on");
            var elemento50 = new Elementosp("Sn", "Otrometal", "on");

            var elemento51 = new Elementosp("Sb", "Metaloide", "on");
            var elemento52 = new Elementosp("Te", "Metaloide", "on");
            var elemento53 = new Elementosp("I", "Halogeno", "on");
            var elemento54 = new Elementosp("Xe", "GasNob", "on");
            var elemento55 = new Elementosp("Cs", "Alcalino", "on");
            var elemento56 = new Elementosp("Ba", "Alcalinoterreo", "on");
            var elemento57 = new Elementosp("La-Lu", "Lantinido", "on");
            var elemento58 = new Elementosp("Hf", "Metalestrans", "on");
            var elemento59 = new Elementosp("Ta", "Metalestrans", "on");
            var elemento60 = new Elementosp("W", "Metalestrans", "on");

            var elemento61 = new Elementosp("Re", "Metalestrans", "on");
            var elemento62 = new Elementosp("Os", "Metalestrans", "on");
            var elemento63 = new Elementosp("Ir", "Metalestrans", "on");
            var elemento64 = new Elementosp("Pt", "Metalestrans", "on");
            var elemento65 = new Elementosp("Au", "Metalestrans", "on");
            var elemento66 = new Elementosp("Hg", "Metalestrans", "on");
            var elemento67 = new Elementosp("Tl", "Otrometal", "on");
            var elemento68 = new Elementosp("Pb", "Otrometal", "on");
            var elemento69 = new Elementosp("Bi", "Otrometal", "on");
            var elemento70 = new Elementosp("Po", "Metaloide", "on");

            var elemento71 = new Elementosp("At", "Halogeno", "on");
            var elemento72 = new Elementosp("Rn", "GasNob", "on");
            var elemento73 = new Elementosp("Fr", "Alcalino", "on");
            var elemento74 = new Elementosp("Ra", "Alcalinoterreo", "on");
            var elemento75 = new Elementosp("Ac-Lr", "Actinido", "on");
            var elemento76 = new Elementosp("Rf", "Metalestrans", "on");
            var elemento77 = new Elementosp("Db", "Metalestrans", "on");
            var elemento78 = new Elementosp("Sg", "Metalestrans", "on");
            var elemento79 = new Elementosp("Bh", "Metalestrans", "on");
            var elemento80 = new Elementosp("Hs", "Metalestrans", "on");

            var elemento81 = new Elementosp("Mt", "Metalestrans", "on");
            var elemento82 = new Elementosp("Ds", "Metalestrans", "on");
            var elemento83 = new Elementosp("Rg", "Metalestrans", "on");
            var elemento84 = new Elementosp("Cn", "Metalestrans", "on");
            var elemento85 = new Elementosp("Nh", "Otrometal", "on");
            var elemento86 = new Elementosp("Fl", "Otrometal", "on");
            var elemento87 = new Elementosp("Mc", "Otrometal", "on");
            var elemento88 = new Elementosp("Lv", "Otrometal", "on");
            var elemento89 = new Elementosp("Ts", "Halogeno", "on");
            var elemento90 = new Elementosp("Og", "GasNob", "on");

            var elemento91 = new Elementosp("La", "Lantinido", "on");
            var elemento92 = new Elementosp("Ce", "Lantinido", "on");
            var elemento93 = new Elementosp("Pr", "Lantinido", "on");
            var elemento94 = new Elementosp("Nd", "Lantinido", "on");
            var elemento95 = new Elementosp("Pm", "Lantinido", "on");
            var elemento96 = new Elementosp("Sm", "Lantinido", "on");
            var elemento97 = new Elementosp("Eu", "Lantinido", "on");
            var elemento98 = new Elementosp("Gd", "Lantinido", "on");
            var elemento99 = new Elementosp("Tb", "Lantinido", "on");
            var elemento100 = new Elementosp("Dy", "Lantinido", "on");

            var elemento101 = new Elementosp("Ho", "Lantinido", "on");
            var elemento102 = new Elementosp("Er", "Lantinido", "on");
            var elemento103 = new Elementosp("Tm", "Lantinido", "on");
            var elemento104 = new Elementosp("Yb", "Lantinido", "on");
            var elemento105 = new Elementosp("Lu", "Lantinido", "on");
            var elemento106 = new Elementosp("Ac", "Actinido", "on");
            var elemento107 = new Elementosp("Th", "Actinido", "on");
            var elemento108 = new Elementosp("Pa", "Actinido", "on");
            var elemento109 = new Elementosp("U", "Actinido", "on");
            var elemento110 = new Elementosp("Np", "Actinido", "on");

            var elemento111 = new Elementosp("Pu", "Actinido", "on");
            var elemento112 = new Elementosp("Am", "Actinido", "on");
            var elemento113 = new Elementosp("Cm", "Actinido", "on");
            var elemento114 = new Elementosp("Bk", "Actinido", "on");
            var elemento115 = new Elementosp("Cf", "Actinido", "on");
            var elemento116 = new Elementosp("Es", "Actinido", "on");
            var elemento117 = new Elementosp("Fm", "Actinido", "on");
            var elemento118 = new Elementosp("Md", "Actinido", "on");
            var elemento119 = new Elementosp("No", "Actinido", "on");
            var elemento120 = new Elementosp("Lr", "Actinido", "on");

            elementoper.Add(elemento1);
            elementoper.Add(elemento2);
            elementoper.Add(elemento3);
            elementoper.Add(elemento4);
            elementoper.Add(elemento5);
            elementoper.Add(elemento6);
            elementoper.Add(elemento7);
            elementoper.Add(elemento8);
            elementoper.Add(elemento9);
            elementoper.Add(elemento10);

            elementoper.Add(elemento11);
            elementoper.Add(elemento12);
            elementoper.Add(elemento13);
            elementoper.Add(elemento14);
            elementoper.Add(elemento15);
            elementoper.Add(elemento16);
            elementoper.Add(elemento17);
            elementoper.Add(elemento18);
            elementoper.Add(elemento19);
            elementoper.Add(elemento20);

            elementoper.Add(elemento21);
            elementoper.Add(elemento22);
            elementoper.Add(elemento23);
            elementoper.Add(elemento24);
            elementoper.Add(elemento25);
            elementoper.Add(elemento26);
            elementoper.Add(elemento27);
            elementoper.Add(elemento28);
            elementoper.Add(elemento29);
            elementoper.Add(elemento30);

            elementoper.Add(elemento31);
            elementoper.Add(elemento32);
            elementoper.Add(elemento33);
            elementoper.Add(elemento34);
            elementoper.Add(elemento35);
            elementoper.Add(elemento36);
            elementoper.Add(elemento37);
            elementoper.Add(elemento38);
            elementoper.Add(elemento39);
            elementoper.Add(elemento40);

            elementoper.Add(elemento41);
            elementoper.Add(elemento42);
            elementoper.Add(elemento43);
            elementoper.Add(elemento44);
            elementoper.Add(elemento45);
            elementoper.Add(elemento46);
            elementoper.Add(elemento47);
            elementoper.Add(elemento48);
            elementoper.Add(elemento49);
            elementoper.Add(elemento50);

            elementoper.Add(elemento51);
            elementoper.Add(elemento52);
            elementoper.Add(elemento53);
            elementoper.Add(elemento54);
            elementoper.Add(elemento55);
            elementoper.Add(elemento56);
            elementoper.Add(elemento57);
            elementoper.Add(elemento58);
            elementoper.Add(elemento59);
            elementoper.Add(elemento60);

            elementoper.Add(elemento61);
            elementoper.Add(elemento62);
            elementoper.Add(elemento63);
            elementoper.Add(elemento64);
            elementoper.Add(elemento65);
            elementoper.Add(elemento66);
            elementoper.Add(elemento67);
            elementoper.Add(elemento68);
            elementoper.Add(elemento69);
            elementoper.Add(elemento70);

            elementoper.Add(elemento71);
            elementoper.Add(elemento72);
            elementoper.Add(elemento73);
            elementoper.Add(elemento74);
            elementoper.Add(elemento75);
            elementoper.Add(elemento76);
            elementoper.Add(elemento77);
            elementoper.Add(elemento78);
            elementoper.Add(elemento79);
            elementoper.Add(elemento80);

            elementoper.Add(elemento81);
            elementoper.Add(elemento82);
            elementoper.Add(elemento83);
            elementoper.Add(elemento84);
            elementoper.Add(elemento85);
            elementoper.Add(elemento86);
            elementoper.Add(elemento87);
            elementoper.Add(elemento88);
            elementoper.Add(elemento89);
            elementoper.Add(elemento90);

            elementoper.Add(elemento91);
            elementoper.Add(elemento92);
            elementoper.Add(elemento93);
            elementoper.Add(elemento94);
            elementoper.Add(elemento95);
            elementoper.Add(elemento96);
            elementoper.Add(elemento97);
            elementoper.Add(elemento98);
            elementoper.Add(elemento99);
            elementoper.Add(elemento100);

            elementoper.Add(elemento101);
            elementoper.Add(elemento102);
            elementoper.Add(elemento103);
            elementoper.Add(elemento104);
            elementoper.Add(elemento105);
            elementoper.Add(elemento106);
            elementoper.Add(elemento107);
            elementoper.Add(elemento108);
            elementoper.Add(elemento109);
            elementoper.Add(elemento110);

            elementoper.Add(elemento111);
            elementoper.Add(elemento112);
            elementoper.Add(elemento113);
            elementoper.Add(elemento114);
            elementoper.Add(elemento115);
            elementoper.Add(elemento116);
            elementoper.Add(elemento117);
            elementoper.Add(elemento118);
            elementoper.Add(elemento119);
            elementoper.Add(elemento120);

            ViewBag.tablaperd = elementoper;


            return View();
        }    
        
    }
}
