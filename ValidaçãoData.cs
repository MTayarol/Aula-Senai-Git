if (!DateTime.TryParse(Console.ReadLine(), out DateTime nascimento))
{
    Console.WriteLine("Data inválida.");
    return;
}

DateTime dataLimite = new DateTime(1950, 6, 20);

if (nascimento <= dataLimite)
{
    Console.WriteLine("A data deve ser posterior a 20/06/1950.");
    return;
}