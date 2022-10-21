namespace CursoBasicoAoAvancado.Fundamentos
{
    public class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leandro"; // Automaticamente o C# converteu o "var" em "string"
            Console.WriteLine(nome);

            // nome = 123; // Impossivel converter;

            var idade = 36; // Quando é "var", obrigatoriamente terá que colocar o valor;
            Console.WriteLine("Idade " + idade);

        }
    }
}