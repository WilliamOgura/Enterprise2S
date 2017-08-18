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
        private static List<String> _tipos = new List<String>();

        [HttpGet]    
        public ActionResult Cadastrar()
        {
            _tipos.Add("Large");
            _tipos.Add("Pilsen");
            _tipos.Add("Red Ale");
            _tipos.Add("Weiss");
            //Passar para tela
            ViewBag.tipos = new SelectList(_tipos);
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Cerveja cerveja)
        {
            TempData["msg"] = "Cadastrado com sucesso";
            _banco.Add(cerveja);
            ViewBag.tipos = new SelectList(_tipos);
            return View();
        }
        public ActionResult Listar()
        {
            
            return View(_banco);
        }
    }
}