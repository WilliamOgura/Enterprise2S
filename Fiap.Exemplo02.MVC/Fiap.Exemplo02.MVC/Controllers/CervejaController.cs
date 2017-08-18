using Fiap.Exemplo02.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Controllers
{
    public class CervejaController : Controller
    {
        private static List<Cerveja> _banco = new List<Cerveja>();
        
        [HttpGet]    
        public ActionResult Cadastrar()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Cerveja cerveja)
        {
            TempData["msg"] = "Cadastrado com sucesso";
            _banco.Add(cerveja);
            return View();
        }
        public ActionResult Listar()
        {
            
            return View(_banco);
        }
    }
}