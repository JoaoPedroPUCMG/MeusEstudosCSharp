namespace ConsoleApp1
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public Pessoa(string nomeInicial, int idadeInicial)
        {
            nome = nomeInicial;
            idade = idadeInicial;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");
        }
    }
    
}
