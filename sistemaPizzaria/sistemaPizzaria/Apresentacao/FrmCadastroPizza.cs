using sistemaPizzaria.Aplicacao;
using sistemaPizzaria.Dominio.Entidades;
using sistemaPizzaria.Infraestrutura.Database;

namespace sistemaPizzaria
{
    public partial class FrmCadastroPizza : Form
    {

        private PizzaService pizzaService;

        public FrmCadastroPizza()
        {
            InitializeComponent();
        }


        private void salvarPizza()
        {
            using var context = new AppDbContext();

            string nome = txtNomePizza.Text;
            decimal preco;

            if(decimal.TryParse(txtPrecoPizza.Text, out preco))
            {
                pizzaService.CadastrarPizza(nome, preco);
                MessageBox.Show("Pizza cadastrada com sucesso!");
            } 
            else
            {
                MessageBox.Show("Por favor, insira um preço válido.");
            }
        }
    }
}
