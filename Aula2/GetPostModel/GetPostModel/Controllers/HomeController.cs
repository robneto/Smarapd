using System.Web.Mvc;
using GetPostModel.Models;

namespace GetPostModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa();

            pessoa.PessoaId = 1;
            pessoa.Nome = "Robson Batista Neto";
            pessoa.Twitter = "robneto@hotmail.com";            

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}