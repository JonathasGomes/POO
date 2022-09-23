using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15_Abstracao
{
    abstract class Padrao
    {
        // Método obrigatório
        public abstract void taxaEmprestimo(double valor);

        // Opcional
        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos obtidos pela poupança"+(valor * taxa));
        }
    }
}
