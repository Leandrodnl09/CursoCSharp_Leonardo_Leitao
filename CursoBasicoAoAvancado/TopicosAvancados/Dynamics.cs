namespace CursoBasicoAoAvancado.TopicosAvancados
{
    public class Dynamics
    {
        public static void Executar(){
            dynamic meuObjeto = "teste";

            meuObjeto = 3;
            meuObjeto ++;

            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Júlia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.idade}");
        }
    }
}