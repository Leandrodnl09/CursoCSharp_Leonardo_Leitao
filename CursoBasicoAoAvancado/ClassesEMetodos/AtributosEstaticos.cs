namespace CursoBasicoAoAvancado.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public double Desconto = 0.1;
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto()
        {

        }
        public double CalculandoDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
    public class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                Desconto = 0.1
            };
            Console.WriteLine("Preço com desconto: {0}", produto1.CalculandoDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalculandoDesconto());
        }
    }
}