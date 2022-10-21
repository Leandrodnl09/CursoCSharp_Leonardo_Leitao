using System.Globalization;
namespace CursoBasicoAoAvancado.Fundamentos
{
    public class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.WriteLine($"{nome} {idade} R$ {salario}");
        }
    }
}