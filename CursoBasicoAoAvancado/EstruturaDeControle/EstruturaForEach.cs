namespace CursoBasicoAoAvancado.EstruturaDeControle
{
    public class EstruturaForEach
    {
        public static void Executar(){
            var palavra = "Opá!";

            foreach (var letra in palavra){
                Console.WriteLine(letra);
            }

            var alunos = new string[] {"Ana", "Bia", "Carlos"};
            foreach (var aluno in alunos){
                Console.WriteLine(aluno);
            }
        }
    }
}