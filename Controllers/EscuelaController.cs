using System;
using ASPNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNet.Controllers
{
    public class EscuelaController: Controller
    {
        //metodo o accion
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoFundación = 2021;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "Bryan School";
            //debe retornar una vista
            return View(escuela);
        }
    }
}