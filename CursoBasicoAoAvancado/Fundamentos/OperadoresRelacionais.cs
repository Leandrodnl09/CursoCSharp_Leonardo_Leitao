namespace CursoBasicoAoAvancado.Fundamentos
{
    public class OperadoresRelacionais
    {
        static public void Executar()
        {
            // double nota = 6.0;
            Console.Write("Digite a nota: ");
            double notaDeCorte = 7.0;
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Nota Iválida? {0}", nota > 10.0);
            Console.WriteLine("Nota Iválida? {0}", nota < 0.0);
            Console.WriteLine("Nota Perfeita? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por Média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
            
        }
    }
}