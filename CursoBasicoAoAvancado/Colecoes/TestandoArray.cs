namespace CursoBasicoAoAvancado.Colecoes
{
    public class TestandoArray
    {
        
        public static void Executar(){
           
            string [] alunos = new string [5];
            
            alunos[0] = "Leandro";
            alunos[1] = "Bernardo";
            alunos[2] = "Pedro";
            alunos[3] = "Sérgio";
            alunos[4] = "Roseli";

            foreach (var aluno in alunos){
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas){
                somatorio += nota;
            }
            double meida = somatorio / notas.Length;
            Console.WriteLine(meida);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(letras); 
        }
    }
}