namespace Trabalho.Modulos{

    class Funcionario{
    string id_funcionario; //Chave primária
    string matricula;
    string nome;
    string dataNascimento;
    string cpf;
    string id_departamento; //Chave estrangeira
    double salario;

    public Funcionario(string id_funcionario, string nome, Departamento dep){
        this.id_funcionario = id_funcionario;
        this.nome_funcionario = nome_funcionario;
        this.id_departamento = dep.GetId();
    }
    
}
}

