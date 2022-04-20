using System;

namespace Aula6_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.altura = 1.75;
            p.peso = 65;
            p.mensagem();
        }
    }
}
