using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    //sealed -> Classe não pode ser herdada
    sealed class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }


        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Tipo == TipoConta.Comum && Saldo < valor)
            {
                throw new Exception("Não foi Possível realizar a Retirada por falta de Saldo");
            }
            else 
            {
                Saldo -= valor;
            }
        }
    }
}
