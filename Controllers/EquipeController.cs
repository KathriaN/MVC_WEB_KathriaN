using E_Jogos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Jogos.Controllers
{
    public class EquipeController : Controller
    {
        // IActionResult representa retorno de status HTTP
        // 500 Status de erro interno
        // 200 Status de OK
        // 404 Status de não encontrado
        
        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            //VIEW = Responsável pela exibição do frontend.
            //Bag = Armazena as informações do backend para serem colocadas na VIEW (Frontend)

            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {

        }
    }
}
