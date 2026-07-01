namespace Trabalho.Modulos{
    class CadastraFuncionario{

        public void Cadastrar(List<Funcionario> funcionarios, List<Departamento> departamentos){

        }
        
        public boolean VerificaIdExiste(List<Funcionario> funcionarios, string id){
            foreach(funcionario in funcionarios){
                if(funcionario.GetId == id)
                    return true;
            }
            return false;
        }

        public boolean VerificaNome(string nome_funcionario){
            if(nome_funcionario == null){
                return false;
            }else {
                return true;
            }
        }

        public boolean ValidaCpf(string cpf){
            if(cpf.length > 11 || cpg.length < 11){
                return false;
            }else{
                return true;
            }
        }
        
        public boolean VerificaData(DateTime data){
            DateTime limite = new DateTime(1950,6,20);

            return data > limite;
        }

        public boolean DepartamentoExiste(List<Departamento> departamentos, string id_departamento){
            foreach(departamento in departamentos){
                if(departamento.GetId() == id_departamento){
                    return true;
                }
            }
            return false;
        }
    }
}