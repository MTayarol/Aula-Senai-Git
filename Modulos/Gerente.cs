namespace Trabalho.Modulos{
    
    class Gerente:Funcionario{
        string id_gerente;

        public Gerente(string id_gerente, string id, string nome, Departamento dep):base(id, nome, dep){
            this.id_gerente = id_gerente;
        }
    }
}