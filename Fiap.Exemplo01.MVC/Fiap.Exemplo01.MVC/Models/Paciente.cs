using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo01.MVC.Models
{
    public class Paciente
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
        public string Convenio { get; set; }
        public string Tipo { get; set; }
    
    }
}