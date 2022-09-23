using System;

namespace Aula16_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculo c = new Calculo();
            c.somar(15, 15);
            c.subtrair(20, 5);
        }
    }
}
