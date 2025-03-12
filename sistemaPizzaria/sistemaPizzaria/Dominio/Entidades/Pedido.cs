using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPizzaria.Dominio.Entidades
{
    public class Pedido
    {

        public int Id { get; set; }
        public required Cliente Nome { get; set; }
        public required int Quantidade { get; set; }
        public decimal ValorTotal => PizzaEscolhida.Preco * Quantidade;
        public required Pizza PizzaEscolhida { get; set; }
        public DateTime DateTime { get; set; }
    }
}
