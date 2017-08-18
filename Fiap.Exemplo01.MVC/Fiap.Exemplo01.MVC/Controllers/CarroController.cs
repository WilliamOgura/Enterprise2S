using Fiap.Exemplo01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Controllers
{
    public class CarroController : Controller
    {
        // GET: Carro
        public ActionResult Cadastrar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Carro carro)
        {
            return View();
        }
    }
}