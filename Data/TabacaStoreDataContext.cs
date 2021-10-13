using System.Data.Entity;
using Tabaca1._1.Models;

namespace Tabaca1._1.Data
{
    public class TabacaStoreDataContext : DbContext
    {
        public TabacaStoreDataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=tabaca;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer(new DbInitializer()); //Cria o banco de dados

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoDeProduto> TipoDeProdutos { get; set; }
        public DbSet<MarcaDeProduto> MarcaDeProdutos { get; set; }
    }
}
