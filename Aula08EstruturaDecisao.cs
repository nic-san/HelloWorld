using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    class Aula08EstruturaDecisao
    {
        public void Aula08()
        {
            /* IF, ELSE, ELSE IF */
            double salario = 0;
            double gastosMensais = 0;
            bool temDecimoTerceiro = false;

            Write("Informe seu salário: ");
            salario = Convert.ToDouble(ReadLine());
            
            Write("Informe os gastos mensais: ");
            gastosMensais = Convert.ToDouble(ReadLine());

            Write("Tem 13º? ");
            Boolean.TryParse(ReadLine(), out temDecimoTerceiro);

            if(temDecimoTerceiro)
            {
                salario += salario;
            }

            if (salario > gastosMensais)
            {
                WriteLine("Sobrou dinheiro!");
            }
            else if(gastosMensais == salario)
            {
                WriteLine("Ufa! Foi por pouco, tô zerado!");
            }
            else
            {
                WriteLine("Precisa economizar!");
            }

            /* Switch Case */

            Write("Informe o saldo do cartão/banco: ");
            var eSaldo = Convert.ToDouble(ReadLine());

            Write("Informe o valor da compra: ");
            var eValor = Convert.ToDouble(ReadLine());

            Write("Informe o tipo de pagamento (C para crédito e D para débito): ");
            char eTipo = Convert.ToChar(ReadLine());

            (double saldo, double compra, char tipo) pagamento = (eSaldo, eValor, eTipo);

            switch (pagamento.tipo)
            {
                case 'C' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com cartão de crédito não aprovada!");
                    break;
                case 'D' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com cartão de débito não aprovada!");
                    break;
                default:
                    WriteLine("Compra aprovada");
                    break;
            }
        }
    }
}
