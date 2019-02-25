using Microsoft.EntityFrameworkCore;
using Pediacai.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pediacai.Repository.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Estoque> Estoques { get; set; }

        public DbSet<Loja> Lojas { get; set; }

        public DbSet<Item> Itens { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Para referenciar chaves estrangeiras
            modelBuilder.Entity<PedidoLoja>()
                .HasKey(PL => new { PL.LojaId, PL.PedidoId });
        }
    }
}
