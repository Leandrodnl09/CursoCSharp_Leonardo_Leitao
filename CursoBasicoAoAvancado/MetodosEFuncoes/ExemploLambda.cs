namespace CursoBasicoAoAvancado.MetodosEFuncoes
{
    public class ExemploLambda
    {
        public static void Executar(){
            Action AlgoNoConsole = () => {
                Console.WriteLine("Lambda com C#!");
            };

            AlgoNoConsole();

            Func<int> JogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(JogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            string.Format("{0:D2}/{1:D2}/{2:D$}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 12, 2019));
        }
    }
}