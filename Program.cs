using ConsoleApp1;
//// Estacionamento com: 1 vaga grande, 1 média e 0 pequenas
//Estacionamento shopping = new Estacionamento(1, 1, 0);
int contadorVip = 0;
List<Pessoa> convidados = new List<Pessoa>();
convidados.Add(new Pessoa("Ana", 34));
convidados.Add(new Pessoa("João", 30));
convidados.Add(new Pessoa("Bruno", 30));
foreach(Pessoa p in convidados)
{
    if(p.idade >= 30)
    {
        p.Apresentar();
        Console.WriteLine($"{p.nome} é um convidado VIP!");
        contadorVip = contadorVip + 1;
    }
    else
    {
        p.Apresentar();
    }
}
Console.WriteLine($"A quantida de VIPS na festa foram: {contadorVip}");
//Console.WriteLine(shopping.AdicionarCarro(1)); // Esperado: True (estacionou o grande)
//Console.WriteLine(shopping.AdicionarCarro(1)); // Esperado: False (vaga grande acabou)
//Console.WriteLine(shopping.AdicionarCarro(3)); // Esperado: False (vaga pequena já nasceu em 0)
//Console.WriteLine(shopping.AdicionarCarro(2)); // Esperado: True (estacionou o médio)