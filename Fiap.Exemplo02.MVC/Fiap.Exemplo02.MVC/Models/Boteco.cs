using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.MVC.Models
{
    public class Boteco
    {
        public int Id { get; set; }
      [Display (Name = "Nome do Estabelecimento :")]
        public string Nome { get; set; }
        [Display(Name = "Endereço :")]
        public string Endereco { get; set; }
        [Display(Name = "Música ao Vivo :")]
        public bool MusicaAoVivo { get; set; }
        [Display(Name = "Consumação")]
        [UIHint("Decimal")]
        public decimal Consumacao { get; set; }
        [Display(Name = "Data de inauguração")]
        [UIHint("Date")]
        public DateTime DataInauguracao { get; set; }


    }
}