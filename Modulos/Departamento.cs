namespace Trabalho.Modulos{

    class Departamento{
        string id; //Chave primária.
        string id_gerente; 
        string nome;
        string sigla;
        int ramal; //Ramal tem que ser validado como apenas numérico
        string chave;

        public Departamento(string id, string nome){
            this.id = id;
            this.nome = nome;
        }

        public string GetId(){
            return this.id;
        }
        public string getNome(){
            return this.nome;
        }
    }
}