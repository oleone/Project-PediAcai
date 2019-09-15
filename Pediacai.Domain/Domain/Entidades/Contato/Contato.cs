using System;
using System.Collections.Generic;
using System.Text;

namespace Pediacai.Domain
{
    public class Contato
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string SiteURL { get; set; }
        public int? EmpresaId { get; set; }
        public int? UsuarioId { get; set; }
    }
}
