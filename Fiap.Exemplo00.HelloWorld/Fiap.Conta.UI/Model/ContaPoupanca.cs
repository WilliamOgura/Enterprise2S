using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fiap.Banco.Model
{
     class ContaPoupanca : Conta, IContaInvestimento
    {
        public readonly decimal _rendimento;

        public decimal Taxa { get; set; }


        public ContaPoupanca(decimal rend)
        {
            _rendimento = rend;
        }


        public decimal CalculaRetornoInvestimento()
        {
            return Saldo = Saldo * _rendimento;
        }


        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }


        public override void Retirar(decimal valor)
        {
            if (Saldo < valor + Taxa)
            {
                throw new Exception("Não foi possível Finalizar a retirada!!");
            }
            else {

            Saldo -= valor+Taxa;
            }
        }
    }
}
