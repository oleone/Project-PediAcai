using System;
using System.Collections.Generic;

namespace Pediacai.Domain
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public DateTime DataCadastro { get; set; }
        public string InscricaoEstadual { get; set; }
        public Perfil Perfil { get; set; }
        public List<Contato> Contatos { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<Loja> Lojas { get; set; }
    }
}