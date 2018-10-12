using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parcial2.Models;

namespace Parcial2.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Random()
        {
			var cliente = new Clientes()
			{
				Nombre = "Sebastian",
				Apellido = "Henao",
				Sueldo = 5000000
			};
            return View(cliente);
        }
    }
}