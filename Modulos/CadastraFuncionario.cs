namespace Trabalho.Modulos{
    class CadastraFuncionario{
        
        public boolean VerificaIdExiste(string id_funcionario){
            if (id_funcionario já existe){
                return true;
            }else {
                return false;
            }
        }

        public boolean VerificaNome(string nome_funcionario){
            if(nome_funcionario == null){
                return false;
            }else {
                return true;
            }
        }

        public boolean ValidaCpf(string cpf){
            if(cpf.lenght > 11 || cpg.lenght < 11){
                return false;
            }else{
                return true;
            }
        }
    }
}