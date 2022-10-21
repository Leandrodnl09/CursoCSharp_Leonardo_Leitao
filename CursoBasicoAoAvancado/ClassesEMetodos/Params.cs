namespace CursoBasicoAoAvancado.ClassesEMetodos
{
    public class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine("OLá {0}", pessoa);
            }
        }
        public static void Executar()
        {
            Recepcionar("Pedro", "Bernardo", "Leandro");
        }
    }
}