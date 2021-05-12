using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    class Aula03Operadores
    {
        public void Aula03()
        {
            var x = 10;
            var y = 5;

            var somar = x + y;
            var subtrair = x - y;
            var multiplicar = x * y;
            var dividir = x / y;

            // Atribuições
            //somar += subtrair; equivale a somar = somar + subtrair
            //somar -= subtrair; equivale a somar = somar - subtrair
            //somar *= subtrair; equivale a somar = somar * subtrair
            //somar /= subtrair; equivale a somar = somar / subtrair
            //somar %= subtrair; equivale a somar = somar % subtrair
            // %, usado para retornar o resto da divisão.
            //Incremento e decremento
            //i++ ou i-- (pos incrementado e decrementado) lê e incrementa/decrementa
            //++i ou --i (pré incrementado e decrementado) incrementa/decrementa e lê

            WriteLine(somar);
            WriteLine(subtrair);
            WriteLine(multiplicar);
            WriteLine(dividir);

            ReadKey();
        }
    }
}
