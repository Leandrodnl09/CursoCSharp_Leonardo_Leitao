namespace CursoBasicoAoAvancado.ClassesEMetodos
{
    public class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Leandro";
            sicrano.Idade = 36;

            Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos!");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Lazarin";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();

        }
    }
}