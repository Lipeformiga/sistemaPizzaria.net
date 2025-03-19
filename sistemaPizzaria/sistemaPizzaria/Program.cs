using Microsoft.Extensions.DependencyInjection;
using sistemaPizzaria.Aplicacao;
using sistemaPizzaria.Infraestrutura.Database;
using sistemaPizzaria.Infraestrutura.Repository;
using Microsoft.EntityFrameworkCore;

namespace sistemaPizzaria
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=estoque.db"));


            services.AddScoped<IPizzaRepository, PizzaRepository>();
            services.AddScoped<IPizzaService, PizzaService>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmCadastroPizza(serviceProvider));
        }
    }
}