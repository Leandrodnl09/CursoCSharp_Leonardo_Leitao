namespace CursoBasicoAoAvancado.MetodosEFuncoes
{
    delegate double Operacoes(double x, double y);
    public class LambdasDelegate
    {
        public static void Executar(){
            Operacoes sum = (x, y) => x + y;
            Operacoes sub = (x, y) => x - y;
            Operacoes mult = (x, y) => x * y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(12, 8));
        }
    }
}