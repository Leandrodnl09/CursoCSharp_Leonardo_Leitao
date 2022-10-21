namespace CursoBasicoAoAvancado.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {   // Área da circunferência
            double raio = 4.5;
            const double PI = 3.14;
            // Quando é constante a váriavel não pode ser mudado;
            //PI = 3.225;
            double area = PI * raio * raio;
            Console.WriteLine(area);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // sbyte e para comocar sinal "-45";
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado, com sinal;
            Console.WriteLine("Menor valor do int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // Número inteiro sem sinal;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;// Número com sinal;
            Console.WriteLine("Menor Valor Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; // Número sem sinal;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f; // o F mo final é para numeros flout, pois tem menor capacidade de amarzenamento do double;
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais;
            Console.WriteLine("Valor da Apple " + valorDeMercadoDaApple);
            
            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreAsEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine("Texto " + texto);
        }
    }
}