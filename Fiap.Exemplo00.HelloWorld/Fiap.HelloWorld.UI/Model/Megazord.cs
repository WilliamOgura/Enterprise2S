using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Megazord:Veiculo
    {
        public string Forma { get; set; }

        public Megazord(string marca):base(marca)
        {

        }

        public Megazord()
        {
        }

        public override void Acelerar(float velocidade)
        {
            Console.WriteLine("EOQ");
        }

        public override void Ligar()
        {
            Console.WriteLine("Morfando");
        }
    }
}
