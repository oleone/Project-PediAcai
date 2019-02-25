using System;
using System.Collections.Generic;
using System.Text;

namespace Pediacai.Domain
{
    public class PedidoLoja
    {
        public int Id { get; set; }

        public int PedidoId { get; set; }

        public int LojaId { get; set; }
    }
}
