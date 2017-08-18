using Fiap.Exemplo01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Gravar(Cliente cliente)
        {
            
            return View(cliente);
        }
    }
}