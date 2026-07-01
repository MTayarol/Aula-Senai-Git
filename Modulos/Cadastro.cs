namespace Trabalho.Modulos{

class Cadastro
{
    public Cadastro(){}
    public Departamento CadastrarDepartamento()
    {
        Console.Write("ID: ");
        String id = Console.ReadLine();

        Console.Write("Nome: ");
        String nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome obrigatório.");
            return null;
        }

        Console.Write("Sigla: ");
        String sigla = Console.ReadLine();

        Console.Write("Ramal: ");
        if (!int.TryParse(Console.ReadLine(), out int ramal))
        {
            Console.WriteLine("O ramal deve ser apenas numérico.");
            return null;
        }

        Console.Write("ID do gerente: ");
        String idGerente = Console.ReadLine();

        return new Departamento(id, nome, sigla, ramal, idGerente);
    }
}
}