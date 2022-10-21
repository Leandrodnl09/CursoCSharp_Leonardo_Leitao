namespace CursoBasicoAoAvancado.EstruturaDeControle
{
    public class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do{
                Console.WriteLine("Digite seu nome: ");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja Bem-Vindo {0}!", entrada);
                Console.WriteLine("Deseja continuar (S/N)?");
                entrada = Console.ReadLine();

            }while (entrada.ToLower() == "s");
        }
    }
}