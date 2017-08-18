using Fiap.Exemplo01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Cadastro()
        {
             return View();
        }
       

        public ActionResult Gravar(Paciente paciente)
        {
            TempData["msg"] = "Paciente Gravado!";
            ViewBag.nomePaciente = paciente.Nome;
            ViewBag.dataAniversario = paciente.DataNascimento.ToString("dd/MM/yyyy");
            return View(paciente);
        //    return Content(paciente.Nome +" Você tá gordo e nasceu no dia "+paciente.DataNascimento+" Seu número do convênio é "+paciente.Convenio+" e seu tipo Sanguíneo é "+paciente.Tipo +".");

        }

    }
}