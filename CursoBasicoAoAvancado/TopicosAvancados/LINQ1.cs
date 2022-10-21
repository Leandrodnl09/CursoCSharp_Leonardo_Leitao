using System.Linq;

namespace CursoBasicoAoAvancado.TopicosAvancados
{
    public class Aluno{
        public string Nome;
        public int Idade;
        public double Nota;
    }
    public class LINQ1
    {
        static public void Executar(){
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "André", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Jorge", Idade = 24, Nota = 9.0},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno() {Nome = "Márcio", Idade = 18, Nota = 6.9},
            };
            Console.WriteLine("=== Aprovados ==================");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach(var aluno in alunos){
                Console.WriteLine(aluno.Nome);
            }
            Console.WriteLine("\n=== Chamada ==================");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach(var aluno in chamada){
                Console.WriteLine(aluno);
            }
            Console.WriteLine("\n=== Arpovados (por idade) ==================");
            var alunosAprovados = from aluno in alunos where aluno.Nota >= 7 orderby aluno.Idade select aluno.Nome;

            foreach(var aluno in alunosAprovados){
                Console.WriteLine(aluno);
            }
        }
    }
}