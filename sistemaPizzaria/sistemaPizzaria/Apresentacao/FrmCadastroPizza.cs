using sistemaPizzaria.Aplicacao;
using sistemaPizzaria.Dominio.Entidades;
using sistemaPizzaria.Infraestrutura.Database;
using sistemaPizzaria.Infraestrutura.Repository;

namespace sistemaPizzaria
{
    public partial class FrmCadastroPizza : Form
    {

        private PizzaService pizzaService;

        public FrmCadastroPizza()
        {
            InitializeComponent();
            carregarPizza();
            var context = new AppDbContext();
            var repository = new PizzaRepository(context);
            pizzaService = new PizzaService(repository);
        }


        private void salvarPizza()
        {
            using var context = new AppDbContext();
            int id;
            bool idExiste = int.TryParse(txtID.Text, out id) && id > 0;

            var pizza = idExiste ? context.Pizzas.Find(id) : new Pizza();

            if (pizza == null)
            {
                MessageBox.Show("Produto não encontrado para atualização.");
                return;
            }

            pizza.Nome = txtNomePizza.Text;
            pizza.Preco = decimal.Parse(txtPrecoPizza.Text);


            if (!idExiste)
            {
                context.Pizzas.Add(pizza);
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            else if (idExiste)
            {
                MessageBox.Show("Produto atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Produto não encontrado");
            }

            context.SaveChanges();
        }

        private void carregarPizza()
        {
            using var context = new AppDbContext();
            var produtos = context.Pizzas.ToList();
            dtgPizza.DataSource = produtos;
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
            using var context = new AppDbContext();

            int id = int.Parse(txtID.Text);
            var pizza = context.Pizzas.Find(id);

            if (pizza != null)
            {
                context.Pizzas.Remove(pizza);
                context.SaveChanges();
                MessageBox.Show("Pizza excluída com sucesso");
            }
            else
            {
                MessageBox.Show("Produto não encontrado");
            }
            limparDados();
            carregarPizza();

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
