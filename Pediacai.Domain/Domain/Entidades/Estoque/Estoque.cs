using System;
using System.Collections.Generic;
using System.Text;

namespace Pediacai.Domain
{
    public class Estoque
    {
        public int Id { get; set; }

        public int LojaId { get; set; }

        public List<Item> Itens { get; set; }

        public int QtdItens { get; set; }
    }
}
