using System;

namespace Aula13_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imposto ObjetoE = new Estagiario();
            ObjetoE.valeAlimentacao(1000);
            ObjetoE.valeTransporte(1000);

            Console.WriteLine("----------------");

            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(5000);

            Console.WriteLine("----------------");

            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.valeTransporte(2000);
        }
    }
}
