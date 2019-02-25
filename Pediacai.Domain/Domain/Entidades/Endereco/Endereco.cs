using System;
using System.Collections.Generic;
using System.Text;

namespace Pediacai.Domain
{
    public class Endereco
    {
        public int Id { get; set; }

        public string UF { get; set; }

        public string Bairro { get; set; }

        public string Pais { get; set; }

        public string Rua { get; set; }

        public string Complemento { get; set; }

        public int UsuarioId { get; set; }
    }
}
