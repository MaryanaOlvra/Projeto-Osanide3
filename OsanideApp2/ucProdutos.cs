using System.Data;
using OsanideBLL;
using OsanideDAL;
using OsanideDTO;

namespace OsanideDesktop
{
    public partial class ucProdutos : UserControl
    {
        ProdutoBLL produtoBLL = new();
        private int? produtoSelecionadoId = null;
        public ucProdutos()
        {
            InitializeComponent();
        }

        private void ucProdutos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            double preco;
            int qtdEstoque;

            if (!double.TryParse(txtPreco.Text, out preco))
            {
                MessageBox.Show("Erro: Por favor, insira um valor numérico válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
                return;
            }

            if (!int.TryParse(txtQtdEstoque.Text, out qtdEstoque))
            {
                MessageBox.Show("Erro: Por favor, insira um número inteiro válido para a Quantidade em Estoque.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdEstoque.Focus();
                return;
            }

            var produto = new ProdutoDTO
            {
                Id = Database.Produtos.Count + 1,
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Preco = preco,
                QtdEstoque = qtdEstoque,
                Categoria = txtCategoria.Text
            };

            produtoBLL.CadastrarProduto(produto);

            MessageBox.Show($"Produto {produto.Nome} cadastrado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AtualizarGrid();

            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtQtdEstoque.Text = string.Empty;
            txtCategoria.Text = string.Empty;

            txtNome.Focus();
        }

        private void AtualizarGrid()
        {
            dgProdutos.Columns.Clear();
            dgProdutos.AutoGenerateColumns = false;
            dgProdutos.RowTemplate.Height = 40;
            dgProdutos.AllowUserToAddRows = false;

            dgProdutos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Name = "Id" });
            dgProdutos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome", Name = "Nome" });
            dgProdutos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descricao", Name = "Descricao" });
            dgProdutos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preco", Name = "Preco" });
            dgProdutos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "QtdEstoque", HeaderText = "QtdEstoque", Name = "QtdEstoque" });
            dgProdutos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Categoria", HeaderText = "Categoria", Name = "Categoria" });

            var produtos = produtoBLL.ListarProdutos();

            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("Preco", typeof(double));
            dt.Columns.Add("QtdEstoque", typeof(int));
            dt.Columns.Add("Categoria", typeof(string));

            foreach (var p in produtos)
            {
                dt.Rows.Add(p.Id, p.Nome, p.Descricao, p.Preco, p.QtdEstoque, p.Categoria);
            }

            dgProdutos.DataSource = dt;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (produtoSelecionadoId != null)
            {
                double preco;
                int qtdEstoque;

                if (!double.TryParse(txtPreco.Text, out preco))
                {
                    MessageBox.Show("Erro de Validação: Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPreco.Focus();
                    return;
                }

                if (!int.TryParse(txtQtdEstoque.Text, out qtdEstoque))
                {
                    MessageBox.Show("Erro de Validação: Por favor, insira um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtdEstoque.Focus();
                    return;
                }

                try
                {
                    btnAtualizar.Enabled = true;

                    var produtoAtualizado = new ProdutoDTO
                    {
                        Id = produtoSelecionadoId.Value,
                        Nome = txtNome.Text,
                        Descricao = txtDescricao.Text,
                        Preco = preco,
                        QtdEstoque = qtdEstoque,
                        Categoria = txtCategoria.Text
                    };

                    produtoBLL.AtualizarProduto(produtoAtualizado);

                    MessageBox.Show($"Produto {produtoAtualizado.Nome} atualizado com sucesso!", "Atualização Efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNome.Clear();
                    produtoSelecionadoId = null;
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o produto: {ex.Message}", "Erro de Processamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnAtualizar.Enabled = false;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            int id = dgProdutos.SelectedRows[0].Cells["Id"]
                .Value.GetHashCode();

            string nome = dgProdutos.SelectedRows[0].Cells["Nome"].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja excluir o produto {nome}?",
                "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                produtoBLL.RemoverProduto(id);
                MessageBox.Show($"Produto {nome} removido com sucesso!");
                AtualizarGrid();
            }
        }

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgProdutos.Rows[e.RowIndex];
                var dataRow = row.DataBoundItem as DataRowView;

                if (dataRow != null)
                {
                    produtoSelecionadoId = Convert.ToInt32(dataRow["Id"]);
                    txtNome.Text = dataRow["Nome"].ToString();
                    txtDescricao.Text = dataRow["Descrição"].ToString();
                    txtPreco.Text = dataRow["Preço"].ToString();
                    txtQtdEstoque.Text = dataRow["Qtd Estoque"].ToString();
                    txtCategoria.Text = dataRow["Categoria"].ToString();

                    btnAtualizar.Enabled = true;
                }
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarProduto();
        }
        private void BuscarProduto()
        {
            string termo = txtPesquisa.Text.Trim().ToLower();

            var filtrados = produtoBLL.ListarProdutos()
                                    .Where(funcionario => funcionario.Nome.ToLower().Contains(termo))
                                    .Select(funcionario => new
                                    {
                                        funcionario.Id,
                                        funcionario.Nome,
                                        funcionario.Descricao,
                                        funcionario.Preco,
                                        funcionario.QtdEstoque,
                                        funcionario.Categoria

                                    }).ToList();

            dgProdutos.DataSource = filtrados;
        }
    }
}
