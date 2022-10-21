namespace CursoBasicoAoAvancado.ClassesEMetodos
{
        class CalculadoraComum
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }
            public int Subtrair(int a, int b)
            {
                return a - b;
            }
            public double Divisao(int a, int b)
            {
                return (double)a / b;
            }
            public int Multiolicacao(int a, int b)
            {
                return a * b;
            }
        }

        class CalculadoraCadeia
        {
            int memoria;

            public CalculadoraCadeia Somar(int a)
            {
                memoria += a;
                return this;
            }

            public CalculadoraCadeia Multiplicar(int a)
            {
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Limpar()
            {
                memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir()
            {
                Console.WriteLine(memoria);
                return this;
            }

            public int Resultado()
            {
                return memoria;
            }
        }

        class MetodosComRetorno
        {
            public static void Executar()
            {
                var CalculadoraComum = new CalculadoraComum();
                var resultado = CalculadoraComum.Somar(5, 5);

                Console.WriteLine(resultado);
                Console.WriteLine(CalculadoraComum.Subtrair(2, 7));
                Console.WriteLine(CalculadoraComum.Divisao(10, 2));
                Console.WriteLine(CalculadoraComum.Multiolicacao(4, 4));

                var CalculadoraCadeia = new CalculadoraCadeia();
                CalculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
            }
        }
    }