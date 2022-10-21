namespace CursoBasicoAoAvancado.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public int Somar(int a, int b) // Método de Instância;
        {
            return a + b;
        }
        public static int Multiplicar(int a, int b) // Método de Classe ou Estático;
        {
            return a * b;
        }
    }
    public class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}