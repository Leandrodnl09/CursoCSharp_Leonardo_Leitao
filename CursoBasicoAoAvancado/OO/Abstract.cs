namespace CursoBasicoAoAvancado.OO
{
    public abstract class Celular {
        public abstract string Assistente();
        public string Tocar() {
            return "Trim Trim Trim....";
        }
    }
    public class Samsung : Celular {
        public override string Assistente(){
            return "Olá! Meu nome é Bixby!";
        }
    }
    public class Iphone : Celular {
        public override string Assistente(){
            return "Olá! Meu nome é Siri!";
        }
    }
    public class Abstract
    {
        public static void Executar(){
            var celulares = new List<Celular> {
                new Iphone(),
                new Samsung()
            };

            foreach(var celular in celulares){
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}