using System;
using System.Collections.Generic;
using System.Text;

namespace Pediacai.Domain
{
    public class Item
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public List<Categoria> Categorias { get; set; }
    }
}
