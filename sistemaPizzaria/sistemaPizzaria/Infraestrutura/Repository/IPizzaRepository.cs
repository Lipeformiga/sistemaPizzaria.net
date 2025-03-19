using sistemaPizzaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPizzaria.Infraestrutura.Repository
{
    public interface IPizzaRepository
    {

        void Salvar(Pizza pizza);
        void Deletar(int id);

        void Alterar(Pizza pizza);

        Pizza? GetPizzaById(int id);

        List<Pizza> GetAll();
    }
}
