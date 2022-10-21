namespace CursoBasicoAoAvancado.ClassesEMetodos
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade}.");
        }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

    }
}