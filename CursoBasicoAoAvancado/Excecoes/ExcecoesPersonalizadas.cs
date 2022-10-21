namespace CursoBasicoAoAvancado.Excecoes
{
    public class NegativoException : Exception {
        public NegativoException() { }
        public NegativoException(string Message) : base(Message) { }
        public NegativoException(string Message, Exception inner) : base(Message, inner) { }
    }
    public class ImparException : Exception {
        public ImparException(string Message) : base(Message) { }
    }
    public class ExcecoesPersonalizadas
    {
        public static int PositivoPar(){
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if(valor < 0){
                throw new NegativoException("Numero negativo :(");
            }

            if (valor % 2 == 1){
                throw new ImparException("Valor Impar :(");
            }
            return valor;
        }
        public static void Executar(){
            try {
                Console.WriteLine(PositivoPar());
            } catch (NegativoException ex){
                Console.WriteLine(ex.Message);
            } catch (ImparException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}