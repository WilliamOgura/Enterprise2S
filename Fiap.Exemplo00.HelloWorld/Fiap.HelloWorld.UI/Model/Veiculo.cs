using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
     abstract class Veiculo
    {
        //Field (atributo)
        private string _marca;

        //Gets e sets
        public string Marca
        {
            get { return _marca; }

            set { _marca = value; }
        }

        public Veiculo()
        {

        }
        //CONSTRUTOR    
        public Veiculo(string marca)
        {
            _marca = marca;
        }

        //MÉTODOS 


            //Abstratos
            // Virtual -> permite sobrescrever o método
        public virtual void Acelerar(float velocidade)
        {
            Console.WriteLine("Vrumm");
        }

        public abstract void Ligar();
    }
}
