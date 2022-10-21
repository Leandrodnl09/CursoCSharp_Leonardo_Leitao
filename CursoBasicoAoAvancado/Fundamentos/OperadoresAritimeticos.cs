namespace CursoBasicoAoAvancado.Fundamentos
{
    public class OperadoresAritimeticos
    {
        static public void Executar()
        {   // Preço com desconto;
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalDesconto = total - (total * desconto);
            Console.WriteLine("O Preço final é {0}", totalDesconto);

            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC : {imc}.");

            // Numero par e impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0} /2 tem resto de {1}", par, par % 2);
            Console.WriteLine("{0} /2 tem resto de {1}", impar, impar % 2);
        }
    }
}