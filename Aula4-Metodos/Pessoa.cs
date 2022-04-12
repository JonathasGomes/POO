using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Metodos
{
    class Pessoa
    {
        public void apresentar()
        {
            Console.WriteLine("Olá!!!");
        }

        public void apresentar(string nome)
        {
            Console.WriteLine("Ola " + nome);
        }

        public void apresentar(string nome, int idade)
        {
            Console.WriteLine("Olá " + nome + " você tem " + idade + " anos");
        }
    }
}
