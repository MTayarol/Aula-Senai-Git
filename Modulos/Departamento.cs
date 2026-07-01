namespace Trabalho.Modulos{
    class Departamento{
        private string id_departamento; // Chave primária
        private string id_gerente;      // Chave estrangeira
        private string nome_departamento;
        private string sigla;
        private int ramal;

        public Departamento(string id_departamento, string nome_departamento, string sigla, int ramal, string id_gerente){
            this.id_departamento = id_departamento;
            this.nome_departamento = nome_departamento;
            this.sigla = sigla;
            this.ramal = ramal;
            this.id_gerente = id_gerente;
        }

        public string GetId(){
            return id;
        }

        public string GetNome(){
            return nome_departamento;
        }

        public string GetSigla(){
            return sigla;
        }

        public int GetRamal(){
            return ramal;
        }

        public string GetIdGerente(){
            return id_gerente;
        }
    }
}