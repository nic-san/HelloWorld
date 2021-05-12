using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    class Aula04Array
    {
        public void Aula04()
        {
            int[] x = new int[3];
            x[0] = 10;
            x[1] = 15;
            x[2] = 20;
            WriteLine(x[1]);

            string[] nomes = new string[2];
            nomes[0] = "Nicolas";
            nomes[1] = "Tony Stark";
            WriteLine(nomes[0]);
            WriteLine(nomes[1]);

            string[] diasSemanas = new string[] { "dom", "seg", "ter", "qua", "qui", "sex", "sab" };
            WriteLine(diasSemanas[3]);
        }
    }
}
