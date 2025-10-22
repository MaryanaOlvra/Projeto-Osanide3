using OsanideDAL;
using OsanideBLL;
using OsanideDTO;
using System.Data;

namespace OsanideDesktop
{
    public partial class ucFuncionarios : UserControl
    {
        FuncionarioBll funcionarioBLL = new();
        private int? funcionarioSelecionadoId = null;
        public ucFuncionarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var funcionario = new FuncionarioDTO
            {
                Id = Database.Funcionarios.Count + 1,
                Nome = txtNome.Text,
                Login = txtLogin.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Cargo = txtCargo.Text,
                DataDeAdmissao = txtDataDeAdmissao.Text
            };

            funcionarioBLL.CadastrarFuncionario(funcionario);

            MessageBox.Show($"Funcionário {funcionario.Nome} cadastrado com sucesso!");
            AtualizarGrid();


            txtNome.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtDataDeAdmissao.Text = string.Empty;
        }

        private void ucFuncionarios_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgFuncionarios.Columns.Clear();
            dgFuncionarios.AutoGenerateColumns = false;
            dgFuncionarios.RowTemplate.Height = 40;
            dgFuncionarios.AllowUserToAddRows = false;

            dgFuncionarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Name = "Id" });
            dgFuncionarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome", Name = "Nome" });
            dgFuncionarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Login", HeaderText = "User", Name = "Login" });
            dgFuncionarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email", Name = "Email" });
            dgFuncionarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Senha", HeaderText = "Senha", Name = "Senha" });
            dgFuncionarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cargo", HeaderText = "Cargo", Name = "Cargo" });
            dgFuncionarios.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DataDeAdmissao", HeaderText = "Data de Admissão", Name = "DataDeAdmissao" });

            var usuarios = funcionarioBLL.ListarFuncionarios();

            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Login", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Senha", typeof(string));
            dt.Columns.Add("Cargo", typeof(string));
            dt.Columns.Add("DataDeAdmissao", typeof(DateTime));

            foreach (var u in usuarios)
            {
                dt.Rows.Add(u.Id, u.Nome, u.Login, u.Senha, u.Cargo, u.Email, u.DataDeAdmissao);
            }

            dgFuncionarios.DataSource = dt;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (funcionarioSelecionadoId != null)
            {
                btnAtualizar.Enabled = true;
                try
                {
                    var funcionarioAtualizado = new FuncionarioDTO
                    {
                        Id = funcionarioSelecionadoId.Value,
                        Nome = txtNome.Text,
                        Login = txtLogin.Text,
                        Email = txtEmail.Text,
                        Senha = txtSenha.Text,
                        Cargo = txtCargo.Text,
                        DataDeAdmissao = txtDataDeAdmissao.Text

                    };
                    funcionarioBLL.AtualizarFuncionario(funcionarioAtualizado);
                    MessageBox.Show($"Funcionário {funcionarioAtualizado.Nome} atualizado com sucesso!");
                    txtNome.Clear();
                    funcionarioSelecionadoId = null;
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }

                finally
                {
                    btnAtualizar.Enabled = false;
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgFuncionarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um funcionário para excluir.");
                return;
            }

            int id = dgFuncionarios.SelectedRows[0].Cells["Id"]
                .Value.GetHashCode();

            string nome = dgFuncionarios.SelectedRows[0].Cells["Nome"].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja excluir o funcionário {nome}?",
                "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                funcionarioBLL.RemoverFuncionario(id);
                MessageBox.Show($"Funcionário {nome} removido com sucesso!");
                AtualizarGrid();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarFuncionario();
        }

        private void BuscarFuncionario()
        {
            string termo = txtPesquisa.Text.Trim().ToLower();

            var filtrados = funcionarioBLL.ListarFuncionarios()
                                    .Where(funcionario => funcionario.Nome.ToLower().Contains(termo))
                                    .Select(funcionario => new
                                    {
                                        funcionario.Id,
                                        funcionario.Nome,
                                        funcionario.Email,
                                        funcionario.Login,
                                        funcionario.Senha,
                                        funcionario.Cargo,
                                        funcionario.DataDeAdmissao

                                    }).ToList();

            dgFuncionarios.DataSource = filtrados;
        }

        private void dgFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgFuncionarios.Rows[e.RowIndex];
                var dataRow = row.DataBoundItem as DataRowView;

                if (dataRow != null)
                {
                    funcionarioSelecionadoId = Convert.ToInt32(dataRow["Id"]);
                    txtNome.Text = dataRow["Nome"].ToString();
                    txtLogin.Text = dataRow["Login"].ToString();
                    txtEmail.Text = dataRow["Email"].ToString();
                    txtSenha.Text = dataRow["Senha"].ToString();
                    txtCargo.Text = dataRow["Cargo"].ToString();
                    txtDataDeAdmissao.Text = dataRow["Data de admissão"].ToString();

                    btnAtualizar.Enabled = true;
                }
            }
        }
    }
}
