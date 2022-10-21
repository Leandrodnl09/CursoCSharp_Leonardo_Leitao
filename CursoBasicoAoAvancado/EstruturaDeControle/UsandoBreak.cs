namespace CursoBasicoAoAvancado.EstruturaDeControle
{
    public class UsandoBreak
    {
        public static void Executar()
        {
            Random randam = new Random();
            int numero = randam.Next(1, 51); // Numeros aleatórios de 1 até 50;

            Console.WriteLine("O número que queremos é {0}:", numero);

            for (int i = 1; i >= 50; i++)
            {
                Console.WriteLine("{0} é o número que queremos? ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break; // Nesse caso o o laço do for se encerra assim que o número e encontrado;
                }else{
                    Console.WriteLine("Não!");
                }
            }
            Console.WriteLine("Fim!");
        }
    }
}