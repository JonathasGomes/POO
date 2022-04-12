using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    class Pessoa
    {
        //Atributos
        public string nome;
        public int idade;

        public void mensagem()
        {
            Console.WriteLine("Olá " + nome + " você tem " + idade + " anos");

        }
    }
}
