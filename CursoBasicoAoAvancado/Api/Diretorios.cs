using System.IO;

namespace CursoBasicoAoAvancado.Api
{
    public class Diretorios
    {
        static public void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir)){
                Directory.Delete(novoDir, true);
            }
            if (Directory.Exists(novoDirDestino)){
                Directory.Delete(novoDirDestino, true);
            }
            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));
            Console.WriteLine("===== Pastas ====================");

            var pastas = Directory.GetDirectories(dirProjeto);
            foreach ( var pasta in pastas){
                Console.WriteLine(pastas);
            }
            Console.WriteLine("\n\n== Arquivos =================");
            
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos){
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n== Raiz =================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);                        
        }
    }
}