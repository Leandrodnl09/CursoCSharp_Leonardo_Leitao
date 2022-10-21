namespace CursoBasicoAoAvancado.Fundamentos
{
    public class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length); // Length é para contar os caracteres;

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); // ? serve pra executar e o código fica mais seguro;
        }
    }
}