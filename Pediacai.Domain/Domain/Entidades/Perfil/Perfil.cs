using System;
using System.Collections.Generic;
using System.Text;

namespace Pediacai.Domain
{
    public class Perfil
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataUltimaModificacao { get; set; }

        public string ImageURL { get; set; }

        public int UsuarioId { get; set; }
    }
}
