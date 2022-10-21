namespace CursoBasicoAoAvancado.ClassesEMetodos
{
    public class ExemploEnum
    {   
        public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

        public class Filme 
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var FilmeParaFamilia = new Filme();
            FilmeParaFamilia.Titulo = "Sharknardo 17";
            FilmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}", FilmeParaFamilia.Titulo, FilmeParaFamilia.GeneroDoFilme);
        }
    }
}