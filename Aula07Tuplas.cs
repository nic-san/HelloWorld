using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    class Aula07Tuplas
    {
        public void Aula07()
        {
            //(string, string, double) brasil = ("Brasil", "Brasília", 1268.43);
            //WriteLine($"O {brasil.Item1}, cuja capital é {brasil.Item2} tem uma renda percapta de {brasil.Item3} reais.");

            (string nome, string tipoGoverno, int populacao, string capital, double rpc) brasil = ("Brasil", "Presidencialismo", 200, "Brasília", 1268.43);
            WriteLine($"O {brasil.nome}, cuja capital é {brasil.capital}, tem uma população de {brasil.populacao} milhões e renda percapta de R${brasil.rpc}.");
        }
    }
}
