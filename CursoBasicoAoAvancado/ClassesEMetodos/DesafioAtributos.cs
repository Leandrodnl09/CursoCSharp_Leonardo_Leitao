namespace CursoBasicoAoAvancado.ClassesEMetodos
{
    public class DesafioAtributos
    {
        int a = 10;
        public static void Executar()
        { // Desafio de como acessar a variável "a";
            DesafioAtributos desafio = new DesafioAtributos();
            Console.WriteLine(desafio.a);
        }
    }
}