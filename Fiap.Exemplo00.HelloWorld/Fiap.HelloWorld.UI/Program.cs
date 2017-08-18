using Fiap.HelloWorld.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma classe
            Carro c = new Carro("HONDA");
            Megazord m = new Megazord("Power Rangers");
            //Setar valores nas propriedades
            c.Marca = "Honda";

            //Exibir um valor da propriedade
            Console.WriteLine("Seu barquito é da marca {0} ", c.Marca);
            Console.ReadLine();
        }
    }
}
