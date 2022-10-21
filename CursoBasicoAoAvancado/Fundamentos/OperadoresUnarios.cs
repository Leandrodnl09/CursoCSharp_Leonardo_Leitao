namespace CursoBasicoAoAvancado.Fundamentos
{
    public class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // O valor vira positivo;
            Console.WriteLine(!booleano); // O valor tornasse falso;
            
            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); // É possivel de ser feito isso, porém confuso pois a negação será 1º depois comparação, e por ultimo o incremento;
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}