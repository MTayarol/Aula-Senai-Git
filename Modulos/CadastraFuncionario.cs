namespace Trabalho.Modulos{

class CadastraFuncionario{
        private List<Funcionario> funcionarios = null;
        private List<Departamento> departamentos = null;
        public void Cadastrar(List<Funcionario> funcionarios, List<Departamento> departamentos){
            this.funcionarios = funcionarios;
            this.departamentos = departamentos;
        }
        
        public bool VerificaIdExiste(List<Funcionario> funcionarios, String id){
            try{
                foreach(var funcionario in funcionarios){
                    if(funcionario.getId() == id)
                        return true;
                }
            
            }catch(Exception e){
                Console.WriteLine("Não tem um objeto para funcionário portanto o Id não pode ser verificado");
                return false;
            }
            return false;
        }

        public bool VerificaNome(String nome_funcionario){
            if(nome_funcionario == null){
                return false;
            }else {
                return true;
            }
        }

        public bool ValidaCpf(String cpf){
            if(cpf.Length > 11 || cpf.Length < 11){
                return false;
            }else{
                return true;
            }
        }
        
        public bool VerificaData(DateTime data){
            try{
            DateTime limite = new DateTime(1950,6,20);

            return data > limite;
            } catch (Exception e){
                Console.WriteLine("Não tem um objeto para funcionário portanto o Id não pode ser verificado");
                return false;
            }
            
        }

        public bool DepartamentoExiste(List<Departamento> departamentos, String id_departamento){
            try{
                foreach(var departamento in departamentos){
                    if(departamento.getId() == id_departamento){
                        return true;
                    }
                }
            }catch (Exception e){
                Console.WriteLine("Não tem um objeto para funcionário portanto o Id não pode ser verificado");
                return false;
            }
            return false;
        }
    }
}