namespace ConsoleApp1
{
    class Estacionamento
    {
        public int grande;
        public int medio;
        public int pequeno;
        public Estacionamento(int vagaGrande, int vagaMedia, int vagaPequena)
        {
            grande = vagaGrande;
            medio = vagaMedia;
            pequeno = vagaPequena;
        }
        public bool AdicionarCarro(int tipoCarro)
        {
            if(tipoCarro == 1 && grande != 0)
            {
                grande = grande - 1;
                return true;
            }
            else if(tipoCarro == 2 && medio !=0)
            {
                medio = medio - 1;
                return true;
            }
            else if (tipoCarro == 3 && pequeno !=0)
            {
                pequeno = pequeno - 1;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
