using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Pratica2
{
    internal class Pessoa
    {
        public double peso, altura;

        public double IMC()
        {
            return peso / (altura * altura);

        }

        public string situacao(double IMC)
        {
            string retorno;

            if (IMC < 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if (IMC < 25)
            {
                retorno = "Peso normal";
            }
            else if (IMC < 30)
            {
                retorno = "Acima do peso";
            }
            else if (IMC < 35)
            {
                retorno = "Obesidade I";
            }
            else if (IMC < 40)
            {
                retorno = "Obesidade II";
            }
            else
            {
                retorno = "Obesidade III";
            }

            return retorno;
        }
        public void mensagem()
        {
            double ObterCalculo = IMC();

            string ObterSituacao = situacao(ObterCalculo);

            Console.WriteLine("Seu calculo é" + ObterCalculo);
            Console.WriteLine("Sua situação é" + ObterSituacao);
        }
    }
}
