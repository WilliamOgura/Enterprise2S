using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente()
            {
                Agencia = 123,
                Numero = 321,
                DataAbertura = DateTime.Now,
                Saldo = 10000,
                Tipo =Model.TipoConta.Comum
            };

            ContaPoupanca cp = new ContaPoupanca(0.1m)
            {
                Agencia = 2,
                Numero = 32,
                DataAbertura = DateTime.Now,
                Saldo = 7000,
                Taxa = 1
            };


            //Chamar os métodos

            cc.Depositar(80000);
            cc.Retirar(80);
            Console.WriteLine(cc.Saldo);
            Console.WriteLine(cp.CalculaRetornoInvestimento());
            Console.ReadLine();


        }

    }
}
