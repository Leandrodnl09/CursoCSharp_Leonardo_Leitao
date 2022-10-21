namespace CursoBasicoAoAvancado.ClassesEMetodos
{
    public class Props
    {
        public class CarroOPcional
        {
            double desconto = 0.1;
            string nome;
            public string Nome {
                get
                {
                    return "Opicional: " + nome;
                }
                set
                {
                    nome = value;
                }
            }
            // Propriedade autoimplementada;
            public double Preco { get; set; }

            // Somente leitura;
            public double PrecoComDesconto
            {
                get => Preco - (desconto * Preco); // Lambda
            }

            public CarroOPcional(){

            }

            public CarroOPcional(string nome, double preco){
                this.nome = nome;
                Preco = preco;
            }

        }
        public static void Executar()
        {
            var op1 = new CarroOPcional("Ar Condicionado", 3499.90);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOPcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.90;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}