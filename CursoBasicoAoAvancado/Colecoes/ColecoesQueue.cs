using System.Collections.Generic;
using System.Collections;

namespace CursoBasicoAoAvancado.Colecoes
{
    public class ColecoesQueue
    {
        public static void Executar(){
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Cicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
            
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila){
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.33);

            Console.WriteLine(salada.Contains("Item"));
            Console.WriteLine(salada.Contains("item"));
        }
    }
}