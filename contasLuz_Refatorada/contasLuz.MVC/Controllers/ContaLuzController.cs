using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using contasLuz.Entities;
using contasLuz.interfaces;
using contasLuz.MVC.Models;
using contasLuz.MVC.ViewsModels;

namespace contasLuz.MVC.Controllers
{
    public class ContaLuzController : Controller
    {
        private readonly IContaLuzRepository contaLuzRepository;
        private readonly IImovelRepository imovelRepository;

        public ContaLuzController(IContaLuzRepository contaLuzRepository, IImovelRepository imovel)
        {
            this.contaLuzRepository = contaLuzRepository;
            this.imovelRepository = imovel;
        }

        public IActionResult Index()
        {
            ViewBag.imovel= imovelRepository.GetAll();
            return View(new ContaLuzViewModel(contaLuzRepository));
        }

        public IActionResult View(int id)
        {
            return View(contaLuzRepository.Get(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
         //   ViewBag.Topico = new SelectList(db.Topicoes, "Id", "Nome");

            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(ContaLuz contaLuz)
        {
            contaLuzRepository.Insert(contaLuz);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(contaLuzRepository.Get(id));
        }

        [HttpPost]
        public RedirectToActionResult Update(ContaLuz contaLuz)
        {
            contaLuzRepository.Update(contaLuz);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            contaLuzRepository.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}