using System;
using System.Collections.Generic;
using System.Text;

namespace Pediacai.Domain
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime UltimoAcesso { get; set; }
    }
}
