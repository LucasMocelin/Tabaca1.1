using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Tabaca1._1.Data;
using Tabaca1._1.Models;
using System.Data.Entity;


namespace Tabaca1._1.Controllers
{
    public class ProdutosController : Controller
    {
        public ViewResult Index()
        {

            IList<Produto> produtos = null;
            using (var ctx = new TabacaStoreDataContext())
            {
              
                produtos = ctx.Produtos.Include(x => x.TipoDeProduto).ToList();

            }
            return View(produtos);
        }

        public ViewResult AddEdit()
        {

            return View();
        }


    }
}
