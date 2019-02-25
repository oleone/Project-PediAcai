using System;

namespace Pediacai.Domain
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public DateTime DataEntrega { get; set; }

        public bool Status { get; set; }
    }
}