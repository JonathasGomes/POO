﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13_Polimorfismo
{
    internal class Imposto
    {
        public virtual void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto padrão do vale alimentação R$" + (salario * 0.1));
        }

        public void valeTransporte(double salario)
        {
            Console.WriteLine("Desconto padrão do vale transporte R$" + (salario * 0.6));
        }
    }
}
