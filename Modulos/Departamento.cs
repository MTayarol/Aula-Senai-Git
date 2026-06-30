namespace Trabalho.Modulos
{
    class Departamento
    {
        private string id;             // Chave primária
        private string id_gerente;     // Chave estrangeira
        private string nome;
        private string sigla;
        private int ramal;

        public Departamento(string id, string nome, string sigla, int ramal, string id_gerente)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
            this.ramal = ramal;
            this.id_gerente = id_gerente;
        }

        public string GetId()
        {
            return id;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetSigla()
        {
            return sigla;
        }

        public int GetRamal()
        {
            return ramal;
        }

        public string GetIdGerente()
        {
            return id_gerente;
        }
    }
}