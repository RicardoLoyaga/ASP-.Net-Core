using System;
using System.Collections.Generic;
using ASPNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNet.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura()
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programacion"
            };

            return View(asignatura);
        }

        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>() {
                new Asignatura {
                Nombre = "Matemáticas",
                UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                Nombre = "Educación Física",
                UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                Nombre = "Castellano",
                UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                Nombre = "Ciencias Naturales",
                UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                Nombre = "Programacion",
                UniqueId = Guid.NewGuid ().ToString ()
                }
            };

            return View(listaAsignaturas);
        }
    }
}