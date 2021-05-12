using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    class Aula06Filas
    {
        public void Aula06()
        {
            //Primeiro que entra = primeiro que sai
            Queue fila = new Queue();
            fila.Enqueue("Nicolas");
            fila.Enqueue("Tony Stark");
            fila.Enqueue("Bruce Wayne");

            WriteLine(fila.Peek());
            WriteLine($"A fila tem {fila.Count} item(ns).");
            WriteLine($"{fila.Dequeue()} saiu da fila");

            WriteLine(fila.Peek());
            WriteLine($"A fila tem {fila.Count} item(ns).");
            WriteLine($"{fila.Dequeue()} saiu da fila");

            WriteLine(fila.Peek());
            WriteLine($"A fila tem {fila.Count} item(ns).");
            WriteLine($"{fila.Dequeue()} saiu da fila");

            WriteLine($"A fila tem {fila.Count} item(ns).");
        }
    }
}
