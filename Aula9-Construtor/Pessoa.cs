using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9_Construtor
{
    internal class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("Construtor executado");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("Olá" + nome);
        }
    }
}
