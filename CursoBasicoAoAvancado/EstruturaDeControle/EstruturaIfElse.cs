namespace CursoBasicoAoAvancado.EstruturaDeControle
{
    public class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}