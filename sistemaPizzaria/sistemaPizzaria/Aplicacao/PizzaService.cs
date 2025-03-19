using Microsoft.EntityFrameworkCore;
using sistemaPizzaria.Dominio.Entidades;
using sistemaPizzaria.Infraestrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPizzaria.Aplicacao
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _repository;
        public PizzaService(IPizzaRepository repository)
        {
            _repository = repository;
        }
        public void AlterarPizza(int id, string nome, decimal preco)
        {
            Pizza Pizza = _repository.GetPizzaById(id);
            Pizza.Nome = nome;
            Pizza.Preco = preco;
            _repository.Alterar(Pizza);
        }

        public void CadastrarPizza(string nome, decimal preco)
        {
            _repository.Salvar(new Pizza(nome, preco));
        }

        public void ExcluirPizza(int id)
        {
            _repository.Deletar(id);
        }

        public List<Pizza> GetPizzas()
        {
            return _repository.GetAll();
        }
    }
}