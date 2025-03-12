using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPizzaria.Dominio.Entidades
{
    public class Cliente
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string senha { get; set; }
    }
}
