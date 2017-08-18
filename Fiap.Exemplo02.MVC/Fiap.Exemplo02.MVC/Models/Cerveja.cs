using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.MVC.Models
{
    public class Cerveja
    {
        [DisplayName("Nome")]
        public string Nome { get; set; }
        
        public string Marca { get; set; }

        [DisplayName("Preço")]
        [UIHint("Decimal")]
        public decimal Preco { get; set; }
        [DisplayName("Possui álcool?")]
        public bool SemAlcool { get; set; }
        [DisplayName("Tipo de cerveja")]
        public string Tipo { get; set; }
        [UIHint("Date")]
        public DateTime Validade { get; set; }

    }
}