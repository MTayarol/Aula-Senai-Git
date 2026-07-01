using System;

class Cadastro
{
    public static Departamento CadastrarDepartamento()
    {
        Console.Write("ID: ");
        string id = Console.ReadLine();

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome obrigatório.");
            return null;
        }

        Console.Write("Sigla: ");
        string sigla = Console.ReadLine();

        Console.Write("Ramal: ");
        if (!int.TryParse(Console.ReadLine(), out int ramal))
        {
            Console.WriteLine("O ramal deve ser apenas numérico.");
            return null;
        }

        Console.Write("ID do gerente: ");
        string idGerente = Console.ReadLine();

        return new Departamento(id, nome, sigla, ramal, idGerente);
    }
}