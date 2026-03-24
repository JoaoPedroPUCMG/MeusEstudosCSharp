using ConsoleApp1;
using System.ComponentModel;
Estacionamento shopping = new Estacionamento(1, 1, 0);
Console.WriteLine("Insira o tipo do carro: 1 para carro grande, 2 para médio e 3 para pequeno");
while (true)
{
    string entrada = (Console.ReadLine());
    if (int.TryParse(entrada, out int tipoCarro))
    {
        if (tipoCarro == 0) break;
        Console.WriteLine(shopping.AdicionarCarro(tipoCarro));
    }
    else
    {
        Console.WriteLine("Entrada inválida! Digite um número.");
    }


}