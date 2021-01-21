using System;
using System.Collections.Generic;
using System.Linq;
using ASPNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNet.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            var alumno = new Alumno()
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "José López"
            };

            return View(alumno);
        }

        public IActionResult MultiAlumno()
        {
            var listaAlumno =  GenerarAlumnosAlAzar();

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View(listaAlumno);
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { 
                                   Nombre = $"{n1} {n2} {a1}" ,
                                   UniqueId = Guid.NewGuid().ToString()
                                   };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
}