using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPizzaria.Dominio.Entidades
{
    public class Pizza
    {

        public int Id { get; set; }
        public  string Nome { get; set; }
        public  decimal Preco { get; set; }

        public Pizza(string Nome, decimal Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }
    }
}
