using OsanideDTO;
using OsanideDAL;

namespace OsanideBLL
{
    public class FuncionarioBll
    {
        public FuncionarioDTO? Login(string Login, string Senha)
        {
            var funcionario = Database.Funcionarios.FirstOrDefault(f => f.Login == Login && f.Senha == Senha);

            if (funcionario == null)
            {
                throw new Exception("Usuário ou senha inválidos");
            }


            return funcionario;
        }

        public void CadastrarFuncionario(FuncionarioDTO funcionario)
        {
            var funcionarios = Database.Funcionarios;

            if (string.IsNullOrWhiteSpace(funcionario.Nome))
            {
                throw new Exception("Nome é obrigatório!");
            }

            if (string.IsNullOrWhiteSpace(funcionario.Login))
            {
                throw new Exception("Login é obrigatório!");
            }

            if (string.IsNullOrEmpty(funcionario.Email))
            {
                throw new Exception("E-mail é obrigatório");
            }

            if (string.IsNullOrWhiteSpace(funcionario.Senha))
            {
                throw new Exception("Senha é obrigatória!");
            }

            if (string.IsNullOrWhiteSpace(funcionario.Cargo))
            {
                throw new Exception("Cargo é obrigatório");
            }
            if (!string.IsNullOrWhiteSpace(funcionario.DataDeAdmissao))
            {
                throw new Exception("Data de admissão é obrigatória, considere colocar a data de hoje");
            }

            funcionarios.Add(funcionario);
            Database.Funcionarios = funcionarios;
        }

        public void RedefinirSenha(string login, string novaSenha)
        {
            var funcionario = Database.Funcionarios.FirstOrDefault(f => f.Login == login);
            if (funcionario == null)
                throw new Exception("Funcionário não encontrado!");

            funcionario.Senha = novaSenha;
        }

        public List<FuncionarioDTO> ListarFuncionarios() => Database.Funcionarios;
        public void RemoverFuncionario(int id)
        {
            var funcionario = Database.Funcionarios.FirstOrDefault(funcionario => funcionario.Id == id);
            if (funcionario == null)
            {
                throw new Exception("Funcionário não encontrado.");
            }

            Database.Funcionarios.Remove(funcionario);
        }

        public void AtualizarFuncionarios(FuncionarioDTO funcionarioDTO)
        {
            var funcionarioExistente = Database.Funcionarios.FirstOrDefault(funcionario => funcionario.Id == funcionarioDTO.Id);
            if (funcionarioExistente == null)
                throw new Exception("Funcionário não encontrado.");

            if (string.IsNullOrWhiteSpace(funcionarioDTO.Nome))
                throw new Exception("Nome é obrigatório.");

            funcionarioExistente.Nome = funcionarioDTO.Nome;
            funcionarioExistente.Login = funcionarioDTO.Login;
            funcionarioExistente.Cargo = funcionarioDTO.Cargo;
            funcionarioExistente.Email = funcionarioDTO.Email;
        }

        public void AtualizarFuncionario(FuncionarioDTO funcionarioDTO)
        {
            var funcionarioExistente = Database.Funcionarios.FirstOrDefault(funcionario => funcionario.Id == funcionarioDTO.Id);

            if (funcionarioExistente == null)
                throw new Exception("Funcionário não encontrado.");

            if (string.IsNullOrWhiteSpace(funcionarioDTO.Nome))
                throw new Exception("Nome é obrigatório.");

            funcionarioExistente.Nome = funcionarioDTO.Nome;
            funcionarioExistente.Login = funcionarioDTO.Login;
            funcionarioExistente.Email = funcionarioDTO.Email;
            funcionarioExistente.Senha = funcionarioDTO.Senha;
            funcionarioExistente.Cargo = funcionarioDTO.Cargo;
            funcionarioExistente.DataDeAdmissao = funcionarioDTO.DataDeAdmissao;
        }
    }
}
