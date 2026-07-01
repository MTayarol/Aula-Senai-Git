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

        public string getId(){
            return this.id_departamento;
        }

        public string getNome(){
            return this.nome_departamento;
        }

        public string getSigla(){
            return this.sigla;
        }

        public int getRamal(){
            return this.ramal;
        }

        public string getIdGerente(){
            return this.id_gerente;
        }
    }
}