namespace ConsoleApp1
{
        class Veiculo
    {
        public string modelo;
        public string placa;
        
        public Veiculo(string Modelo, string Placa)
        {
            modelo = Modelo;
            placa = Placa;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Veículo modelo: [{modelo}], Placa: [{placa}]");
        }
    }

}
