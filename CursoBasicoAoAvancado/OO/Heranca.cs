namespace CursoBasicoAoAvancado.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelociaddeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int AlterarVelocodade(int delta)
        {
            int novaVelocidade = VelociaddeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelociaddeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelociaddeAtual = VelocidadeMaxima;
            }
            else
            {
                VelociaddeAtual = novaVelocidade;
            }
            return VelociaddeAtual;
        }

        public virtual int Acelerar()
        {
            return AlterarVelocodade(5);
        }
        public int Frear()
        {
            return AlterarVelocodade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }
    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }
        public override int Acelerar()
        {
            return AlterarVelocodade(15);
        }
        // Oculta o método da classe Pai;
        public new int Frear()
        {
            return AlterarVelocodade(-15);
        }

        public class Heranca
        {
            static public void Executar()
            {
                Console.WriteLine("Uno....");
                Uno carro1 = new Uno();
                Console.WriteLine(carro1.Acelerar());
                Console.WriteLine(carro1.Acelerar());
                Console.WriteLine(carro1.Frear());
                Console.WriteLine(carro1.Frear());

                Console.WriteLine("Ferrari....");
                Ferrari carro2 = new Ferrari();
                Console.WriteLine(carro2.Acelerar());
                Console.WriteLine(carro2.Acelerar());
                Console.WriteLine(carro2.Frear());
                Console.WriteLine(carro2.Frear());

                Console.WriteLine("Ferrari com tipo Carro....");
                Carro carro3 = new Ferrari(); // Plimorfismo
                Console.WriteLine(carro3.Acelerar());
                Console.WriteLine(carro3.Acelerar());
                Console.WriteLine(carro3.Frear());
                Console.WriteLine(carro3.Frear());

                Console.WriteLine("Uno com tipo Carro....");
                carro3 = new Uno(); // Plimorfismo
                Console.WriteLine(carro3.Acelerar());
                Console.WriteLine(carro3.Acelerar());
                Console.WriteLine(carro3.Frear());
                Console.WriteLine(carro3.Frear());
            }
        }
    }
}