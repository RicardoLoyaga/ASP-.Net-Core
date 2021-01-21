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
            escuela.AñoDeCreación = 2021;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Bryan School";
            escuela.Ciudad = "Quito";
            escuela.Pais = "Ecuador";
            escuela.Dirección = "Quitumbe";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            //debe retornar una vista
            return View(escuela);
        }
    }
}