namespace CursoBasicoAoAvancado.EstruturaDeControle
{
    public class EstruturaIFELSEIF
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");
            
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Aluno no quadro de honra!");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aluno Aprovado!");
            }
            else if (nota >=  5.0)
            {
                Console.WriteLine("Aluno em Recuperação!");
            }
            else
            {
                Console.WriteLine("Te vejo na proxima....");
            }
            Console.WriteLine("Fim!");

        }
    }
}