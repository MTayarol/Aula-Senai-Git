namespace Trabalho.Modulos{

    class Funcionario{
    string id; //Chave primária
    string matricula;
    string nome;
    string dataNascimento;
    string cpf;
    string id_departamento; //Chave estrangeira
    double salario;

    public Funcionario(string id, string nome, Departamento dep){
        this.id = id;
        this.nome = nome;
        this.id_departamento = dep.GetId();
    }
    
}
}

