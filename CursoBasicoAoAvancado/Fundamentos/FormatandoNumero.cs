using System.Globalization;

namespace CursoBasicoAoAvancado.Fundamentos
{
    public class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Uma casa decimal;
            Console.WriteLine(valor.ToString("C")); // Moeda local;
            Console.WriteLine(valor.ToString("P")); // Porcentagem;
            Console.WriteLine(valor.ToString("#.##")); // Duas casas decimais;
            
            CultureInfo cultura = new CultureInfo("en-US");

            Console.WriteLine(valor.ToString("C0", cultura)); // Valor real com nenhuma casa decimal;

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Completar com 0 o numero inteiro;
        }
    }
}