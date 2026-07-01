namespace Trabalho.Modulos{

    class Funcionario{
    string id_funcionario; //Chave primária
    string matricula;
    string nome_funcionario;
    string dataNascimento;
    string cpf;
    string id_departamento; //Chave estrangeira
    double salario;

    public Funcionario(string id_funcionario, string nome_funcionario, Departamento dep){
        this.id_funcionario = id_funcionario;
        this.nome_funcionario = nome_funcionario;
        this.id_departamento = dep.getId();
    }

    public String getId(){
        return id_funcionario;
    }
    
}
}

