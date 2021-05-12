using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Aula01Variaveis
    {
        public void Aula01()
        {
            int idade = 17;
            string nome = "Nicolas";
            bool ativo = false;
            decimal salario = 1230.30m;
            float desconto = 50f;
            var cidade = "Jundiaí";

            WriteLine($"O usuário {nome} tem {idade} anos de idade, está {ativo} no sistema. Recebe {salario} reais de salário e tem desconto de {desconto}% em compras na empresa e mora em {cidade}.");
            Write("\n -------------------------------------- \n");

            dynamic x = "Essa variável é uma string";
            WriteLine(x);

            x = 10;
            WriteLine(x);

            x = true;
            WriteLine(x);
        }
    }
}
