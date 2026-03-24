namespace ConsoleApp1
{
    class Vaga
    {
        public int NumeroDaVaga;
        public bool EstaOcupado;
        public Vaga(int NumeroDaVaga)
        {
            NumeroDaVaga = NumeroDaVaga;
            EstaOcupado = false;
        }
        public void OcuparVaga()
        {
            if(EstaOcupado == false)
            {
                EstaOcupado = true;
                Console.WriteLine($"A vaga [{NumeroDaVaga}] agora está ocupada!");
            }
            else
            {
                Console.WriteLine($"A vaga [{NumeroDaVaga}] está ocupada");
            }   
        }
    }
}
