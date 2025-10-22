using OsanideDAL;

namespace OsanideDesktop
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            ContarFuncionarios();
            ContarQtdEstoque();
            ContarProdutos();
        }

        private void ContarFuncionarios()
        {
            lblFuncionarios.Text = Database.Funcionarios.Count.ToString();
        }

        private void ContarQtdEstoque()
        {
            lblQtdEstoque.Text = Database.QtdEstoque.Count.ToString();
        }

        private void ContarProdutos()
        {
            lblProdutos.Text = Database.Produtos.Count.ToString();
        }
    }
}
