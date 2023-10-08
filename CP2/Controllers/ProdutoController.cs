using CP2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CP2.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> _listaProduto = new List<Produto>();
        private static int _count = 0;

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            produto.Id = ++_count;
            _listaProduto.Add(produto);
            TempData["mensagemProd"] = "Produto cadastrado";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_listaProduto);
        }

        [HttpPost]
        public IActionResult Editar(Produto produto)
        {
            var index = _listaProduto.FindIndex(p => p.Id == produto.Id);
            _listaProduto[index] = produto;
            TempData["mensagemProd"] = "Produto atualizado!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var prod = _listaProduto.First(p => p.Id == id);
            return View(prod);
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var produto = _listaProduto.First(p => p.Id == id);
            _listaProduto.Remove(produto);
            TempData["mensagemProd"] = "Produto removido!";
            return RedirectToAction("Index");
        }

    }
}
