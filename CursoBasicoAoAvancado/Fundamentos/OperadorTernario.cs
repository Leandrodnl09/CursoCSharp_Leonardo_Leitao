namespace CursoBasicoAoAvancado.Fundamentos
{
    public class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultado);
        }
    }
}