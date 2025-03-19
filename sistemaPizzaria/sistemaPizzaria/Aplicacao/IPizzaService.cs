using sistemaPizzaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPizzaria.Aplicacao
{
    internal interface IPizzaService
    {
        void CadastrarPizza(string nome, decimal preco);
        void ExcluirPizza(int id);
        List<Pizza> GetPizzas();
        void AlterarPizza(int id, string nome, decimal preco);
    }
}
