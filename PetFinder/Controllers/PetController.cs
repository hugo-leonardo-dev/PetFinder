using Microsoft.AspNetCore.Mvc;
using PetFinder.Models;
using PetFinder.Repositorio;

namespace PetFinder.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetRepositorio _petRepositorio;
        public PetController(IPetRepositorio petRepositorio)
        {
            _petRepositorio = petRepositorio;
        }
        public IActionResult Index()
        {
            var listagem = _petRepositorio.Listar();
            return View(listagem);
        }

        public IActionResult Criar()
        {
            return View();
        }       

        public IActionResult Recuperar(int id)
        {
            PetModel listagem = _petRepositorio.ListarPorId(id);
            return View("Editar", listagem);
        }
            
        public IActionResult Excluir()
        {
            return View();
        }
               
        public IActionResult Exportar()
        {
            return View();
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _petRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Pet excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, algum erro aconteceu!";
                }
                return RedirectToAction("Index");
            }

            catch(System.Exception error)
            {
                TempData["MensagemErro"] = $"Ops, algum erro aconteceu!, ERRO: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            PetModel pet = _petRepositorio.ListarPorId(id);
            return View(pet);
        }

        [HttpPost]
        public IActionResult Criar(PetModel pet)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _petRepositorio.Criar(pet);
                    TempData["MensagemSucesso"] = "Pet cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }


                return View(pet);
            }

            catch (SystemException error)
            {
                TempData["MensagemErro"] = $"Ops, algum erro aconteceu! ERRO: {error.Message}";
                return RedirectToAction("Index");
            }
        }        
        
        [HttpPost]
        public IActionResult Alterar(PetModel pet)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _petRepositorio.Editar(pet);
                    TempData["MensagemSucesso"] = "Pet alterado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", pet);
            }
            catch(SystemException error)
            {
                TempData["MensagemErro"] = $"Ops, algum erro aconteceu! ERRO: {error.Message}";
                return RedirectToAction("Index");
            }

        }

    }
}
