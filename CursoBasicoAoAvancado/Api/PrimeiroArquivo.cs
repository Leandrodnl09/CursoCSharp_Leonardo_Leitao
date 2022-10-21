namespace CursoBasicoAoAvancado.Api
{
    public static class ExtencaoString {
        public static string ParseHome(this string path){
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
            ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    public class PrimeiroArquivo
    {
        public static void Executar(){
            var path = @"~/Primeiro_Arquivo.txt".ParseHome();

            if(!File.Exists(path)){
                using (StreamWriter sw = File.CreateText(path)){
                sw.WriteLine("Esse é");
                sw.WriteLine("o nosso");
                sw.WriteLine("primeiro");
                sw.WriteLine("arquivo!");                   
                }
            }
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("É Possivel");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!"); 
            }
        }
    }
}