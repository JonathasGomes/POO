using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8_Encapsulamento
{
    internal class Aluno
    {
        // Atributos
        private double nota1, nota2;
        
        private double Media()
        {
            return (nota1 + nota2)/2;
        }

        public void Mensagem()
        {
            Console.WriteLine("Informe a primeira nota");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informa a segunda nota");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A média é" + Media());
        }
    }
}
