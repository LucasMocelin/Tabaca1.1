using System.Collections.Generic;
using System.Data.Entity;
using Tabaca1._1.Models;

namespace Tabaca1._1.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists<TabacaStoreDataContext>
    {

        protected override void Seed(TabacaStoreDataContext context)
        {
            var essencia = new TipoDeProduto() { Nome = "Essencias" };
            var narguile = new TipoDeProduto() { Nome = "Narguiles" };
            var rosh = new TipoDeProduto() { Nome = "Rosh" };
            var mangueira = new TipoDeProduto() { Nome = "Mangueira" };
            var carvao = new TipoDeProduto() { Nome = "Carvao" };
            var acessorios = new TipoDeProduto() { Nome = "Acessorios" };

            var ziggy = new MarcaDeProduto() { Nome = "Ziggy" };
            var nay = new MarcaDeProduto() { Nome = "Nay" };
            var zomo = new MarcaDeProduto() { Nome = "Zomo" };

            var produtos = new List<Produto>
            {
                new Produto(){Nome= "RED LEMONADE", Preco =12.00M, Qtde = 10, TipoDeProduto = essencia, MarcaDeProduto= ziggy },
                new Produto(){Nome= "FRAMBOERA", Preco =10.00M, Qtde = 20, TipoDeProduto = essencia, MarcaDeProduto= zomo },
                new Produto(){Nome= "Berries Blend", Preco =12.00M, Qtde = 10, TipoDeProduto = essencia, MarcaDeProduto= nay },
                new Produto(){Nome= "Carvao Hexagonal Zomo", Preco =70.00M, Qtde = 10, TipoDeProduto = carvao, MarcaDeProduto= zomo },
             };

            context.Produtos.AddRange(produtos);
            context.SaveChanges();
        }


    }
}
