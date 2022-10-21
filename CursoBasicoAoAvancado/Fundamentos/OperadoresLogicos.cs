namespace CursoBasicoAoAvancado.Fundamentos
{
    public class OperadoresLogicos
    {
        static public void Executar()
        {
           var executouTrabalho1 = true;
           var executouTrabalho2 = false;

           bool comprouTV50 = executouTrabalho1 && executouTrabalho2;
           Console.WriteLine("Comprou a TV de 50? {0}", comprouTV50); 

           var comprouSorvete = executouTrabalho1 || executouTrabalho2;
           Console.WriteLine("Comprou o Sorvete? {0}", comprouSorvete);

           var comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
           Console.WriteLine("Comprou a TV de 32? {0}", comprouTV32);

           Console.WriteLine("Mais Saudável? {0}", !comprouTV50);
        }
    }
}