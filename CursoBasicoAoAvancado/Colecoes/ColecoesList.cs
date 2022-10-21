using System.Collections.Generic;

namespace CursoBasicoAoAvancado.Colecoes
{
    public class Produto{
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }
    }
    public class ColecoesList
    {
        public static void Executar(){
            var livro = new Produto(" - Game of Thrones", 49.99);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>{
                new Produto(" Camiseta", 29.90),
                new Produto("8ª Temporada Game of Thrones", 99.99),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho){
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" - {item.Nome} {item.Preco}");
            }
        }
    }
}