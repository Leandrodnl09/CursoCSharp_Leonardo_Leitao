namespace CursoBasicoAoAvancado.MetodosEFuncoes
{
    public class DelegateFuncAnonima
    {
        delegate string StringOperacoes(string s);
        static public void Executar(){
            StringOperacoes inverter = delegate(string s){
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };
            Console.WriteLine(inverter("C# é Show!!!"));
        }
    }
}