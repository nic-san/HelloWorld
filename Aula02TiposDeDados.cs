using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    class Aula02TiposDeDados
    {
        public void Aula02()
        {
            /* Tipos de dados
             * 
            bool  true / false
            byte
            char  'asdf'
            decimal 
            double
            enum 
            float
            int
            long
            sbyte
            short
            struct
            uint
            ulong
            ushort
            string
            */

            /*char status = 'Á';
            int idade = 17;
            string nome = "Nicolas";
            */

            int n1 = 10;
            //long n2 = n1; OK
            short n2 = (short)n1; //sem o cast, da erro, pois int > short

            WriteLine(n2);

            ReadKey();
        }
    }
}
