using Trabalho.Modulos;

class Program{
    static void Main(){
        Departamento dep_compras = new Departamento("D23", "Compras");
        Funcionario funcionario = new Funcionario("A43", "Matheus", dep_compras);
        Gerente gere = new Gerente(dep_compras.GetId(), "A-123", "Matheus", dep_compras);
    }
}










//Criar função de cadastrar departamento: Deve-se verificar a unicidade do código (Não podem haver ids repetidas), nome obrigatório,
//Ramal apenas numérico e existência de id_gerente no arquivo de funcionários.

//Criar função de cadastrar funcionário: Exigir uma matrícula única, nome obrigatório, validação de CPF e data de nascimento (Deve ser posterior a 20/06/1950),
//O Id_departamento deve ser válido.

//Funcionalidade para editar dados de funcionários e gerentes de departamentos, garantindo que as mudanaçs gerem registros nos respectivos históricos

//Consultas: Consultar funcionário por matrícula (ID), exibindo também o nome do departamento, geração de folha de pagamento geral,
//Relatório de funcionários agrupados por departamento, incluindo o total de salário que cada setor tem.
//Histórico salarial de um funcionário em um período específico. Listagem de todos os gerentes que já passaram por um determinado departamento. 