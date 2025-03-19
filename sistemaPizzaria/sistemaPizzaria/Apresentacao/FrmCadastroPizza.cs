using Microsoft.Extensions.DependencyInjection;
using sistemaPizzaria.Aplicacao;
using sistemaPizzaria.Dominio.Entidades;
using sistemaPizzaria.Infraestrutura.Database;
using sistemaPizzaria.Infraestrutura.Repository;

namespace sistemaPizzaria
{
    public partial class FrmCadastroPizza : Form
    {

        private readonly IPizzaService _ipizzaService;  

        public FrmCadastroPizza(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _ipizzaService = serviceProvider.GetRequiredService<IPizzaService>();
        }
            

       


        private void salvarPizza()
        {

            if (string.IsNullOrEmpty(txtNomePizza.Text))
            {
                MessageBox.Show("Nome da pizza é obrigatório.");
                return;
            }


            if (!decimal.TryParse(txtPrecoPizza.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido.");
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    _ipizzaService.CadastrarPizza(txtNomePizza.Text, decimal.Parse(txtPrecoPizza.Text));
                    MessageBox.Show("pizza salva com sucesso!");
                    carregarPizza();
                }
                else
                {
                    _ipizzaService.AlterarPizza(int.Parse(txtID.Text), txtNomePizza.Text, decimal.Parse(txtPrecoPizza.Text));
                    MessageBox.Show("pizza atualizada com sucesso!");
                    carregarPizza();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a pizza: {ex.Message}");
            }

        }

        private void carregarPizza()
        {
            var pizzas = _ipizzaService.GetPizzas();

            dtgPizza.DataSource = pizzas;

            dtgPizza.Columns["Id"].HeaderText = "ID";
            dtgPizza.Columns["Nome"].HeaderText = "Nome da Pizza";
            dtgPizza.Columns["Preco"].HeaderText = "Preço";
        }

  

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvarPizza();
            carregarPizza();
        }

        private void dtgPizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgPizza.Rows[e.RowIndex];

            txtID.Text = row.Cells["Id"].Value.ToString();
            txtNomePizza.Text = row.Cells["Nome"].Value.ToString();
            txtNomePizza.Text = row.Cells["Preco"].Value.ToString();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || !int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
           
            try
            {
                _ipizzaService.ExcluirPizza(id);
                MessageBox.Show("Produto excluido com sucesso");
                carregarPizza();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o produto: {ex.Message}");
            }

        }

        private void limparDados()
        {
            txtID.Clear();
            txtNomePizza.Clear();
            txtPrecoPizza.Clear();
        }

        private void FrmCadastroPizza_Load(object sender, EventArgs e)
        {
            carregarPizza();
        }
    }
}
